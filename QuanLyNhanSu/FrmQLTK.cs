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
    public partial class FrmQLTK : Form
    {
        Connect cn = new Connect();
        public FrmQLTK()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNhapLai_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
           

        }

        

        private void dataGridViewTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void FrmQLTK_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            cn.loadcombobox(comboBoxQuyen, "select TenQuyen from tblQuyen", 0);
        }


        public void LoadDataGridView()
        {
            string connections = ConfigurationManager.ConnectionStrings["QuanLyNhanSu.Properties.Settings.QLNSConnectionString1"].ConnectionString;//goi den connection trong app.config de ket noi voi database
            SqlConnection con = new SqlConnection(connections);
            con.Open();
            string query = "SELECT * FROM tbuser";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridViewTaiKhoan.DataSource = dt;
            dataGridViewTaiKhoan.Columns[0].HeaderText = "Username";
            dataGridViewTaiKhoan.Columns[1].HeaderText = "Password";
            dataGridViewTaiKhoan.Columns[2].HeaderText = "Quyền";
            dataGridViewTaiKhoan.Columns[3].HeaderText = "Tên thật";
        }


        private void buttonTroVe_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridViewTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewTaiKhoan.Rows[e.RowIndex];
                textBoxTen.Text = row.Cells[0].Value.ToString();
                textBoxMatKhau.Text = row.Cells[1].Value.ToString();
                comboBoxQuyen.Text = row.Cells[2].Value.ToString();
                textBoxTenThat.Text = row.Cells[3].Value.ToString();
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonThem_Click_1(object sender, EventArgs e)
        {
            string input = textBoxTen.Text;
            string query = "SELECT * FROM tbuser";
            if (cn.Exitsted(input, query))
            {
                MessageBox.Show("Tên tài khoản đã tồn tại, mời bạn nhập lại");
                textBoxTen.Text = "";
            }
            else
            {
                string insert = "INSERT INTO tbuser VALUES('" + textBoxTen.Text + "','" + textBoxMatKhau.Text + "', '" + comboBoxQuyen.Text + "', N'" + textBoxTenThat.Text + "')";
                cn.makeConnected(insert);
                LoadDataGridView();
            }
        }

        private void buttonMoi_Click(object sender, EventArgs e)
        {
            textBoxTen.Text = "";
            textBoxTenThat.Text = "";
            textBoxMatKhau.Text = "";
            comboBoxQuyen.Text = "";
        }

        private void buttonSua_Click_1(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE tbuser SET Username = '" + textBoxTen.Text + "', Pass = '" + textBoxMatKhau.Text + "', Quyen = '" + comboBoxQuyen.Text + "', Ten = '" + textBoxTenThat.Text + "' WHERE Username = '" + textBoxTen.Text + "'";
                cn.makeConnected(query);
                LoadDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM tbuser WhERE Username = '" + textBoxTen.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cn.makeConnected(query);
                    LoadDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
        }
    }
}
