#undef DEBUG
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
using System.Timers;
using System.Windows.Forms.DataVisualization.Charting;
using System.Security.AccessControl;
using System.IO;
using System.Text.Json;

namespace 机械双动
{
    public partial class 测试界面 : Form
    {
        const string MkdirAddress = ".\\results\\";
        string[] FilesAddress = new string[2] {
            "data_corruption",
            "gradient_noise"
        };
        string[] ErroAddress = new string[3]
        {
            "_low",
            "_medium",
            "_high"
        };
        private void 测试界面_Load(object sender, System.EventArgs e)
        {
            //btn_normal.Checked = false;
            //btn__data_corruption.Checked =
            //btn__gradient_noise.Checked =
            //btn__interruption.Checked =
            //btn_high.Checked =
            //btn_medium.Checked =
            //btn_low.Checked = false;
            //btn__interruption.Enabled = false;
            加载数据();
            mychart.Show();
        }
        public 测试界面()
        {
            InitializeComponent();
            #region 创建图表

            ChartArea chartArea1 = new ChartArea();
            mychart.ChartAreas.Add(chartArea1);
            //x轴
            mychart.ChartAreas[0].AxisX.Title = "x";
            mychart.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Center;
            mychart.ChartAreas[0].AxisX.LabelStyle.Interval = 100;
            //y轴
            mychart.ChartAreas[0].AxisY.Title = "y";
            mychart.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Center;
            mychart.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            mychart.ChartAreas[0].AxisY.LabelStyle.Interval = 1;
            //杂项
            mychart.ChartAreas[0].BackColor = SystemColors.Control;
            mychart.MouseClick += Mychart_MouseClick;
            mychart.BorderlineDashStyle = ChartDashStyle.Solid;

            #endregion
        }
        static bool gpu_checked = false;
        #region 全局变量
        class JsonReadStruct
        {
            private const int series_num = 7;
            public JsonReadStruct() {
                enable = false;
                Enable = false;
            }

            private bool enable;
            public bool Enable {
                get { return enable; }
                set
                {
                    if(enable != value)
                    {
                        enable = value;
                        series[0].Enabled = enable;
                        series[1].Enabled = enable;
                        series[2].Enabled = enable;
                        series[3].Enabled = enable;
                        //series[4].Enabled = enable;
                        series[5].Enabled = enable;
                        //series[6].Enabled = enable;
                    }
                }
            }
            private List<Int32> X = new();
            private Series[] series;
            public void setSeries(string name, Chart mychart) {
                int size = train_loss.Count;
                for (int i = 0; i < size; i++)
                {
                    X.Add(i);
                }
                series = new Series[series_num];

                series[0] = new Series
                {
                    ChartType = SeriesChartType.Line,
                    YAxisType = AxisType.Secondary,
                    Name = name + "_train_loss",
                    IsXValueIndexed = true,
                    XValueType = ChartValueType.Int32,
                    //Color = Color.Red
                };
                series[0].Points.DataBindXY(X, train_loss);
                mychart.Series.Add(series[0]);
                series[0].Enabled = false;

                series[1] = new Series
                {
                    ChartType = SeriesChartType.Line,
                    YAxisType = AxisType.Secondary,
                    Name = name + "_accuracy",
                    IsXValueIndexed = true,
                    XValueType = ChartValueType.Int32,
                    //Color = Color.Yellow
                };
                series[1].Points.DataBindXY(X, accuracy);
                mychart.Series.Add(series[1]);
                series[1].Enabled = false;

                series[2] = new Series
                {
                    ChartType = SeriesChartType.Line,
                    YAxisType = AxisType.Secondary,
                    Name = name + "_grad_norm",
                    IsXValueIndexed = true,
                    XValueType = ChartValueType.Int32,
                    //Color = Color.Green
                };
                series[2].Points.DataBindXY(X, grad_norm);
                mychart.Series.Add(series[2]);
                series[2].Enabled = false;

                series[3] = new Series
                {
                    ChartType = SeriesChartType.Line,
                    YAxisType = AxisType.Secondary,
                    Name = name + "_time_per_step",
                    IsXValueIndexed = true,
                    XValueType = ChartValueType.Int32,
                    //Color = Color.Blue
                };
                series[3].Points.DataBindXY(X, time_per_step);
                mychart.Series.Add(series[3]);
                series[3].Enabled = false;

                series[4] = new Series
                {
                    ChartType = SeriesChartType.Line,
                    YAxisType = AxisType.Secondary,
                    Name = name + "_gpu_memory",
                    IsXValueIndexed = true,
                    XValueType = ChartValueType.Int32,
                    //Color = Color.MediumPurple
                };
                series[4].Points.DataBindXY(X, gpu_memory);
                mychart.Series.Add(series[4]);
                series[4].Enabled = false;

                series[5] = new Series
                {
                    ChartType = SeriesChartType.Line,
                    YAxisType = AxisType.Secondary,
                    Name = name + "_grad_variance",
                    IsXValueIndexed = true,
                    XValueType = ChartValueType.Int32,
                    //Color = Color.Pink
                };
                series[5].Points.DataBindXY(X, grad_variance);
                mychart.Series.Add(series[5]);
                series[5].Enabled = false;

                series[6] = new Series
                {
                    ChartType = SeriesChartType.Line,
                    YAxisType = AxisType.Secondary,
                    Name = name + "_update_ratio",
                    IsXValueIndexed = true,
                    XValueType = ChartValueType.Int32,
                    //Color = Color.Black
                };
                series[6].Points.DataBindXY(X, update_ratio);
                mychart.Series.Add(series[6]);
                series[6].Enabled = false;

            }
            public List<double> train_loss { get; set; }
            public List<double> val_loss {  get; set; }
            public List<double> accuracy { get; set; }
            public List<double> grad_norm { get; set; }
            public List<double> time_per_step { get; set; }
            public List<double> gpu_memory {  get; set; }
            public List<double> grad_variance {  get; set; }
            public List<double> update_ratio {  get; set; }
            public int iterations;
            public object convergence_iter;
            public double total_time;
            public double avg_train_loss;
            public double avg_accuracy;
            public double avg_grad_norm;
            public double avg_time_per_step;
        }
        JsonReadStruct[] jsonReadStruct;

