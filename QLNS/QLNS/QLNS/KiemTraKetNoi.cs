using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLNS
{
    static class KiemTraKetNoi
    {
        static SqlConnection conn = new SqlConnection();
        static public void KetNoi()
        {
            string connstring = @"Data Source=DESKTOP-KA710V7\SQLEXPRESS;Initial Catalog=QuanLiNhanSu;Integrated Security=True";
            conn.ConnectionString = connstring;
            try
            {
                conn.Open();
            }
            catch
            {

            }
        }
        static public DataTable getDatatable(string sql)
        {
            if (conn.State == ConnectionState.Closed)
                KetNoi();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "QLNS");
            return ds.Tables["QLNS"];
        }
    }
}
