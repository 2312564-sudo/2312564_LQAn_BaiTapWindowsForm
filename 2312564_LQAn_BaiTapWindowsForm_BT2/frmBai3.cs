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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnNoiChuoi_Click(object sender, EventArgs e)
        {
            string a = txtChuoi1.Text;
            string b = txtChuoi2.Text;
            string ketQua = "";
            Cau3.NoiChuoi(a, b, ref ketQua);
            lblGhepChuoi.Text = ketQua;
        }

        private void btnGiaiThua_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSo.Text);
            long ketQua = 0;

            ketQua = Cau3.GiaiThua(n);
            lblGiaiThua.Text = ketQua.ToString();
        }

        
    }
}
