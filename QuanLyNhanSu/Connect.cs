using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QuanLyNhanSu
{
    class Connect
    {
        string connections = ConfigurationManager.ConnectionStrings["QuanLyNhanSu.Properties.Settings.QuanLyNhanSuConnectionString"].ConnectionString;//goi den connection trong app.config de ket noi voi database
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter sda;

        public void Connected()//de ket noi database
        {
            SqlConnection con = new SqlConnection(connections);
            con.Open();
        }
        public void Disconnected()//ngat database
        {
            SqlConnection con = new SqlConnection(connections);
            con.Close();
        }

        public void makeConnected(string queryC)//thuc thi ket noi
        {
            SqlConnection con = new SqlConnection(connections);
            con.Open();
            cmd = new SqlCommand(queryC, con);
            cmd.ExecuteNonQuery();
            Disconnected();
        }

        public bool CheckUsernameExitsted(string input, string query) //kiem tra username co bi trung lap hay khong
        {
            SqlConnection con = new SqlConnection(connections);
            con.Open();
            cmd = new SqlCommand(query, con);
            reader = cmd.ExecuteReader();
            bool check = false;
            while (reader.Read())
            {
                if(reader[0].ToString() == input)
                {
                    check = true;//neu bi trung username se tra ve true
                }
            }
            reader.Close();
            Disconnected();
            return check;
        }

        public DataTable GetDataTable(string queryGet)
        {
            SqlConnection con = new SqlConnection(connections);
            DataTable dt = new DataTable();
            cmd = new SqlCommand(queryGet, con);
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                dt.Load(reader, LoadOption.OverwriteChanges);
                if(dt.Rows.Count == 0)
                {
                    return null;
                }
            }
            catch
            {

            }
            finally
            {
                Disconnected();
            }
            return dt;
        }
    }
}
