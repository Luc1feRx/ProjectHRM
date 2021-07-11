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
    public partial class FrmCaNhan : Form
    {
        Connect cn = new Connect();
        public FrmCaNhan()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
          
        }

        public void LoadDataGridView()
        {
            string connections = ConfigurationManager.ConnectionStrings["QuanLyNhanSu.Properties.Settings.QLNSConnectionString"].ConnectionString;//goi den connection trong app.config de ket noi voi database
            SqlConnection con = new SqlConnection(connections);
            con.Open();
            string query = "select * from TblTTCaNhan";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[1].HeaderText = "Họ tên";
            dataGridView1.Columns[2].HeaderText = "Nơi sinh";
            dataGridView1.Columns[3].HeaderText = "Nguyên quán";
            dataGridView1.Columns[4].HeaderText = "ĐC thường trú";
            dataGridView1.Columns[5].HeaderText = "ĐC tạm trú";
            dataGridView1.Columns[6].HeaderText = "SĐT";
            dataGridView1.Columns[7].HeaderText = "Dân tộc";
            dataGridView1.Columns[8].HeaderText = "Tôn giáo";
            dataGridView1.Columns[9].HeaderText = "Quốc tịch";
            dataGridView1.Columns[10].HeaderText = "Học vấn";
            dataGridView1.Columns[11].HeaderText = "Ghi chú";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmCaNhan_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            cn.loadcombobox(comboBox1, "select * from TblTTNVCoBan", 2);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                comboBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                textBox6.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                textBox7.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
                textBox8.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
                textBox9.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
                textBox12.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
                textBox17.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.loadtextbox(textBox1, "select * from TblTTCaNhan where MaNV='" + comboBox1.Text + "'", 1);
            cn.loadtextbox(textBox2, "select * from TblTTCaNhan where MaNV='" + comboBox1.Text + "'", 2);
            cn.loadtextbox(textBox3, "select * from TblTTCaNhan where MaNV='" + comboBox1.Text + "'", 3);
            cn.loadtextbox(textBox4, "select * from TblTTCaNhan where MaNV='" + comboBox1.Text + "'", 4);
            cn.loadtextbox(textBox5, "select * from TblTTCaNhan where MaNV='" + comboBox1.Text + "'", 5);
            cn.loadtextbox(textBox6, "select * from TblTTCaNhan where MaNV='" + comboBox1.Text + "'", 6);
            cn.loadtextbox(textBox7, "select * from TblTTCaNhan where MaNV='" + comboBox1.Text + "'", 7);
            cn.loadtextbox(textBox8, "select * from TblTTCaNhan where MaNV='" + comboBox1.Text + "'", 8);
            cn.loadtextbox(textBox9, "select * from TblTTCaNhan where MaNV='" + comboBox1.Text + "'", 9);
            cn.loadtextbox(textBox12, "select * from TblTTCaNhan where MaNV='" + comboBox1.Text + "'", 10);
            cn.loadtextbox(textBox17, "select * from TblTTCaNhan where MaNV='" + comboBox1.Text + "'", 11);
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblTTCaNhan set Noisinh=N'" + textBox2.Text + "',NguyenQuan=N'" + textBox3.Text + "',DCThuongChu=N'" + textBox4.Text + "',DCTamChu=N'" + textBox5.Text + "',SDT=N'" + textBox6.Text + "',DanToc=N'" + textBox7.Text + "',TonGiao=N'" + textBox8.Text + "',QuocTich=N'" + textBox9.Text + "',HocVan=N'" + textBox12.Text + "',GhiChu=N'" + textBox17.Text + "' where MaNV=N'" + comboBox1.Text + "'";
                cn.makeConnected(update);
                LoadDataGridView();
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                string delete = "delete from TblTTCaNhan where MaNV=N'" + comboBox1.Text + "'";
                string delete2 = "delete from TblTTNVCoBan where MaNV=N'" + comboBox1.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cn.makeConnected(delete);
                    cn.makeConnected(delete2);
                    LoadDataGridView();
                }
            }
            catch
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
        }
    }
}
