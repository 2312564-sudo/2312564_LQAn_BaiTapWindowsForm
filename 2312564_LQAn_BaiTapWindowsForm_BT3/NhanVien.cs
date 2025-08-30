using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312564_LQAn_BaiTapWindowsForm_BT3
{
    internal class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public double HeSoLuong { get; set; }
        public double HeSoPhuCap { get; set; }

        public NhanVien(string ma, string hoTen, string ngaySinh, double heSoLuong,double heSoPhuCap)
        {
            this.MaNhanVien = ma;
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.HeSoLuong = heSoLuong;
            this.HeSoPhuCap = heSoPhuCap;
        }
        public double TinhLuong()
        {
            return (HeSoLuong + HeSoPhuCap) * 1150000;
        }
        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", MaNhanVien, HoTen, NgaySinh, HeSoLuong, HeSoPhuCap);
        }
    }
}
