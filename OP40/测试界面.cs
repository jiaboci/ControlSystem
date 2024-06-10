//#undef DEBUG
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using System.Timers;
using System.Windows.Forms.DataVisualization.Charting;
using System.Security.AccessControl;
using System.IO;

namespace 摩擦力试验机
{
    public partial class 测试界面 : Form
    {
        public 测试界面()
        {
            InitializeComponent();
            #region 创建图表
            recodeData.Elapsed += RecodeData;
            recodeData.AutoReset = true;
            recodeData.Enabled = false;
            showData.Elapsed += ShowData;
            showData.AutoReset = true;
            showData.Enabled = false;

            ChartArea chartArea1 = new ChartArea();
            mychart.ChartAreas.Add(chartArea1);
            //x轴
            mychart.ChartAreas[0].AxisX.Title = "时间";
            mychart.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Center;
            mychart.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            mychart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            mychart.ChartAreas[0].AxisX.LabelStyle.Interval = 5;
            //y轴
            mychart.ChartAreas[0].AxisY.Title = "压力";
            mychart.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Center;
            mychart.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            mychart.ChartAreas[0].AxisY.Maximum = 10d;
            mychart.ChartAreas[0].AxisY.Minimum = 0d;
            mychart.ChartAreas[0].AxisY.LabelStyle.Interval = 1d;
            //杂项
            mychart.ChartAreas[0].BackColor = SystemColors.Control;
            mychart.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            mychart.MouseWheel += new MouseEventHandler(MouseWheel);
            mychart.MouseClick += Mychart_MouseClick;
            mychart.BorderlineDashStyle = ChartDashStyle.Solid;

            series[0] = new Series
            {
                ChartType = SeriesChartType.Line,
                YAxisType = AxisType.Secondary,
                Name = "1#压力",
                IsXValueIndexed = true,
                XValueType = ChartValueType.DateTime,
                Color = Color.Red
            };
            series[1] = new Series
            {
                ChartType = SeriesChartType.Line,
                YAxisType = AxisType.Secondary,
                Name = "2#压力",
                IsXValueIndexed = true,
                XValueType = ChartValueType.DateTime,
                Color = Color.Green
            };
            series[2] = new Series
            {
                ChartType = SeriesChartType.Line,
                YAxisType = AxisType.Secondary,
                Name = "3#压力",
                IsXValueIndexed = true,
                XValueType = ChartValueType.DateTime,
                Color = Color.Black
            };
            series[3] = new Series
            {
                ChartType = SeriesChartType.Line,
                YAxisType = AxisType.Secondary,
                Name = "4#压力",
                IsXValueIndexed = true,
                XValueType = ChartValueType.DateTime,
                Color = Color.Blue
            };
            mychart.Series.Add(series[0]);
            mychart.Series.Add(series[1]);
            mychart.Series.Add(series[2]);
            mychart.Series.Add(series[3]);
            series[0].Points.DataBindXY(Times, Y0);
            series[1].Points.DataBindXY(Times, Y1);
            series[2].Points.DataBindXY(Times, Y2);
            series[3].Points.DataBindXY(Times, Y3);
            #endregion
        }

        #region 全局变量
        //*************
        // 必要变量声明
        //*************
        System.Timers.Timer hreatbits = new System.Timers.Timer(1000);
        Plc plc;
        Thread ReadPLCData;
        Thread ChartWork;
        //*****************
        // 读取数据变量声明
        //*****************
        bool bl读PLC数据成功 = false;
        bool bl写PLC数据成功 = false;

        Byte[] readPLC_M;//MB2600-MB2602
        //Byte[] readPLC_I;
        //Byte[] readPLC_Q;

        object[] readPlc压力 = new object[4];//MD2620-MD2632

        object[] readPlc温度 = new object[4];//MD2644-MD2656
        double[] data温度 = new double[4] { 0d, 0d, 0d, 0d };

