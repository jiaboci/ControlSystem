using System.Windows.Forms.DataVisualization.Charting;

namespace 机械双动
{
    partial class 测试界面
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_normal = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn__gradient_noise = new System.Windows.Forms.RadioButton();
            this.btn__interruption = new System.Windows.Forms.RadioButton();
            this.btn_low = new System.Windows.Forms.CheckBox();
            this.btn_medium = new System.Windows.Forms.CheckBox();
            this.btn__data_corruption = new System.Windows.Forms.RadioButton();
            this.btn_high = new System.Windows.Forms.CheckBox();
            this.mychart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mychart)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1042, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "运行界面";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_normal);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.mychart);
            this.panel1.Location = new System.Drawing.Point(7, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 555);
            this.panel1.TabIndex = 5;
            // 
            // btn_normal
            // 
            this.btn_normal.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_normal.AutoSize = true;
            this.btn_normal.BackColor = System.Drawing.SystemColors.Control;
            this.btn_normal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_normal.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_normal.Location = new System.Drawing.Point(514, 491);
            this.btn_normal.Margin = new System.Windows.Forms.Padding(0);
            this.btn_normal.Name = "btn_normal";
            this.btn_normal.Size = new System.Drawing.Size(85, 30);
            this.btn_normal.TabIndex = 11;
            this.btn_normal.Text = "normal";
            this.btn_normal.UseVisualStyleBackColor = false;
            this.btn_normal.CheckedChanged += new System.EventHandler(this.btn_normal_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn__gradient_noise);
            this.panel2.Controls.Add(this.btn__interruption);
            this.panel2.Controls.Add(this.btn_low);
            this.panel2.Controls.Add(this.btn_medium);
            this.panel2.Controls.Add(this.btn__data_corruption);
            this.panel2.Controls.Add(this.btn_high);
            this.panel2.Location = new System.Drawing.Point(2, 491);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 69);
            this.panel2.TabIndex = 10;
            // 
            // btn__gradient_noise
            // 
            this.btn__gradient_noise.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn__gradient_noise.AutoSize = true;
            this.btn__gradient_noise.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btn__gradient_noise.Location = new System.Drawing.Point(336, 1);
            this.btn__gradient_noise.Margin = new System.Windows.Forms.Padding(0);
            this.btn__gradient_noise.Name = "btn__gradient_noise";
            this.btn__gradient_noise.Size = new System.Drawing.Size(173, 30);
            this.btn__gradient_noise.TabIndex = 13;
            this.btn__gradient_noise.TabStop = true;
            this.btn__gradient_noise.Text = "gradient_noise";
            this.btn__gradient_noise.UseVisualStyleBackColor = true;
            this.btn__gradient_noise.CheckedChanged += new System.EventHandler(this.btn__gradient_noise_CheckedChanged);
            // 
            // btn__interruption
            // 
            this.btn__interruption.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn__interruption.AutoSize = true;
            this.btn__interruption.Enabled = false;
            this.btn__interruption.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btn__interruption.Location = new System.Drawing.Point(185, 1);
            this.btn__interruption.Margin = new System.Windows.Forms.Padding(0);
            this.btn__interruption.Name = "btn__interruption";
            this.btn__interruption.Size = new System.Drawing.Size(151, 30);
            this.btn__interruption.TabIndex = 14;
            this.btn__interruption.TabStop = true;
            this.btn__interruption.Text = "interruption";
            this.btn__interruption.UseVisualStyleBackColor = true;
            this.btn__interruption.CheckedChanged += new System.EventHandler(this.btn__interruption_CheckedChanged);
            // 
            // btn_low
            // 
            this.btn_low.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_low.AutoSize = true;
            this.btn_low.BackColor = System.Drawing.SystemColors.Control;
            this.btn_low.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_low.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_low.Location = new System.Drawing.Point(1, 34);
            this.btn_low.Margin = new System.Windows.Forms.Padding(0);
            this.btn_low.Name = "btn_low";
            this.btn_low.Size = new System.Drawing.Size(52, 30);
            this.btn_low.TabIndex = 5;
            this.btn_low.Text = "low";
            this.btn_low.UseVisualStyleBackColor = false;
            this.btn_low.CheckedChanged += new System.EventHandler(this.btn_low_CheckedChanged);
            // 
            // btn_medium
            // 
            this.btn_medium.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_medium.AutoSize = true;
            this.btn_medium.BackColor = System.Drawing.SystemColors.Control;
            this.btn_medium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_medium.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_medium.Location = new System.Drawing.Point(185, 34);
            this.btn_medium.Margin = new System.Windows.Forms.Padding(0);
            this.btn_medium.Name = "btn_medium";
            this.btn_medium.Size = new System.Drawing.Size(85, 30);
            this.btn_medium.TabIndex = 6;
            this.btn_medium.Text = "medium";
            this.btn_medium.UseVisualStyleBackColor = false;
            this.btn_medium.CheckedChanged += new System.EventHandler(this.btn_medium_CheckedChanged);
            // 
            // btn__data_corruption
            // 
            this.btn__data_corruption.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn__data_corruption.AutoSize = true;
            this.btn__data_corruption.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btn__data_corruption.Location = new System.Drawing.Point(1, 1);
            this.btn__data_corruption.Margin = new System.Windows.Forms.Padding(0);
            this.btn__data_corruption.Name = "btn__data_corruption";
            this.btn__data_corruption.Size = new System.Drawing.Size(184, 30);
            this.btn__data_corruption.TabIndex = 12;
            this.btn__data_corruption.Text = "data_corruption";
            this.btn__data_corruption.UseVisualStyleBackColor = true;
            this.btn__data_corruption.CheckedChanged += new System.EventHandler(this.btn__data_corruption_CheckedChanged);
            // 
            // btn_high
            // 
            this.btn_high.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_high.AutoSize = true;
            this.btn_high.BackColor = System.Drawing.SystemColors.Control;
            this.btn_high.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_high.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_high.Location = new System.Drawing.Point(357, 34);
            this.btn_high.Margin = new System.Windows.Forms.Padding(0);
            this.btn_high.Name = "btn_high";
            this.btn_high.Size = new System.Drawing.Size(63, 30);
            this.btn_high.TabIndex = 7;
            this.btn_high.Text = "high";
            this.btn_high.UseVisualStyleBackColor = false;
            this.btn_high.CheckedChanged += new System.EventHandler(this.btn_high_CheckedChanged);
            // 
            // mychart
            // 
            this.mychart.BackColor = System.Drawing.SystemColors.Control;
            this.mychart.BorderlineColor = System.Drawing.Color.Black;
            this.mychart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.mychart.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.BackColor = System.Drawing.SystemColors.Control;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.mychart.Legends.Add(legend1);
            this.mychart.Location = new System.Drawing.Point(0, 0);
            this.mychart.Margin = new System.Windows.Forms.Padding(2);
            this.mychart.Name = "mychart";
            this.mychart.Size = new System.Drawing.Size(1031, 487);
            this.mychart.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1050, 602);
            this.tabControl1.TabIndex = 11;
            // 
            // 测试界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1050, 602);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "测试界面";
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mychart)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.Load += 测试界面_Load;
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Chart mychart;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.CheckBox btn_low;
        private System.Windows.Forms.CheckBox btn_medium;
        private System.Windows.Forms.CheckBox btn_high;
        private System.Windows.Forms.CheckBox btn_normal;
        private System.Windows.Forms.RadioButton btn__gradient_noise;
        private System.Windows.Forms.RadioButton btn__interruption;
        private System.Windows.Forms.RadioButton btn__data_corruption;
    }
}

