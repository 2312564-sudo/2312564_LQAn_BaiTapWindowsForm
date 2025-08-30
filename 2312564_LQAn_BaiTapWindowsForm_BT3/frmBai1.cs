using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2312564_LQAn_BaiTapWindowsForm_BT3
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien("2312564", "Lê Quốc An", "02/10/2005", 12, 2.7);
            double kq = 0;

            lblThongBao.Text = nv.HienThi();

            kq = nv.TinhLuong();
            lblLuong.Text = kq.ToString();
        }
    }
}
