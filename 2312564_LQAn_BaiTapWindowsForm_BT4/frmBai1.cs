using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2312564_LQAn_BaiTapWindowsForm_BT4
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSanPham = "M001";
            sp.LoaiSanPham = "Chai Nước";
            sp.TenSanPham = "Chai Sting ";
            sp.NgaySanXuat = DateTime.Parse("6/9/2025");
            lblThongBao.Text = sp.HienThi();
        }
    }
}