        object[] readPlcdata = new object[4];//MD2700-MD2704//MD2008-MD2012
        /// <summary>
        /// [0]-上机振频率显示；[1]-下机振频率显示  =>
        /// MD2700,MD2704
        /// </summary>
        double[] data激振频率 = new double[2] { 0d, 0d };
        /// <summary>
        /// [0]-当前运行次数 上；[1]-当前运行次数 下  =>
        /// MD2016,MD2020
        /// </summary>
        int[] data次数 = new int[2] { 0, 0 };
        //*****************
        // 自动测试变量声明
        //*****************
        int Data上激振数 = 500, Data下激振数 = 500;
        double Data上激振频 = 50d, Data下激振频 = 50d;
        int Data_当前运行次数上 = 0, Data_当前运行次数下 = 0;
        bool Data_运行指示上 = false, Data_运行指示下 = false;
        int Data周期上 = 100, Data周期下 = 100;
        double Y0Max = 0d, Y0Min = 1000d;
        double Y1Max = 0d, Y1Min = 1000d;
        double Y2Max = 0d, Y2Min = 1000d;
        double Y3Max = 0d, Y3Min = 1000d;
        //*********
        // 创建图表
        //*********
        System.Timers.Timer recodeData = new System.Timers.Timer(100);
        System.Timers.Timer showData = new System.Timers.Timer(100);
        Series[] series = new Series[4];
        List<Double> Y0 = new List<Double>();
        List<Double> Y1 = new List<Double>();
        List<Double> Y2 = new List<Double>();
        List<Double> Y3 = new List<Double>();
        List<DateTime> Times = new List<DateTime>();
        int ChartScaleViewAdd = 1;
        //***************
        // 自定义类的声明
        //***************
        函数库 Para = new 函数库();
        //Para.DeterminePlcByte(byte plcbyte,PlcByte @byte)使用示例：读取M1.3位状态
        //bool ll = Para.DeterminePlcByte(readPLC_M[1], PlcByte._3);
        #endregion
        
