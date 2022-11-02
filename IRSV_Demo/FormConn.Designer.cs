namespace IRSV_NetPro_SDK_CSharp
{
    partial class FormConn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConn));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_devtype = new System.Windows.Forms.ComboBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_ipaddress = new System.Windows.Forms.ComboBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_ip = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox_IP = new System.Windows.Forms.GroupBox();
            this.checkBox_IPAuto = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox_IP.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // comboBox_devtype
            // 
            this.comboBox_devtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_devtype.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox_devtype, "comboBox_devtype");
            this.comboBox_devtype.Name = "comboBox_devtype";
            this.comboBox_devtype.SelectedIndexChanged += new System.EventHandler(this.comboBox_devtype_SelectedIndexChanged);
            // 
            // textBox_port
            // 
            resources.ApplyResources(this.textBox_port, "textBox_port");
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_port_KeyPress);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // comboBox_ipaddress
            // 
            this.comboBox_ipaddress.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox_ipaddress, "comboBox_ipaddress");
            this.comboBox_ipaddress.Name = "comboBox_ipaddress";
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.button_ok, "button_ok");
            this.button_ok.Name = "button_ok";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.button_cancel, "button_cancel");
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox_IP);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_port);
            this.panel1.Controls.Add(this.comboBox_devtype);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // button_ip
            // 
            resources.ApplyResources(this.button_ip, "button_ip");
            this.button_ip.Name = "button_ip";
            this.toolTip1.SetToolTip(this.button_ip, resources.GetString("button_ip.ToolTip"));
            this.button_ip.UseVisualStyleBackColor = true;
            this.button_ip.Click += new System.EventHandler(this.button_ip_Click);
            // 
            // groupBox_IP
            // 
            this.groupBox_IP.Controls.Add(this.checkBox_IPAuto);
            this.groupBox_IP.Controls.Add(this.comboBox_ipaddress);
            this.groupBox_IP.Controls.Add(this.button_ip);
            resources.ApplyResources(this.groupBox_IP, "groupBox_IP");
            this.groupBox_IP.Name = "groupBox_IP";
            this.groupBox_IP.TabStop = false;
            // 
            // checkBox_IPAuto
            // 
            resources.ApplyResources(this.checkBox_IPAuto, "checkBox_IPAuto");
            this.checkBox_IPAuto.Name = "checkBox_IPAuto";
            this.checkBox_IPAuto.UseVisualStyleBackColor = true;
            // 
            // FormConn
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConn";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormConn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox_IP.ResumeLayout(false);
            this.groupBox_IP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_devtype;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_ipaddress;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_ip;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox_IP;
        private System.Windows.Forms.CheckBox checkBox_IPAuto;
    }
}