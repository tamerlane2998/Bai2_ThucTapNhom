using System;
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

        public DataTable TimKiemBDID(string _MaBD)
        {
            DataTable dt = new DataTable();
            string str = string.Format("Select * from dbo.BanDoc where (MaBD = @MaBD)");
            SqlParameter[] arrPara = new SqlParameter[1];
            arrPara[0] = new SqlParameter("@MaBD", SqlDbType.NVarChar, 10);
            arrPara[0].Value = _MaBD;

            dt = dbcon.executeSelectQuery(str, arrPara);
            return dt;
        }
        
    }
}