        #region 从PLC中读取数据
        private void ReadPLC()
        {
            while(ReadPLCData.ThreadState != ThreadState.Stopped)
            {
                //读取温度数值
                Application.DoEvents();
                if (!Para.ReadPlcMoreData(new string[4] { "MD2644", "MD2648", "MD2652", "MD2656" }, out readPlc温度))
                {
                    bl读PLC数据成功 = false;
                    return;
                }
                else
                {
                    bl读PLC数据成功 = true;
                    for (int i = 0; i < 4; i++) { data温度[i] = Convert.ToDouble(readPlc温度[i]); };
                }
                //读取其余数值
                Application.DoEvents();
                if (!Para.ReadPlcMoreData(new string[4] {"MD2700", "MD2704", "MD2008", "MD2012" }, out readPlcdata))
                {
                    bl读PLC数据成功 = false;
                    continue;
                }
                else
                {
                    bl读PLC数据成功 = true;
                    data激振频率[0] = Convert.ToDouble(readPlcdata[0]);
                    data激振频率[1] = Convert.ToDouble(readPlcdata[1]);
                    data次数[0] = Convert.ToInt32(readPlcdata[2]);
                    data次数[1] = Convert.ToInt32(readPlcdata[3]);
                }

                Application.DoEvents();
                readPLC_M = plc.ReadBytes(DataType.Memory, 0, 2600, 3);
                if(readPLC_M == null)
                {
                    bl读PLC数据成功 = false;
                    continue;
                }
                else bl读PLC数据成功 = true;
                Thread.Sleep(100);
            }
        }
        #endregion
        #region 测试启动
        private void btn_start_Click(object sender, EventArgs e)
        {
            //检查自动运行状态
            if (!主界面.is自动运行)
            {
                MessageBox.Show("当前为手动运行，请切换至自动运行。", "运行失败", MessageBoxButtons.OK);
                return;
            }
            if (!启动前检查(0x3)) return;
            btn_启动上.Enabled = false;
            btn_启动下.Enabled = false;
            txt_上激振数.ReadOnly = true;
            txt_上激振频.ReadOnly = true;
            txt_下激振数.ReadOnly = true;
            txt_下激振频.ReadOnly = true;
#if !DEBUG
            plc.Write("M2600.7", true);
            函数库.Delay(300);
            plc.Write("M2600.7", false);
#endif
            Start();
        }
        private void Start()
        {
            BeginInvoke(new Action(() =>
            {
                btn_esc.Enabled = false;
                btn_选择自动.Enabled = false;
                btn_start.Enabled = false;
                btn_stop.Enabled = true;
                btn_reset.Enabled = true;
                btn_delet.Enabled = false;
                btn_save.Enabled = true;
                btn_启动上.Enabled = false;
                btn_启动下.Enabled = false;
                txt_上激振数.ReadOnly = true;
                txt_上激振频.ReadOnly = true;
                txt_下激振数.ReadOnly = true;
                txt_下激振频.ReadOnly = true;
            }));
            Data_运行指示上 = true;
            Data_运行指示下 = true;
        }
        #endregion
        #region 界面装载
        private void 摩擦力试验机_Load(object sender, EventArgs e)
        {
            btn_save.Enabled = false;
            btn_stop.Enabled = false;
#if !DEBUG
            //连接PLC
            plc = new Plc(CpuType.S71200, "192.168.0.1", 0, 1);
            plc.Open();

            //启动线程
            ReadPLCData = new Thread(ReadPLC);
            ReadPLCData.IsBackground = true;
            ReadPLCData.Start();

            hreatbits.Elapsed += HreatBits;
            hreatbits.AutoReset = true;
            hreatbits.Start();

            if (主界面.fileAdress != "")
            {
                加载数据(true);
            }
#endif
            recodeData.Start();
            showData.Start();
        }
        /// <summary>
        /// PLC心跳+数据加载，由计时器在独立线程控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HreatBits(object sender, ElapsedEventArgs e)
        {
            plc.Write("M2601.4", true);
            bl写PLC数据成功 = Convert.ToBoolean(plc.Read("M2601.4"));
            ledPLC.CurrentValue = plc.IsConnected ? 2 : 1;
            txt_上激振频.Text = Math.Round(data激振频率[0], 2).ToString();
            txt_下激振频.Text = Math.Round(data激振频率[1], 2).ToString();
            txt当前运行次数上.Text = data次数[0].ToString();
            txt当前运行次数下.Text = data次数[1].ToString();
            txt1温度.Text = Math.Round(data温度[0], 2).ToString();
            txt2温度.Text = Math.Round(data温度[1], 2).ToString();
            txt3温度.Text = Math.Round(data温度[2], 2).ToString();
            txt4温度.Text = Math.Round(data温度[3], 2).ToString();
            ledplc读.CurrentValue = bl读PLC数据成功 ? 2 : 1;
            ledplc写.CurrentValue = bl写PLC数据成功 ? 2 : 1;
            led心跳.CurrentValue = 函数库.DeterminePlcByte(readPLC_M[1], PlcByte._4) ? 2 : 1;
            if (函数库.DeterminePlcByte(readPLC_M[2], PlcByte._2 | PlcByte._3))
            {
                btn_启动上.Enabled = true;
                btn_启动下.Enabled = true;
                txt_上激振数.ReadOnly = false;
                txt_上激振频.ReadOnly = false;
                txt_下激振数.ReadOnly = false;
                txt_下激振频.ReadOnly = false;
                btn_start.Enabled = true;
                btn_delet.Enabled = true;
                停止自动运行();
            }
            if (函数库.DeterminePlcByte(readPLC_M[2], PlcByte._1))
            {
                btn_delet.PerformClick();
            }
        }
        #region 压力按钮相关处理
        private void btn_1压力_CheckedChanged(object sender, EventArgs e)
        {
            series[0].Enabled = btn_1压力.Checked;
        }

        private void btn_2压力_CheckedChanged(object sender, EventArgs e)
        {
            series[1].Enabled = btn_2压力.Checked;
        }

        private void btn_3压力_CheckedChanged(object sender, EventArgs e)
        {
            series[2].Enabled = btn_3压力.Checked;
        }

        private void btn_4压力_CheckedChanged(object sender, EventArgs e)
        {
            series[3].Enabled = btn_4压力.Checked;
        }

        private void check_1压力_CheckedChanged(object sender, EventArgs e)
        {
            Show压力Text();
        }

        private void check_2压力_CheckedChanged(object sender, EventArgs e)
        {
            Show压力Text();
        }

