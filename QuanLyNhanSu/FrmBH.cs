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
    public partial class FrmBH : Form
    {
        Connect cn = new Connect();
        public FrmBH()
        {
            InitializeComponent();
        }

        private void FrmBH_Load(object sender, EventArgs e)
        {
            dtNgayCap.CustomFormat = " MM / dd / yyyy ";
            cn.loadcombobox(comboBoxMaNV, "select * from TblTTNVCoBan", 2);
            LoadDataGridView();
        }

        private void button6_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
           
=======
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
        }

        public void LoadDataGridView()
        {
            string connections = ConfigurationManager.ConnectionStrings["QuanLyNhanSu.Properties.Settings.QLNSConnectionString"].ConnectionString;//goi den connection trong app.config de ket noi voi database
            SqlConnection con = new SqlConnection(connections);
            con.Open();
            string query = "select * from TblSoBH";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Mã NV";
            dataGridView1.Columns[1].HeaderText = "Mã Lương";
            dataGridView1.Columns[2].HeaderText = "Mã BH";
            dataGridView1.Columns[3].HeaderText = "Ngày cấp sổ";
            dataGridView1.Columns[4].HeaderText = "Nơi cấp sổ";
            dataGridView1.Columns[5].HeaderText = "Ghi chú";
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            comboBoxMaNV.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtMaLuong.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtMaBaoHiem.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dtNgayCap.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtNoiCap.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtGhiChu.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.loadtextbox(txtMaLuong, "select * from TblTTNVCoBan where MaNV=N'" + comboBoxMaNV.Text + "'", 4);
            cn.loadtextbox(txtMaBaoHiem, "select * from TblSoBH where MaNV=N'" + comboBoxMaNV.Text + "'", 2);
            cn.loaddatetime(dtNgayCap, "select * from TblSoBH where MaNV=N'" + comboBoxMaNV.Text + "'", 3);
            cn.loadtextbox(txtNoiCap, "select * from TblSoBH where MaNV=N'" + comboBoxMaNV.Text + "'", 4);
            cn.loadtextbox(txtGhiChu, "select * from TblSoBH where MaNV=N'" + comboBoxMaNV.Text + "'", 5);
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

        private void buttonThem_Click(object sender, EventArgs e)
        {

=======
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
            try
            {
                string insert = "insert into TblSoBH values(N'" + comboBoxMaNV.Text + "',N'" + txtMaLuong.Text + "',N'" + txtMaBaoHiem.Text + "',N'" + dtNgayCap.Text + "',N'" + txtNoiCap.Text + "',N'" + txtGhiChu.Text + "')";
                if (!cn.Exitsted(txtMaLuong.Text, "select MaSoBH from TblSoBH"))
                {
                    if (txtMaLuong.Text != "")
                    {
                        cn.makeConnected(insert);
                        dataGridView1.Refresh();
                        LoadDataGridView();
                        MessageBox.Show("Thêm thành công");
                    }
                    else MessageBox.Show("Bạn chưa nhập Mã số bảo hiểm");
                }
                else
                    MessageBox.Show("Mã số bảo hiểm này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

<<<<<<< HEAD
        private void buttonSua_Click(object sender, EventArgs e)
=======
        private void button2_Click(object sender, EventArgs e)
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
        {
            try
            {
                string update = "update TblSoBH set MaSoBH=N'" + txtMaBaoHiem.Text + "',NgayCapSo=N'" + dtNgayCap.Text + "',NoiCapSo=N'" + txtNoiCap.Text + "',GhiChu=N'" + txtGhiChu.Text + "' where MaNV=N'" + comboBoxMaNV.Text + "'";
                cn.makeConnected(update);
                LoadDataGridView();
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

<<<<<<< HEAD
        private void buttonXoa_Click(object sender, EventArgs e)
=======
        private void button3_Click(object sender, EventArgs e)
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
        {
            string delete = "delete from TblSoBH where MaNV=N'" + comboBoxMaNV.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cn.makeConnected(delete);
                LoadDataGridView();
            }
        }

<<<<<<< HEAD
        private void buttonThoat_Click(object sender, EventArgs e)
=======
        private void button5_Click(object sender, EventArgs e)
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
        {
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
        }
<<<<<<< HEAD
=======

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            comboBoxMaNV.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtMaLuong.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtMaBaoHiem.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dtNgayCap.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtNoiCap.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtGhiChu.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.loadtextbox(txtMaLuong, "select * from TblTTNVCoBan where MaNV=N'" + comboBoxMaNV.Text + "'", 4);
            cn.loadtextbox(txtMaBaoHiem, "select * from TblSoBH where MaNV=N'" + comboBoxMaNV.Text + "'", 2);
            cn.loaddatetime(dtNgayCap, "select * from TblSoBH where MaNV=N'" + comboBoxMaNV.Text + "'", 3);
            cn.loadtextbox(txtNoiCap, "select * from TblSoBH where MaNV=N'" + comboBoxMaNV.Text + "'", 4);
            cn.loadtextbox(txtGhiChu, "select * from TblSoBH where MaNV=N'" + comboBoxMaNV.Text + "'", 5);
        }
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
    }
}
