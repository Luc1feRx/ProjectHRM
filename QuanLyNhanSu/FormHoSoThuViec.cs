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
using System.IO;

namespace QuanLyNhanSu
{
    public partial class FormHoSoThuViec : Form
    {
        string strconnect = @"Data Source=LAPTOP-GUMFVEKB;Initial Catalog=QLNS;User ID=sa;Password=123";
        Connect cn = new Connect();
        public FormHoSoThuViec()
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
            string query = "select * from TblHoSoThuViec";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Mã Phòng";
            dataGridView1.Columns[1].HeaderText = "Mã NVTV";
            dataGridView1.Columns[2].HeaderText = "Họ Tên";
            dataGridView1.Columns[3].HeaderText = "Ngày sinh";
            dataGridView1.Columns[4].HeaderText = "Giới tính";
            dataGridView1.Columns[5].HeaderText = "Địa chỉ";
            dataGridView1.Columns[6].HeaderText = "TD học vấn";
            dataGridView1.Columns[7].HeaderText = "Vị trí TV";
            dataGridView1.Columns[8].HeaderText = "Ngày TV";
            dataGridView1.Columns[9].HeaderText = "Ghi chú";
            dataGridView1.Columns[10].HeaderText = "Avatar";
        }

        byte[] ConvertImageToBytes(Image img) //chuyen doi anh thanh dang byte
        {
            MemoryStream memoryStream = new MemoryStream();
            img.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
            return memoryStream.ToArray();
        }

        Image ByteToImage(byte[] b) //chuyendoi byte sang anh
        {
            MemoryStream ms = new MemoryStream(b);
            return Image.FromStream(ms);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxAnhNVTV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG files(*.png)|*.png|JPG files (*.jpg|*.jpg|All files (*.*)|*.*";
            openFileDialog.FilterIndex = -1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxAnhNVTV.ImageLocation = openFileDialog.FileName;
                this.Text = openFileDialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                comboBoxMaPhong.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txtMaNVTV.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                txtHoTen.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                dateTimePickerngaySinh.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                comboBoxGioiTinh.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                txtDiaChi.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                txtTrinhDo.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                txtVTTV.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
                dateTimePickerNgayThuViec.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
                txtGhiChu.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
                byte[] b = (byte[])dataGridView1.Rows[i].Cells[10].Value;
                pictureBoxAnhNVTV.Image = ByteToImage(b);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không tải được dữ liệu");
            }
        }

        private void FormHoSoThuViec_Load(object sender, EventArgs e)
        {
            dateTimePickerngaySinh.CustomFormat = " MM / dd / yyyy ";
            dateTimePickerNgayThuViec.CustomFormat = " MM / dd / yyyy ";
            LoadDataGridView();
            cn.loadcombobox(comboBoxMaPhong, "select * from Tblphongban", 1);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(strconnect);
                byte[] b = ConvertImageToBytes(pictureBoxAnhNVTV.Image);
                string queryinsert = "insert into TblHoSoThuViec values(@MaPhong, @MaNVTV, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @TDHocVan, @ViTriThuViec, @NgayTV, @GhiChu, @AnhNVTV)";
                if (!cn.Exitsted(txtMaNVTV.Text, "select MaNVTV from TblHoSoThuViec"))
                {
                    sqlcon.Open();
                    SqlCommand cmd = new SqlCommand(queryinsert, sqlcon);
                    cmd.Parameters.AddWithValue("@MaPhong", comboBoxMaPhong.Text);
                    cmd.Parameters.AddWithValue("@MaNVTV", txtMaNVTV.Text);
                    cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", dateTimePickerngaySinh.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", comboBoxGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    cmd.Parameters.AddWithValue("@TDHocVan", txtTrinhDo.Text);
                    cmd.Parameters.AddWithValue("@ViTriThuViec", txtVTTV.Text);
                    cmd.Parameters.AddWithValue("@NgayTV", dateTimePickerNgayThuViec.Text);
                    cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
                    cmd.Parameters.AddWithValue("@AnhNVTV", b);
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();
                    dataGridView1.Refresh();
                    LoadDataGridView();
                    MessageBox.Show("Thêm thành công");
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(strconnect);
                byte[] b = ConvertImageToBytes(pictureBoxAnhNVTV.Image);
                string update = "update TblHoSoThuViec set MaPhong=@MaPhong,HoTen=@HoTen,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh,DiaChi=@DiaChi,TDHocVan=@TDHocVan,ViTriThuViec=@ViTriThuViec,NgayTV=@NgayTV,GhiChu=@GhiChu,AnhNVTV=@AnhNVTV where MaNVTV=@MaNVTV";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(update, sqlcon);
                cmd.Parameters.AddWithValue("@MaPhong", comboBoxMaPhong.Text);
                cmd.Parameters.AddWithValue("@MaNVTV", txtMaNVTV.Text);
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateTimePickerngaySinh.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", comboBoxGioiTinh.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@TDHocVan", txtTrinhDo.Text);
                cmd.Parameters.AddWithValue("@ViTriThuViec", txtVTTV.Text);
                cmd.Parameters.AddWithValue("@NgayTV", dateTimePickerNgayThuViec.Text);
                cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
                cmd.Parameters.AddWithValue("@AnhNVTV", b);
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                dataGridView1.Refresh();
                LoadDataGridView();
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string dell = "delete from TblBangCongThuViec where MaNVTV='" + txtMaNVTV.Text + "'";
                cn.makeConnected(dell);
                string del = "delete from TblHoSoThuViec where MaNVTV='" + txtMaNVTV.Text + "'";
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cn.makeConnected(del);
                    LoadDataGridView();
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
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
