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
    public partial class FrmPhongBan : Form
    {
        Connect cn = new Connect();
        public FrmPhongBan()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void LoadDataGridView()
        {
            string connections = ConfigurationManager.ConnectionStrings["QuanLyNhanSu.Properties.Settings.QLNSConnectionString"].ConnectionString;//goi den connection trong app.config de ket noi voi database
            SqlConnection con = new SqlConnection(connections);
            con.Open();
            string query = "select * from TblPhongBan";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridViewPhongBan.DataSource = dt;
            dataGridViewPhongBan.Columns[0].HeaderText = "Mã Bộ Phận";
            dataGridViewPhongBan.Columns[1].HeaderText = "Mã Phòng";
            dataGridViewPhongBan.Columns[2].HeaderText = "Tên Phòng";
            dataGridViewPhongBan.Columns[3].HeaderText = "Ngày Thành Lập";
            dataGridViewPhongBan.Columns[4].HeaderText = "Ghi Chú";
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
        }

        private void buttonMoi_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            comboBoxMaBoPhan.Text = dataGridViewPhongBan.Rows[i].Cells[0].Value.ToString();
            textBoxMaPhong.Text = dataGridViewPhongBan.Rows[i].Cells[1].Value.ToString();
            textBoxTenPhong.Text = dataGridViewPhongBan.Rows[i].Cells[2].Value.ToString();
            dateTimePickerNgayTL.Text = dataGridViewPhongBan.Rows[i].Cells[3].Value.ToString();
            textBoxGhiChu.Text = dataGridViewPhongBan.Rows[i].Cells[4].Value.ToString();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmPhongBan_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            dateTimePickerNgayTL.CustomFormat = " dd / MM / yyyy ";
            cn.loadcombobox(comboBoxMaBoPhan, "select * from TblBoPhan", 0);
        }

        private void buttonMoi_Click_1(object sender, EventArgs e)
        {
            comboBoxMaBoPhan.Text = "";
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void buttonThem_Click_1(object sender, EventArgs e)
        {

=======
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
            try
            {
                if (!cn.Exitsted(textBoxMaPhong.Text, "select MaPhong from TblPhongBan"))
                {
                    string insert = "insert into TblPhongBan values('" + comboBoxMaBoPhan.Text + "',N'" + textBoxMaPhong.Text + "',N'" + textBoxTenPhong.Text + "',convert(datetime,'" + dateTimePickerNgayTL.Text + "',103),N'" + textBoxGhiChu.Text + "')";
                    cn.makeConnected(insert);
                    LoadDataGridView();
                    MessageBox.Show("Thêm thành công!!!");
                }
                else
                {
                    MessageBox.Show("Mã phòng này đã tòn tại bạn có thể thử mã phòng khác", "Trùng mã phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

<<<<<<< HEAD
        private void buttonSua_Click_1(object sender, EventArgs e)
=======
        private void buttonMoi_Click(object sender, EventArgs e)
        {
            comboBoxMaBoPhan.Text = "";
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void dataGridViewPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            comboBoxMaBoPhan.Text = dataGridViewPhongBan.Rows[i].Cells[0].Value.ToString();
            textBoxMaPhong.Text = dataGridViewPhongBan.Rows[i].Cells[1].Value.ToString();
            textBoxTenPhong.Text = dataGridViewPhongBan.Rows[i].Cells[2].Value.ToString();
            dateTimePickerNgayTL.Text = dataGridViewPhongBan.Rows[i].Cells[3].Value.ToString();
            textBoxGhiChu.Text = dataGridViewPhongBan.Rows[i].Cells[4].Value.ToString();
        }

        private void buttonSua_Click(object sender, EventArgs e)
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
        {
            try
            {
                string update = "update TblPhongBan set MaBoPhan=N'" + comboBoxMaBoPhan.Text + "', MaPhong=N'" + textBoxMaPhong.Text + "', TenPhong=N'" + textBoxTenPhong.Text + "',NgayThanhLap=convert(datetime,'" + dateTimePickerNgayTL.Text + "',103),GhiChu=N'" + textBoxGhiChu.Text + "' where MaPhong=N'" + textBoxMaPhong.Text + "'";
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
        private void buttonXoa_Click_1(object sender, EventArgs e)
=======
        private void buttonXoa_Click(object sender, EventArgs e)
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
        {
            try
            {
                string delete = "delete from TblPhongBan where MaPhong=N'" + textBoxMaPhong.Text + "'";
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cn.makeConnected(delete);
                    LoadDataGridView();
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

<<<<<<< HEAD
        private void buttonThoat_Click_1(object sender, EventArgs e)
=======
        private void buttonThoat_Click(object sender, EventArgs e)
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
        {
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
        }
<<<<<<< HEAD
=======

        private void FrmPhongBan_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            dateTimePickerNgayTL.CustomFormat = " dd / MM / yyyy ";
            cn.loadcombobox(comboBoxMaBoPhan, "select * from TblBoPhan", 0);
        }
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
    }
}