        private void check_3压力_CheckedChanged(object sender, EventArgs e)
        {
            Show压力Text();
        }

        private void check_4压力_CheckedChanged(object sender, EventArgs e)
        {
            Show压力Text();
        }
        #endregion
        #endregion
        #region 界面退出
        private void OP40_FormClosing(object sender, FormClosingEventArgs e)
        {
            主界面.formempte = true;
#if !DEBUG
            if (ReadPLCData.IsAlive) ReadPLCData.Abort();
            plc.Close();
            hreatbits.Stop();
#endif
            recodeData.Stop();
            showData.Stop();
        }
#endregion
        private void 停止自动运行()
        {
            BeginInvoke(new Action(() =>
            {
                btn_start.Enabled = true;
                btn_esc.Enabled = true;
                btn_选择自动.Enabled = true;
                btn_stop.Enabled = false;
                btn_reset.Enabled = true;
                btn_delet.Enabled = true;
                btn_save.Enabled = false;
                btn_启动上.Enabled = true;
                btn_启动下.Enabled = true;
                txt_上激振数.ReadOnly = false;
                txt_上激振频.ReadOnly = false;
                txt_下激振数.ReadOnly = false;
                txt_下激振频.ReadOnly = false;
            }));
        }
        private void 加载数据(bool p)
        {
            //常规加载

            if(p)//指定数据加载
            {

            }
        }
        private void Show压力Text()
        {
#if !DEBUG
            BeginInvoke(new Action(() =>
            {
                txt1压力.Text = check_1压力.Checked ?
                    "Max:" + Math.Round(Y0Max, 2).ToString() + " Min:" + Math.Round(Y0Min, 2).ToString() :
                    Math.Round(Convert.ToDouble(readPlc压力[0]), 2).ToString();
                txt2压力.Text = check_2压力.Checked ?
                    "Max:" + Math.Round(Y1Max, 2).ToString() + " Min:" + Math.Round(Y1Min, 2).ToString() :
                    Math.Round(Convert.ToDouble(readPlc压力[1]), 2).ToString();
                txt3压力.Text = check_3压力.Checked ?
                    "Max:" + Math.Round(Y2Max, 2).ToString() + " Min:" + Math.Round(Y2Min, 2).ToString() :
                    Math.Round(Convert.ToDouble(readPlc压力[2]), 2).ToString();
                txt4压力.Text = check_4压力.Checked ?
                    "Max:" + Math.Round(Y3Max, 2).ToString() + " Min:" + Math.Round(Y3Min, 2).ToString() :
                    Math.Round(Convert.ToDouble(readPlc压力[3]), 2).ToString();
            }));
#else
            BeginInvoke(new Action(() =>
            {
                txt1压力.Text = check_1压力.Checked ?
                    "Max:" + Math.Round(Y0Max, 2).ToString() + " Min:" + Math.Round(Y0Min, 2).ToString() :
                    Math.Round(Y0[Y0.Count - 1], 2).ToString();
                txt2压力.Text = check_2压力.Checked ?
                    "Max:" + Math.Round(Y1Max, 2).ToString() + " Min:" + Math.Round(Y1Min, 2).ToString() :
                    Math.Round(Y1[Y1.Count - 1], 2).ToString();
                txt3压力.Text = check_3压力.Checked ?
                    "Max:" + Math.Round(Y2Max, 2).ToString() + " Min:" + Math.Round(Y2Min, 2).ToString() :
                    Math.Round(Y2[Y2.Count - 1], 2).ToString();
                txt4压力.Text = check_4压力.Checked ?
                    "Max:" + Math.Round(Y3Max, 2).ToString() + " Min:" + Math.Round(Y3Min, 2).ToString() :
                    Math.Round(Y3[Y3.Count - 1], 2).ToString();
            }));
#endif
        }
        
