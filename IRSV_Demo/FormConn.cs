using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using System.Text.RegularExpressions;
using CommonLib;
using System.IO;
using IRSV_NetPro_SDK;

namespace IRSV_NetPro_SDK_CSharp
{
    public partial class FormConn : Form
    {
        public string _devtype = "";
        public string _ipaddress = "";
        public string _port = "";
        private string _lastip = "";

        /// <summary>
        /// 相机通道(1、2)
        /// </summary>
        private int _CamChannel = 1;

        private string[] ArrayCam = { "Ethernet", "Ethernet_TW" };
        private List<string> _ListConn = new List<string>();
        private List<string> _ListCam = new List<string>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="camchannel">相机通道(1、2)</param>
        public FormConn(int camchannel = 1)
        {
            _CamChannel = camchannel;

            InitializeComponent();
        }

        private void FormConn_Load(object sender, EventArgs e)
        {
            ReadIni();
            Control_Init();
        }

        private void Control_Init()
        {
            //V1.1.11.6:
            #region 选择相机类型
            string[] sArray1 = new string[2];
            sArray1[0] = "Ethernet";//普通相机
            sArray1[1] = "0";
            _ListCam.Add(sArray1[0]);
            comboBox_devtype.Items.Add(sArray1[0]);

            sArray1[0] = "Ethernet_TW";//高温相机
            sArray1[1] = "1";
            _ListCam.Add(sArray1[0]);
            comboBox_devtype.Items.Add(sArray1[0]);

            comboBox_devtype.SelectedIndex = 0;//普通相机
            //comboBox_devtype.SelectedIndex = 1;//高温相机
            comboBox_devtype.Enabled = true;
            #endregion 选择相机类型


            GetIp();

            textBox_port.MaxLength = 5;
            if (textBox_port.Text == "")
                textBox_port.Text = "8000";
        }

