namespace IRSV_NetPro_SDK_CSharp
{
    partial class FormCamSetTR
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
            this.comboBox_SetVidColor = new System.Windows.Forms.ComboBox();
            this.button_SetVidColor = new System.Windows.Forms.Button();
            this.button_GetVidColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_State = new System.Windows.Forms.Label();
            this.timerResult = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_FccOff = new System.Windows.Forms.RadioButton();
            this.radioButton_FccOn = new System.Windows.Forms.RadioButton();
            this.button_External = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timerUIinit = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_SetVidColor
            // 
            this.comboBox_SetVidColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SetVidColor.FormattingEnabled = true;
            this.comboBox_SetVidColor.Location = new System.Drawing.Point(219, 35);
            this.comboBox_SetVidColor.Name = "comboBox_SetVidColor";
            this.comboBox_SetVidColor.Size = new System.Drawing.Size(147, 20);
            this.comboBox_SetVidColor.TabIndex = 14;
            // 
            // button_SetVidColor
            // 
            this.button_SetVidColor.Location = new System.Drawing.Point(175, 33);
            this.button_SetVidColor.Name = "button_SetVidColor";
            this.button_SetVidColor.Size = new System.Drawing.Size(38, 25);
            this.button_SetVidColor.TabIndex = 13;
            this.button_SetVidColor.Text = "Set";
            this.button_SetVidColor.UseVisualStyleBackColor = true;
            this.button_SetVidColor.Click += new System.EventHandler(this.button_SetVidColor_Click);
            // 
            // button_GetVidColor
            // 
            this.button_GetVidColor.Location = new System.Drawing.Point(131, 33);
            this.button_GetVidColor.Name = "button_GetVidColor";
            this.button_GetVidColor.Size = new System.Drawing.Size(38, 25);
            this.button_GetVidColor.TabIndex = 12;
            this.button_GetVidColor.Text = "Get";
            this.button_GetVidColor.UseVisualStyleBackColor = true;
            this.button_GetVidColor.Click += new System.EventHandler(this.button_GetVidColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Analog Video Color:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "状态：";
            // 
            // label_State
            // 
            this.label_State.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_State.Location = new System.Drawing.Point(54, 155);
            this.label_State.Name = "label_State";
            this.label_State.Size = new System.Drawing.Size(293, 24);
            this.label_State.TabIndex = 9;
            this.label_State.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerResult
            // 
            this.timerResult.Interval = 25;
            this.timerResult.Tick += new System.EventHandler(this.timerResult_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.button_External);
            this.groupBox2.Controls.Add(this.button_1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBox_SetVidColor);
            this.groupBox2.Controls.Add(this.label_State);
            this.groupBox2.Controls.Add(this.button_GetVidColor);
            this.groupBox2.Controls.Add(this.button_SetVidColor);
            this.groupBox2.Location = new System.Drawing.Point(12, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 191);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "命令功能";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_FccOff);
            this.groupBox1.Controls.Add(this.radioButton_FccOn);
            this.groupBox1.Location = new System.Drawing.Point(219, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 42);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "自动校正";
            // 
            // radioButton_FccOff
            // 
            this.radioButton_FccOff.AutoSize = true;
            this.radioButton_FccOff.Location = new System.Drawing.Point(93, 17);
            this.radioButton_FccOff.Name = "radioButton_FccOff";
            this.radioButton_FccOff.Size = new System.Drawing.Size(35, 16);
            this.radioButton_FccOff.TabIndex = 1;
            this.radioButton_FccOff.TabStop = true;
            this.radioButton_FccOff.Text = "关";
            this.radioButton_FccOff.UseVisualStyleBackColor = true;
            this.radioButton_FccOff.CheckedChanged += new System.EventHandler(this.radioButton_FccOff_CheckedChanged);
            // 
            // radioButton_FccOn
            // 
            this.radioButton_FccOn.AutoSize = true;
            this.radioButton_FccOn.Location = new System.Drawing.Point(16, 17);
            this.radioButton_FccOn.Name = "radioButton_FccOn";
            this.radioButton_FccOn.Size = new System.Drawing.Size(35, 16);
            this.radioButton_FccOn.TabIndex = 0;
            this.radioButton_FccOn.TabStop = true;
            this.radioButton_FccOn.Text = "开";
            this.radioButton_FccOn.UseVisualStyleBackColor = true;
            this.radioButton_FccOn.CheckedChanged += new System.EventHandler(this.radioButton_FccOn_CheckedChanged);
            // 
            // button_External
            // 
            this.button_External.Location = new System.Drawing.Point(120, 80);
            this.button_External.Name = "button_External";
            this.button_External.Size = new System.Drawing.Size(93, 28);
            this.button_External.TabIndex = 16;
            this.button_External.Text = "背景校正";
            this.button_External.UseVisualStyleBackColor = true;
            this.button_External.Click += new System.EventHandler(this.button_External_Click);
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(9, 80);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(93, 28);
            this.button_1.TabIndex = 15;
            this.button_1.Text = "快门校正";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "提示：一个命令执行完成后，才能执行另一个命令";
            // 
            // timerUIinit
            // 
            this.timerUIinit.Interval = 10;
            this.timerUIinit.Tick += new System.EventHandler(this.timerUIinit_Tick);
            // 
            // FormCamSetTR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 230);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCamSetTR";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ethernet相机设置(TR)";
            this.Load += new System.EventHandler(this.FormCamSetIy_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_SetVidColor;
        private System.Windows.Forms.Button button_SetVidColor;
        private System.Windows.Forms.Button button_GetVidColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_State;
        private System.Windows.Forms.Timer timerResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button_External;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_FccOff;
        private System.Windows.Forms.RadioButton radioButton_FccOn;
        private System.Windows.Forms.Timer timerUIinit;
    }
}