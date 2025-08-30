using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2312564_LQAn_BaiTapThietKeForm
{
    public partial class frmBai3 : Form
    {
        List<string> list = new List<string>();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var tu = txtTuMoi.Text;
            var nghia = txtNghia.Text;
            listBox1.Items.Add(tu);
            list.Add(nghia);

            //Xóa văn bản 2 ô
            txtTuMoi.Focus();
            txtTuMoi.Text = "";
            txtNghia.Text = "";

            listBox1.SelectedIndex = listBox1.Items.Count - 1; // Chọn phần tử cuối (mới thêm)
            txtHienThiNghia.Text = nghia;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Lấy stt của từ trong Listbox
            var stt = listBox1.SelectedIndex;
            //Tra nghĩa của từ trong list dựa vào stt
            txtHienThiNghia.Text = list[stt];
        }
    }
}
