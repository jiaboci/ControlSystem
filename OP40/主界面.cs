using OP40;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 摩擦力试验机
{
    public partial class 主界面 : Form
    {
        public static bool formempte = true;
        public static string fileAdress = "";
        static public bool is自动运行 = true;
        public 主界面()
        {
            InitializeComponent();
        }
        private Point point1,point2;
        private void 主界面_Load(object sender, System.EventArgs e)
        {
            //*****************************
            //   屏幕分辨率1440x900
            //*****************************
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = 1440;
            this.Height = 850;
            this.panel1.Width = this.Width-18;
            this.panel1.Height = this.Height-77;
            point1 = this.Location;
            point2 = this.panel1.Location;
            //*************************
            Process p = new Process();
            //设置要启动的应用程序
            p.StartInfo.FileName = "cmd.exe";
            //删除
            p.StartInfo.Arguments = " /c taskkill  /F /T /IM EXCEL.EXE";
            //是否使用操作系统shell启动
            p.StartInfo.UseShellExecute = false;
            // 接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardInput = false;
            //输出信息
            p.StartInfo.RedirectStandardOutput = false;
            // 输出错误
            p.StartInfo.RedirectStandardError = false;
            //不显示dos程序窗口
            p.StartInfo.CreateNoWindow = true;
            //启动程序
            p.Start();
            //等待dos程序执行完退出进程
            p.WaitForExit();
            p.Close();
            Application.DoEvents();
            //***************************************
        }
        private void mu_1_参数设置_Click(object sender, EventArgs e)
        {
            if (!formempte) { return; }
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is 配置参数 || frm is 参数设置)
                {
                    frm.Activate();
                    frm.WindowState = FormWindowState.Normal;
                    return;
                }
            }
            formempte = false;
            密码 _password = new 密码();
            _password.ShowDialog();
            if (密码.bl密码正确性)
            {
                参数设置 frm = new 参数设置();
                frm.Show();
            }
        }

        private void mu_1_关于_Click(object sender, EventArgs e)
        {
            foreach(Form frm in Application.OpenForms)
            {
                if(frm is 配置参数)
                {
                    frm.Activate();
                    frm.WindowState = FormWindowState.Normal;
                    return;
                }
            }
            配置参数 form = new 配置参数();
            form.Show();
        }

        private void mu_2_打开测试数据_Click(object sender, EventArgs e)
        {
            formempte = false;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "文件|*.*";
            ofd.Multiselect = false;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                fileAdress = ofd.FileName;
                测试界面 form = new 测试界面();
                CreatMyForm(form);
            }
        }

        private void mu_2_新建测试数据_Click(object sender, EventArgs e)
        {
            formempte = false;
            fileAdress = "";
            测试界面 form = new 测试界面();
            CreatMyForm(form);
        }

        private void mu_2_保存测试数据_Click(object sender, EventArgs e)
        {

        }

        private void CreatMyForm(Form form)
        {
            //清除容器中的所有控件。
            this.panel1.Controls.Clear();
            //去掉窗体的边框。
            form.FormBorderStyle = FormBorderStyle.None;
            //将窗体设置为非顶级窗体。
            form.TopLevel = false;
            //设置子窗体随器大小自动调整。
            form.Dock = DockStyle.Fill;
            //设置mdi父窗体为当前容器。  
            form.Parent = this.panel1;
            form.Show();
        }
    }
}
