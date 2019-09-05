﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using KetNoiDB;
namespace BangThuVien
{
    public class BUS_BanDoc
    {
        KetNoi cn = new KetNoi();
        dbConnection dbcon = new dbConnection();
        // Tao bang tim kiem theo ID
        public DataTable TimKiemBDID(string _MaBD)
               private void frm_load(object sender, EventArgs e)
         
        {
            DataTable dt = new DataTable();
            string str = string.Format("Select * from dbo.BanDoc where (MaBD = @MaBD)");
            SqlParameter[] arrPara = new SqlParameter[1];
            arrPara[0] = new SqlParameter("@MaBD", SqlDbType.NVarChar, 10);
            arrPara[0].Value = _MaBD;

            dt = dbcon.executeSelectQuery(str, arrPara);
            return dt;
        }
        // Tao bang de hien thi ban doc

        //Them ban doc
        public void ThemBanDoc(string HoTen, string GioiTinh, DateTime NgaySinh, string CMND, string MaLop, string DiaChi, string Email, string DienThoai)
        {
            string sql = "ADDBanDoc";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            cmd.Parameters.AddWithValue("@CMND", CMND);
            cmd.Parameters.AddWithValue("@MaLop", MaLop);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@DienThoai", DienThoai);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            {
                bool b = true;
                string str = string.Format("UpdateSLTL");
                SqlConnection con = new SqlConnection(AppConfig.connectionString());
                con.Open();

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@MaDS", _MaDauSach);
                cmd.Parameters.AddWithValue("@SoLuong", -1);
                cmd.CommandType = CommandType.StoredProcedure;
                if (cmd.ExecuteNonQuery() > 0)
                    b = true;
                con.Close();
                return b;
            }
            public void SuaBanDoc(string MaBD, string HoTen, string GioiTinh, DateTime NgaySinh, string CMND, string MaLop, string DiaChi, string Email, string DienThoai)
            {
                string sql = "SuaBanDoc";
                SqlConnection con = new SqlConnection(KetNoi.connect());
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaBD", MaBD);
                cmd.Parameters.AddWithValue("@HoTen", HoTen);
                cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                cmd.Parameters.AddWithValue("@CMND", CMND);
                cmd.Parameters.AddWithValue("@MaLop", MaLop);
                cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@DienThoai", DienThoai);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            //Ham xoa ban doc
            public void XoaBanDoc(string MaBD)
            {
                string sql = "Xoa_BD";
                SqlConnection con = new SqlConnection(KetNoi.connect());
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaBD", MaBD);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            //Thong ke sach da muon theo ID
            public DataTable ThongKeSachDaMuonTheoID(string _MaBD)
            {
                string str = string.Format("ThongKeSachDaMuon");
                DataTable dt = new DataTable();

                SqlConnection con = new SqlConnection(KetNoi.connect());
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaBD", _MaBD);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }

            // SuaBanDoc
            public void ThemBanDoc1(string HoTen, string GioiTinh, DateTime NgaySinh, string CMND, string MaLop, string DiaChi, string Email, string DienThoai)
            {
                string sql = "ADDBanDoc";
                SqlConnection con = new SqlConnection(KetNoi.connect());
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@HoTen", HoTen);
                cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                cmd.Parameters.AddWithValue("@CMND", CMND);
                cmd.Parameters.AddWithValue("@MaLop", MaLop);
                cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@DienThoai", DienThoai);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            //Sua ban doc 1
            public void SuaBanDoc1(string MaBD, string HoTen, string GioiTinh, DateTime NgaySinh, string CMND, string MaLop, string DiaChi, string Email, string DienThoai)
            {
                string sql = "SuaBanDoc";
                SqlConnection con = new SqlConnection(KetNoi.connect());
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaBD", MaBD);
                cmd.Parameters.AddWithValue("@HoTen", HoTen);
                cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                cmd.Parameters.AddWithValue("@CMND", CMND);
                cmd.Parameters.AddWithValue("@MaLop", MaLop);
                cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@DienThoai", DienThoai);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            public void XoaBanDoc1(string MaBD)
            {
                string sql = "Xoa_BD";
                SqlConnection con = new SqlConnection(KetNoi.connect());
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaBD", MaBD);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }

        }
    }
}

