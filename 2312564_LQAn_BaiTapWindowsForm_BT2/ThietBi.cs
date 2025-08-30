using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm_BT2
{
    internal class ThietBi
    {
        public string MaTB { get; set; }
        public string TenTB { get; set; }
        public string NuocSanXuat { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }

        public ThietBi(string ma, string ten, string nuocSX, int donGia, int soLuong)
        {
            this.MaTB = ma;
            this.TenTB = ten;
            this.NuocSanXuat = nuocSX;
            this.DonGia = donGia;
            this.SoLuong = soLuong;
        }

        public int ThanhTien(int DonGia, int SoLuong)
        {
            return DonGia * SoLuong;
        }

        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", MaTB, TenTB, NuocSanXuat ,DonGia, SoLuong);
        }


    }
}
