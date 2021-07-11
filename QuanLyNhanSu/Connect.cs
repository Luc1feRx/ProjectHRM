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
        string connections = ConfigurationManager.ConnectionStrings["QuanLyNhanSu.Properties.Settings.QLNSConnectionString"].ConnectionString;//goi den connection trong app.config de ket noi voi database
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter sda;
        SqlConnection con;

        public void Connected()//de ket noi database
        {
            con = new SqlConnection(connections);
            con.Open();
        }
        public void Disconnected()//ngat database
        {
            con = new SqlConnection(connections);
            con.Close();
        }

        public void makeConnected(string queryC)//thuc thi ket noi
        {
            con = new SqlConnection(connections);
            con.Open();
            cmd = new SqlCommand(queryC, con);
            cmd.ExecuteNonQuery();
            Disconnected();
        }

        public bool Exitsted(string input, string query) //kiem tra trung lap hay khong
        {
            con = new SqlConnection(connections);
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

        //public DataTable GetDataTable(string queryGet)
        //{
        //    con = new SqlConnection(connections);
        //    DataTable dt = new DataTable();
        //    cmd = new SqlCommand(queryGet, con);
        //    try
        //    {
        //        con.Open();
        //        reader = cmd.ExecuteReader();
        //        dt.Load(reader, LoadOption.OverwriteChanges);
        //        if(dt.Rows.Count == 0)
        //        {
        //            return null;
        //        }
        //    }
        //    catch
        //    {

        //    }
        //    finally
        //    {
        //        Disconnected();
        //    }
        //    return dt;
        //}

        public void loadcombobox(ComboBox cb, string strselect, int cot)
        {
            Connected();
            cmd = new SqlCommand(strselect, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cb.Items.Add(reader[cot].ToString());
            }
            Disconnected();
        }
        public void loadcomboboxText(ComboBox cb, string strselect)
        {
            Connected();
            cmd = new SqlCommand(strselect, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cb.Text = reader[0].ToString();
            }
            Disconnected();
        }

        public void loadtextbox(TextBox cb, string strselect, int cot)
        {
            Connected();
            cmd = new SqlCommand(strselect, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cb.Text = reader[cot].ToString();
            }
            Disconnected();
        }
        public void loaddatetime(DateTimePicker dt, string strselect, int cot)
        {
            Connected();
            cmd = new SqlCommand(strselect, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dt.Text = reader[cot].ToString();
            }
            Disconnected();
        }

        public void loadtextboxText(TextBox tb, string strselect)
        {
            Connected();
            cmd = new SqlCommand(strselect, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tb.Text = reader[0].ToString();
            }
            Disconnected();
        }
    }
}
