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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            float dTB = (int.Parse(txtLyThuyet.Text) + int.Parse(txtThucHanh.Text)) / 2;
            if (int.Parse(txtLyThuyet.Text) < 5 || int.Parse(txtThucHanh.Text) < 5)
                lblXepLoai.Text = "Yếu";
            else if (dTB < 7)  lblXepLoai.Text = "Trung Bình";
            else if (dTB <= 7 && dTB < 8) lblXepLoai.Text = "Khá";
            else if (dTB <= 8 && dTB < 9) lblXepLoai.Text = "Giỏi";
            else lblXepLoai.Text = "Xuất sắc";
        }
    }
}
