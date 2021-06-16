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
    public partial class FrmChucVu : Form
    {
        Connect cn = new Connect();
        public FrmChucVu()
        {
            InitializeComponent();
        }

        private void tblChucVuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblChucVuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLNSDataSet);

        }

        private void FrmChucVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNSDataSet.tblChucVu' table. You can move, or remove it, as needed.
            this.tblChucVuTableAdapter.Fill(this.qLNSDataSet.tblChucVu);
            LoadDataGridView();

        }

        public void LoadDataGridView()
        {
            string connections = ConfigurationManager.ConnectionStrings["QuanLyNhanSu.Properties.Settings.QLNSConnectionString1"].ConnectionString;//goi den connection trong app.config de ket noi voi database
            SqlConnection con = new SqlConnection(connections);
            con.Open();
            string query = "SELECT * FROM tblChucVu";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridViewChucVu.DataSource = dt;
            dataGridViewChucVu.Columns[0].HeaderText = "Mã chức vụ";
            dataGridViewChucVu.Columns[1].HeaderText = "Chức vụ";
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            string query = "insert into tblChucVu values(N'" + maChucVuTextBox.Text + "',N'" + chucVuTextBox.Text + "')";
            if(!cn.Exitsted(maChucVuTextBox.Text, "select MaChucVu from tblChucVu") && !cn.Exitsted(chucVuTextBox.Text, "select ChucVu from tblChucVu"))
            {
                if (maChucVuTextBox.Text != "" && chucVuTextBox.Text != "")
                {
                    cn.makeConnected(query);
                    dataGridViewChucVu.Refresh();
                    LoadDataGridView();
                    MessageBox.Show("Thêm thành công!!!");
                }
                else if (maChucVuTextBox.Text == "") MessageBox.Show("Bạn chưa nhập mã chức vụ");
                else if (chucVuTextBox.Text == "") MessageBox.Show("Bạn chưa nhập chức vụ");
            }
            else if(cn.Exitsted(maChucVuTextBox.Text, "select MaChucVu from tblChucVu") && !cn.Exitsted(chucVuTextBox.Text, "select ChucVu from tblChucVu"))
            {
                MessageBox.Show("Trùng mã chức vụ!!!");
            }else if (!cn.Exitsted(maChucVuTextBox.Text, "select MaChucVu from tblChucVu") && cn.Exitsted(chucVuTextBox.Text, "select ChucVu from tblChucVu"))
            {
                MessageBox.Show("Trùng chức vụ!!!");
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridViewChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            maChucVuTextBox.Text = dataGridViewChucVu.Rows[i].Cells[0].Value.ToString();
            chucVuTextBox.Text = dataGridViewChucVu.Rows[i].Cells[1].Value.ToString();
        }

        private void buttonThem_Click_1(object sender, EventArgs e)
        {
            string query = "insert into tblChucVu values(N'" + maChucVuTextBox.Text + "',N'" + chucVuTextBox.Text + "')";
            if (!cn.Exitsted(maChucVuTextBox.Text, "select MaChucVu from tblChucVu") && !cn.Exitsted(chucVuTextBox.Text, "select ChucVu from tblChucVu"))
            {
                if (maChucVuTextBox.Text != "" && chucVuTextBox.Text != "")
                {
                    cn.makeConnected(query);
                    dataGridViewChucVu.Refresh();
                    LoadDataGridView();
                    MessageBox.Show("Thêm thành công!!!");
                }
                else if (maChucVuTextBox.Text == "") MessageBox.Show("Bạn chưa nhập mã chức vụ");
                else if (chucVuTextBox.Text == "") MessageBox.Show("Bạn chưa nhập chức vụ");
            }
            else if (cn.Exitsted(maChucVuTextBox.Text, "select MaChucVu from tblChucVu") && !cn.Exitsted(chucVuTextBox.Text, "select ChucVu from tblChucVu"))
            {
                MessageBox.Show("Trùng mã chức vụ!!!");
            }
            else if (!cn.Exitsted(maChucVuTextBox.Text, "select MaChucVu from tblChucVu") && cn.Exitsted(chucVuTextBox.Text, "select ChucVu from tblChucVu"))
            {
                MessageBox.Show("Trùng chức vụ!!!");
            }
        }

        private void buttonSua_Click_1(object sender, EventArgs e)
        {
            string query = "update tblChucVu set MaChucVu = N'" + maChucVuTextBox.Text + "',ChucVu = N'" + chucVuTextBox.Text + "' where MaChucVu='" + maChucVuTextBox.Text + "'";
            cn.makeConnected(query);
            dataGridViewChucVu.Refresh();
            LoadDataGridView();
            MessageBox.Show("Sửa thành công!!!");
        }

        private void buttonXoa_Click_1(object sender, EventArgs e)
        {
            string query = "DELETE FROM tblChucVu WhERE MaChucVu = '" + maChucVuTextBox.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cn.makeConnected(query);
                LoadDataGridView();
            }
        }

        private void buttonThoat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
        }
    }
}
