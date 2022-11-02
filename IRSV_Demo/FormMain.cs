using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using IRSV_NetPro_SDK;
using IRSV_NetPro_SDK.Selection;
using System.IO;
using CommonLib;
using DataAccess;
using System.Reflection;
using System.Text;


namespace IRSV_NetPro_SDK_CSharp
{
    public partial class FormMain : Form
    {
        public VideoView videoView1 = new VideoView();//v1.1.11.2
        public static FormMain _formMain = null;
        private static string _tilte = "";

        /// <summary>当前的选择框形状</summary>
        private SelectionShape _selectionShape = SelectionShape.Pointer;
        /// <summary>当前调色板</summary>
        private ColorPaletteType _colorPaletteType = ColorPaletteType.Fusion;
        /// <summary>序列热图像</summary>
        private RawImgData _rawImgData = null;
        private TempeMath _tempeMath = new TempeMath();
        public object _objLock = new object();
        //private string pathfilename = Application.StartupPath + @"\SaveImage";
        /// <summary>图像文件路径</summary>
        private string path = @"D:\TI_Data\SaveImage";
        int _CamChannel = 0;//相机序号
        Color _selectionColor = Color.Black;//图像中温度文字颜色
        Color _selectionColorOut = Color.Silver;  //灰色

        public FormMain()
        {
            InitializeComponent();

            _formMain = this;

            //配置文件：ImageInterval=100  videoView1控件内部图像的自动刷新时间
            videoView1._videoComponentType = VideoComponentType.Collect; //当前为实时连接相机模式
            videoView1.Left = 0;
            videoView1.Top = 0;
            videoView1.Parent = this;
            videoView1.Visible = false;

            //回放.raw文件时使用:
            //SysSdk.RawFileTempFMode = 1;//v1.1.11.2  1:国产TR2机芯14位图像, 2:国产TR1机芯8位, 3:进口TF机芯14位，6:国产TC机芯，7:TW高温机芯，8:TG1机芯  //或修改配置文件NetPro.ini：[Image]--RawFileTempFMode

            ApplyResource();
            videoView1.EnableTimerUpdate(false);//true：组件内部自动刷新显示，false：不使用刷新
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _tilte = Assembly.GetExecutingAssembly().GetName().Name;
            this.Text = _tilte;

            videoView1._PlaybackNo = 1;
            videoView1.Ev_StartDeviceResult += new VideoView.De_StartDeviceResult(Event_StartDeviceResult);
            videoView1.Ev_StopDeviceResult += new VideoView.De_StopDeviceResult(Event_StopDeviceResult);
            videoView1.Ev_RawImgTransmit += new VideoView.De_RawImgTransmit(Event_RawImgTransmit);//以太网实时接收raw帧数据的回调函数，与videoView1控件内部图像的自动刷新时间无关

            timer1.Enabled = true;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.videoView1.Stop();
            SysSdk.SysClose = true;
            _formMain = null;
        }

        //连接相机,显示实时视频
        private void button_Start_Click(object sender, EventArgs e)
        {
            label_Status.Text = "";
            CheckImgProc();

            this.videoView1._videoComponentType = VideoComponentType.Collect;//V1.1.11.6
            FormConn frm = new FormConn(1);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                StartCollect(frm._ipaddress, Convert.ToInt32(frm._port), frm._devtype);
            }
        }

        //关闭相机
        private void button_Stop_Click(object sender, EventArgs e)
        {
            this.videoView1.Stop();
        }

