using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2312564_LQAn_BaiTapWindowsForm_BT4
{
    internal class Cau3
    {
        public static void ChaoHoi(string hoTen, bool gioiTinh)
        {
            string loaiGioiTinh = gioiTinh ? "Ông" : "Bà";
            MessageBox.Show($"Chào {loaiGioiTinh} {hoTen}");
        }
        public static int USCLN(int m, int n)
        {
            while (n != 0)
            {
                int UCLN = m % n;
                m = n;
                n = UCLN;
            }
            return m;
        }
    }
}
