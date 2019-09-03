﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using KetNoiDB;

namespace BangThuVien
{
    public class BUS_TaiKhoan
    {
        KetNoi con = new KetNoi();
        dbConnection dbcon = new dbConnection();

        public DataTable HienThi()
        {
            DataTable dt = new DataTable();
            string str = string.Format("Select * from TaiKhoan");
            dt = dbcon.executeSelectQueryNonParameter(str);
            return dt;
        }
        public DataTable TimKiemID(string _ID)
        {
            DataTable dt = new DataTable();
            string str = string.Format("Select * from TaiKhoan where (ID = @ID)");
            SqlParameter[] arrPara = new SqlParameter[1];
            arrPara[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 20);
            arrPara[0].Value = _ID;

            dt = dbcon.executeSelectQuery(str, arrPara);
            return dt;
        }
        public frmthongtinpphongkh()
        {
            InitializeComponent();
        }

        private void frm_load(object sender, EventArgs e)
        {
            phongBLL pbll = new phongBLL();
            dataGridView1.DataSource = pbll.hienthithongtinphong();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdangnhap frm = new frmdangnhap();
            frm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmCriticalItems CI = new frmCriticalItems();
            CI.Show();
        }

    }
}
