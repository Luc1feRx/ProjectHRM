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
    public partial class FrmBoPhan : Form
    {
        Connect cn = new Connect();
        public FrmBoPhan()
        {
            InitializeComponent();
        }

        private void FrmBoPhan_Load(object sender, EventArgs e)
        {
            dateTimePickerTL.CustomFormat = " dd / MM / yyyy ";
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            string connections = ConfigurationManager.ConnectionStrings["QuanLyNhanSu.Properties.Settings.QLNSConnectionString"].ConnectionString;//goi den connection trong app.config de ket noi voi database
            SqlConnection con = new SqlConnection(connections);
            con.Open();
            string query = "select * from TblBoPhan";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridViewBoPhan.DataSource = dt;
            dataGridViewBoPhan.Columns[0].HeaderText = "Mã Bộ Phận";
            dataGridViewBoPhan.Columns[1].HeaderText = "Tên bộ phận";
            dataGridViewBoPhan.Columns[2].HeaderText = "Ngày Thành Lập";
            dataGridViewBoPhan.Columns[3].HeaderText = "Ghi Chú";
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
           
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewBoPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            textBoxMaBoPhan.Text = dataGridViewBoPhan.Rows[i].Cells[0].Value.ToString();
            textBoxTenBP.Text = dataGridViewBoPhan.Rows[i].Cells[1].Value.ToString();
            dateTimePickerTL.Text = dataGridViewBoPhan.Rows[i].Cells[2].Value.ToString();
            textBoxGhiChu.Text = dataGridViewBoPhan.Rows[i].Cells[3].Value.ToString();
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

        private void buttonMoi_Click(object sender, EventArgs e)
        {
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
                if (!cn.Exitsted(textBoxMaBoPhan.Text, "select MaBoPhan from TblBoPhan"))
                {
                    string insert = "insert into TblBoPhan values(N'" + textBoxMaBoPhan.Text + "',N'" + textBoxTenBP.Text + "',Convert(datetime, '" + dateTimePickerTL.Text + "',103),N'" + textBoxGhiChu.Text + "')";
                    cn.makeConnected(insert);
                    MessageBox.Show("Thêm thành công!!");
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Bộ phận này đã tòn tại ", "Trùng bộ phân", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void dataGridViewBoPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            textBoxMaBoPhan.Text = dataGridViewBoPhan.Rows[i].Cells[0].Value.ToString();
            textBoxTenBP.Text = dataGridViewBoPhan.Rows[i].Cells[1].Value.ToString();
            dateTimePickerTL.Text = dataGridViewBoPhan.Rows[i].Cells[2].Value.ToString();
            textBoxGhiChu.Text = dataGridViewBoPhan.Rows[i].Cells[3].Value.ToString();
        }

        private void buttonSua_Click(object sender, EventArgs e)
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
        {
            try
            {
                string update = "update TblBoPhan set MaBoPhan=N'" + textBoxMaBoPhan.Text + "',TenBoPhan=N'" + textBoxTenBP.Text + "',NgayThanhLap=convert(datetime,'" + dateTimePickerTL.Text + "',103),GhiChu=N'" + textBoxGhiChu.Text + "' where MaBoPhan='" + textBoxMaBoPhan.Text + "'";
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
            string del = "delete from TblBoPhan where MaBoPhan='" + textBoxMaBoPhan.Text + "'";
            string del1 = "delete from TblPhongBan where MaBoPhan='" + textBoxMaBoPhan.Text + "'";
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cn.makeConnected(del1);
                cn.makeConnected(del);
                LoadDataGridView();
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
    }
}
