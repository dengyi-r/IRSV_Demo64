namespace IRSV_NetPro_SDK_CSharp
{
    partial class FormCamSetTF
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
            this.timerResult = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button_GetVidColor = new System.Windows.Forms.Button();
            this.button_SetVidColor = new System.Windows.Forms.Button();
            this.comboBox_SetVidColor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2_AutoCal = new System.Windows.Forms.Button();
            this.button_HandCal = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "状态：";
            // 
            // label_State
            // 
            this.label_State.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_State.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_State.Location = new System.Drawing.Point(60, 145);
            this.label_State.Name = "label_State";
            this.label_State.Size = new System.Drawing.Size(293, 24);
            this.label_State.TabIndex = 3;
            this.label_State.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerResult
            // 
            this.timerResult.Tick += new System.EventHandler(this.timerResult_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Analog Video Color:";
            // 
            // button_GetVidColor
            // 
            this.button_GetVidColor.Location = new System.Drawing.Point(131, 23);
            this.button_GetVidColor.Name = "button_GetVidColor";
            this.button_GetVidColor.Size = new System.Drawing.Size(38, 25);
            this.button_GetVidColor.TabIndex = 6;
            this.button_GetVidColor.Text = "Get";
            this.button_GetVidColor.UseVisualStyleBackColor = true;
            this.button_GetVidColor.Click += new System.EventHandler(this.button_GetVidColor_Click);
            // 
            // button_SetVidColor
            // 
            this.button_SetVidColor.Enabled = false;
            this.button_SetVidColor.Location = new System.Drawing.Point(175, 23);
            this.button_SetVidColor.Name = "button_SetVidColor";
            this.button_SetVidColor.Size = new System.Drawing.Size(38, 25);
            this.button_SetVidColor.TabIndex = 7;
            this.button_SetVidColor.Text = "Set";
            this.button_SetVidColor.UseVisualStyleBackColor = true;
            this.button_SetVidColor.Click += new System.EventHandler(this.button_SetVidColor_Click);
            // 
            // comboBox_SetVidColor
            // 
            this.comboBox_SetVidColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SetVidColor.FormattingEnabled = true;
            this.comboBox_SetVidColor.Location = new System.Drawing.Point(219, 25);
            this.comboBox_SetVidColor.Name = "comboBox_SetVidColor";
            this.comboBox_SetVidColor.Size = new System.Drawing.Size(147, 20);
            this.comboBox_SetVidColor.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "提示：一个命令执行完成后，才能执行另一个命令";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.button2_AutoCal);
            this.groupBox2.Controls.Add(this.button_HandCal);
            this.groupBox2.Controls.Add(this.button_1);
            this.groupBox2.Controls.Add(this.comboBox_SetVidColor);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label_State);
            this.groupBox2.Controls.Add(this.button_SetVidColor);
            this.groupBox2.Controls.Add(this.button_GetVidColor);
            this.groupBox2.Location = new System.Drawing.Point(12, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 184);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "命令功能";
            // 
            // button2_AutoCal
            // 
            this.button2_AutoCal.Location = new System.Drawing.Point(120, 104);
            this.button2_AutoCal.Name = "button2_AutoCal";
            this.button2_AutoCal.Size = new System.Drawing.Size(93, 28);
            this.button2_AutoCal.TabIndex = 21;
            this.button2_AutoCal.Text = "自动校正模式";
            this.button2_AutoCal.UseVisualStyleBackColor = true;
            this.button2_AutoCal.Click += new System.EventHandler(this.button2_AutoCal_Click);
            // 
            // button_HandCal
            // 
            this.button_HandCal.Location = new System.Drawing.Point(8, 102);
            this.button_HandCal.Name = "button_HandCal";
            this.button_HandCal.Size = new System.Drawing.Size(93, 28);
            this.button_HandCal.TabIndex = 20;
            this.button_HandCal.Text = "手动校正模式";
            this.button_HandCal.UseVisualStyleBackColor = true;
            this.button_HandCal.Click += new System.EventHandler(this.button_HandCal_Click);
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(8, 60);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(93, 28);
            this.button_1.TabIndex = 16;
            this.button_1.Text = "单点校正(FFC)";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // FormCamSetTF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 224);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCamSetTF";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ethernet相机设置(TF)";
            this.Load += new System.EventHandler(this.FormCamSetTau_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_State;
        private System.Windows.Forms.Timer timerResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_GetVidColor;
        private System.Windows.Forms.Button button_SetVidColor;
        private System.Windows.Forms.ComboBox comboBox_SetVidColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button2_AutoCal;
        private System.Windows.Forms.Button button_HandCal;
    }
}