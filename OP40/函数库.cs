//#undef DEBUG
using S7.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 摩擦力试验机
{
    public enum PlcByte
    {
        _0 = 0x01,
        _1 = 0x02,
        _2 = 0x04,
        _3 = 0x08,
        _4 = 0x10,
        _5 = 0x20,
        _6 = 0x40,
        _7 = 0x80
    }
    internal class 函数库
    {
        public 函数库()
        {
#if !DEBUG
            plc = new Plc(CpuType.S71200, "192.168.0.1", 0, 1);
            plc.Open();
#endif
        }
        public static string measingless_suffix = ".logn";
        readonly Plc plc;
        /// <summary>
        /// 用于获取PLC某字节某位状态
        /// </summary>
        /// <param name="plcbyte">PLC中某字节</param>
        /// <param name="byte">字节中某位</param>
        /// <returns>
        /// 返回bool值：true代表上升沿，false代表下降沿
        /// </returns>
        /// 
        public static bool DeterminePlcByte(byte plcbyte,PlcByte @byte)
        {
            bool Point_statu;
            try
            {
                Point_statu = (plcbyte & (byte)@byte) == (byte)@byte;
            }
            catch
            {
                Point_statu = false;
            }
            return Point_statu;
        }
        public bool ReadPlcMoreData(string[] strings, out object[] result)
        {
            if (strings.Length == 0)
            {
                result = null;
                return false;
            }
            
            result = new object[strings.Length];
            foreach (string address in strings)
            {
                result.Append(plc.Read(address));
            }
            return true;
        }
        public void ChangPassword(string password)
        {
            string Address = Application.StartupPath + "\\password";
            File.WriteAllText(Address + ".txt", password);
            File.Move(Address + ".txt", Address + measingless_suffix);
        }
        public static void Delay(int milliSecond)
        {
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < milliSecond) //毫秒
            {
                Application.DoEvents();//可执行其他的操作
            }
        }
    }
}
