namespace 机械双动
{
    partial class 主界面
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
            this.mu选项状态栏 = new System.Windows.Forms.MenuStrip();
            this.mu_1_文件 = new System.Windows.Forms.ToolStripMenuItem();
            this.mu_2_打开测试数据 = new System.Windows.Forms.ToolStripMenuItem();
            this.mu_2_新建测试数据 = new System.Windows.Forms.ToolStripMenuItem();
            this.mu_1_参数设置 = new System.Windows.Forms.ToolStripMenuItem();
            this.mu_1_关于 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mu选项状态栏.SuspendLayout();
            this.SuspendLayout();
            // 
            // mu选项状态栏
            // 
            this.mu选项状态栏.BackColor = System.Drawing.Color.LightGray;
            this.mu选项状态栏.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mu选项状态栏.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mu_1_文件,
            this.mu_1_参数设置,
            this.mu_1_关于});
            this.mu选项状态栏.Location = new System.Drawing.Point(0, 0);
            this.mu选项状态栏.Name = "mu选项状态栏";
            this.mu选项状态栏.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mu选项状态栏.Size = new System.Drawing.Size(1066, 25);
            this.mu选项状态栏.TabIndex = 0;
            this.mu选项状态栏.Text = "mu选项状态栏";
            // 
            // mu_1_文件
            // 
            this.mu_1_文件.Checked = true;
            this.mu_1_文件.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mu_1_文件.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mu_1_文件.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mu_2_打开测试数据,
            this.mu_2_新建测试数据});
            this.mu_1_文件.Name = "mu_1_文件";
            this.mu_1_文件.Size = new System.Drawing.Size(44, 21);
            this.mu_1_文件.Text = "文件";
            // 
            // mu_2_打开测试数据
            // 
            this.mu_2_打开测试数据.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mu_2_打开测试数据.Name = "mu_2_打开测试数据";
            this.mu_2_打开测试数据.Size = new System.Drawing.Size(180, 22);
            this.mu_2_打开测试数据.Text = "打开实验历史";
            this.mu_2_打开测试数据.Click += new System.EventHandler(this.mu_2_打开测试数据_Click);
            // 
            // mu_2_新建测试数据
            // 
            this.mu_2_新建测试数据.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mu_2_新建测试数据.Name = "mu_2_新建测试数据";
            this.mu_2_新建测试数据.Size = new System.Drawing.Size(180, 22);
            this.mu_2_新建测试数据.Text = "新建实验数据";
            this.mu_2_新建测试数据.Click += new System.EventHandler(this.mu_2_新建测试数据_Click);
            // 
            // mu_1_参数设置
            // 
            this.mu_1_参数设置.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mu_1_参数设置.Name = "mu_1_参数设置";
            this.mu_1_参数设置.Size = new System.Drawing.Size(68, 21);
            this.mu_1_参数设置.Text = "参数设置";
            this.mu_1_参数设置.Click += new System.EventHandler(this.mu_1_参数设置_Click);
            // 
            // mu_1_关于
            // 
            this.mu_1_关于.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mu_1_关于.Name = "mu_1_关于";
            this.mu_1_关于.Size = new System.Drawing.Size(44, 21);
            this.mu_1_关于.Text = "关于";
            this.mu_1_关于.Click += new System.EventHandler(this.mu_1_关于_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 618);
            this.panel1.TabIndex = 1;
            // 
            // 主界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 642);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mu选项状态栏);
            this.HelpButton = true;
            this.MainMenuStrip = this.mu选项状态栏;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "主界面";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "摩擦力试验机";
            this.mu选项状态栏.ResumeLayout(false);
            this.mu选项状态栏.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip mu选项状态栏;
        private System.Windows.Forms.ToolStripMenuItem mu_1_文件;
        private System.Windows.Forms.ToolStripMenuItem mu_2_打开测试数据;
        private System.Windows.Forms.ToolStripMenuItem mu_2_新建测试数据;
        private System.Windows.Forms.ToolStripMenuItem mu_1_参数设置;
        private System.Windows.Forms.ToolStripMenuItem mu_1_关于;
        private System.Windows.Forms.Panel panel1;
    }
}