        private void RecodeData(object sender, ElapsedEventArgs e)
        {
#if !DEBUG
            Application.DoEvents();
            if (!Para.ReadPlcMoreData(new string[4] { "MD2620", "MD2624", "MD2628", "MD2632" }, out readPlc压力))
            {
                bl读PLC数据成功 = false;
                return;
            }
            else
            {
                bl读PLC数据成功 = true;
                Times.Add(DateTime.Now);
                Y0.Add(Convert.ToDouble(readPlc压力[0]));
                Y1.Add(Convert.ToDouble(readPlc压力[1]));
                Y2.Add(Convert.ToDouble(readPlc压力[2]));
                Y3.Add(Convert.ToDouble(readPlc压力[3]));
                Show压力Text();
            }
#endif
#if DEBUG
            Random random = new Random();
            Times.Add(DateTime.Now);
            Y0.Add(random.NextDouble() * 1000);
            Y1.Add(random.NextDouble() * 1000);
            Y2.Add(random.NextDouble() * 1000);
            Y3.Add(random.NextDouble() * 1000);
#endif
            Y0Max = Math.Max(Y0Max, Y0.Max()); Y0Min = Math.Min(Y0Min, Y0.Min());
            Y1Max = Math.Max(Y1Max, Y1.Max()); Y1Min = Math.Min(Y1Min, Y1.Min());
            Y2Max = Math.Max(Y2Max, Y2.Max()); Y2Min = Math.Min(Y2Min, Y2.Min());
            Y3Max = Math.Max(Y3Max, Y3.Max()); Y3Min = Math.Min(Y3Min, Y3.Min());
            BeginInvoke(new Action(delegate ()
            {
                if (Times.Count >= 600)
                {
                    Times.RemoveAt(0);
                    Y0.RemoveAt(0);
                    Y1.RemoveAt(0);
                    Y2.RemoveAt(0);
                    Y3.RemoveAt(0);
                }
            }));
            Show压力Text();
        }
        private void ShowData(object sender, ElapsedEventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                mychart.Series[0].Points.DataBindXY(Times, Y0);
                mychart.Series[1].Points.DataBindXY(Times, Y1);
                mychart.Series[2].Points.DataBindXY(Times, Y2);
                mychart.Series[3].Points.DataBindXY(Times, Y3);
                mychart.ChartAreas[0].AxisX.ScaleView.Position += ChartScaleViewAdd;
            }));
        }
        private void MouseWheel(object sender, MouseEventArgs e)
        {
            if(e.Delta == 120)
            {
                Console.WriteLine(mychart.ChartAreas[0].AxisX.ScaleView.Size);
                if (mychart.ChartAreas[0].AxisX.ScaleView.Size > 0)
                {
                    mychart.ChartAreas[0].AxisX.ScaleView.Size /= 2;
                    //Console.WriteLine(11111111 + "-" + mychart.ChartAreas[0].AxisX.ScaleView.Size);
                }
                else
                {
                    //Console.WriteLine(88888888888 + "-" + mychart.ChartAreas[0].AxisX.ScaleView.Size);
                    mychart.ChartAreas[0].AxisX.ScaleView.Size = 128;
                }
            }
            else if(e.Delta == -120)
            {
                if (mychart.ChartAreas[0].AxisX.ScaleView.Size > 0)
                {
                    mychart.ChartAreas[0].AxisX.ScaleView.Size *= 2;
                    //Console.WriteLine(2222222222 + "-" + mychart.ChartAreas[0].AxisX.ScaleView.Size);
                }
                else
                {
                    mychart.ChartAreas[0].AxisX.ScaleView.Size = 128;
                }
            }
        }
        ToolTip toolTip = new ToolTip();
        private void Mychart_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            var area = mychart.ChartAreas[0]; ;
            double Xvalue = area.AxisX.PixelPositionToValue(e.X);
            double Yvalue = area.AxisY.PixelPositionToValue(e.Y);
            toolTip.Show("时间:" + DateTime.FromOADate(Xvalue).ToString() + "\n当前值:" + Yvalue.ToString(), mychart, 5000);
        }
        /// <summary>
        /// 轴复位程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_reset_Click(object sender, EventArgs e)
        {
            mychart.ChartAreas[0].AxisX.ScaleView.ZoomReset(0);
        }
        /// <summary>
        /// 锁定视图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_锁定_CheckedChanged(object sender, EventArgs e)
        {
            ChartScaleViewAdd = btn_锁定.Checked ? 0 : 1;
        }
        /// <summary>
        /// 暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_sleep_CheckedChanged(object sender, EventArgs e)
        {
            showData.Enabled = !btn_sleep.Checked;
        }
        /// <summary>
        /// 停止采集
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_stop_Click(object sender, EventArgs e)
        {
#if !DEBUG
            plc.Write("M2601.0", true);
            函数库.Delay(300);
            plc.Write("M2601.0", false);
#endif
            btn_启动上.Enabled = true;
            btn_启动下.Enabled = true;
            txt_上激振数.ReadOnly = false;
            txt_上激振频.ReadOnly = false;
            txt_下激振数.ReadOnly = false;
            txt_下激振频.ReadOnly = false;
            btn_start.Enabled = true;
            btn_delet.Enabled = true;
            停止自动运行();
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Application.StartupPath + @"\数据记录"))
            {
                Directory.CreateDirectory(Application.StartupPath + @"\数据记录");
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "请选择保存路径：";
            sfd.ShowHelp = true;
            sfd.InitialDirectory = Application.StartupPath + @"\数据记录\";
            sfd.Filter = "文本文件|*.txt";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                string strPath = sfd.FileName;
                using (FileStream fsWrite = new FileStream(strPath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    List<byte[]> buffer = new List<byte[]>();
                    buffer.Add(Encoding.Default.GetBytes(
                        "<上激振实验次数>" + "   " + data次数[0].ToString() + "/" + Data上激振数.ToString() + "\n\n"));
                    buffer.Add(Encoding.Default.GetBytes(
                        "<下激振实验次数>" + "   " + data次数[1].ToString() + "/" + Data下激振数.ToString() + "\n\n"));
                    buffer.Add(Encoding.Default.GetBytes("<压力传感器>\n\n"));
                    buffer.Add(Encoding.Default.GetBytes(
                        "   " + "<1#压力最高值>" + "   " + Y0Max + "\n"));
                    buffer.Add(Encoding.Default.GetBytes(
                        "   " + "<1#压力最低值>" + "   " + Y0Min + "\n\n"));
                    buffer.Add(Encoding.Default.GetBytes(
                        "   " + "<2#压力最高值>" + "   " + Y1Max + "\n"));
                    buffer.Add(Encoding.Default.GetBytes(
                        "   " + "<2#压力最低值>" + "   " + Y1Min + "\n\n"));
                    buffer.Add(Encoding.Default.GetBytes(
                        "   " + "<3#压力最高值>" + "   " + Y2Max + "\n"));
                    buffer.Add(Encoding.Default.GetBytes(
                        "   " + "<3#压力最低值>" + "   " + Y2Min + "\n\n"));
                    buffer.Add(Encoding.Default.GetBytes(
                        "   " + "<4#压力最高值>" + "   " + Y3Max + "\n"));
                    buffer.Add(Encoding.Default.GetBytes(
                        "   " + "<4#压力最低值>" + "   " + Y3Min + "\n\n"));
                    foreach (byte[] i in buffer) fsWrite.Write(i, 0, i.Length);
                }
            }
        }
        /// <summary>
        /// 清空图表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delet_Click(object sender, EventArgs e)
        {
            Y0.Clear();
            Y1.Clear();
            Y2.Clear();
            Y3.Clear();
            Times.Clear();
            BeginInvoke(new Action(() =>
            {
                mychart.Series[0].Points.DataBindXY(Times, Y0);
                mychart.Series[1].Points.DataBindXY(Times, Y1);
                mychart.Series[2].Points.DataBindXY(Times, Y2);
                mychart.Series[3].Points.DataBindXY(Times, Y3);
            }));
        }
        
        private void btn_esc_Click(object sender, EventArgs e)
        {
            btn_save.PerformClick();
            this.Close();
        }

        private void btn_选择自动_Click(object sender, EventArgs e)
        {
            if (btn_选择自动.Text == "手  动")
            {
                btn_选择自动.Text = "自  动";
                主界面.is自动运行 = true;
#if !DEBUG
                WritePLC();
#endif
            }
            else if (btn_选择自动.Text == "自  动")
            {
                btn_选择自动.Text = "手  动";
                主界面.is自动运行 = false;
            }
#if !DEBUG
            plc.Write("M2602.0", 主界面.is自动运行);
#endif
        }
        private void WritePLC()
        {
            plc.Write("MD2000", Data上激振频);
            plc.Write("MD2004", Data下激振频);
            plc.Write("MD2008", Data上激振数);
            plc.Write("MD2012", Data下激振数);
        }