        private int FindComboBox(string sz)
        {
            int index = 0;
            for (int i = 0; i < comboBox_devtype.Items.Count; i++)
            {
                if (comboBox_devtype.Items[i].ToString() == sz)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        private void GetIp()
        {
            comboBox_ipaddress.Items.Clear();

            comboBox_ipaddress.MaxLength = 15;
            List<string> ListIP = ReadIPFile();
            bool add = true;
            if (ListIP.Count > 0)
            {
                for (int i = 0; i < ListIP.Count; i++)
                {
                    comboBox_ipaddress.Items.Add(ListIP[i]);
                    if (ListIP[i] == _lastip)
                        add = false;
                }
            }
            else
            {
                comboBox_ipaddress.Items.Add("192.168.1.201");
                comboBox_ipaddress.Items.Add("192.168.1.25");
                for (int i = 0; i < comboBox_ipaddress.Items.Count; i++)
                {
                    if (comboBox_ipaddress.Items[i].ToString() == _lastip)
                        add = false;
                }
            }
            if (add)
            {
                if (_lastip != "")
                    comboBox_ipaddress.Items.Add(_lastip);
            }
            if (_lastip != "")
            {
                for (int i = 0; i < comboBox_ipaddress.Items.Count; i++)
                {
                    if (comboBox_ipaddress.Items[i].ToString() == _lastip)
                    {
                        comboBox_ipaddress.SelectedIndex = i;
                        break;
                    }
                }
            }
            if (comboBox_ipaddress.Text == "")
                comboBox_ipaddress.SelectedIndex = 0;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (JudegInput())
            {
                _devtype = comboBox_devtype.Text;
                if (_devtype == "Ethernet_TW")
                    _ipaddress = "";//
                else
                    _ipaddress = comboBox_ipaddress.Text;
                _port = textBox_port.Text;

                WriteIni();
                this.DialogResult = DialogResult.OK;

                this.Close();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox_port_KeyPress(object sender, KeyPressEventArgs e)
        {
            //0~9 8：回退键
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true; //删除字符
        }

        private bool JudegInput()
        {
            if (comboBox_ipaddress.Text == "")
            {
                MessageBox.Show(Iinternational.GlobalLanguage.msg_IPAddrInputError, Iinternational.GlobalLanguage.msg_Prompt, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (!IsRightIP(comboBox_ipaddress.Text))
            {
                MessageBox.Show(Iinternational.GlobalLanguage.msg_IPAddrFormatError, Iinternational.GlobalLanguage.msg_Prompt, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }


            int port;
            if (int.TryParse(textBox_port.Text, out port))
            {
                if (textBox_port.Text != port.ToString())
                    textBox_port.Text = port.ToString();
                if (port <= 0 || port > 99999)
                {
                    MessageBox.Show(Iinternational.GlobalLanguage.msg_PortNumber, Iinternational.GlobalLanguage.msg_Prompt, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            else
            {
                MessageBox.Show(Iinternational.GlobalLanguage.msg_PortNumber, Iinternational.GlobalLanguage.msg_Prompt, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            
            return true;
        }

        /// <summary>
        /// 判断ip地址是否正确，正确返回true 错误false
        /// </summary>
        /// <param name="strLocalIP">需要判断的字符串(IP地址)</param>
        /// <returns>TRUE OR FALSE</returns>
        private bool IsRightIP(string strLocalIP)
        {
            bool bFlag = false;
            bool Result = true;

            Regex regex = new Regex("^[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}$");
            bFlag = regex.IsMatch(strLocalIP);
            if (bFlag == true)
            {
                string[] strTemp = strLocalIP.Split(new char[] { '.' });
                int nDotCount = strTemp.Length - 1; //字符串中.的数量，若.的数量小于3，则是非法的ip地址
                if (3 == nDotCount)//判断 .的数量
                {
                    for (int i = 0; i < strTemp.Length; i++)
                    {
                        if (Convert.ToInt32(strTemp[i]) > 255)   //大于255不符合返回false
                        {
                            Result = false;
                        }
                    }
                }
                else
                {
                    Result = false;
                }
            }
            else
            {
                //输入非数字则提示，不符合IP格式
                //MessageBox.Show("不符合IP格式");
                Result = false;
            }
            return Result;
        }

        private void ReadIni()
        {
            string file = System.Windows.Forms.Application.StartupPath + "\\Config\\NetPro.ini";
            if (System.IO.File.Exists(file))
            {
                IniFile Ini1 = new IniFile(file, false);
                try
                {
                    if (Ini1.FileName != "")
                    {
                        string s;
                        _lastip = Ini1.ReadString("Cam" + _CamChannel, "ipaddress", "");
                        textBox_port.Text = Ini1.ReadString("Cam" + _CamChannel, "port", "8000");
                    }
                }
                catch (Exception ex)
                {
                    //WatchLog.Write("ReadTestIni()错误:", ex);
                }
                finally
                {
                    Ini1 = null;
                }
            }
            else
            {

            }
        }

        public bool WriteIni()
        {
            string SysMainSetFile = System.Windows.Forms.Application.StartupPath + "\\Config\\NetPro.ini";
            //if (File.Exists(SysMainSetFile))
            {
                IniFile Ini1 = new IniFile(SysMainSetFile, false);
                try
                {
                    if (Ini1.FileName != "")
                    {
                        Ini1.WriteString("Cam" + _CamChannel, "devtype", _devtype);
                        Ini1.WriteString("Cam" + _CamChannel, "ipaddress", _ipaddress);
                        Ini1.WriteString("Cam" + _CamChannel, "port", _port);
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("写配置文件错误！");
                }
                finally
                {
                    Ini1 = null;
                }
            }
            return false;
        }

        private List<string> ReadIPFile()
        {
            List<string> ListIP = new List<string>();
            string ip;
            string file = Application.StartupPath + "\\Config\\IP.txt";
            if (File.Exists(file))
            {
                using (FileStream aFile = new FileStream(file, FileMode.Open))
                using (StreamReader sr = new StreamReader(aFile, Encoding.GetEncoding("gb2312")))  //System.Text.Encoding.Default
                {
                    while (!sr.EndOfStream)
                    {
                        ip = sr.ReadLine();
                        if (!string.IsNullOrEmpty(ip))
                        {
                            if (ip.Trim() != "")
                                ListIP.Add(ip.Trim());
                        }
                    }
                }
            }
            return ListIP;
        }

        private void button_ip_Click(object sender, EventArgs e)
        {
            FormIP frm = new FormIP();
            frm.ShowDialog();
            GetIp();
        }

        private void comboBox_devtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            string devtype = GetCamName(comboBox_devtype.SelectedItem.ToString());

            if (devtype == "Ethernet_TW")//TW高温相机
            {
                groupBox_IP.Visible = true;
                checkBox_IPAuto.Checked = true;
                checkBox_IPAuto.Enabled = false;  //true;
                Set_IP(true);
                textBox_port.Enabled = false;
            }
            else//Ethernet
            {
                groupBox_IP.Visible = true;
                checkBox_IPAuto.Checked = false;
                checkBox_IPAuto.Enabled = false;
                Set_IP(true);
            }

        }

        private void Set_IP(bool enable)
        {
            try
            {
                string devtype = GetCamName(comboBox_devtype.SelectedItem.ToString());
                if (devtype == "Ethernet")
                {
                    comboBox_ipaddress.Enabled = true;
                    button_ip.Enabled = true;
                }
                else if (devtype == "Ethernet_TW")
                {
                    if (checkBox_IPAuto.Checked)
                    {
                        comboBox_ipaddress.Enabled = false;
                        button_ip.Enabled = false;
                    }
                    else
                    {
                        comboBox_ipaddress.Enabled = enable;
                        button_ip.Enabled = enable;
                    }
                }

                if (devtype == "Ethernet_TW")
                    textBox_port.Enabled = false;
                else//Ethernet
                    textBox_port.Enabled = true;
            }
            catch { }
        }

        private string GetCamName(string find)
        {
            string camename = "";
            for (int i = 0; i < _ListCam.Count; i++)
            {
                if (_ListCam[i] == find)
                {
                    camename = this._ListCam[i];
                    break;
                }
            }

            return camename;
        }

    }
}
