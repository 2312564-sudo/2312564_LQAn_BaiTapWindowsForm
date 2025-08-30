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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

       

        private void btnTachChuoi_Click(object sender, EventArgs e)
        {
            string s1 = "";
            string s2 = "";
            Cau3.TachChuoi(txtChuoi.Text, out s1, out s2);

            lblHo.Text = s1.ToString();
            lblTen.Text = s2.ToString();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            bool kq = false;
            kq = Cau3.ThuTu(a, b);
            if (kq == true)
            {
                lblKetQua.Text = "A và B là số nguyên liên tiếp nhau";
            }
            else
                lblKetQua.Text = "A và B không là số nguyên liên tiếp nhau";
        }
    }
}