        int ChartScaleViewAdd = 1;
        #endregion
        
        private void 加载数据()
        {
            jsonReadStruct = new JsonReadStruct[10];
            string jsonString = File.ReadAllText(MkdirAddress + "normal\\metrics_normal.json");
            jsonString = jsonString.Replace("Infinity", "1000.0");
            jsonReadStruct[0] = JsonSerializer.Deserialize<JsonReadStruct>(jsonString);
            jsonReadStruct[0].setSeries("normal", mychart);
            jsonReadStruct[0].Enable = false;
            int k = 1;
            for(int i = 0; i < 2; i++)
            {
                foreach(string j in ErroAddress)
                {
                    try{
                        jsonString = File.ReadAllText(MkdirAddress +
                        FilesAddress[i] + j + "\\metrics_fault_" + FilesAddress[i] + ".json");
                    }
                    catch{
                        continue;
                    }
                    jsonString = jsonString.Replace("Infinity", "1000.0");
                    jsonReadStruct[k] = JsonSerializer.Deserialize<JsonReadStruct>(jsonString);
                    jsonReadStruct[k].setSeries(FilesAddress[i] + j, mychart);
                    jsonReadStruct[k].Enable = false;
                    k++;
                }
            }
        }
        
        ToolTip toolTip = new ToolTip();
        private void Mychart_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            var area = mychart.ChartAreas[0]; ;
            double Xvalue = area.AxisX.PixelPositionToValue(e.X);
            double Yvalue = area.AxisY.PixelPositionToValue(e.Y);
            toolTip.Show("迭代次数:" + Xvalue.ToString() + "\n当前值:" + Yvalue.ToString(), mychart, 5000);
        }
        private int GetEnable()
        {
            if (btn__data_corruption.Checked) return 0;
            if (btn__gradient_noise.Checked) return 1;
            if (btn__interruption.Checked) return 2;
            return -1;
        }
        private void ColseEnable(int first)
        {
            jsonReadStruct[first * 3 + 1].Enable = false;
            jsonReadStruct[first * 3 + 2].Enable = false;
            jsonReadStruct[first * 3 + 3].Enable = false;
        }

        private void btn_normal_CheckedChanged(object sender, EventArgs e)
        {
            jsonReadStruct[0].Enable = btn_normal.Checked;
        }

        private void btn_medium_CheckedChanged(object sender, EventArgs e)
        {
            int first = GetEnable();
            if(first != -1) jsonReadStruct[first * 3 + 2].Enable = btn_medium.Checked;
        }

        private void btn_low_CheckedChanged(object sender, EventArgs e)
        {
            int first = GetEnable();
            if (first != -1) jsonReadStruct[first * 3 + 1].Enable = btn_low.Checked;
        }

        private void btn_high_CheckedChanged(object sender, EventArgs e)
        {
            int first = GetEnable();
            if (first != -1) jsonReadStruct[first * 3 + 3].Enable = btn_high.Checked;
        }

        private void btn__data_corruption_CheckedChanged(object sender, EventArgs e)
        {
            if (btn__data_corruption.Checked)
            {
                jsonReadStruct[1].Enable = btn_low.Checked;
                jsonReadStruct[2].Enable = btn_medium.Checked;
                jsonReadStruct[3].Enable = btn_high.Checked;
            }
            else
            {
                ColseEnable(0);
            }
        }

        private void btn__interruption_CheckedChanged(object sender, EventArgs e)
        {
            if (btn__interruption.Checked)
            {
                jsonReadStruct[7].Enable = btn_low.Checked;
                jsonReadStruct[8].Enable = btn_medium.Checked;
                jsonReadStruct[9].Enable = btn_high.Checked;
            }
            else
            {
                ColseEnable(2);
            }
        }

        private void btn__gradient_noise_CheckedChanged(object sender, EventArgs e)
        {
            if (btn__gradient_noise.Checked)
            {
                jsonReadStruct[4].Enable = btn_low.Checked;
                jsonReadStruct[5].Enable = btn_medium.Checked;
                jsonReadStruct[6].Enable = btn_high.Checked;
            }
            else
            {
                ColseEnable(1);
            }
        }
    }
}
