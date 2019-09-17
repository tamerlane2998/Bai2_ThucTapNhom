﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BangThuVien;
namespace QL_ThuVien
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        BUS_DangNhap dn = new BUS_DangNhap();

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (dn.DangNhap(txtUserName.Text, txtPass.Text) == true)
            {
                // bool x = false;
                MessageBox.Show("Đăng nhập thành công ^^", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmQLThuVien frm1 = new frmQLThuVien();
                frm1.Show();
                Hide();
            }
            else MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát ??", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            //SetStyle(ControlStyles.ResizeRedraw, true);
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           // label1.Text = label1.Text.Substring(2, label1.Text.Length - 2) + label1.Text.Substring(0, 2);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           // label1.ForeColor = Color.Yellow;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //label1.ForeColor = Color.Red;
        }
		        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát ??", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            //SetStyle(ControlStyles.ResizeRedraw, true);
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }
    }
}