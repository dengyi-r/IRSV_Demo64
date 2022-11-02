using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CommonLib;
using IRSV_NetPro_SDK;
using NetBase;

namespace IRSV_NetPro_SDK_CSharp
{
    //TW高温相机
    public partial class FormCamSetTW : Form
    {
        /// <summary>父窗体(0:主窗体、1：监视回放窗体)</summary>
        public int _fatherForm = 0;
        public TempeMath _tempeMath = null;
        private TWCommand command = null;

        /// <summary>初始化通讯命令是否完成</summary>
        private bool _uiInitFinish = false;

        public FormCamSetTW()
        {
            InitializeComponent();
        }

        private void FormCamSetTW_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void FormCamSetTW_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Init()
        {
            label_remark.Text = "";

            comboBox_GainType.Items.Clear();
            comboBox_GainType.Items.Add("0-常温");
            comboBox_GainType.Items.Add("1-中温");
            comboBox_GainType.Items.Add("2-高温");
            comboBox_GainType.SelectedIndex = _tempeMath.TWCamGainType;

            if (!SysSdk.ConnDeviceStatus || _fatherForm == 1)
            {
                groupBox2.Enabled = false;
            }

            _uiInitFinish = true;
        }

        private void timerResult_Tick(object sender, EventArgs e)
        {
            if (FormMain._formMain.videoView1._camData.twData.ListCommand.Count == 0)
            {
                timerResult.Enabled = false;
                label_State.Text = "命令已执行完成.";

                string ErrorMsg = "";
                List<TWCommand> listCmd = null;
                List<string> ListCmdResult;
                lock (FormMain._formMain.videoView1._camData.twData.lockobj)
                {
                    ErrorMsg = FormMain._formMain.videoView1._camData.twData.ErrorMsg;
                    listCmd = new List<TWCommand>(FormMain._formMain.videoView1._camData.twData.ListCmd);//深复制
                    ListCmdResult = new List<string>(FormMain._formMain.videoView1._camData.twData.ListCmdResult);

                    FormMain._formMain.videoView1._camData.twData.ListCmd.Clear();
                    FormMain._formMain.videoView1._camData.twData.ListCmdResult.Clear();
                }

                try
                {
                    if (listCmd.Count > 0)
                    {
                        if (listCmd[0].TwCmd == TWCamCmd.SetGain)//增益表 积分表
                        {
                            //_tempeMath.TWCamGainType = Convert.ToInt32(ListCmdResult[0]);
                        }
                        if (listCmd[0].TwCmd == TWCamCmd.DoNuc1Pt)
                            ;
                        if (listCmd[0].TwCmd == TWCamCmd.HandCal)
                            ;
                        if (listCmd[0].TwCmd == TWCamCmd.AutoCal)
                            ;
                    }
                }
                catch(Exception ex)
                {
                    WatchLog.WriteMsg(ex.ToString());
                }

                lock (FormMain._formMain.videoView1._camData.twData.lockobj)
                {
                    if (listCmd != null && listCmd.Count > 0)
                    {
                        FormMain._formMain.videoView1._camData.twData.ListCmd.Clear();
                        FormMain._formMain.videoView1._camData.twData.ListCmdResult.Clear();
                    }
                }
            }
        }

        private void AddCom(TWCamCmd cmd, List<string> listParam)
        {
            command = new TWCommand()
            {
                TwCmd = cmd,
                ListParam = listParam,
            };
            FormMain._formMain.videoView1._camData.twData.ListCommand.Add(command);
            timerResult.Enabled = true;
        }

        private void comboBox_GainType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this._uiInitFinish)
                return;
            if ((FormMain._formMain.videoView1._videoComponentType == CommonLib.VideoComponentType.Collect) && 
                (FormMain._formMain.videoView1._camData.twData.ListCommand.Count > 0))
                return;

            if (comboBox_GainType.SelectedIndex != _tempeMath.TWCamGainType)
            {
                _tempeMath.TWCamGainType = comboBox_GainType.SelectedIndex;
                //Console.WriteLine("comboBox_GainType.SelectedIndex=" + comboBox_GainType.SelectedIndex);

                if (this._fatherForm == 0 && FormMain._formMain.videoView1._videoComponentType == CommonLib.VideoComponentType.Collect)//相机在线，发送命令
                {
                    if (FormMain._formMain.videoView1._camData.twData == null || FormMain._formMain.videoView1._camData.twData.ListCommand.Count > 0)
                        return;
                    label_State.Text = "已发送命令：设置相机增益";
                    label_State.Refresh();
                    List<string> param = new List<string>() { _tempeMath.TWCamGainType.ToString() };
                    AddCom(TWCamCmd.SetGain, param);
                }
            }
        }

        //快门校准
        private void button_ffc_Click(object sender, EventArgs e)
        {
            if (!this._uiInitFinish)
                return;
            if (FormMain._formMain.videoView1._camData.twData == null || FormMain._formMain.videoView1._camData.twData.ListCommand.Count > 0)
                return;

            label_State.Text = "已发送命令：设置快门校准";
            label_State.Refresh();
            AddCom(TWCamCmd.DoNuc1Pt, null);
        }

        //手动校正模式
        private void button_HandCal_Click(object sender, EventArgs e)
        {
            if (!this._uiInitFinish)
                return;
            if (FormMain._formMain.videoView1._camData.twData == null || FormMain._formMain.videoView1._camData.twData.ListCommand.Count > 0)
                return;

            label_State.Text = "已发送命令：设置手动校正模式";
            label_State.Refresh();
            AddCom(TWCamCmd.HandCal, null);
        }

        //自动校正模式
        private void button2_AutoCal_Click(object sender, EventArgs e)
        {
            if (!this._uiInitFinish)
                return;
            if (FormMain._formMain.videoView1._camData.twData == null || FormMain._formMain.videoView1._camData.twData.ListCommand.Count > 0)
                return;

            label_State.Text = "已发送命令：设置自动校正模式";
            label_State.Refresh();
            AddCom(TWCamCmd.AutoCal, null);
        }

        //设置IP
        private void button_SetIP_Click(object sender, EventArgs e)
        {
            if (!this._uiInitFinish)
                return;
            if (FormMain._formMain.videoView1._camData.twData == null || FormMain._formMain.videoView1._camData.twData.ListCommand.Count > 0)
                return;

            if(!Class3.IsRightIP(textBox_ip.Text))
            {
                MessageBox.Show("ip地址输入格式不正确.");
                return;
            }

            string oldip = FormMain._formMain.videoView1.CameraIP;
            label_State.Text = "已发送命令：设置IP";
            label_State.Refresh();
            List<string> param = new List<string>() { textBox_ip.Text };
            AddCom(TWCamCmd.SetIP, param);
            WatchLog.WriteMsg("当前ip:" + oldip + "  已发送命令：设置IP" + textBox_ip.Text);
        }
    }
}
