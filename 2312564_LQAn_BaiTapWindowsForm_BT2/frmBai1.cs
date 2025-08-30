using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm_BT2
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            ThietBi tb = new ThietBi("TB01", "Máy in", "Việt Nam", 3500000, 4);
            int donGia = tb.DonGia;
            int soLuong = tb.SoLuong;
            int ketQua = 0;
            ketQua=tb.ThanhTien(donGia, soLuong);
            
            lblThongBao.Text = tb.HienThi();
            lblKQThanhTien.Text = ketQua.ToString();
        }
    }
}
