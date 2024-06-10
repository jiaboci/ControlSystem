using System.Windows.Forms.DataVisualization.Charting;

namespace 摩擦力试验机
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
            this.btn_1压力 = new System.Windows.Forms.CheckBox();
            this.btn_2压力 = new System.Windows.Forms.CheckBox();
            this.btn_3压力 = new System.Windows.Forms.CheckBox();
            this.btn_4压力 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_锁定 = new System.Windows.Forms.CheckBox();
            this.btn_delet = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_sleep = new System.Windows.Forms.CheckBox();
            this.mychart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_esc = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_选择自动 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ledplc写 = new zyj.MyControl.MyRectLED();
            this.ledplc读 = new zyj.MyControl.MyRectLED();
            this.ledPLC = new zyj.MyControl.MyRectLED();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.led心跳 = new zyj.MyControl.MyRectLED();
            this.panel3 = new System.Windows.Forms.Panel();
            this.check_4压力 = new System.Windows.Forms.CheckBox();
            this.check_3压力 = new System.Windows.Forms.CheckBox();
            this.check_2压力 = new System.Windows.Forms.CheckBox();
            this.check_1压力 = new System.Windows.Forms.CheckBox();
            this.txt振频率下 = new System.Windows.Forms.TextBox();
            this.txt振频率上 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.txt目标次数下 = new System.Windows.Forms.TextBox();
            this.txt目标次数上 = new System.Windows.Forms.TextBox();
            this.txt1压力 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.txt当前运行次数下 = new System.Windows.Forms.TextBox();
            this.txt当前运行次数上 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.txt4温度 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.txt3温度 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.txt2温度 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.txt1温度 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.txt4压力 = new System.Windows.Forms.TextBox();
            this.txt3压力 = new System.Windows.Forms.TextBox();
            this.txt2压力 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_下激振频 = new System.Windows.Forms.NumericUpDown();
            this.txt_上激振频 = new System.Windows.Forms.NumericUpDown();
            this.txt_下激振数 = new System.Windows.Forms.NumericUpDown();
            this.txt_上激振数 = new System.Windows.Forms.NumericUpDown();
            this.led_冷却水选择 = new zyj.MyControl.MyRectLED();
            this.led_温度保护 = new zyj.MyControl.MyRectLED();
            this.led_压力保护 = new zyj.MyControl.MyRectLED();
            this.btn_冷却水启动 = new System.Windows.Forms.CheckBox();
            this.btn_停止下 = new System.Windows.Forms.Button();
            this.btn_停止上 = new System.Windows.Forms.Button();
            this.btn_启动下 = new System.Windows.Forms.Button();
            this.btn_启动上 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbook = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mychart)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_下激振频)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_上激振频)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_下激振数)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_上激振数)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_1压力
            // 
            this.btn_1压力.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_1压力.AutoSize = true;
            this.btn_1压力.BackColor = System.Drawing.SystemColors.Control;
            this.btn_1压力.Checked = true;
            this.btn_1压力.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btn_1压力.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1压力.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_1压力.Location = new System.Drawing.Point(1, 1);
            this.btn_1压力.Margin = new System.Windows.Forms.Padding(2);
            this.btn_1压力.Name = "btn_1压力";
            this.btn_1压力.Size = new System.Drawing.Size(83, 30);
            this.btn_1压力.TabIndex = 1;
            this.btn_1压力.Text = "1#压力";
            this.btn_1压力.UseVisualStyleBackColor = false;
            this.btn_1压力.CheckedChanged += new System.EventHandler(this.btn_1压力_CheckedChanged);
            // 
            // btn_2压力
            // 
            this.btn_2压力.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_2压力.AutoSize = true;
            this.btn_2压力.BackColor = System.Drawing.SystemColors.Control;
            this.btn_2压力.Checked = true;
            this.btn_2压力.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btn_2压力.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2压力.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_2压力.Location = new System.Drawing.Point(82, 1);
            this.btn_2压力.Margin = new System.Windows.Forms.Padding(2);
            this.btn_2压力.Name = "btn_2压力";
            this.btn_2压力.Size = new System.Drawing.Size(83, 30);
            this.btn_2压力.TabIndex = 2;
            this.btn_2压力.Text = "2#压力";
            this.btn_2压力.UseVisualStyleBackColor = false;
            this.btn_2压力.CheckedChanged += new System.EventHandler(this.btn_2压力_CheckedChanged);
            // 
            // btn_3压力
            // 
            this.btn_3压力.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_3压力.AutoSize = true;
            this.btn_3压力.BackColor = System.Drawing.SystemColors.Control;
            this.btn_3压力.Checked = true;
            this.btn_3压力.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btn_3压力.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3压力.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_3压力.Location = new System.Drawing.Point(163, 1);
            this.btn_3压力.Margin = new System.Windows.Forms.Padding(2);
            this.btn_3压力.Name = "btn_3压力";
            this.btn_3压力.Size = new System.Drawing.Size(83, 30);
            this.btn_3压力.TabIndex = 3;
            this.btn_3压力.Text = "3#压力";
            this.btn_3压力.UseVisualStyleBackColor = false;
            this.btn_3压力.CheckedChanged += new System.EventHandler(this.btn_3压力_CheckedChanged);
            // 
            // btn_4压力
            // 
            this.btn_4压力.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_4压力.AutoSize = true;
            this.btn_4压力.BackColor = System.Drawing.SystemColors.Control;
            this.btn_4压力.Checked = true;
            this.btn_4压力.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btn_4压力.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4压力.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_4压力.Location = new System.Drawing.Point(244, 1);
            this.btn_4压力.Margin = new System.Windows.Forms.Padding(2);
            this.btn_4压力.Name = "btn_4压力";
            this.btn_4压力.Size = new System.Drawing.Size(83, 30);
            this.btn_4压力.TabIndex = 4;
            this.btn_4压力.Text = "4#压力";
            this.btn_4压力.UseVisualStyleBackColor = false;
            this.btn_4压力.CheckedChanged += new System.EventHandler(this.btn_4压力_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.mychart);
            this.panel1.Location = new System.Drawing.Point(345, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 475);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_锁定);
            this.panel2.Controls.Add(this.btn_delet);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.btn_reset);
            this.panel2.Controls.Add(this.btn_sleep);
            this.panel2.Controls.Add(this.btn_1压力);
            this.panel2.Controls.Add(this.btn_2压力);
            this.panel2.Controls.Add(this.btn_3压力);
            this.panel2.Controls.Add(this.btn_4压力);
            this.panel2.Location = new System.Drawing.Point(2, 428);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 31);
            this.panel2.TabIndex = 10;
            // 
            // btn_锁定
            // 
            this.btn_锁定.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_锁定.AutoSize = true;
            this.btn_锁定.BackColor = System.Drawing.SystemColors.Control;
            this.btn_锁定.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_锁定.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_锁定.Location = new System.Drawing.Point(389, 1);
            this.btn_锁定.Margin = new System.Windows.Forms.Padding(0);
            this.btn_锁定.Name = "btn_锁定";
            this.btn_锁定.Size = new System.Drawing.Size(61, 30);
            this.btn_锁定.TabIndex = 13;
            this.btn_锁定.Text = "锁定";
            this.btn_锁定.UseVisualStyleBackColor = false;
            this.btn_锁定.CheckedChanged += new System.EventHandler(this.btn_锁定_CheckedChanged);
            // 
            // btn_delet
            // 
            this.btn_delet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delet.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_delet.Location = new System.Drawing.Point(501, 1);
            this.btn_delet.Margin = new System.Windows.Forms.Padding(0);
            this.btn_delet.Name = "btn_delet";
            this.btn_delet.Size = new System.Drawing.Size(64, 30);
            this.btn_delet.TabIndex = 12;
            this.btn_delet.Text = "复位";
            this.btn_delet.UseVisualStyleBackColor = true;
            this.btn_delet.Click += new System.EventHandler(this.btn_delet_Click);
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_save.Location = new System.Drawing.Point(564, 1);
            this.btn_save.Margin = new System.Windows.Forms.Padding(0);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(64, 30);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_reset.Location = new System.Drawing.Point(326, 1);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(64, 30);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "视图";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_sleep
            // 
            this.btn_sleep.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_sleep.AutoSize = true;
            this.btn_sleep.BackColor = System.Drawing.SystemColors.Control;
            this.btn_sleep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sleep.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sleep.Location = new System.Drawing.Point(627, 1);
            this.btn_sleep.Margin = new System.Windows.Forms.Padding(0);
            this.btn_sleep.Name = "btn_sleep";
            this.btn_sleep.Size = new System.Drawing.Size(61, 30);
            this.btn_sleep.TabIndex = 6;
            this.btn_sleep.Text = "暂停";
            this.btn_sleep.UseVisualStyleBackColor = false;
            this.btn_sleep.CheckedChanged += new System.EventHandler(this.btn_sleep_CheckedChanged);
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
            this.mychart.Size = new System.Drawing.Size(693, 424);
            this.mychart.TabIndex = 7;
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.SystemColors.Info;
            this.btn_stop.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_stop.Location = new System.Drawing.Point(401, 5);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(0);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(128, 56);
            this.btn_stop.TabIndex = 6;
            this.btn_stop.Text = "同步停止";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_esc
            // 
            this.btn_esc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_esc.BackColor = System.Drawing.SystemColors.Info;
            this.btn_esc.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_esc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_esc.Location = new System.Drawing.Point(4, 5);
            this.btn_esc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_esc.Name = "btn_esc";
            this.btn_esc.Size = new System.Drawing.Size(128, 56);
            this.btn_esc.TabIndex = 6;
            this.btn_esc.Text = "保存并退出";
            this.btn_esc.UseVisualStyleBackColor = false;
            this.btn_esc.Click += new System.EventHandler(this.btn_esc_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // btn_start
            // 
            this.btn_start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_start.BackColor = System.Drawing.SystemColors.Info;
            this.btn_start.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_start.Location = new System.Drawing.Point(268, 5);
            this.btn_start.Margin = new System.Windows.Forms.Padding(2);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(128, 56);
            this.btn_start.TabIndex = 7;
            this.btn_start.Text = "同步启动";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_选择自动
            // 
            this.btn_选择自动.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_选择自动.BackColor = System.Drawing.SystemColors.Info;
            this.btn_选择自动.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_选择自动.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_选择自动.Location = new System.Drawing.Point(136, 5);
            this.btn_选择自动.Margin = new System.Windows.Forms.Padding(2);
            this.btn_选择自动.Name = "btn_选择自动";
            this.btn_选择自动.Size = new System.Drawing.Size(128, 56);
            this.btn_选择自动.TabIndex = 9;
            this.btn_选择自动.Text = "自  动";
            this.btn_选择自动.UseVisualStyleBackColor = false;
            this.btn_选择自动.Click += new System.EventHandler(this.btn_选择自动_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.ledplc写);
            this.tabPage1.Controls.Add(this.btn_stop);
            this.tabPage1.Controls.Add(this.ledplc读);
            this.tabPage1.Controls.Add(this.ledPLC);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.led心跳);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btn_esc);
            this.tabPage1.Controls.Add(this.btn_选择自动);
            this.tabPage1.Controls.Add(this.btn_start);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1042, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "运行界面";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(822, 47);
            this.label13.Margin = new System.Windows.Forms.Padding(3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 16);
            this.label13.TabIndex = 49;
            this.label13.Text = "PLC写状态";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(822, 12);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 16);
            this.label12.TabIndex = 48;
            this.label12.Text = "PLC读状态";
            // 
            // ledplc写
            // 
            this.ledplc写.Color1 = System.Drawing.Color.DarkGray;
            this.ledplc写.Color2 = System.Drawing.Color.SeaGreen;
            this.ledplc写.Color3 = System.Drawing.Color.Red;
            this.ledplc写.Color4 = System.Drawing.Color.DarkGoldenrod;
            this.ledplc写.Color5 = System.Drawing.Color.Blue;
            this.ledplc写.CurrentValue = 1;
            this.ledplc写.Location = new System.Drawing.Point(911, 41);
            this.ledplc写.Margin = new System.Windows.Forms.Padding(160, 81, 160, 81);
            this.ledplc写.Name = "ledplc写";
            this.ledplc写.Size = new System.Drawing.Size(20, 20);
            this.ledplc写.TabIndex = 48;
            // 
            // ledplc读
            // 
            this.ledplc读.Color1 = System.Drawing.Color.DarkGray;
            this.ledplc读.Color2 = System.Drawing.Color.SeaGreen;
            this.ledplc读.Color3 = System.Drawing.Color.Red;
            this.ledplc读.Color4 = System.Drawing.Color.DarkGoldenrod;
            this.ledplc读.Color5 = System.Drawing.Color.Blue;
            this.ledplc读.CurrentValue = 1;
            this.ledplc读.Location = new System.Drawing.Point(911, 8);
            this.ledplc读.Margin = new System.Windows.Forms.Padding(80, 44, 80, 44);
            this.ledplc读.Name = "ledplc读";
            this.ledplc读.Size = new System.Drawing.Size(20, 20);
            this.ledplc读.TabIndex = 47;
            // 
            // ledPLC
            // 
            this.ledPLC.Color1 = System.Drawing.Color.DarkGray;
            this.ledPLC.Color2 = System.Drawing.Color.SeaGreen;
            this.ledPLC.Color3 = System.Drawing.Color.Red;
            this.ledPLC.Color4 = System.Drawing.Color.DarkGoldenrod;
            this.ledPLC.Color5 = System.Drawing.Color.Blue;
            this.ledPLC.CurrentValue = 1;
            this.ledPLC.Location = new System.Drawing.Point(1013, 41);
            this.ledPLC.Margin = new System.Windows.Forms.Padding(80, 44, 80, 44);
            this.ledPLC.Name = "ledPLC";
            this.ledPLC.Size = new System.Drawing.Size(20, 20);
            this.ledPLC.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(943, 47);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 48;
            this.label11.Text = "PLC连接";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(943, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 47;
            this.label10.Text = "PLC心跳";
            // 
            // led心跳
            // 
            this.led心跳.Color1 = System.Drawing.Color.DarkGray;
            this.led心跳.Color2 = System.Drawing.Color.SeaGreen;
            this.led心跳.Color3 = System.Drawing.Color.Red;
            this.led心跳.Color4 = System.Drawing.Color.DarkGoldenrod;
            this.led心跳.Color5 = System.Drawing.Color.Blue;
            this.led心跳.CurrentValue = 1;
            this.led心跳.Location = new System.Drawing.Point(1013, 8);
            this.led心跳.Margin = new System.Windows.Forms.Padding(40, 24, 40, 24);
            this.led心跳.Name = "led心跳";
            this.led心跳.Size = new System.Drawing.Size(20, 20);
            this.led心跳.TabIndex = 46;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.check_4压力);
            this.panel3.Controls.Add(this.check_3压力);
            this.panel3.Controls.Add(this.check_2压力);
            this.panel3.Controls.Add(this.check_1压力);
            this.panel3.Controls.Add(this.txt振频率下);
            this.panel3.Controls.Add(this.txt振频率上);
            this.panel3.Controls.Add(this.textBox26);
            this.panel3.Controls.Add(this.txt目标次数下);
            this.panel3.Controls.Add(this.txt目标次数上);
            this.panel3.Controls.Add(this.txt1压力);
            this.panel3.Controls.Add(this.textBox22);
            this.panel3.Controls.Add(this.txt当前运行次数下);
            this.panel3.Controls.Add(this.txt当前运行次数上);
            this.panel3.Controls.Add(this.textBox20);
            this.panel3.Controls.Add(this.txt4温度);
            this.panel3.Controls.Add(this.textBox14);
            this.panel3.Controls.Add(this.txt3温度);
            this.panel3.Controls.Add(this.textBox16);
            this.panel3.Controls.Add(this.txt2温度);
            this.panel3.Controls.Add(this.textBox12);
            this.panel3.Controls.Add(this.txt1温度);
            this.panel3.Controls.Add(this.textBox10);
            this.panel3.Controls.Add(this.txt4压力);
            this.panel3.Controls.Add(this.txt3压力);
            this.panel3.Controls.Add(this.txt2压力);
            this.panel3.Location = new System.Drawing.Point(4, 73);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 475);
            this.panel3.TabIndex = 11;
            // 
            // check_4压力
            // 
            this.check_4压力.Appearance = System.Windows.Forms.Appearance.Button;
            this.check_4压力.AutoSize = true;
            this.check_4压力.BackColor = System.Drawing.SystemColors.Control;
            this.check_4压力.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.check_4压力.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_4压力.Font = new System.Drawing.Font("宋体", 12F);
            this.check_4压力.Location = new System.Drawing.Point(2, 94);
            this.check_4压力.Margin = new System.Windows.Forms.Padding(2);
            this.check_4压力.Name = "check_4压力";
            this.check_4压力.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.check_4压力.Size = new System.Drawing.Size(129, 26);
            this.check_4压力.TabIndex = 40;
            this.check_4压力.Text = "4#压力(MD2632)";
            this.check_4压力.UseVisualStyleBackColor = false;
            this.check_4压力.CheckedChanged += new System.EventHandler(this.check_4压力_CheckedChanged);
            // 
            // check_3压力
            // 
            this.check_3压力.Appearance = System.Windows.Forms.Appearance.Button;
            this.check_3压力.AutoSize = true;
            this.check_3压力.BackColor = System.Drawing.SystemColors.Control;
            this.check_3压力.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.check_3压力.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_3压力.Font = new System.Drawing.Font("宋体", 12F);
            this.check_3压力.Location = new System.Drawing.Point(2, 65);
            this.check_3压力.Margin = new System.Windows.Forms.Padding(2);
            this.check_3压力.Name = "check_3压力";
            this.check_3压力.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.check_3压力.Size = new System.Drawing.Size(129, 26);
            this.check_3压力.TabIndex = 39;
            this.check_3压力.Text = "3#压力(MD2628)";
            this.check_3压力.UseVisualStyleBackColor = false;
            this.check_3压力.CheckedChanged += new System.EventHandler(this.check_3压力_CheckedChanged);
            // 
            // check_2压力
            // 
            this.check_2压力.Appearance = System.Windows.Forms.Appearance.Button;
            this.check_2压力.AutoSize = true;
            this.check_2压力.BackColor = System.Drawing.SystemColors.Control;
            this.check_2压力.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.check_2压力.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_2压力.Font = new System.Drawing.Font("宋体", 12F);
            this.check_2压力.Location = new System.Drawing.Point(2, 36);
            this.check_2压力.Margin = new System.Windows.Forms.Padding(2);
            this.check_2压力.Name = "check_2压力";
            this.check_2压力.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.check_2压力.Size = new System.Drawing.Size(129, 26);
            this.check_2压力.TabIndex = 38;
            this.check_2压力.Text = "2#压力(MD2624)";
            this.check_2压力.UseVisualStyleBackColor = false;
            this.check_2压力.CheckedChanged += new System.EventHandler(this.check_2压力_CheckedChanged);
            // 
            // check_1压力
            // 
            this.check_1压力.Appearance = System.Windows.Forms.Appearance.Button;
            this.check_1压力.AutoSize = true;
            this.check_1压力.BackColor = System.Drawing.SystemColors.Control;
            this.check_1压力.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.check_1压力.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_1压力.Font = new System.Drawing.Font("宋体", 12F);
            this.check_1压力.Location = new System.Drawing.Point(2, 6);
            this.check_1压力.Margin = new System.Windows.Forms.Padding(2);
            this.check_1压力.Name = "check_1压力";
            this.check_1压力.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.check_1压力.Size = new System.Drawing.Size(129, 26);
            this.check_1压力.TabIndex = 37;
            this.check_1压力.Text = "1#压力(MD2620)";
            this.check_1压力.UseVisualStyleBackColor = false;
            this.check_1压力.CheckedChanged += new System.EventHandler(this.check_1压力_CheckedChanged);
            // 
            // txt振频率下
            // 
            this.txt振频率下.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt振频率下.Location = new System.Drawing.Point(135, 433);
            this.txt振频率下.Margin = new System.Windows.Forms.Padding(2);
            this.txt振频率下.Name = "txt振频率下";
            this.txt振频率下.ReadOnly = true;
            this.txt振频率下.Size = new System.Drawing.Size(199, 26);
            this.txt振频率下.TabIndex = 36;
            this.txt振频率下.Text = "10.00";
            // 
            // txt振频率上
            // 
            this.txt振频率上.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt振频率上.Location = new System.Drawing.Point(135, 403);
            this.txt振频率上.Margin = new System.Windows.Forms.Padding(2);
            this.txt振频率上.Name = "txt振频率上";
            this.txt振频率上.ReadOnly = true;
            this.txt振频率上.Size = new System.Drawing.Size(199, 26);
            this.txt振频率上.TabIndex = 34;
            this.txt振频率上.Text = "10.00";
            // 
            // textBox26
            // 
            this.textBox26.BackColor = System.Drawing.SystemColors.Control;
            this.textBox26.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox26.Location = new System.Drawing.Point(2, 403);
            this.textBox26.Margin = new System.Windows.Forms.Padding(2);
            this.textBox26.Multiline = true;
            this.textBox26.Name = "textBox26";
            this.textBox26.ReadOnly = true;
            this.textBox26.Size = new System.Drawing.Size(129, 54);
            this.textBox26.TabIndex = 33;
            this.textBox26.Text = "振频率\r\n上激振(MD2700)\r\n下激振(MD2704)";
            this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt目标次数下
            // 
            this.txt目标次数下.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt目标次数下.Location = new System.Drawing.Point(135, 362);
            this.txt目标次数下.Margin = new System.Windows.Forms.Padding(2);
            this.txt目标次数下.Name = "txt目标次数下";
            this.txt目标次数下.ReadOnly = true;
            this.txt目标次数下.Size = new System.Drawing.Size(199, 26);
            this.txt目标次数下.TabIndex = 32;
            this.txt目标次数下.Text = "500";
            // 
            // txt目标次数上
            // 
            this.txt目标次数上.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt目标次数上.Location = new System.Drawing.Point(135, 332);
            this.txt目标次数上.Margin = new System.Windows.Forms.Padding(2);
            this.txt目标次数上.Name = "txt目标次数上";
            this.txt目标次数上.ReadOnly = true;
            this.txt目标次数上.Size = new System.Drawing.Size(199, 26);
            this.txt目标次数上.TabIndex = 31;
            this.txt目标次数上.Text = "500";
            // 
            // txt1压力
            // 
            this.txt1压力.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt1压力.Location = new System.Drawing.Point(135, 6);
            this.txt1压力.Margin = new System.Windows.Forms.Padding(2);
            this.txt1压力.Name = "txt1压力";
            this.txt1压力.ReadOnly = true;
            this.txt1压力.Size = new System.Drawing.Size(199, 26);
            this.txt1压力.TabIndex = 11;
            // 
            // textBox22
            // 
            this.textBox22.BackColor = System.Drawing.SystemColors.Control;
            this.textBox22.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox22.Location = new System.Drawing.Point(2, 332);
            this.textBox22.Margin = new System.Windows.Forms.Padding(2);
            this.textBox22.Multiline = true;
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            this.textBox22.Size = new System.Drawing.Size(129, 54);
            this.textBox22.TabIndex = 30;
            this.textBox22.Text = "目标次数\r\n上机振(MD2008)\r\n下机振(MD2012)";
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt当前运行次数下
            // 
            this.txt当前运行次数下.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt当前运行次数下.Location = new System.Drawing.Point(135, 295);
            this.txt当前运行次数下.Margin = new System.Windows.Forms.Padding(2);
            this.txt当前运行次数下.Name = "txt当前运行次数下";
            this.txt当前运行次数下.ReadOnly = true;
            this.txt当前运行次数下.Size = new System.Drawing.Size(199, 26);
            this.txt当前运行次数下.TabIndex = 29;
            this.txt当前运行次数下.Text = "0";
            // 
            // txt当前运行次数上
            // 
            this.txt当前运行次数上.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt当前运行次数上.Location = new System.Drawing.Point(135, 265);
            this.txt当前运行次数上.Margin = new System.Windows.Forms.Padding(2);
            this.txt当前运行次数上.Name = "txt当前运行次数上";
            this.txt当前运行次数上.ReadOnly = true;
            this.txt当前运行次数上.Size = new System.Drawing.Size(199, 26);
            this.txt当前运行次数上.TabIndex = 27;
            this.txt当前运行次数上.Text = "0";
            // 
            // textBox20
            // 
            this.textBox20.BackColor = System.Drawing.SystemColors.Control;
            this.textBox20.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox20.Location = new System.Drawing.Point(2, 265);
            this.textBox20.Margin = new System.Windows.Forms.Padding(2);
            this.textBox20.Multiline = true;
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.textBox20.Size = new System.Drawing.Size(129, 54);
            this.textBox20.TabIndex = 26;
            this.textBox20.Text = "当前运行次数\r\n上(MD2016)\r\n下(MD2020)";
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt4温度
            // 
            this.txt4温度.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt4温度.Location = new System.Drawing.Point(135, 222);
            this.txt4温度.Margin = new System.Windows.Forms.Padding(2);
            this.txt4温度.Name = "txt4温度";
            this.txt4温度.ReadOnly = true;
            this.txt4温度.Size = new System.Drawing.Size(199, 26);
            this.txt4温度.TabIndex = 25;
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.SystemColors.Control;
            this.textBox14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox14.Location = new System.Drawing.Point(2, 222);
            this.textBox14.Margin = new System.Windows.Forms.Padding(2);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(129, 26);
            this.textBox14.TabIndex = 24;
            this.textBox14.Text = "4#温度(MD2656)";
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt3温度
            // 
            this.txt3温度.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt3温度.Location = new System.Drawing.Point(135, 194);
            this.txt3温度.Margin = new System.Windows.Forms.Padding(2);
            this.txt3温度.Name = "txt3温度";
            this.txt3温度.ReadOnly = true;
            this.txt3温度.Size = new System.Drawing.Size(199, 26);
            this.txt3温度.TabIndex = 23;
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.SystemColors.Control;
            this.textBox16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox16.Location = new System.Drawing.Point(2, 194);
            this.textBox16.Margin = new System.Windows.Forms.Padding(2);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(129, 26);
            this.textBox16.TabIndex = 22;
            this.textBox16.Text = "3#温度(MD2652)";
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt2温度
            // 
            this.txt2温度.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt2温度.Location = new System.Drawing.Point(135, 165);
            this.txt2温度.Margin = new System.Windows.Forms.Padding(2);
            this.txt2温度.Name = "txt2温度";
            this.txt2温度.ReadOnly = true;
            this.txt2温度.Size = new System.Drawing.Size(199, 26);
            this.txt2温度.TabIndex = 21;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.Control;
            this.textBox12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox12.Location = new System.Drawing.Point(2, 165);
            this.textBox12.Margin = new System.Windows.Forms.Padding(2);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(129, 26);
            this.textBox12.TabIndex = 20;
            this.textBox12.Text = "2#温度(MD2648)";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt1温度
            // 
            this.txt1温度.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt1温度.Location = new System.Drawing.Point(135, 136);
            this.txt1温度.Margin = new System.Windows.Forms.Padding(2);
            this.txt1温度.Name = "txt1温度";
            this.txt1温度.ReadOnly = true;
            this.txt1温度.Size = new System.Drawing.Size(199, 26);
            this.txt1温度.TabIndex = 19;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.Control;
            this.textBox10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox10.Location = new System.Drawing.Point(2, 136);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(129, 26);
            this.textBox10.TabIndex = 18;
            this.textBox10.Text = "1#温度(MD2644)";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt4压力
            // 
            this.txt4压力.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt4压力.Location = new System.Drawing.Point(135, 94);
            this.txt4压力.Margin = new System.Windows.Forms.Padding(2);
            this.txt4压力.Name = "txt4压力";
            this.txt4压力.ReadOnly = true;
            this.txt4压力.Size = new System.Drawing.Size(199, 26);
            this.txt4压力.TabIndex = 17;
            // 
            // txt3压力
            // 
            this.txt3压力.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt3压力.Location = new System.Drawing.Point(135, 65);
            this.txt3压力.Margin = new System.Windows.Forms.Padding(2);
            this.txt3压力.Name = "txt3压力";
            this.txt3压力.ReadOnly = true;
            this.txt3压力.Size = new System.Drawing.Size(199, 26);
            this.txt3压力.TabIndex = 15;
            // 
            // txt2压力
            // 
            this.txt2压力.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt2压力.Location = new System.Drawing.Point(135, 36);
            this.txt2压力.Margin = new System.Windows.Forms.Padding(2);
            this.txt2压力.Name = "txt2压力";
            this.txt2压力.ReadOnly = true;
            this.txt2压力.Size = new System.Drawing.Size(199, 26);
            this.txt2压力.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.txt_下激振频);
            this.tabPage2.Controls.Add(this.txt_上激振频);
            this.tabPage2.Controls.Add(this.txt_下激振数);
            this.tabPage2.Controls.Add(this.txt_上激振数);
            this.tabPage2.Controls.Add(this.led_冷却水选择);
            this.tabPage2.Controls.Add(this.led_温度保护);
            this.tabPage2.Controls.Add(this.led_压力保护);
            this.tabPage2.Controls.Add(this.btn_冷却水启动);
            this.tabPage2.Controls.Add(this.btn_停止下);
            this.tabPage2.Controls.Add(this.btn_停止上);
            this.tabPage2.Controls.Add(this.btn_启动下);
            this.tabPage2.Controls.Add(this.btn_启动上);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBox31);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox33);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textbook);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBox24);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1042, 563);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "实验设置";
            // 
            // txt_下激振频
            // 
            this.txt_下激振频.DecimalPlaces = 2;
            this.txt_下激振频.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_下激振频.Increment = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.txt_下激振频.Location = new System.Drawing.Point(295, 45);
            this.txt_下激振频.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txt_下激振频.Name = "txt_下激振频";
            this.txt_下激振频.Size = new System.Drawing.Size(129, 28);
            this.txt_下激振频.TabIndex = 61;
            this.txt_下激振频.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txt_下激振频.ValueChanged += new System.EventHandler(this.txt_下激振频_ValueChanged);
            // 
            // txt_上激振频
            // 
            this.txt_上激振频.DecimalPlaces = 2;
            this.txt_上激振频.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_上激振频.Increment = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.txt_上激振频.Location = new System.Drawing.Point(295, 15);
            this.txt_上激振频.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txt_上激振频.Name = "txt_上激振频";
            this.txt_上激振频.Size = new System.Drawing.Size(129, 28);
            this.txt_上激振频.TabIndex = 60;
            this.txt_上激振频.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txt_上激振频.ValueChanged += new System.EventHandler(this.txt_上激振频_ValueChanged);
            // 
            // txt_下激振数
            // 
            this.txt_下激振数.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_下激振数.Location = new System.Drawing.Point(295, 144);
            this.txt_下激振数.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_下激振数.Name = "txt_下激振数";
            this.txt_下激振数.Size = new System.Drawing.Size(129, 28);
            this.txt_下激振数.TabIndex = 59;
            this.txt_下激振数.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.txt_下激振数.ValueChanged += new System.EventHandler(this.txt_下激振数_ValueChanged);
            // 
            // txt_上激振数
            // 
            this.txt_上激振数.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_上激振数.Location = new System.Drawing.Point(295, 114);
            this.txt_上激振数.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_上激振数.Name = "txt_上激振数";
            this.txt_上激振数.Size = new System.Drawing.Size(129, 28);
            this.txt_上激振数.TabIndex = 58;
            this.txt_上激振数.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.txt_上激振数.ValueChanged += new System.EventHandler(this.txt_上激振数_ValueChanged);
            // 
            // led_冷却水选择
            // 
            this.led_冷却水选择.Color1 = System.Drawing.Color.DarkGray;
            this.led_冷却水选择.Color2 = System.Drawing.Color.SeaGreen;
            this.led_冷却水选择.Color3 = System.Drawing.Color.Red;
            this.led_冷却水选择.Color4 = System.Drawing.Color.DarkGoldenrod;
            this.led_冷却水选择.Color5 = System.Drawing.Color.Blue;
            this.led_冷却水选择.CurrentValue = 1;
            this.led_冷却水选择.Location = new System.Drawing.Point(332, 345);
            this.led_冷却水选择.Margin = new System.Windows.Forms.Padding(320, 148, 320, 148);
            this.led_冷却水选择.Name = "led_冷却水选择";
            this.led_冷却水选择.Size = new System.Drawing.Size(32, 31);
            this.led_冷却水选择.TabIndex = 57;
            // 
            // led_温度保护
            // 
            this.led_温度保护.Color1 = System.Drawing.Color.DarkGray;
            this.led_温度保护.Color2 = System.Drawing.Color.SeaGreen;
            this.led_温度保护.Color3 = System.Drawing.Color.Red;
            this.led_温度保护.Color4 = System.Drawing.Color.DarkGoldenrod;
            this.led_温度保护.Color5 = System.Drawing.Color.Blue;
            this.led_温度保护.CurrentValue = 1;
            this.led_温度保护.Location = new System.Drawing.Point(166, 282);
            this.led_温度保护.Margin = new System.Windows.Forms.Padding(320, 148, 320, 148);
            this.led_温度保护.Name = "led_温度保护";
            this.led_温度保护.Size = new System.Drawing.Size(32, 31);
            this.led_温度保护.TabIndex = 56;
            // 
            // led_压力保护
            // 
            this.led_压力保护.Color1 = System.Drawing.Color.DarkGray;
            this.led_压力保护.Color2 = System.Drawing.Color.SeaGreen;
            this.led_压力保护.Color3 = System.Drawing.Color.Red;
            this.led_压力保护.Color4 = System.Drawing.Color.DarkGoldenrod;
            this.led_压力保护.Color5 = System.Drawing.Color.Blue;
            this.led_压力保护.CurrentValue = 1;
            this.led_压力保护.Location = new System.Drawing.Point(166, 222);
            this.led_压力保护.Margin = new System.Windows.Forms.Padding(160, 81, 160, 81);
            this.led_压力保护.Name = "led_压力保护";
            this.led_压力保护.Size = new System.Drawing.Size(32, 31);
            this.led_压力保护.TabIndex = 55;
            // 
            // btn_冷却水启动
            // 
            this.btn_冷却水启动.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_冷却水启动.AutoSize = true;
            this.btn_冷却水启动.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_冷却水启动.Location = new System.Drawing.Point(209, 345);
            this.btn_冷却水启动.Name = "btn_冷却水启动";
            this.btn_冷却水启动.Size = new System.Drawing.Size(104, 32);
            this.btn_冷却水启动.TabIndex = 54;
            this.btn_冷却水启动.Text = "M2600.2";
            this.btn_冷却水启动.UseVisualStyleBackColor = false;
            this.btn_冷却水启动.CheckedChanged += new System.EventHandler(this.btn_冷却水启动_CheckedChanged);
            // 
            // btn_停止下
            // 
            this.btn_停止下.BackColor = System.Drawing.SystemColors.Info;
            this.btn_停止下.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_停止下.Location = new System.Drawing.Point(681, 113);
            this.btn_停止下.Name = "btn_停止下";
            this.btn_停止下.Size = new System.Drawing.Size(110, 57);
            this.btn_停止下.TabIndex = 50;
            this.btn_停止下.Text = "下机振停止\r\n(M2600.6)";
            this.btn_停止下.UseVisualStyleBackColor = false;
            this.btn_停止下.Click += new System.EventHandler(this.btn_停止下_Click);
            // 
            // btn_停止上
            // 
            this.btn_停止上.BackColor = System.Drawing.SystemColors.Info;
            this.btn_停止上.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_停止上.Location = new System.Drawing.Point(681, 15);
            this.btn_停止上.Name = "btn_停止上";
            this.btn_停止上.Size = new System.Drawing.Size(110, 57);
            this.btn_停止上.TabIndex = 49;
            this.btn_停止上.Text = "上机振停止\r\n(M2600.5)";
            this.btn_停止上.UseVisualStyleBackColor = false;
            this.btn_停止上.Click += new System.EventHandler(this.btn_停止上_Click);
            // 
            // btn_启动下
            // 
            this.btn_启动下.BackColor = System.Drawing.SystemColors.Info;
            this.btn_启动下.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_启动下.Location = new System.Drawing.Point(523, 113);
            this.btn_启动下.Name = "btn_启动下";
            this.btn_启动下.Size = new System.Drawing.Size(110, 57);
            this.btn_启动下.TabIndex = 47;
            this.btn_启动下.Text = "下机振启动\r\n(M2600.4)";
            this.btn_启动下.UseVisualStyleBackColor = false;
            this.btn_启动下.Click += new System.EventHandler(this.btn_启动下_Click);
            // 
            // btn_启动上
            // 
            this.btn_启动上.BackColor = System.Drawing.SystemColors.Info;
            this.btn_启动上.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_启动上.Location = new System.Drawing.Point(523, 15);
            this.btn_启动上.Name = "btn_启动上";
            this.btn_启动上.Size = new System.Drawing.Size(110, 57);
            this.btn_启动上.TabIndex = 46;
            this.btn_启动上.Text = "上机振启动\r\n(M2600.3)";
            this.btn_启动上.UseVisualStyleBackColor = false;
            this.btn_启动上.Click += new System.EventHandler(this.btn_启动上_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 350);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "冷却水启动选择";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 291);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "温度保护";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 231);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "压力保护";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(429, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "次";
            // 
            // textBox31
            // 
            this.textBox31.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox31.Location = new System.Drawing.Point(166, 144);
            this.textBox31.Margin = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.textBox31.Name = "textBox31";
            this.textBox31.ReadOnly = true;
            this.textBox31.Size = new System.Drawing.Size(129, 28);
            this.textBox31.TabIndex = 11;
            this.textBox31.Text = "下激振(MD2012)";
            this.textBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(429, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "次";
            // 
            // textBox33
            // 
            this.textBox33.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox33.Location = new System.Drawing.Point(166, 114);
            this.textBox33.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.textBox33.Name = "textBox33";
            this.textBox33.ReadOnly = true;
            this.textBox33.Size = new System.Drawing.Size(129, 28);
            this.textBox33.TabIndex = 8;
            this.textBox33.Text = "上激振(MD2008)";
            this.textBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "实验次数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(429, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hz";
            // 
            // textbook
            // 
            this.textbook.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textbook.Location = new System.Drawing.Point(166, 45);
            this.textbook.Margin = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.textbook.Name = "textbook";
            this.textbook.ReadOnly = true;
            this.textbook.Size = new System.Drawing.Size(129, 28);
            this.textbook.TabIndex = 4;
            this.textbook.Text = "下激振(MD2004)";
            this.textbook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(429, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hz";
            // 
            // textBox24
            // 
            this.textBox24.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox24.Location = new System.Drawing.Point(166, 15);
            this.textBox24.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.textBox24.Name = "textBox24";
            this.textBox24.ReadOnly = true;
            this.textBox24.Size = new System.Drawing.Size(129, 28);
            this.textBox24.TabIndex = 1;
            this.textBox24.Text = "上激振(MD2000)";
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "试验频率设置";
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OP40_FormClosing);
            this.Load += new System.EventHandler(this.摩擦力试验机_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mychart)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_下激振频)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_上激振频)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_下激振数)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_上激振数)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.CheckBox btn_1压力;
        private System.Windows.Forms.CheckBox btn_2压力;
        private System.Windows.Forms.CheckBox btn_3压力;
        private System.Windows.Forms.CheckBox btn_4压力;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox btn_sleep;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.DataVisualization.Charting.Chart mychart;
        private System.Windows.Forms.Button btn_esc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_选择自动;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt2温度;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox txt1温度;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox txt4压力;
        private System.Windows.Forms.TextBox txt3压力;
        private System.Windows.Forms.TextBox txt2压力;
        private System.Windows.Forms.TextBox txt1压力;
        private System.Windows.Forms.TextBox txt振频率下;
        private System.Windows.Forms.TextBox txt振频率上;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox txt目标次数下;
        private System.Windows.Forms.TextBox txt目标次数上;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox txt当前运行次数下;
        private System.Windows.Forms.TextBox txt当前运行次数上;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox txt4温度;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox txt3温度;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public zyj.MyControl.MyRectLED ledplc读;
        public zyj.MyControl.MyRectLED ledPLC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public zyj.MyControl.MyRectLED led心跳;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        public zyj.MyControl.MyRectLED ledplc写;
        private System.Windows.Forms.Button btn_启动下;
        private System.Windows.Forms.Button btn_启动上;
        private System.Windows.Forms.Button btn_停止下;
        private System.Windows.Forms.Button btn_停止上;
        private System.Windows.Forms.CheckBox btn_冷却水启动;
        public zyj.MyControl.MyRectLED led_冷却水选择;
        public zyj.MyControl.MyRectLED led_温度保护;
        public zyj.MyControl.MyRectLED led_压力保护;
        private System.Windows.Forms.NumericUpDown txt_下激振数;
        private System.Windows.Forms.NumericUpDown txt_上激振数;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_delet;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.NumericUpDown txt_下激振频;
        private System.Windows.Forms.NumericUpDown txt_上激振频;
        private System.Windows.Forms.TextBox textbook;
        private System.Windows.Forms.CheckBox btn_锁定;
        private System.Windows.Forms.CheckBox check_1压力;
        private System.Windows.Forms.CheckBox check_4压力;
        private System.Windows.Forms.CheckBox check_3压力;
        private System.Windows.Forms.CheckBox check_2压力;
    }
}

