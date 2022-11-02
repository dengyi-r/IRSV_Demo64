using System;
using System.Collections.Generic;
using System.Windows.Forms;

using CommonLib;
using IRSV_NetPro_SDK;
using NetBase;

namespace IRSV_NetPro_SDK_CSharp
{
    public partial class FormCamSetTR : Form
    {
        /// <summary>父窗体(0:主窗体、1：监视回放窗体)</summary>
        public int _fatherForm = 0;
        public TempeMath _tempeMath = null;
        private IyCommand command = null;

        /// <summary>界面显示后，需要自动执行通讯命令的步骤</summary>
        private int _UIinitSetp = 0;
        /// <summary>当前一步通讯命令步骤是否进行中</summary>
        private bool _uiinitCmding = false;
        /// <summary>初始化通讯命令是否完成</summary>
        private bool _uiInitFinish = false;

        string[] Colors1 = { "WhiteHot", "BlackHot", "Rain", "Rainbow", "Night-Day", "Color2", "Sea-Fire", "B-G-R", "Jasper-Red",
                "Lava", "Arctic", "Red", "Icefire", "Black-Red", "GreyRed", "Glowbow", "GlowHot", "Sepia", "Green", "Blue" };
        string[] Colors2 = { "白热", "黑热", "彩虹", "三原色", "蓝红黄", "蓝紫红", "混合色", "蓝绿红", "墨绿红",
                "熔岩", "蓝青橙", "警示红", "冰火", "黑红", "蓝红", "渐变红", "渐变绿", "渐变黄", "警示绿", "警示蓝" };
        //调色板类型的编号
        int[] PaletteID = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
                0xa, 0xb, 0xc, 0xd, 0xe, 0xf, 0x10, 0x11, 0x12, 0x13};

        public FormCamSetTR()
        {
            InitializeComponent();
        }

        private void FormCamSetIy_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            groupBox2.Enabled = false;

            comboBox_SetVidColor.Items.Clear();
            for (int i = 0; i < Colors1.Length; i++)
            {
                string s = Colors1[i];
                if (Iinternational.currentCulture == CultureTransition.CultureToString(Culture.zh_CN))
                    s += " (" + Colors2[i] + ")";
                comboBox_SetVidColor.Items.Add(s);
            }
            comboBox_SetVidColor.SelectedIndex = -1;

