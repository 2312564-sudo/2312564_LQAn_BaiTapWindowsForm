using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312564_LQAn_BaiTapWindowsForm_BT3
{
    internal class Cau3
    {
        public static void TachChuoi(string hoten, out string s1, out string s2)
        {
            string[] tach = hoten.Split(' ');
            int n = tach.Length;
            s1 = tach[0];
            s2 = tach[n - 1];
        }
        public static bool ThuTu(int n1, int n2)
        {
            bool ketQua = false;
            if (n2 == n1 + 1)
            {
                ketQua = true;
            }
            return ketQua;
        }

    }
}
