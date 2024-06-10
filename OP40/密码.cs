using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 摩擦力试验机;

namespace OP40
{
    public partial class 密码 : Form
    {
        public static bool bl密码正确性=false;
        public 密码()
        {
            InitializeComponent();
        }

        private void bn取消_Click(object sender, EventArgs e)
        {
            bl密码正确性 = false;
            主界面.formempte = true;
            Close();
        }

        private void bn确认_Click(object sender, EventArgs e)
        {
            string txt用户输入密码 = txt密码框.Text;                                   //变量：用户输入密码
            if (txt用户输入密码.Length == 0 )                                          //禁止输入为空
            {
                MessageBox.Show("输入的密码不能为空！\r\n","操作确认",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                txt密码框.Text = string.Empty;
                bl密码正确性 = false;
                return;
            }
            string PasswordAdress = Application.StartupPath;                          //变量：程序入口地址，不含程序本身
            string PasswordName = @"\password";                                       //变量：文件名，可改
            string Password;                                                          //变量：预设密码
            if(!File.Exists(PasswordAdress + PasswordName + 函数库.measingless_suffix))                 //判断文件是否被误删，也可用于密码初始化
            {
                Password = "1234567890";                                              //默认密码
                File.WriteAllText(PasswordAdress + PasswordName + ".txt", Password);  //录入默认密码
                File.Move(PasswordAdress + PasswordName + ".txt", 
                    PasswordAdress + PasswordName + 函数库.measingless_suffix);                         //防止误操作，用无意义后缀
            }
            else
            {
                File.Move(PasswordAdress + PasswordName + 函数库.measingless_suffix, 
                    PasswordAdress + PasswordName + ".txt");
                Password = File.ReadAllText(PasswordAdress + PasswordName +".txt");  //读取预设密码
                File.Move(PasswordAdress + PasswordName + ".txt",
                    PasswordAdress + PasswordName + 函数库.measingless_suffix);
            }
            if(Password == txt用户输入密码)                                          //判断密码正确性
            {
                bl密码正确性 = true;                                                 //使用静态变量作为返回值读取
                主界面.formempte = true;
                Close();
            }
            else
            {
                MessageBox.Show("密码错误！请重试！\r\n","密码错误",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                txt密码框.Text = string.Empty;
                bl密码正确性 = false;
                return;
            }
        }
    }
}
