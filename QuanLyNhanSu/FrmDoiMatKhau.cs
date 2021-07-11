using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace QuanLyNhanSu
{
    public partial class FrmDoiMatKhau : Form
    {
        string username, password;
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        public FrmDoiMatKhau(string user, string pass)
        {
            InitializeComponent();
            username = user;
            password = pass;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            string connections = ConfigurationManager.ConnectionStrings["QuanLyNhanSu.Properties.Settings.QLNSConnectionString"].ConnectionString;//goi den connection trong app.config de ket noi voi database
            SqlConnection con = new SqlConnection(connections);//khoi tao bien con de ket noi database su dung thu vien sqlClient
            con.Open();
            string query = "SELECT * FROM tbuser WHERE Username = '" + textboxTenTruycap.Text + "'";//chon ra Username ma ban muon doi pass
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();//doc du lieu tu bang database
            if (reader.Read())
            {
                if (textboxTenTruycap.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên truy cập");
                }
                else
                {
                    if (textBoxMatKhauCu.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu");
                    }
                    else
                    {
                        if (textBoxMKMoi.Text == "")
                        {
                            MessageBox.Show("Bạn chưa nhập mật khẩu mới");
                        }
                        else
                        {
                            if (textBoxNhapLaiMK.Text == "")
                            {
                                MessageBox.Show("Bạn chưa nhập lại mật khẩu");
                            }
                            else
                            {
                                if (textBoxMatKhauCu.Text != reader[1].ToString())// so sanh pass cu tu textbox voi pass cu
                                {
                                    MessageBox.Show("Bạn đã nhập sai mật khẩu cũ");
                                }
                                else
                                {
                                    if(textBoxMatKhauCu.Text == textBoxMKMoi.Text)
                                    {
                                        MessageBox.Show("Trùng mật khẩu cũ, mời bạn nhập lại!!!");
                                    }
                                    else
                                    {
                                        if (textBoxMKMoi.Text == textBoxNhapLaiMK.Text)
                                        {
                                            string query2 = "UPDATE tbuser SET Pass = '" + textBoxMKMoi.Text + "' WHERE(Username = '" + textboxTenTruycap.Text + "' AND Pass = '" + textBoxMatKhauCu.Text + "')";
                                            SqlCommand cmd2 = new SqlCommand(query2, con);//xac dinh thao tac can xu ly doi voi data
                                            Connect cn = new Connect();
                                            cn.makeConnected(query2);
                                            MessageBox.Show("Bạn đã thay đổi mật khẩu thành công");
                                            FrmMain frm = new FrmMain(textboxTenTruycap.Text, textBoxMKMoi.Text);
                                            frm.ShowDialog();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Bạn nhập lại mật khẩu không đúng");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                reader.Close();
                this.Hide();
            }
        }

        private void buttonMoi_Click(object sender, EventArgs e)
        {
            textboxTenTruycap.Text = "";
            textBoxMKMoi.Text = "";
            textBoxNhapLaiMK.Text = "";
            textBoxMatKhauCu.Text = "";
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frmMain = new FrmMain(textboxTenTruycap.Text, textBoxMKMoi.Text);
            frmMain.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {
            textboxTenTruycap.Text = username;
        }
    }
}
