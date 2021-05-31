using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace QuanLyNhanSu
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string connections = ConfigurationManager.ConnectionStrings["QuanLyNhanSu.Properties.Settings.QuanLyNhanSuConnectionString"].ConnectionString;//goi den connection trong app.config de ket noi voi database
            SqlConnection con = new SqlConnection(connections);//khoi tao bien con de ket noi database su dung thu vien sqlClient
            try
            {
                con.Open();// mo ket noi den database
                string query = "SELECT * FROM tbUsers WHERE Username = '" + textBoxUsername.Text + "' AND Pass = '" + textBoxPass.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);//xac dinh thao tac can xu ly doi voi data
                SqlDataReader reader = cmd.ExecuteReader();//doc du lieu tu database
                if (reader.HasRows)//rows > 0
                {
                    reader.Read();
                    String LoaiDN = reader[2].ToString();//phan loai dang nhap
                    if(LoaiDN == "Admin     ")
                    {
                        MessageBox.Show("Đăng nhập thành công!!! (Admin)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmMain.Quyen = "Admin";
                        this.Hide();
                        this.Close();
                    }else if (LoaiDN == "User      ")
                    {
                        MessageBox.Show("Đăng nhập thành công!!! (User)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmMain.Quyen = "User";
                        this.Hide();
                        this.Close();
                    }
                    FrmMain frm = new FrmMain();
                    frm.ShowDialog();
                    cmd.Dispose();
                    reader.Dispose();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không đúng ", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxUsername.Text = "";
                    textBoxPass.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
        }
    }
}
