using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm_BT2
{
    internal class Cau3
    {
        public static void NoiChuoi(string ho, string ten, ref string s)
        {
            s = ho + ten;
        }
        public static long GiaiThua(int n)
        {
            int kq = 1;
            for (int i = n; i >= 1; i--)
            {
                kq *= i;
            }
            return kq;
        }
    }
}
