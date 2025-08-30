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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoThuNhat.Text);
            int b = int.Parse(txtSoThuHai.Text);
            float ketQua = 0;
            if (rdCong.Checked) ketQua = a + b;
            else if (rdTru.Checked) ketQua = a - b;
            else if (rdNhan.Checked) ketQua = a * b;
            else ketQua = a / b;

            lblKetQua.Text = ketQua.ToString();
        }
    }
}
