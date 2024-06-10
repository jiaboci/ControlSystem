namespace OP40
{
    partial class 密码
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
            this.bn确认 = new System.Windows.Forms.Button();
            this.bn取消 = new System.Windows.Forms.Button();
            this.txt密码框 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bn确认
            // 
            this.bn确认.BackColor = System.Drawing.SystemColors.Info;
            this.bn确认.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bn确认.Location = new System.Drawing.Point(109, 254);
            this.bn确认.Name = "bn确认";
            this.bn确认.Size = new System.Drawing.Size(120, 50);
            this.bn确认.TabIndex = 0;
            this.bn确认.Text = "确  认";
            this.bn确认.UseVisualStyleBackColor = false;
            this.bn确认.Click += new System.EventHandler(this.bn确认_Click);
            // 
            // bn取消
            // 
            this.bn取消.BackColor = System.Drawing.SystemColors.Info;
            this.bn取消.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bn取消.Location = new System.Drawing.Point(350, 254);
            this.bn取消.Name = "bn取消";
            this.bn取消.Size = new System.Drawing.Size(120, 50);
            this.bn取消.TabIndex = 1;
            this.bn取消.Text = "取  消";
            this.bn取消.UseVisualStyleBackColor = false;
            this.bn取消.Click += new System.EventHandler(this.bn取消_Click);
            // 
            // txt密码框
            // 
            this.txt密码框.Location = new System.Drawing.Point(165, 155);
            this.txt密码框.MaxLength = 10;
            this.txt密码框.Name = "txt密码框";
            this.txt密码框.ShortcutsEnabled = false;
            this.txt密码框.Size = new System.Drawing.Size(250, 25);
            this.txt密码框.TabIndex = 2;
            this.txt密码框.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(215, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "请输入密码";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bn取消);
            this.panel1.Controls.Add(this.txt密码框);
            this.panel1.Controls.Add(this.bn确认);
            this.panel1.Location = new System.Drawing.Point(80, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 375);
            this.panel1.TabIndex = 4;
            // 
            // 密码
            // 
            this.AcceptButton = this.bn确认;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.bn取消;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "密码";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bn确认;
        private System.Windows.Forms.Button bn取消;
        private System.Windows.Forms.TextBox txt密码框;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}