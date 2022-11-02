using System;
using System.Collections.Generic;
using System.Windows.Forms;

using IRSV_NetPro_SDK;
using NetBase;

namespace IRSV_NetPro_SDK_CSharp
{
    //进口机芯
    public partial class FormCamSetTF : Form
    {
        /// <summary>父窗体(0:主窗体、1：监视回放窗体)</summary>
        public int _fatherForm = 0;
        public TempeMath _tempeMath = null;
        private TauCommand command = null;

        public FormCamSetTF()
        {
            InitializeComponent();
        }

        private void FormCamSetTau_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            comboBox_SetVidColor.Items.Clear();
            comboBox_SetVidColor.Items.Add("WhiteHot");
            comboBox_SetVidColor.Items.Add("BlackHot");
            comboBox_SetVidColor.Items.Add("Fusion");
            comboBox_SetVidColor.Items.Add("Rainbow");
            comboBox_SetVidColor.Items.Add("Globow");
            comboBox_SetVidColor.Items.Add("Ironbow1");
            comboBox_SetVidColor.Items.Add("Ironbow2");
            comboBox_SetVidColor.Items.Add("Sepia");
            comboBox_SetVidColor.Items.Add("Color1");
            comboBox_SetVidColor.Items.Add("Color2");
            comboBox_SetVidColor.Items.Add("Icefire");
            comboBox_SetVidColor.Items.Add("Rain");
            comboBox_SetVidColor.Items.Add("RedHot");
            comboBox_SetVidColor.Items.Add("GreenHot");
            comboBox_SetVidColor.SelectedIndex = -1;

            if (!SysSdk.ConnDeviceStatus)
            {
                groupBox2.Enabled = false;
            }
        }

        private void timerResult_Tick(object sender, EventArgs e)
        {
            if (FormMain._formMain.videoView1._camData.tauData.ListCommand.Count == 0)
            {
                timerResult.Enabled = false;
                label_State.Text = "命令已执行完成.";

                List<TauCommand> listCmd = new List<TauCommand>(FormMain._formMain.videoView1._camData.tauData.ListCmd);//深复制
                List<string> ListCmdResult = new List<string>(FormMain._formMain.videoView1._camData.tauData.ListCmdResult);
                if (listCmd.Count > 0)
                {
                    if (listCmd[0].TauCmd == TauCamCmd.Get_VIDEO_PALETTE)
                        comboBox_SetVidColor.SelectedIndex = Convert.ToInt32(ListCmdResult[0]);
                }

                FormMain._formMain.videoView1._camData.tauData.ListCmd.Clear();
                FormMain._formMain.videoView1._camData.tauData.ListCmdResult.Clear();
            }
        }

        private void AddCom(TauCamCmd cmd, List<string> listParam)
        {
            command = new TauCommand()
            {
                TauCmd = cmd,
                ListParam = listParam,
            };
            FormMain._formMain.videoView1._camData.tauData.ListCommand.Add(command);
            timerResult.Enabled = true;
        }

        //版本
        private void button_Revision_Click(object sender, EventArgs e)
        {
            if (FormMain._formMain.videoView1._camData.tauData == null || FormMain._formMain.videoView1._camData.tauData.ListCommand.Count > 0)
                return;
            label_State.Text = "";
            label_State.Refresh();
            AddCom(TauCamCmd.Revision, null);
        }

        //模拟视频颜色
        private void button_GetVidColor_Click(object sender, EventArgs e)
        {
            if (FormMain._formMain.videoView1._camData.tauData == null || FormMain._formMain.videoView1._camData.tauData.ListCommand.Count > 0)
                return;
            comboBox_SetVidColor.SelectedIndex = -1;
            AddCom(TauCamCmd.Get_VIDEO_PALETTE, null);
        }
        private void button_SetVidColor_Click(object sender, EventArgs e)
        {
            if (FormMain._formMain.videoView1._camData.tauData == null || FormMain._formMain.videoView1._camData.tauData.ListCommand.Count > 0)
                return;
            int Palette = comboBox_SetVidColor.SelectedIndex;
            if (Palette == -1)
            {
                MessageBox.Show("请先在列表中选择一个调色板");
                return;
            }
            List<string> list = new List<string>() { Palette.ToString() };
            AddCom(TauCamCmd.Set_VIDEO_PALETTE, list);
        }

        //单点校正
        private void button_1_Click(object sender, EventArgs e)
        {
            if (FormMain._formMain.videoView1._camData.tauData.ListCommand.Count > 0)
                return;

            label_State.Text = "已发送命令：单点校正";
            label_State.Refresh();

            TauCommand cmd = new TauCommand()
            {
                TauCmd = TauCamCmd.DoNuc1Pt,
                //ParamType = "Command",
                ListParam = new List<string>() { "0" }
            };

            FormMain._formMain.videoView1._camData.tauData.ListCommand.Add(cmd);
            timerResult.Enabled = true;
        }

        //手动校正模式
        private void button_HandCal_Click(object sender, EventArgs e)
        {
            if (FormMain._formMain.videoView1._camData.hkData == null || FormMain._formMain.videoView1._camData.tauData.ListCommand.Count > 0)
                return;
            label_State.Text = "已发送命令：手动校正";
            label_State.Refresh();
            AddCom(TauCamCmd.HandCal, null);
        }

        //自动校正模式
        private void button2_AutoCal_Click(object sender, EventArgs e)
        {
            if (FormMain._formMain.videoView1._camData.hkData == null || FormMain._formMain.videoView1._camData.tauData.ListCommand.Count > 0)
                return;
            label_State.Text = "已发送命令：自动校正";
            label_State.Refresh();
            AddCom(TauCamCmd.AutoCal, null);
        }
    }
}
