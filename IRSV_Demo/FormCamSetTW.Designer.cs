namespace IRSV_NetPro_SDK_CSharp
{
    partial class FormCamSetTW
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label_State = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_remark = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_GainType = new System.Windows.Forms.ComboBox();
            this.timerResult = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2_AutoCal = new System.Windows.Forms.Button();
            this.button_HandCal = new System.Windows.Forms.Button();
            this.button_ffc = new System.Windows.Forms.Button();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.button_SetIP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "状态：";
            // 
            // label_State
            // 
            this.label_State.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_State.Location = new System.Drawing.Point(60, 280);
            this.label_State.Name = "label_State";
            this.label_State.Size = new System.Drawing.Size(293, 24);
            this.label_State.TabIndex = 3;
            this.label_State.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "提示：一个命令执行完成后，才能执行另一个命令";
            // 
            // label_remark
            // 
            this.label_remark.AutoSize = true;
            this.label_remark.Location = new System.Drawing.Point(244, 27);
            this.label_remark.Name = "label_remark";
            this.label_remark.Size = new System.Drawing.Size(29, 12);
            this.label_remark.TabIndex = 4;
            this.label_remark.Text = "注释";
            this.label_remark.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "温度增益：";
            // 
            // comboBox_GainType
            // 
            this.comboBox_GainType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_GainType.FormattingEnabled = true;
            this.comboBox_GainType.Location = new System.Drawing.Point(101, 23);
            this.comboBox_GainType.Name = "comboBox_GainType";
            this.comboBox_GainType.Size = new System.Drawing.Size(116, 20);
            this.comboBox_GainType.TabIndex = 0;
            this.comboBox_GainType.SelectedIndexChanged += new System.EventHandler(this.comboBox_GainType_SelectedIndexChanged);
            // 
            // timerResult
            // 
            this.timerResult.Tick += new System.EventHandler(this.timerResult_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_remark);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_GainType);
            this.groupBox1.Location = new System.Drawing.Point(2, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 61);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2_AutoCal);
            this.groupBox2.Controls.Add(this.button_HandCal);
            this.groupBox2.Controls.Add(this.button_ffc);
            this.groupBox2.Location = new System.Drawing.Point(2, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 103);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "参数";
            // 
            // button2_AutoCal
            // 
            this.button2_AutoCal.Location = new System.Drawing.Point(132, 66);
            this.button2_AutoCal.Name = "button2_AutoCal";
            this.button2_AutoCal.Size = new System.Drawing.Size(93, 28);
            this.button2_AutoCal.TabIndex = 23;
            this.button2_AutoCal.Text = "自动校正模式";
            this.button2_AutoCal.UseVisualStyleBackColor = true;
            this.button2_AutoCal.Click += new System.EventHandler(this.button2_AutoCal_Click);
            // 
            // button_HandCal
            // 
            this.button_HandCal.Location = new System.Drawing.Point(20, 64);
            this.button_HandCal.Name = "button_HandCal";
            this.button_HandCal.Size = new System.Drawing.Size(93, 28);
            this.button_HandCal.TabIndex = 22;
            this.button_HandCal.Text = "手动校正模式";
            this.button_HandCal.UseVisualStyleBackColor = true;
            this.button_HandCal.Click += new System.EventHandler(this.button_HandCal_Click);
            // 
            // button_ffc
            // 
            this.button_ffc.Location = new System.Drawing.Point(20, 20);
            this.button_ffc.Name = "button_ffc";
            this.button_ffc.Size = new System.Drawing.Size(93, 28);
            this.button_ffc.TabIndex = 17;
            this.button_ffc.Text = "快门校准";
            this.button_ffc.UseVisualStyleBackColor = true;
            this.button_ffc.Click += new System.EventHandler(this.button_ffc_Click);
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(72, 223);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(146, 21);
            this.textBox_ip.TabIndex = 24;
            // 
            // button_SetIP
            // 
            this.button_SetIP.Location = new System.Drawing.Point(236, 219);
            this.button_SetIP.Name = "button_SetIP";
            this.button_SetIP.Size = new System.Drawing.Size(93, 28);
            this.button_SetIP.TabIndex = 25;
            this.button_SetIP.Text = "设置IP";
            this.button_SetIP.UseVisualStyleBackColor = true;
            this.button_SetIP.Click += new System.EventHandler(this.button_SetIP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "ip：";
            // 
            // FormCamSetTW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 316);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_SetIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label_State);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCamSetTW";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ethernet相机设置(TW)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCamSetTW_FormClosed);
            this.Load += new System.EventHandler(this.FormCamSetTW_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_State;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_remark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_GainType;
        private System.Windows.Forms.Timer timerResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_ffc;
        private System.Windows.Forms.Button button2_AutoCal;
        private System.Windows.Forms.Button button_HandCal;
        private System.Windows.Forms.Button button_SetIP;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.Label label2;
    }
}