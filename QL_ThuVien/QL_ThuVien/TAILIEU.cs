using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KetNoiDB;
using BangThuVien;
namespace QL_ThuVien
{
    public partial class frmTAILIEU : Form
    {
        public frmTAILIEU()
        {
            InitializeComponent();
        }
        BUS_TaiLieu _tailieu = new BUS_TaiLieu();
        int chon = 0;
        TimKiem tk = new TimKiem();

        void KhoaDieuKhien()
        {
            txtTG.Enabled = txtNhanDe.Enabled = txtSoLuong.Enabled = txtNgonNgu.Enabled = cbMaTheLoai.Enabled = cbMaNXB.Enabled = txtDoMat.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            
        }

        void MoDieuKhien()
        {
            txtTG.Enabled = txtNhanDe.Enabled = txtSoLuong.Enabled = txtNgonNgu.Enabled = cbMaTheLoai.Enabled = cbMaNXB.Enabled = txtDoMat.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled =false;
            btnLuu.Enabled = true;
        }

        void SetNull()
        {
            txtDoMat.Text = cbMaNXB.Text = txtMaTL.Text = cbMaTheLoai.Text = txtNgonNgu.Text = txtNhanDe.Text = txtSoLuong.Text = txtTG.Text = "";
            txttk_MaTL.Text = txttk_NhanDe.Text = txttk_Tacgia.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            SetNull();
            chon = 1;
        }

       
    }
}