        /// <summary>检测ImgProc动态库，因为会经常被360软件莫名的杀掉</summary>
        private void CheckImgProc()
        {
            if (!File.Exists(Application.StartupPath + "\\ImgProc.dll"))
                MessageBox.Show("图像动态库文件'ImgProc.dll'未找到，会导致无法显示图像，请确认文件是否丢失！", Iinternational.GlobalLanguage.msg_Warning, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>设置语言资源</summary>
        private void ApplyResource()
        {
            List<MenuStrip> menuStrip = new List<MenuStrip>();
            List<ToolStrip> toolStrip = new List<ToolStrip>();
            ComponentResourceManager res = Iinternational.ApplyResource(this, menuStrip, toolStrip);
            res.ApplyResources(videoView1, videoView1.Name);
        }

        /// <summary>开始采集(显示)视频</summary>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        /// <param name="devicetype"></param>
        private void StartCollect(string ip, int port, string devicetype)
        {
            videoView1._videoComponentType = VideoComponentType.Collect;

            this.videoView1.CameraIP = ip; //"192.168.1.201";
            this.videoView1.CameraPort = port; //8000;
            this.videoView1._devicetype = (CommonLib.DeviceType)Enum.Parse(typeof(CommonLib.DeviceType), devicetype);
            this.videoView1._devCollectType = DevCollectType.Real;//v1.1.11.6
            this.videoView1.AllowSelection = true;
            this.videoView1.SetPaletteType(_colorPaletteType);//v1.1.11.2
            this.videoView1.SelectionShape = _selectionShape;
            this.videoView1.ShowTemperature = 1;
            this.videoView1._CamChannel = 1;

            this.videoView1.SaveImagePath(SysSdk.pathSaveImage);//更新控件内部保存路径的设置
            this.videoView1.SaveVideoPath(SysSdk.pathSaveVideo);
            this.videoView1.Start();
        }

        //更换videoView1控件内部的调色板
        private void ChangeColorPalette()
        {
            //可更换的调色板：
            //Color1 Color2 Fusion  Globow PAL_Gray0to255 Gray255to0 PAL_Icefire Ironbow1 Ironbow2 Rain Rainbow Sepia
            string palName = "Color1";
            _colorPaletteType = (ColorPaletteType)Enum.Parse(typeof(ColorPaletteType), palName);
            this.videoView1.SetPaletteType(_colorPaletteType);//v1.1.11.2
            this.videoView1.UpdatePaint();
        }

        /// <summary>
        /// 启动连接设备的结果
        /// </summary>
        private void Event_StartDeviceResult(bool result, string msg)
        {
            try
            {
                this.BeginInvoke(new EventHandler(delegate
                {
                    if (result)//成功
                    {
                        label_Status.Text = "已连接设备";
                        //设置工具栏按钮,绘图按钮等

                        Console.WriteLine("相机ip=" + this.videoView1.CameraIP);
                    }
                    else//失败
                    {
                        MessageBox.Show(msg, Iinternational.GlobalLanguage.msg_Prompt, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }));
            }
            catch (Exception ex)
            { }
        }

        /// <summary>
        /// 关闭设备连接的结果
        /// </summary>
        private void Event_StopDeviceResult()
        {
            try
            {
                this.BeginInvoke(new EventHandler(delegate
                {
                    label_Status.Text = "已关闭设备连接";
                    _rawImgData = null;
                }));
            }
            catch (Exception ex)
            { }
        }

        /// <summary>实时视频每帧数据</summary>
        /// <param name="rawImgData"></param>
        private void Event_RawImgTransmit(RawImgData rawImgData)
        {
            try
            {
                this.BeginInvoke(new EventHandler(delegate
                {
                    _rawImgData = rawImgData;//覆盖到全局变量中，以便在UI的定时器中进行显示。  //rawImgData在底层线程中每帧都分配了新的内存。
                    if (rawImgData.frameindex == 1)
                    {
                        _tempeMath = this.videoView1.rawImage.tempeMath;
                    }

                    //当前帧raw数据保存磁盘等...

                    //RawImgData newdata = rawImgData.Clone();//数据深度复制
                    //lock(_objLock)
                    //{
                    //    //可以在此处，将newdata传递给其他需要的线程
                    //}
                }));
            }
            catch (Exception ex)
            { }
        }

        //定时刷新图像显示
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (_rawImgData != null)
                {
                    RawImgData newrawImgData = _rawImgData.Clone();//数据深度复制

                    //raw转bmp示例：
                    //newrawImgData.displaySource：代表机芯类别。1:进口TF机芯14位, 3:国产TR1机芯8位, 6:国产TR2机芯14位图像, 7:国产TC机芯14位，8:TW高温机芯16位，9:TG1机芯16位
                    Bitmap bmp = RawToBmp(newrawImgData.TemData, newrawImgData.imagewidth, newrawImgData.imageheight, newrawImgData.displaySource, ref _tempeMath);//v1.1.12.5
                    if (bmp != null)
                    {
                        //pictureBox1.Image = bmp;//1:1比例显示图像

                        //在pictureBox1中，尽量最大可能的显示图像
                        double ratio = (double)pictureBox1.Width / (double)pictureBox1.Height;
                        int showheight;
                        if (ratio >= this.videoView1.IMAGE_RATIO)
                            showheight = pictureBox1.Height;
                        else
                            showheight = Convert.ToInt32((double)pictureBox1.Width / this.videoView1.IMAGE_RATIO);
                        Bitmap bmpzoom = ZoomImage(bmp, Convert.ToInt32((double)showheight * this.videoView1.IMAGE_RATIO), showheight);
                        pictureBox1.Image = bmpzoom;

                        //获取点温度示例：
                        Point point = new Point()
                        {
                            X = 10,
                            Y = 10
                        };
                        double temperature = DetectExtreme_Point(newrawImgData.SourceData, newrawImgData.TemData, point,
                            newrawImgData.imagewidth, newrawImgData.imageheight, newrawImgData.displaySource, ref _tempeMath);
                        label_pointtempe.Text = string.Format("{0:F3}", temperature);

                        //获取矩形温度示例：
                        Rectangle rangeRect = new Rectangle()
                        {
                            X = 10,
                            Y = 10,
                            Size = new Size(100, 100),
                        };
                        //Rectangle rangeRect = new Rectangle()
                        //{
                        //    X = 0,
                        //    Y = 0,
                        //    Size = new Size(newrawImgData.imagewidth, newrawImgData.imageheight),
                        //};
                        ExtremePoint extremePoint = new ExtremePoint();
                        DetectExtreme_Rectangle(newrawImgData.SourceData, newrawImgData.TemData, rangeRect, out extremePoint,
                            newrawImgData.imagewidth, newrawImgData.imageheight, newrawImgData.displaySource, ref _tempeMath);
                        label_rectangletempe.Text = string.Format("{0:F3}", extremePoint.MaxTemperature);
                        label_rectangleavgtempe.Text = string.Format("{0:F3}", extremePoint.AvgTemperature);

                        //3、示例：通过相机raw数据的AD值来查找大于某个温度的所有点
                        FindTemperaturePointWithAD(newrawImgData);
                    }
                }
                else
                {
                    if (pictureBox1.Image != null)
                        pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>将raw数据转为bmp图像</summary>
        private Bitmap RawToBmp(byte[] rawData, int image_width, int image_height, int displaysource, ref TempeMath tempeMath)
        {
            Bitmap bmp;
            bmp = ImageAPI.RawToBmp(rawData, image_width, image_height, _colorPaletteType, displaysource, ref tempeMath);//v1.1.12.5

            if (bmp != null)
                bmp.RotateFlip(RotateFlipType.Rotate180FlipX);   //图片旋转180度
            return bmp;
        }

        /// <summary>获取raw数据中，某一图像中点的温度(正立时坐标)</summary>
        private double DetectExtreme_Point(byte[] sourceData, byte[] temData, Point point, int image_width, int image_height, int displaysource, ref TempeMath tempeMath)
        {
            double temperature = 0;
            ImageAPI.DetectExtreme_Point(point, out temperature, ref tempeMath, temData, image_width, image_height, displaysource, SysSdk.RawFileTempFMode);//v1.1.12.5
            return temperature;
        }

        /// <summary>获取raw数据中，某一图像中矩形区域的温度(正立时坐标)</summary>
        private double[] DetectExtreme_Rectangle(byte[] sourceData, byte[] temData, Rectangle rangeRect, 
            int image_width, int image_height, int displaysource, ref TempeMath tempeMath)
        {
            double[] temperatures = null;
            bool ok = ImageAPI.DetectExtreme_Rectangle(rangeRect, out temperatures, ref tempeMath, temData, image_width, image_height, displaysource, SysSdk.RawFileTempFMode);//v1.1.11.5
            return temperatures;
        }

        /// <summary>测量一帧rawData数组中一个矩形范围所有点的温度，并计算极端点(正立时坐标)</summary>
        private double[] DetectExtreme_Rectangle(byte[] sourceData, byte[] temData, Rectangle rangeRect, out ExtremePoint extremePoint, 
            int image_width, int image_height, int displaysource, ref TempeMath tempeMath)
        {
            double[] temperatures = null;
            bool ok = ImageAPI.DetectExtreme_Rectangle(rangeRect, out temperatures, out extremePoint, ref tempeMath, temData, 
                image_width, image_height, displaysource, SysSdk.RawFileTempFMode);//v1.1.12.5
            return temperatures;
        }

        //保存raw文件
        private void button_saveraw_Click(object sender, EventArgs e)
        {
            string pathfilename = this.path + "\\" + DateTime.Now.ToString("yyyyMMdd-HHmmssfff") + ".raw";
            bool ren = this.videoView1.SaveRaw(pathfilename);
        }


        //获取整帧温度数据
        private static double[] GetAllTempe(RawImgData rawImgData, ref TempeMath tempeMath)
        {
            double[] temperature = ImageAPI.GetAllTempe(rawImgData, ref tempeMath);
            return temperature;

        }

        //保存jpg文件
        private void button_savejpg_Click(object sender, EventArgs e)
        {
            if ((_rawImgData != null) && (_rawImgData.SourceData != null))//v1.1.11.2
            {
                DateTime timefff = DateTime.Now;

                string pathfilename = this.path + "\\" + timefff.ToString("yyyyMMdd-HHmmssfff") + ".jpg";

                double[] temperature = GetAllTempe(_rawImgData, ref this.videoView1.rawImage.tempeMath);

                FileStream fs = new FileStream(this.path + "\\" + timefff.ToString("yyyyMMdd-HHmmssfff") + "_write.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);


                for (int i = 0; i < _rawImgData.imageheight; i++)
                {
                    for (int j = 0; j < _rawImgData.imagewidth; j++)
                    {
                        sw.Write(temperature[_rawImgData.imagewidth * i + j].ToString("f1"));
                        sw.Write(" ");

                        //输出data到textBox1
                        //textBox1.AppendText(temperature[_rawImgData.imagewidth * i + j].ToString("f1"));
                        //sw.Write(" ");
                    }
                    sw.Write("\t");

                }

                sw.Close();
                fs.Close();
          
                textBox1.Text=" ";
                byte[] buffer = File.ReadAllBytes(@fs.Name);
                //将字节数组中的每一个元素都要按照我们指定的编码格式解码成字符串
                //UTF-8  GB2312 GBK ASCII  Unicode//Default国内默认编码GBK
                string str = Encoding.Default.GetString(buffer);

                textBox1.AppendText(str);


                


                bool ok = this.videoView1.SaveToJpgFile(_rawImgData, pathfilename, timefff);//sdk v.1.12.5
                
            }
        }

        public Bitmap ZoomImage(Bitmap bitmap, int destWidth, int destHeight)
        {
            try
            {
                //Bitmap bitmap2 = new Bitmap(bitmap);
                System.Drawing.Image sourImage = bitmap;
                Rectangle sourImageRectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);

                Bitmap destBitmap = new Bitmap(destWidth, destHeight);
                Graphics g = Graphics.FromImage(destBitmap);
                g.Clear(Color.Transparent);
                //设置画布的描绘质量         
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(sourImage, new Rectangle(0, 0, destWidth, destHeight), sourImageRectangle, GraphicsUnit.Pixel);  //左顶显示

                string stime = DateTime.Now.ToString("M月d日 HH:mm");//M/d HH:mm
                Font stringFont = new Font("宋体", 30);
                SizeF stringSize = g.MeasureString(stime, stringFont);
                g.Dispose();
                sourImage.Dispose();
                sourImage = null;
                //bitmap2.Dispose();
                //bitmap2 = null;
                return destBitmap;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ZoomImage()错误：" + ex.Message);
                WatchLog.Write("ZoomImage()", ex);
                return bitmap;
            }
        }

        //相机设置
        private void button_camera_Click(object sender, EventArgs e)
        {
            if ((_rawImgData != null) && (_rawImgData.SourceData != null))
            {

                Form form = null;
                if (_rawImgData.displaySource == 1)//进口机芯
                {
                    FormCamSetTF frm = new FormCamSetTF();
                    frm._fatherForm = 0;
                    frm._tempeMath = this.videoView1.rawImage.tempeMath;
                    form = frm;
                }
                else if (_rawImgData.displaySource == 3 || _rawImgData.displaySource == 6)//国产机芯
                {
                    FormCamSetTR frm = new FormCamSetTR();
                    frm._fatherForm = 0;
                    frm._tempeMath = this.videoView1.rawImage.tempeMath;
                    form = frm;
                }
                else if (_rawImgData.displaySource == 8)//TW高温机芯
                {
                    FormCamSetTW frm = new FormCamSetTW();
                    frm._fatherForm = 0;
                    frm._tempeMath = this.videoView1.rawImage.tempeMath;
                    form = frm;
                }

                if (form != null)
                {
                    form.ShowDialog(this);
                    form.Dispose();
                    form = null;
                }
            }
        }

        //打开raw文件 //v1.1.11.5
        private void button_openraw_Click(object sender, EventArgs e)
        {
            if (!IsCollect())
            {
                this.videoView1._videoComponentType = VideoComponentType.Playback;//V1.1.11.6
                label_Status.Text = "";

                OpenFileDialog fdlg = new OpenFileDialog();
                fdlg.Filter = "原始热像文件(*.raw)|*.raw";
                fdlg.InitialDirectory = path;
                if (fdlg.ShowDialog() == DialogResult.OK)
                {
                    string errormsg;
                    string file = fdlg.FileName;
                    //回放.raw前，可先在FormMain()中或此处设置SysSdk.RawFileTempFMode的值(即指定机芯类别)，sdk根据raw文件尺寸自动判断机芯类别；
                    //    当两种机芯的raw尺寸相同时，由SysSdk.RawFileTempFMode的值最终决定机芯的类别！
                    //若文件尺寸对应唯一的机芯类别，则可不设置SysSdk.RawFileTempFMode的值

                    //方法一:
                    if (this.videoView1.OpenViewFile(file, out errormsg))
                    {
                        _rawImgData = this.videoView1.rawImage.GetImgData();
                    }

                    //方法二： 如果文件后缀名不是.raw，使用此方法
                    //ImageStore imageStore;
                    //if (ImageRead.ReadRaw(file, out imageStore))
                    //{
                    //    RawImgData rawImgData = new RawImgData()
                    //    {
                    //        displaySource = imageStore.displaysource,
                    //        SourceData = imageStore.SourceData,
                    //        TemData = imageStore.temData,
                    //        ImgData = imageStore.imgData,
                    //        videoComponentType = VideoComponentType.Playback,
                    //        imagewidth = imageStore.image_width,
                    //        imageheight = imageStore.image_height,
                    //        Complex = (imageStore.displaysource != 0 && imageStore.displaysource != 3) ? 0 : 1,
                    //        frameindex = 0,
                    //        revtime = imageStore.time != "" ? Convert.ToDateTime(imageStore.time) : Convert.ToDateTime(null),
                    //        Allname = file,
                    //        imgFileType = IRSV_NetPro_SDK.Common.ImgFileType.Raw,
                    //    };
                    //    _rawImgData = rawImgData;
                    //}
                }
            }
        }

        //打开jpg文件 //v1.1.11.5
        private void button_openjpg_Click(object sender, EventArgs e)
        {
            if (!IsCollect())
            {
                OpenFileDialog fdlg = new OpenFileDialog();
                fdlg.Filter = "热像图片(*.jpg)|*.jpg";
                fdlg.InitialDirectory = path;
                if (fdlg.ShowDialog() == DialogResult.OK)
                {
                    string errormsg;
                    string file = fdlg.FileName;
                    //.jpg文件内部，保存有机芯的类别，打开时会自动进行判断
                    if (this.videoView1.OpenViewFile(file, out errormsg))
                    {
                        _rawImgData = this.videoView1.rawImage.GetImgData();
                    }
                }
            }
        }

        //v1.1.11.5
        /// <summary>判断当前是否视频连接模式</summary>
        private bool IsCollect()
        {
            if (this.videoView1._videoComponentType == CommonLib.VideoComponentType.Collect)
            {
                if (SysSdk.ConnDeviceStatus || this.videoView1._stopRunning || !this.videoView1._threadStop)
                {
                    MessageBox.Show("请先关闭实时视频连接", Iinternational.GlobalLanguage.msg_Prompt, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //获取相机raw数据的所有AD值
        private ushort[] GetAllAD(RawImgData rawImgDat, int image_width, int image_height, int displaysource)
        {
            ushort[] values = new ushort[image_width * image_height];
            for (int i = 0; i < values.Length; i++)
            {
                //下面2种方式均可
                //values[i] = ImageAPI.GetPointAD(i * 2, rawImgDat.TemData, displaysource);
                values[i] = ImageAPI.GetPointAD(rawImgDat.TemData[i * 2], rawImgDat.TemData[i * 2 + 1], displaysource);//由2字节数据计算灰度值
            }
            return values;
        }

        //示例：通过相机raw数据的数字值来查找大于某个温度的所有点
        private void FindTemperaturePointWithAD(RawImgData rawImgData)
        {
            //取相机原始raw中任意点的AD值，可对AD值的大小进行比较操作
            int image_width, image_height, displaysource;
            this.videoView1.GetRawImageSize(rawImgData.SourceData.Length, out image_width, out image_height, out displaysource);

            ushort[] cameraADs = GetAllAD(rawImgData, image_width, image_height, displaysource);

            double dTempe = 35.0;//25度
            TempeMath tempeMath = new TempeMath();
            TempeCorMode Correcte = new TempeCorMode();
            ushort value = ImageAPI.GetADByTempe((decimal)dTempe, displaysource, ref tempeMath, Correcte);

            //寻找>25度的点
            List<Point> points = new List<Point>();
            for (int i = 0; i < cameraADs.Length; i++)
            {
                if (cameraADs[i] > value)
                {
                    int y = i / image_width + 1;
                    int x = i - ((y - 1) * image_width) + 1;
                    points.Add(new Point(x, y));
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader rd = File.OpenText(@"修正后的数据文件.txt");
            string s = rd.ReadLine();

            string[] ss = s.Split(',');

            DateTime timefff = DateTime.Now;

            int row = int.Parse(ss[0]); //行数
            int col = int.Parse(ss[1]);  //每行数据的个数
            double max_data = -100;
            double[,] p1 = new double[row, col]; //数组
            FileStream fs_change = new FileStream(this.path + "\\" + timefff.ToString("yyyyMMdd-HHmmssfff") + "_change_write.txt", FileMode.Append);
            StreamWriter sw_change = new StreamWriter(fs_change);


            for (int i = 0; i < row; i++)  //读入数据并赋予数组
            {
                string line = rd.ReadLine();
                string[] data = line.Split(',');
                for (int j = 0; j < col; j++)
                {
                    p1[i, j] = double.Parse(data[j]);
                    if (max_data< p1[i, j])
                    {
                        max_data = p1[i, j];
                    }
                    sw_change.Write(p1[i, j].ToString("f1"));
                    sw_change.Write(" ");

                }

                sw_change.Write("\t");


            }

            sw_change.Close();
            fs_change.Close();

            label_maxTem.Text = max_data.ToString(); //输出修正后的最大数据

            textBox1.Text = " ";
            byte[] buffer = File.ReadAllBytes(@fs_change.Name);
            //将字节数组中的每一个元素都要按照我们指定的编码格式解码成字符串
            //UTF-8  GB2312 GBK ASCII  Unicode//Default国内默认编码GBK
            string str = Encoding.Default.GetString(buffer);

            textBox1.AppendText(str);


        }




        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
