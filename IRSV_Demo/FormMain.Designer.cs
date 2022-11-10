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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_pointtempe = new System.Windows.Forms.Label();
            this.label_tem1 = new System.Windows.Forms.Label();
            this.label_rectangletempe = new System.Windows.Forms.Label();
            this.label_tem2 = new System.Windows.Forms.Label();
            this.label_rectangleavgtempe = new System.Windows.Forms.Label();
            this.label_tem3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_maxTem = new System.Windows.Forms.Label();
            this.系统工具栏 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统工具栏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开相机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭相机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setcamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存jpg文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存raw文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.模型预测ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.预测数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存文件ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.保存raw文件ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.打开raw文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4_Nowmax = new System.Windows.Forms.Label();
            this.label_now_maxData = new System.Windows.Forms.Label();
            this.label_min_dataTem = new System.Windows.Forms.Label();
            this.label_minData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.系统工具栏.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(147, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(865, 649);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.label_Status.Location = new System.Drawing.Point(282, 15);
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
            // label_pointtempe
            // 
            this.label_pointtempe.AutoSize = true;
            this.label_pointtempe.Location = new System.Drawing.Point(28, 120);
            this.label_pointtempe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_pointtempe.Name = "label_pointtempe";
            this.label_pointtempe.Size = new System.Drawing.Size(15, 15);
            this.label_pointtempe.TabIndex = 8;
            this.label_pointtempe.Text = "0";
            // 
            // label_tem1
            // 
            this.label_tem1.AutoSize = true;
            this.label_tem1.Location = new System.Drawing.Point(28, 91);
            this.label_tem1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tem1.Name = "label_tem1";
            this.label_tem1.Size = new System.Drawing.Size(67, 15);
            this.label_tem1.TabIndex = 7;
            this.label_tem1.Text = "点温度：";
            // 
            // label_rectangletempe
            // 
            this.label_rectangletempe.AutoSize = true;
            this.label_rectangletempe.Location = new System.Drawing.Point(28, 202);
            this.label_rectangletempe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_rectangletempe.Name = "label_rectangletempe";
            this.label_rectangletempe.Size = new System.Drawing.Size(15, 15);
            this.label_rectangletempe.TabIndex = 10;
            this.label_rectangletempe.Text = "0";
            // 
            // label_tem2
            // 
            this.label_tem2.AutoSize = true;
            this.label_tem2.Location = new System.Drawing.Point(28, 173);
            this.label_tem2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tem2.Name = "label_tem2";
            this.label_tem2.Size = new System.Drawing.Size(112, 15);
            this.label_tem2.TabIndex = 9;
            this.label_tem2.Text = "矩形最高温度：";
            this.label_tem2.Click += new System.EventHandler(this.label_tem2_Click);
            // 
            // label_rectangleavgtempe
            // 
            this.label_rectangleavgtempe.AutoSize = true;
            this.label_rectangleavgtempe.Location = new System.Drawing.Point(28, 277);
            this.label_rectangleavgtempe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_rectangleavgtempe.Name = "label_rectangleavgtempe";
            this.label_rectangleavgtempe.Size = new System.Drawing.Size(15, 15);
            this.label_rectangleavgtempe.TabIndex = 12;
            this.label_rectangleavgtempe.Text = "0";
            // 
            // label_tem3
            // 
            this.label_tem3.AutoSize = true;
            this.label_tem3.Location = new System.Drawing.Point(28, 249);
            this.label_tem3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tem3.Name = "label_tem3";
            this.label_tem3.Size = new System.Drawing.Size(112, 15);
            this.label_tem3.TabIndex = 11;
            this.label_tem3.Text = "矩形平均温度：";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(1019, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(491, 86);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "当前帧最高温度";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_maxTem
            // 
            this.label_maxTem.AutoSize = true;
            this.label_maxTem.Location = new System.Drawing.Point(28, 328);
            this.label_maxTem.Name = "label_maxTem";
            this.label_maxTem.Size = new System.Drawing.Size(15, 15);
            this.label_maxTem.TabIndex = 19;
            this.label_maxTem.Text = "0";
            this.label_maxTem.Click += new System.EventHandler(this.label3_Click);
            // 
            // 系统工具栏
            // 
            this.系统工具栏.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.系统工具栏.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.系统工具栏.Location = new System.Drawing.Point(0, 850);
            this.系统工具栏.Name = "系统工具栏";
            this.系统工具栏.Size = new System.Drawing.Size(1533, 25);
            this.系统工具栏.TabIndex = 21;
            this.系统工具栏.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(167, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 828);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1533, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统工具栏ToolStripMenuItem,
            this.保存文件ToolStripMenuItem,
            this.模型预测ToolStripMenuItem,
            this.保存文件ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1533, 28);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统工具栏ToolStripMenuItem
            // 
            this.系统工具栏ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开相机ToolStripMenuItem,
            this.关闭相机ToolStripMenuItem,
            this.setcamToolStripMenuItem});
            this.系统工具栏ToolStripMenuItem.Name = "系统工具栏ToolStripMenuItem";
            this.系统工具栏ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.系统工具栏ToolStripMenuItem.Text = "系统工具栏";
            // 
            // 打开相机ToolStripMenuItem
            // 
            this.打开相机ToolStripMenuItem.Name = "打开相机ToolStripMenuItem";
            this.打开相机ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.打开相机ToolStripMenuItem.Text = "open_cam";
            this.打开相机ToolStripMenuItem.Click += new System.EventHandler(this.打开相机ToolStripMenuItem_Click);
            // 
            // 关闭相机ToolStripMenuItem
            // 
            this.关闭相机ToolStripMenuItem.Name = "关闭相机ToolStripMenuItem";
            this.关闭相机ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.关闭相机ToolStripMenuItem.Text = "close_cam";
            this.关闭相机ToolStripMenuItem.Click += new System.EventHandler(this.关闭相机ToolStripMenuItem_Click);
            // 
            // setcamToolStripMenuItem
            // 
            this.setcamToolStripMenuItem.Name = "setcamToolStripMenuItem";
            this.setcamToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.setcamToolStripMenuItem.Text = "set_cam";
            this.setcamToolStripMenuItem.Click += new System.EventHandler(this.setcamToolStripMenuItem_Click);
            // 
            // 保存文件ToolStripMenuItem
            // 
            this.保存文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存jpg文件ToolStripMenuItem,
            this.保存raw文件ToolStripMenuItem});
            this.保存文件ToolStripMenuItem.Name = "保存文件ToolStripMenuItem";
            this.保存文件ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.保存文件ToolStripMenuItem.Text = "保存文件";
            // 
            // 保存jpg文件ToolStripMenuItem
            // 
            this.保存jpg文件ToolStripMenuItem.Name = "保存jpg文件ToolStripMenuItem";
            this.保存jpg文件ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.保存jpg文件ToolStripMenuItem.Text = "保存jpg文件";
            this.保存jpg文件ToolStripMenuItem.Click += new System.EventHandler(this.保存jpg文件ToolStripMenuItem_Click);
            // 
            // 保存raw文件ToolStripMenuItem
            // 
            this.保存raw文件ToolStripMenuItem.Name = "保存raw文件ToolStripMenuItem";
            this.保存raw文件ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.保存raw文件ToolStripMenuItem.Text = "保存raw文件";
            this.保存raw文件ToolStripMenuItem.Click += new System.EventHandler(this.保存raw文件ToolStripMenuItem_Click);
            // 
            // 模型预测ToolStripMenuItem
            // 
            this.模型预测ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.预测数据ToolStripMenuItem});
            this.模型预测ToolStripMenuItem.Name = "模型预测ToolStripMenuItem";
            this.模型预测ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.模型预测ToolStripMenuItem.Text = "模型预测";
            // 
            // 预测数据ToolStripMenuItem
            // 
            this.预测数据ToolStripMenuItem.Name = "预测数据ToolStripMenuItem";
            this.预测数据ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.预测数据ToolStripMenuItem.Text = "预测数据";
            this.预测数据ToolStripMenuItem.Click += new System.EventHandler(this.预测数据ToolStripMenuItem_Click);
            // 
            // 保存文件ToolStripMenuItem1
            // 
            this.保存文件ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存raw文件ToolStripMenuItem1,
            this.打开raw文件ToolStripMenuItem});
            this.保存文件ToolStripMenuItem1.Name = "保存文件ToolStripMenuItem1";
            this.保存文件ToolStripMenuItem1.Size = new System.Drawing.Size(81, 24);
            this.保存文件ToolStripMenuItem1.Text = "打开文件";
            // 
            // 保存raw文件ToolStripMenuItem1
            // 
            this.保存raw文件ToolStripMenuItem1.Name = "保存raw文件ToolStripMenuItem1";
            this.保存raw文件ToolStripMenuItem1.Size = new System.Drawing.Size(170, 26);
            this.保存raw文件ToolStripMenuItem1.Text = "打开jpg文件";
            this.保存raw文件ToolStripMenuItem1.Click += new System.EventHandler(this.保存raw文件ToolStripMenuItem1_Click);
            // 
            // 打开raw文件ToolStripMenuItem
            // 
            this.打开raw文件ToolStripMenuItem.Name = "打开raw文件ToolStripMenuItem";
            this.打开raw文件ToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.打开raw文件ToolStripMenuItem.Text = "打开raw文件";
            this.打开raw文件ToolStripMenuItem.Click += new System.EventHandler(this.打开raw文件ToolStripMenuItem_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(1019, 141);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(491, 557);
            this.chart1.TabIndex = 24;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label4_Nowmax
            // 
            this.label4_Nowmax.AutoSize = true;
            this.label4_Nowmax.Location = new System.Drawing.Point(28, 429);
            this.label4_Nowmax.Name = "label4_Nowmax";
            this.label4_Nowmax.Size = new System.Drawing.Size(112, 15);
            this.label4_Nowmax.TabIndex = 26;
            this.label4_Nowmax.Text = "当前帧最高温度";
            this.label4_Nowmax.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_now_maxData
            // 
            this.label_now_maxData.AutoSize = true;
            this.label_now_maxData.Location = new System.Drawing.Point(28, 465);
            this.label_now_maxData.Name = "label_now_maxData";
            this.label_now_maxData.Size = new System.Drawing.Size(15, 15);
            this.label_now_maxData.TabIndex = 27;
            this.label_now_maxData.Text = "0";
            // 
            // label_min_dataTem
            // 
            this.label_min_dataTem.AutoSize = true;
            this.label_min_dataTem.Location = new System.Drawing.Point(28, 553);
            this.label_min_dataTem.Name = "label_min_dataTem";
            this.label_min_dataTem.Size = new System.Drawing.Size(15, 15);
            this.label_min_dataTem.TabIndex = 29;
            this.label_min_dataTem.Text = "0";
            // 
            // label_minData
            // 
            this.label_minData.AutoSize = true;
            this.label_minData.Location = new System.Drawing.Point(28, 517);
            this.label_minData.Name = "label_minData";
            this.label_minData.Size = new System.Drawing.Size(112, 15);
            this.label_minData.TabIndex = 28;
            this.label_minData.Text = "当前帧最低温度";
            this.label_minData.Click += new System.EventHandler(this.label_minData_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 875);
            this.Controls.Add(this.label_min_dataTem);
            this.Controls.Add(this.label_minData);
            this.Controls.Add(this.label_now_maxData);
            this.Controls.Add(this.label4_Nowmax);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.系统工具栏);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label_maxTem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_rectangleavgtempe);
            this.Controls.Add(this.label_tem3);
            this.Controls.Add(this.label_rectangletempe);
            this.Controls.Add(this.label_tem2);
            this.Controls.Add(this.label_pointtempe);
            this.Controls.Add(this.label_tem1);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IResearch_Demo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.系统工具栏.ResumeLayout(false);
            this.系统工具栏.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_pointtempe;
        private System.Windows.Forms.Label label_tem1;
        private System.Windows.Forms.Label label_rectangletempe;
        private System.Windows.Forms.Label label_tem2;
        private System.Windows.Forms.Label label_rectangleavgtempe;
        private System.Windows.Forms.Label label_tem3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_maxTem;
        private System.Windows.Forms.StatusStrip 系统工具栏;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统工具栏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开相机ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭相机ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存jpg文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存raw文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 模型预测ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 预测数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setcamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存文件ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 保存raw文件ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 打开raw文件ToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4_Nowmax;
        private System.Windows.Forms.Label label_now_maxData;
        private System.Windows.Forms.Label label_min_dataTem;
        private System.Windows.Forms.Label label_minData;
    }
}