            if (SysSdk.ConnDeviceStatus)
                timerUIinit.Enabled = true;
        }

        //界面显示后，需要自动执行的通讯命令
        private void timerUIinit_Tick(object sender, EventArgs e)
        {
            if (FormMain._formMain.videoView1._camData.iyData.ListCommand.Count > 0)
                return;

            if (_uiinitCmding)
                return;
            _UIinitSetp++;

            List<string> param1 = null;
            switch (_UIinitSetp)
            {
                case 1:
                    _uiinitCmding = true;
                    label_State.Text = "已发送命令：获取自动校正开关";
                    label_State.Refresh();
                    AddCom(IyCamCmd.ReadFcc, null);
                    break;

                case 2:
                    timerUIinit.Enabled = false;
                    groupBox2.Enabled = true;
                    _uiInitFinish = true;
                    break;
            }
        }

        private void timerResult_Tick(object sender, EventArgs e)
        {
            if (FormMain._formMain.videoView1._camData.iyData.ListCommand.Count == 0)
            {
                timerResult.Enabled = false;
                label_State.Text = "命令已执行完成.";

                List<IyCommand> listCmd = new List<IyCommand>(FormMain._formMain.videoView1._camData.iyData.ListCmd);//深复制
                List<string> ListCmdResult = new List<string>(FormMain._formMain.videoView1._camData.iyData.ListCmdResult);
                if (listCmd.Count > 0)
                {
                    if (_uiinitCmding)
                        _uiinitCmding = false;

                    if (listCmd[0].IyCmd == IyCamCmd.Get_VIDEO_PALETTE)
                        comboBox_SetVidColor.SelectedIndex = Convert.ToInt32(ListCmdResult[0]);
                    else if (listCmd[0].IyCmd == IyCamCmd.Set_VIDEO_PALETTE)
                        ;
                    else if (listCmd[0].IyCmd == IyCamCmd.DoNuc1Pt)
                        ;
                    else if (listCmd[0].IyCmd == IyCamCmd.External)//背景校正
                        ;
                    else if (listCmd[0].IyCmd == IyCamCmd.ReadFcc)//读自动校正开关
                    {
                        if (Convert.ToInt32(ListCmdResult[0]) == 1)
                            radioButton_FccOn.Checked = true;
                        else//0
                            radioButton_FccOff.Checked = true;
                    }
                    else if (listCmd[0].IyCmd == IyCamCmd.FccOn)//自动校正-开
                        ;
                    else if (listCmd[0].IyCmd == IyCamCmd.FccOff)//自动校正-关
                        ;
                }

                FormMain._formMain.videoView1._camData.iyData.ListCmd.Clear();
                FormMain._formMain.videoView1._camData.iyData.ListCmdResult.Clear();
            }
        }

        private void AddCom(IyCamCmd cmd, List<string> listParam)
        {
            command = new IyCommand()
            {
                IyCmd = cmd,
                ListParam = listParam,
            };
            FormMain._formMain.videoView1._camData.iyData.ListCommand.Add(command);
            timerResult.Enabled = true;
        }

        //模拟视频颜色
        private void button_GetVidColor_Click(object sender, EventArgs e)
        {
            if (FormMain._formMain.videoView1._camData.iyData == null || FormMain._formMain.videoView1._camData.iyData.ListCommand.Count > 0)
                return;
            comboBox_SetVidColor.SelectedIndex = -1;
            List<string> list = new List<string>() { "0", "0" };
            AddCom(IyCamCmd.Get_VIDEO_PALETTE, null);
        }

        private void button_SetVidColor_Click(object sender, EventArgs e)
        {
            if (FormMain._formMain.videoView1._camData.iyData == null || FormMain._formMain.videoView1._camData.tauData.ListCommand.Count > 0)
                return;
            int Palette = comboBox_SetVidColor.SelectedIndex;
            if (Palette == -1)
            {
                MessageBox.Show("请先在列表中选择一个调色板");
                return;
            }
            int id = PaletteID[Palette];
            List<string> list = new List<string>() { id.ToString() };
            AddCom(IyCamCmd.Set_VIDEO_PALETTE, list);
        }

        //单点校正-快门校正
        private void button_1_Click(object sender, EventArgs e)
        {
            if (FormMain._formMain.videoView1._camData.iyData.ListCommand.Count > 0)
                return;

            label_State.Text = "已发送命令：单点校正";
            label_State.Refresh();

            IyCommand cmd = new IyCommand()
            {
                IyCmd = IyCamCmd.DoNuc1Pt,
                //ParamType = "Command",
                ListParam = new List<string>() { "0" }//0:快门校正
            };

            FormMain._formMain.videoView1._camData.iyData.ListCommand.Add(cmd);
            timerResult.Enabled = true;
        }

        //背景校正 External
        private void button_External_Click(object sender, EventArgs e)
        {
            if (FormMain._formMain.videoView1._camData.iyData.ListCommand.Count > 0)
                return;

            label_State.Text = "已发送命令：背景校正";
            label_State.Refresh();

            IyCommand cmd = new IyCommand()
            {
                IyCmd = IyCamCmd.External,
                //ParamType = "Command",
                ListParam = new List<string>() { "2" }//2:背景校正
            };

            FormMain._formMain.videoView1._camData.iyData.ListCommand.Add(cmd);
            timerResult.Enabled = true;
        }

        //自动校正-开
        private void radioButton_FccOn_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton_FccOn.Checked)
                return;
            if (!_uiInitFinish)
                return;
            if (FormMain._formMain.videoView1._camData.iyData.ListCommand.Count > 0)
                return;

            label_State.Text = "已发送命令：自动校正-开";
            label_State.Refresh();

            IyCommand cmd = new IyCommand()
            {
                IyCmd = IyCamCmd.FccOn,
                //ParamType = "Command",
                ListParam = new List<string>() { "1" }//
            };

            FormMain._formMain.videoView1._camData.iyData.ListCommand.Add(cmd);
            timerResult.Enabled = true;
        }
        //自动校正-关
        private void radioButton_FccOff_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton_FccOff.Checked)
                return;
            if (!_uiInitFinish)
                return;
            if (FormMain._formMain.videoView1._camData.iyData.ListCommand.Count > 0)
                return;

            label_State.Text = "已发送命令：自动校正-关";
            label_State.Refresh();

            IyCommand cmd = new IyCommand()
            {
                IyCmd = IyCamCmd.FccOff,
                //ParamType = "Command",
                ListParam = new List<string>() { "0" }//
            };

            FormMain._formMain.videoView1._camData.iyData.ListCommand.Add(cmd);
            timerResult.Enabled = true;
        }

    }
}