#region 设置界面事件处理
        private void btn_启动上_Click(object sender, EventArgs e)
        {
            if (!启动前检查(0x1)) return;
            btn_启动上.Enabled = false;
            txt_上激振数.ReadOnly = true;
            txt_上激振频.ReadOnly = true;
            plc.Write("M2600.3", true);
            函数库.Delay(300);
            plc.Write("M2600.3", false);
        }

        private void btn_启动下_Click(object sender, EventArgs e)
        {
            if (!启动前检查(0x2)) return;
            btn_启动下.Enabled = false;
            txt_下激振数.ReadOnly = true;
            txt_下激振频.ReadOnly = true;
            plc.Write("M2600.4", true);
            函数库.Delay(300);
            plc.Write("M2600.4", false);
        }

        private bool 启动前检查(byte type)
        {
            if (函数库.DeterminePlcByte(type, PlcByte._0)) 
            {
                if (Data上激振数 <= 0)
                {
                    MessageBox.Show("请输入大于0的实验次数！", "错误的数据", MessageBoxButtons.OK);
                    return false;
                }
                if (Data上激振频 <= 0d)
                {
                    MessageBox.Show("请输入大于0的试验频率！", "错误的数据", MessageBoxButtons.OK);
                    return false;
                }
            }
            if (函数库.DeterminePlcByte(type, PlcByte._1))
            {
                if (Data下激振数 <= 0)
                {
                    MessageBox.Show("请输入大于0的实验次数！", "错误的数据", MessageBoxButtons.OK);
                    return false;
                }
                if (Data下激振频 <= 0d)
                {
                    MessageBox.Show("请输入大于0的试验频率！", "错误的数据", MessageBoxButtons.OK);
                    return false;
                }
            }
            return true;
        }
        private void btn_停止上_Click(object sender, EventArgs e)
        {
            if (btn_启动上.Enabled) return;
            plc.Write("M2600.5", true);
            函数库.Delay(300);
            plc.Write("M2600.5", false);
            btn_启动上.Enabled = true;
            txt_上激振数.ReadOnly = false;
            txt_上激振频.ReadOnly = false;
        }

        private void btn_停止下_Click(object sender, EventArgs e)
        {
            if (btn_启动下.Enabled) return;
            plc.Write("M2600.6", true);
            函数库.Delay(300);
            plc.Write("M2600.6", false);
            btn_启动下.Enabled = true;
            txt_下激振数.ReadOnly = false;
            txt_下激振频.ReadOnly = false;
        }

        private void btn_冷却水启动_CheckedChanged(object sender, EventArgs e)
        {
            plc.Write("M2600.2", btn_冷却水启动.Checked);
            led_冷却水选择.CurrentValue = Convert.ToBoolean(plc.Read("M2600.2")) ? 2 : 1;
        }

        private void txt_上激振频_ValueChanged(object sender, EventArgs e)
        {
            Data上激振频 = Convert.ToDouble(txt_上激振频.Value);
            txt振频率上.Text = Math.Round(Data上激振频, 2).ToString();
            Data周期上 = (int)(1000 / Data上激振频);
        }

        private void txt_下激振频_ValueChanged(object sender, EventArgs e)
        {
            Data下激振频 = Convert.ToDouble(txt_下激振频.Value);
            txt振频率下.Text = Math.Round(Data下激振频, 2).ToString();
            Data周期下 = (int)(1000 / Data下激振频);
        }

        private void txt_上激振数_ValueChanged(object sender, EventArgs e)
        {
            Data上激振数 = Convert.ToInt32(txt_上激振数.Value);
            txt目标次数上.Text = Data上激振数.ToString();
        }

        private void txt_下激振数_ValueChanged(object sender, EventArgs e)
        {
            Data下激振数 = Convert.ToInt32(txt_下激振数.Value);
            txt目标次数下.Text = Data下激振数.ToString();
        }
#endregion
    }
}
