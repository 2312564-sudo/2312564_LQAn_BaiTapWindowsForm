namespace _2312564_LQAn_BaiTapWindowsForm_BT3
{
    partial class frmBai2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdGiaiThua = new System.Windows.Forms.RadioButton();
            this.rdTinhTong = new System.Windows.Forms.RadioButton();
            this.btnGiaiThua = new System.Windows.Forms.Button();
            this.lblGiaiThua = new System.Windows.Forms.Label();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdGiaiThua);
            this.groupBox1.Controls.Add(this.rdTinhTong);
            this.groupBox1.Location = new System.Drawing.Point(282, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(300, 125);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn công việc";
            // 
            // rdGiaiThua
            // 
            this.rdGiaiThua.AutoSize = true;
            this.rdGiaiThua.Location = new System.Drawing.Point(9, 74);
            this.rdGiaiThua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdGiaiThua.Name = "rdGiaiThua";
            this.rdGiaiThua.Size = new System.Drawing.Size(168, 24);
            this.rdGiaiThua.TabIndex = 1;
            this.rdGiaiThua.TabStop = true;
            this.rdGiaiThua.Text = "Tính N giai thừa(N!)";
            this.rdGiaiThua.UseVisualStyleBackColor = true;
            // 
            // rdTinhTong
            // 
            this.rdTinhTong.AutoSize = true;
            this.rdTinhTong.Checked = true;
            this.rdTinhTong.Location = new System.Drawing.Point(9, 29);
            this.rdTinhTong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdTinhTong.Name = "rdTinhTong";
            this.rdTinhTong.Size = new System.Drawing.Size(168, 24);
            this.rdTinhTong.TabIndex = 0;
            this.rdTinhTong.TabStop = true;
            this.rdTinhTong.Text = "Tính tổng 1+2+..+N";
            this.rdTinhTong.UseVisualStyleBackColor = true;
            // 
            // btnGiaiThua
            // 
            this.btnGiaiThua.Location = new System.Drawing.Point(282, 246);
            this.btnGiaiThua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGiaiThua.Name = "btnGiaiThua";
            this.btnGiaiThua.Size = new System.Drawing.Size(112, 35);
            this.btnGiaiThua.TabIndex = 19;
            this.btnGiaiThua.Text = "Xem kết quả";
            this.btnGiaiThua.UseVisualStyleBackColor = true;
            this.btnGiaiThua.Click += new System.EventHandler(this.btnGiaiThua_Click);
            // 
            // lblGiaiThua
            // 
            this.lblGiaiThua.AutoSize = true;
            this.lblGiaiThua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaiThua.Location = new System.Drawing.Point(413, 307);
            this.lblGiaiThua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiaiThua.Name = "lblGiaiThua";
            this.lblGiaiThua.Size = new System.Drawing.Size(17, 25);
            this.lblGiaiThua.TabIndex = 18;
            this.lblGiaiThua.Text = ".";
            // 
            // txtSo
            // 
            this.txtSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSo.Location = new System.Drawing.Point(350, 31);
            this.txtSo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(230, 30);
            this.txtSo.TabIndex = 16;
            this.txtSo.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(278, 307);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Kết quả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nhập một số nguyên dương N:";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 382);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGiaiThua);
            this.Controls.Add(this.lblGiaiThua);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Name = "frmBai2";
            this.Text = "Bài 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdGiaiThua;
        private System.Windows.Forms.RadioButton rdTinhTong;
        private System.Windows.Forms.Button btnGiaiThua;
        private System.Windows.Forms.Label lblGiaiThua;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
    }
}