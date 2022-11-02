namespace IRSV_NetPro_SDK_CSharp
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_saveraw = new System.Windows.Forms.Button();
            this.button_savejpg = new System.Windows.Forms.Button();
            this.label_pointtempe = new System.Windows.Forms.Label();
            this.label_tem1 = new System.Windows.Forms.Label();
            this.label_rectangletempe = new System.Windows.Forms.Label();
            this.label_tem2 = new System.Windows.Forms.Label();
            this.label_rectangleavgtempe = new System.Windows.Forms.Label();
            this.label_tem3 = new System.Windows.Forms.Label();
            this.button_camera = new System.Windows.Forms.Button();
            this.button_openraw = new System.Windows.Forms.Button();
            this.button_openjpg = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_xiuzheng = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_maxTem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(183, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(832, 665);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(29, 15);
            this.button_Start.Margin = new System.Windows.Forms.Padding(4);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(96, 45);
            this.button_Start.TabIndex = 1;
            this.button_Start.Text = "连接相机";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(29, 70);
            this.button_Stop.Margin = new System.Windows.Forms.Padding(4);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(96, 45);
            this.button_Stop.TabIndex = 2;
            this.button_Stop.Text = "关闭相机";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "状态：";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(243, 15);
            this.label_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(37, 15);
            this.label_Status.TabIndex = 4;
            this.label_Status.Text = "状态";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_saveraw
            // 
            this.button_saveraw.Location = new System.Drawing.Point(29, 155);
            this.button_saveraw.Margin = new System.Windows.Forms.Padding(4);
            this.button_saveraw.Name = "button_saveraw";
            this.button_saveraw.Size = new System.Drawing.Size(105, 45);
            this.button_saveraw.TabIndex = 5;
            this.button_saveraw.Text = "保存raw文件";
            this.button_saveraw.UseVisualStyleBackColor = true;
            this.button_saveraw.Click += new System.EventHandler(this.button_saveraw_Click);
            // 
            // button_savejpg
            // 
            this.button_savejpg.Location = new System.Drawing.Point(29, 214);
            this.button_savejpg.Margin = new System.Windows.Forms.Padding(4);
            this.button_savejpg.Name = "button_savejpg";
            this.button_savejpg.Size = new System.Drawing.Size(105, 45);
            this.button_savejpg.TabIndex = 6;
            this.button_savejpg.Text = "保存jpg文件";
            this.button_savejpg.UseVisualStyleBackColor = true;
            this.button_savejpg.Click += new System.EventHandler(this.button_savejpg_Click);
            // 
            // label_pointtempe
            // 
            this.label_pointtempe.AutoSize = true;
            this.label_pointtempe.Location = new System.Drawing.Point(27, 549);
            this.label_pointtempe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_pointtempe.Name = "label_pointtempe";
            this.label_pointtempe.Size = new System.Drawing.Size(15, 15);
            this.label_pointtempe.TabIndex = 8;
            this.label_pointtempe.Text = "0";
            // 
            // label_tem1
            // 
            this.label_tem1.AutoSize = true;
            this.label_tem1.Location = new System.Drawing.Point(27, 520);
            this.label_tem1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tem1.Name = "label_tem1";
            this.label_tem1.Size = new System.Drawing.Size(67, 15);
            this.label_tem1.TabIndex = 7;
            this.label_tem1.Text = "点温度：";
            // 
            // label_rectangletempe
            // 
            this.label_rectangletempe.AutoSize = true;
            this.label_rectangletempe.Location = new System.Drawing.Point(27, 631);
            this.label_rectangletempe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_rectangletempe.Name = "label_rectangletempe";
            this.label_rectangletempe.Size = new System.Drawing.Size(15, 15);
            this.label_rectangletempe.TabIndex = 10;
            this.label_rectangletempe.Text = "0";
            // 
            // label_tem2
            // 
            this.label_tem2.AutoSize = true;
            this.label_tem2.Location = new System.Drawing.Point(27, 602);
            this.label_tem2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tem2.Name = "label_tem2";
            this.label_tem2.Size = new System.Drawing.Size(112, 15);
            this.label_tem2.TabIndex = 9;
            this.label_tem2.Text = "矩形最高温度：";
            // 
            // label_rectangleavgtempe
            // 
            this.label_rectangleavgtempe.AutoSize = true;
            this.label_rectangleavgtempe.Location = new System.Drawing.Point(27, 706);
            this.label_rectangleavgtempe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_rectangleavgtempe.Name = "label_rectangleavgtempe";
            this.label_rectangleavgtempe.Size = new System.Drawing.Size(15, 15);
            this.label_rectangleavgtempe.TabIndex = 12;
            this.label_rectangleavgtempe.Text = "0";
            // 
            // label_tem3
            // 
            this.label_tem3.AutoSize = true;
            this.label_tem3.Location = new System.Drawing.Point(27, 678);
            this.label_tem3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tem3.Name = "label_tem3";
            this.label_tem3.Size = new System.Drawing.Size(112, 15);
            this.label_tem3.TabIndex = 11;
            this.label_tem3.Text = "矩形平均温度：";
            // 
            // button_camera
            // 
            this.button_camera.Location = new System.Drawing.Point(29, 271);
            this.button_camera.Margin = new System.Windows.Forms.Padding(4);
            this.button_camera.Name = "button_camera";
            this.button_camera.Size = new System.Drawing.Size(105, 45);
            this.button_camera.TabIndex = 13;
            this.button_camera.Text = "相机设置";
            this.button_camera.UseVisualStyleBackColor = true;
            this.button_camera.Click += new System.EventHandler(this.button_camera_Click);
            // 
            // button_openraw
            // 
            this.button_openraw.Location = new System.Drawing.Point(29, 362);
            this.button_openraw.Margin = new System.Windows.Forms.Padding(4);
            this.button_openraw.Name = "button_openraw";
            this.button_openraw.Size = new System.Drawing.Size(105, 45);
            this.button_openraw.TabIndex = 14;
            this.button_openraw.Text = "打开raw文件";
            this.button_openraw.UseVisualStyleBackColor = true;
            this.button_openraw.Click += new System.EventHandler(this.button_openraw_Click);
            // 
            // button_openjpg
            // 
            this.button_openjpg.Location = new System.Drawing.Point(29, 426);
            this.button_openjpg.Margin = new System.Windows.Forms.Padding(4);
            this.button_openjpg.Name = "button_openjpg";
            this.button_openjpg.Size = new System.Drawing.Size(105, 45);
            this.button_openjpg.TabIndex = 15;
            this.button_openjpg.Text = "打开jpg文件";
            this.button_openjpg.UseVisualStyleBackColor = true;
            this.button_openjpg.Click += new System.EventHandler(this.button_openjpg_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(1022, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(481, 665);
            this.textBox1.TabIndex = 16;
            // 
            // btn_xiuzheng
            // 
            this.btn_xiuzheng.Location = new System.Drawing.Point(29, 748);
            this.btn_xiuzheng.Name = "btn_xiuzheng";
            this.btn_xiuzheng.Size = new System.Drawing.Size(105, 41);
            this.btn_xiuzheng.TabIndex = 17;
            this.btn_xiuzheng.Text = "修正数据";
            this.btn_xiuzheng.UseVisualStyleBackColor = true;
            this.btn_xiuzheng.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 748);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "当前帧最高温度";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_maxTem
            // 
            this.label_maxTem.AutoSize = true;
            this.label_maxTem.Location = new System.Drawing.Point(180, 792);
            this.label_maxTem.Name = "label_maxTem";
            this.label_maxTem.Size = new System.Drawing.Size(15, 15);
            this.label_maxTem.TabIndex = 19;
            this.label_maxTem.Text = "0";
            this.label_maxTem.Click += new System.EventHandler(this.label3_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 856);
            this.Controls.Add(this.label_maxTem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_xiuzheng);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_openjpg);
            this.Controls.Add(this.button_openraw);
            this.Controls.Add(this.button_camera);
            this.Controls.Add(this.label_rectangleavgtempe);
            this.Controls.Add(this.label_tem3);
            this.Controls.Add(this.label_rectangletempe);
            this.Controls.Add(this.label_tem2);
            this.Controls.Add(this.label_pointtempe);
            this.Controls.Add(this.label_tem1);
            this.Controls.Add(this.button_savejpg);
            this.Controls.Add(this.button_saveraw);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IResearch_Demo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_saveraw;
        private System.Windows.Forms.Button button_savejpg;
        private System.Windows.Forms.Label label_pointtempe;
        private System.Windows.Forms.Label label_tem1;
        private System.Windows.Forms.Label label_rectangletempe;
        private System.Windows.Forms.Label label_tem2;
        private System.Windows.Forms.Label label_rectangleavgtempe;
        private System.Windows.Forms.Label label_tem3;
        private System.Windows.Forms.Button button_camera;
        private System.Windows.Forms.Button button_openraw;
        private System.Windows.Forms.Button button_openjpg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_xiuzheng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_maxTem;
    }
}

