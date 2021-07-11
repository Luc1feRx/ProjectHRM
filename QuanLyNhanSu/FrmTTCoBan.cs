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
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace QuanLyNhanSu
{
    public partial class FrmTTCoBan : Form
    {
        Connect cn = new Connect();
<<<<<<< HEAD
        string strconnect = @"Data Source=LAPTOP-GUMFVEKB;Initial Catalog=QLNS;User ID=sa;Password=123";
=======
        string strconnect = "Data Source=LAPTOP-GUMFVEKB;Initial Catalog=QLNS;User ID=sa;Password=123";
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
        public FrmTTCoBan()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCombobox("select p.MaPhong from TblBoPhan b,TblPhongBan p where b.MaBoPhan=p.MaBoPhan and p.MaBoPhan=N'" + comboBoxMaBoPhan.SelectedValue + "'", comboBoxMaPhong, "MaPhong", "MaPhong");
        }

        public void LoadDataGridView()
        {
            string connections = ConfigurationManager.ConnectionStrings["QuanLyNhanSu.Properties.Settings.QLNSConnectionString"].ConnectionString;//goi den connection trong app.config de ket noi voi database
            SqlConnection con = new SqlConnection(connections);
            con.Open();
<<<<<<< HEAD
            string query = "SELECT MaBoPhan, MaPhong, MaNV,HoTen, MaLuong, GioiTinh, NgaySinh, TTHonNhan, CMTND, NoiCap, ChucVu, LoaiHD, ThoiGian, NgayKy, NgayHetHan, GhiChu, AnhNV FROM TblTTNVCoBan";
=======
            string query = "SELECT * FROM TblTTNVCoBan";
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridViewTTCoBan.DataSource = dt;
            dataGridViewTTCoBan.Columns[0].HeaderText = "Mã bộ phận";
            dataGridViewTTCoBan.Columns[1].HeaderText = "Mã phòng";
            dataGridViewTTCoBan.Columns[2].HeaderText = "Mã nhân viên";
            dataGridViewTTCoBan.Columns[3].HeaderText = "Họ tên";
            dataGridViewTTCoBan.Columns[4].HeaderText = "Mã lương";
<<<<<<< HEAD
            dataGridViewTTCoBan.Columns[5].HeaderText = "Giới tính";
            dataGridViewTTCoBan.Columns[6].HeaderText = "Ngày sinh";
=======
            dataGridViewTTCoBan.Columns[5].HeaderText = "Ngày sinh";
            dataGridViewTTCoBan.Columns[6].HeaderText = "Giới tính";
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
            dataGridViewTTCoBan.Columns[7].HeaderText = "TTHôn nhân";
            dataGridViewTTCoBan.Columns[8].HeaderText = "CMTND";
            dataGridViewTTCoBan.Columns[9].HeaderText = "Nơi cấp";
            dataGridViewTTCoBan.Columns[10].HeaderText = "Chức vụ";
            dataGridViewTTCoBan.Columns[11].HeaderText = "Loại HĐ";
            dataGridViewTTCoBan.Columns[12].HeaderText = "Thời gian";
            dataGridViewTTCoBan.Columns[13].HeaderText = "Ngày ký";
            dataGridViewTTCoBan.Columns[14].HeaderText = "Ngày hết hạn";
            dataGridViewTTCoBan.Columns[15].HeaderText = "Ghi chú";
            dataGridViewTTCoBan.Columns[16].HeaderText = "Avatar";

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

        private void buttonThem_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBoxTTCB.Controls)
            {
                if ((ctr is System.Windows.Forms.TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewTTCoBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewTTCoBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
<<<<<<< HEAD
                int i = e.RowIndex;
                comboBoxMaBoPhan.Text = dataGridViewTTCoBan.Rows[i].Cells[0].Value.ToString();
                comboBoxMaPhong.Text = dataGridViewTTCoBan.Rows[i].Cells[1].Value.ToString();
                textBoxMaNV.Text = dataGridViewTTCoBan.Rows[i].Cells[2].Value.ToString();
                textBoxHoTen.Text = dataGridViewTTCoBan.Rows[i].Cells[3].Value.ToString();
                comboBoxMaLuong.Text = dataGridViewTTCoBan.Rows[i].Cells[4].Value.ToString();
                dateTimeNgaySinh.Text = dataGridViewTTCoBan.Rows[i].Cells[6].Value.ToString();
                comboBoxGioiTinh.Text = dataGridViewTTCoBan.Rows[i].Cells[5].Value.ToString();
                comboBoxTTHonNhan.Text = dataGridViewTTCoBan.Rows[i].Cells[7].Value.ToString();
                textBoxCMTND.Text = dataGridViewTTCoBan.Rows[i].Cells[8].Value.ToString();
                textBoxNoiCap.Text = dataGridViewTTCoBan.Rows[i].Cells[9].Value.ToString();
                comboBoxChucVu.Text = dataGridViewTTCoBan.Rows[i].Cells[10].Value.ToString();
                comboBoxHopDong.Text = dataGridViewTTCoBan.Rows[i].Cells[11].Value.ToString();
                textBoxThoiGian.Text = dataGridViewTTCoBan.Rows[i].Cells[12].Value.ToString();
                dateBoxThoiGiaNgayKy.Text = dataGridViewTTCoBan.Rows[i].Cells[13].Value.ToString();
                dateTimePickerNgayHetHan.Text = dataGridViewTTCoBan.Rows[i].Cells[14].Value.ToString();
                textBoxGhiChu.Text = dataGridViewTTCoBan.Rows[i].Cells[15].Value.ToString();
                byte[] b = (byte[])dataGridViewTTCoBan.Rows[i].Cells[16].Value;
                pictureBoxAnhNV.Image = ByteToImage(b);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không tải được dữ liệu");
            }
        }

        private void FrmTTCoBan_Load(object sender, EventArgs e)
        {
            string connections = ConfigurationManager.ConnectionStrings["QuanLyNhanSu.Properties.Settings.QLNSConnectionString"].ConnectionString;//goi den connection trong app.config de ket noi voi database
            SqlConnection con = new SqlConnection(connections);
            con.Open();
            FillCombobox("SELECT MaBoPhan FROM TblBoPhan", comboBoxMaBoPhan, "MaBoPhan", "MaBoPhan");
            //cn.loadcombobox(comboBoxMaBoPhan, "SELECT MaBoPhan FROM TblBoPhan", 0);
            comboBoxMaBoPhan.SelectedIndex = -1; //set index = -1 de ko hien ma bo phan khi load form
            LoadDataGridView();
            cn.loadcombobox(comboBoxMaLuong, "Select MaLuong from TblBangLuongCTy", 0);
            cn.loadcombobox(comboBoxChucVu, "select ChucVu from tblChucVu", 0);
            cn.loadcombobox(comboBoxHopDong, "select LoaiHD from tblLoaiHD", 0);


            //FillCombobox("SELECT MaChucVu FROM tblChucVu", comboBoxChucVu, "MaChucVu", "MaChucVu");
            //comboBoxChucVu.DisplayMember = "MaChucVu";
            //comboBoxChucVu.ValueMember = "MaChucVu";


            dateTimeNgaySinh.CustomFormat = " MM / dd / yyyy ";
            dateBoxThoiGiaNgayKy.CustomFormat = " MM / dd / yyyy ";
            dateTimePickerNgayHetHan.CustomFormat = " MM / dd / yyyy ";
        }

        public static void FillCombobox(string query, ComboBox cb, string ma, string ten) // do du lieu vao combobox
        {
            string connections = ConfigurationManager.ConnectionStrings["QuanLyNhanSu.Properties.Settings.QLNSConnectionString"].ConnectionString;//goi den connection trong app.config de ket noi voi database
            SqlConnection con = new SqlConnection(connections);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            cb.DataSource = dt;
            cb.ValueMember = ma; //Trường giá trị
            cb.DisplayMember = ten; //Trường hiển thị
        }

        private void comboBoxMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxCMTND_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCMTND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void comboBoxHopDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxHopDong.Text == "Không thời hạn")
            {
                dateTimePickerNgayHetHan.Enabled = false;
                dateTimePickerNgayHetHan.CustomFormat = " ";
                textBoxThoiGian.Text = "";
                textBoxThoiGian.Enabled = false;
            }
            else
            {
                dateTimePickerNgayHetHan.Enabled = true;
                dateTimePickerNgayHetHan.CustomFormat = " MM / dd / yyyy ";
                textBoxThoiGian.Enabled = true;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG files(*.png)|*.png|JPG files (*.jpg|*.jpg|All files (*.*)|*.*";
            openFileDialog.FilterIndex = -1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxAnhNV.ImageLocation = openFileDialog.FileName;
                this.Text = openFileDialog.FileName;
            }
        }

        private void exportExcel(DataGridView dg, string path, string fileName)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < dg.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = dg.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                for (int j = 0; j < dg.Columns.Count; j++)
                {
                    if (dg.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = dg.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(path + fileName + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonThem_Click_1(object sender, EventArgs e)
        {
            try
            {
=======
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
                SqlConnection sqlcon = new SqlConnection(strconnect);
                byte[] b = ConvertImageToBytes(pictureBoxAnhNV.Image);
                string queryinsert = "insert into TblTTNVCoBan values(@MaBoPhan, @MaPhong, @MaNV, @HoTen, @MaLuong, @NgaySinh, @GioiTinh, @TTHonNhan, @CMTND, @NoiCap, @ChucVu, @LoaiHD, @ThoiGian, @NgayKy, @NgayHetHan, @GhiChu, @AnhNV)";
                if (!cn.Exitsted(textBoxMaNV.Text, "SELECT MaNV FROM TblTTNVCoBan") && !cn.Exitsted(textBoxCMTND.Text, "SELECT CMTND FROM tblThoiViec"))
                {
                    //kiem tra nguoi dung da nhap hay chua
<<<<<<< HEAD
                    if (textBoxMaNV.Text != "" && textBoxCMTND.Text != "" && textBoxNoiCap.Text != "" && comboBoxChucVu.Text != "" && comboBoxHopDong.Text != "" && textBoxHoTen.Text != "")
=======
                    if(textBoxMaNV.Text != "" && textBoxCMTND.Text != "" && textBoxNoiCap.Text != "" && comboBoxChucVu.Text != "" && comboBoxHopDong.Text != "" && textBoxHoTen.Text != "")
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
                    {
                        sqlcon.Open();
                        SqlCommand cmd = new SqlCommand(queryinsert, sqlcon);
                        cmd.Parameters.AddWithValue("@MaBoPhan", comboBoxMaBoPhan.Text);
                        cmd.Parameters.AddWithValue("@MaPhong", comboBoxMaPhong.Text);
                        cmd.Parameters.AddWithValue("@MaNV", textBoxMaNV.Text);
<<<<<<< HEAD
                        cmd.Parameters.AddWithValue("@HoTen", textBoxHoTen.Text);
                        cmd.Parameters.AddWithValue("@MaLuong", comboBoxMaLuong.Text);
=======
                        cmd.Parameters.AddWithValue("@HoTen", textBoxHoTen .Text);
                        cmd.Parameters.AddWithValue("@MaLuong", comboBoxMaLuong .Text);
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
                        cmd.Parameters.AddWithValue("@NgaySinh", dateTimeNgaySinh.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh", comboBoxGioiTinh.Text);
                        cmd.Parameters.AddWithValue("@TTHonNhan", comboBoxTTHonNhan.Text);
                        cmd.Parameters.AddWithValue("@CMTND", textBoxCMTND.Text);
                        cmd.Parameters.AddWithValue("@NoiCap", textBoxNoiCap.Text);
                        cmd.Parameters.AddWithValue("@ChucVu", comboBoxChucVu.Text);
                        cmd.Parameters.AddWithValue("@LoaiHD", comboBoxHopDong.Text);
                        cmd.Parameters.AddWithValue("@ThoiGian", textBoxThoiGian.Text);
<<<<<<< HEAD
                        cmd.Parameters.AddWithValue("@NgayKy", dateBoxThoiGiaNgayKy.Text);
=======
                        cmd.Parameters.AddWithValue("@NgayKy",dateBoxThoiGiaNgayKy.Text);
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
                        cmd.Parameters.AddWithValue("@NgayHetHan", dateTimePickerNgayHetHan.Text);
                        cmd.Parameters.AddWithValue("@GhiChu", textBoxGhiChu.Text);
                        cmd.Parameters.AddWithValue("@AnhNV", b);
                        cmd.ExecuteNonQuery();
                        sqlcon.Close();
                        dataGridViewTTCoBan.Refresh();
                        LoadDataGridView();
                        MessageBox.Show("Thêm thành công");
                    }
                    //kiem tra neu nguoi dung chua nhap du lieu
                    else if (textBoxHoTen.Text == "") MessageBox.Show("Bạn chưa nhập họ tên");
                    else if (textBoxMaNV.Text == "") MessageBox.Show("Bạn chưa nhập Mã nhân viên");
                    else if (textBoxCMTND.Text == "") MessageBox.Show("Bạn chưa nhập căn cước công dân");
                    else if (textBoxNoiCap.Text == "") MessageBox.Show("Bạn chưa nhập nơi cấp");
                    else if (comboBoxChucVu.Text == "") MessageBox.Show("Bạn chưa nhập chức vụ");
                    else if (comboBoxHopDong.Text == "") MessageBox.Show("Bạn chưa nhập loại hợp đồng");
                }
                else if (!cn.Exitsted(textBoxMaNV.Text, "SELECT MaNV FROM TblTTNVCoBan") && cn.Exitsted(textBoxCMTND.Text, "SELECT CMTND FROM tblThoiViec"))
                {
                    //them nhan vien da xoa hoac khong
                    if (MessageBox.Show("Nhân viên này đã từng làm ở công ty, bạn có chắc muốn thêm?", "Thêm thất bại", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        sqlcon.Open();
                        SqlCommand cmd = new SqlCommand(queryinsert, sqlcon);
                        cmd.Parameters.AddWithValue("@MaBoPhan", comboBoxMaBoPhan.Text);
                        cmd.Parameters.AddWithValue("@MaPhong", comboBoxMaPhong.Text);
                        cmd.Parameters.AddWithValue("@MaNV", textBoxMaNV.Text);
                        cmd.Parameters.AddWithValue("@HoTen", textBoxHoTen.Text);
                        cmd.Parameters.AddWithValue("@MaLuong", comboBoxMaLuong.Text);
<<<<<<< HEAD
                        cmd.Parameters.AddWithValue("@GioiTinh", comboBoxGioiTinh.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dateTimeNgaySinh.Text);
=======
                        cmd.Parameters.AddWithValue("@NgaySinh", dateTimeNgaySinh.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh", comboBoxGioiTinh.Text);
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
                        cmd.Parameters.AddWithValue("@TTHonNhan", comboBoxTTHonNhan.Text);
                        cmd.Parameters.AddWithValue("@CMTND", textBoxCMTND.Text);
                        cmd.Parameters.AddWithValue("@NoiCap", textBoxNoiCap.Text);
                        cmd.Parameters.AddWithValue("@ChucVu", comboBoxChucVu.Text);
                        cmd.Parameters.AddWithValue("@LoaiHD", comboBoxHopDong.Text);
                        cmd.Parameters.AddWithValue("@ThoiGian", textBoxThoiGian.Text);
                        cmd.Parameters.AddWithValue("@NgayKy", dateBoxThoiGiaNgayKy.Text);
                        cmd.Parameters.AddWithValue("@NgayHetHan", dateTimePickerNgayHetHan.Text);
                        cmd.Parameters.AddWithValue("@GhiChu", textBoxGhiChu.Text);
                        cmd.Parameters.AddWithValue("@AnhNV", b);
                        cmd.ExecuteNonQuery();
                        sqlcon.Close();
                        dataGridViewTTCoBan.Refresh();
                        LoadDataGridView();
                        MessageBox.Show("Thêm thành công");
                        string delete = "delete from tblThoiViec where CMTND='" + textBoxCMTND.Text + "'";
                        cn.makeConnected(delete);
<<<<<<< HEAD
                    }
                }
                else if (cn.Exitsted(textBoxMaNV.Text, "SELECT MaNV FROM TblTTNVCoBan") && (!cn.Exitsted(textBoxCMTND.Text, "select CMTND from tblThoiViec")))
                    MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                string queryin = "INSERT INTO TblTTCaNhan(MaNV,HoTen) select MaNV,HoTen from TblTTNVCoBan where MaNV='" + textBoxMaNV.Text + "'";
                if ((!cn.Exitsted(textBoxMaNV.Text, "select MaNV from TblTTCaNhan")))
                {
                    if (textBoxMaNV.Text != "")
                    {
                        cn.makeConnected(queryin);
                        dataGridViewTTCoBan.Refresh();
                    }
=======
                    }   
                }
                else if (cn.Exitsted(textBoxMaNV.Text, "SELECT MaNV FROM TblTTNVCoBan") && (!cn.Exitsted(textBoxCMTND.Text, "select CMTND from tblThoiViec")))
                    MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                string queryin = "INSERT INTO TblTTCaNhan(MaNV,HoTen) select MaNV,HoTen from TblTTNVCoBan where MaNV='" + textBoxMaNV.Text + "'";
                if ((!cn.Exitsted(textBoxMaNV.Text, "select MaNV from TblTTCaNhan")))
                {
                    if (textBoxMaNV.Text != "")
                    {
                        cn.makeConnected(queryin);
                        dataGridViewTTCoBan.Refresh();
                    }else MessageBox.Show("Bạn chưa nhập Mã nhân viên");
                }

                string queryins = "insert into TblCongKhoiDieuHanh(MaNV,HoTen,MaLuong) select MaNV,HoTen,MaLuong from TblTTNVCoBan where MaNV='" + textBoxMaNV.Text + "'";
                if ((!cn.Exitsted(textBoxMaNV.Text, "select MaNV from TblCongKhoiDieuHanh")))
                {
                    if (textBoxMaNV.Text != "")
                    {
                       cn.makeConnected(queryins);
                        dataGridViewTTCoBan.Refresh();
                    }else MessageBox.Show("Bạn chưa nhập Mã nhân viên");
                }

                string upda = " update TblCongKhoiDieuHanh set TenPhong = (select top(1) TenPhong from TblPhongBan a,TblTTNVCoBan b where a.MaPhong=b.MaPhong and a.MaPhong=N'" + comboBoxMaPhong.Text + "' group by TenPhong) where MaNV='" + textBoxMaNV.Text + "'";
                cn.makeConnected(upda);
                dataGridViewTTCoBan.Refresh();
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

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBoxTTCB.Controls)
            {
                if ((ctr is System.Windows.Forms.TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
                }

                string queryins = "insert into TblCongKhoiDieuHanh(MaNV,HoTen,MaLuong) select MaNV,HoTen,MaLuong from TblTTNVCoBan where MaNV='" + textBoxMaNV.Text + "'";
                if ((!cn.Exitsted(textBoxMaNV.Text, "select MaNV from TblCongKhoiDieuHanh")))
                {
                    if (textBoxMaNV.Text != "")
                    {
                        cn.makeConnected(queryins);
                        dataGridViewTTCoBan.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonSua_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(strconnect);
                byte[] b = ConvertImageToBytes(pictureBoxAnhNV.Image);
                string update = "update TblTTNVCoBan set MaBoPhan=@MaBoPhan,MaPhong=@MaPhong,HoTen=@HoTen,MaLuong=@MaLuong, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh,TTHonNhan=@TTHonNhan,CMTND=@CMTND,NoiCap=@NoiCap,ChucVu=@ChucVu,LoaiHD=@LoaiHD,ThoiGian=@ThoiGian,NgayKy=@NgayKy,NgayHetHan=NgayHetHan,GhiChu=@GhiChu,AnhNV=@AnhNV where MaNV=@MaNV";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(update, sqlcon);
                cmd.Parameters.AddWithValue("@MaBoPhan", comboBoxMaBoPhan.Text);
                cmd.Parameters.AddWithValue("@MaPhong", comboBoxMaPhong.Text);
                cmd.Parameters.AddWithValue("@MaNV", textBoxMaNV.Text);
                cmd.Parameters.AddWithValue("@HoTen", textBoxHoTen.Text);
                cmd.Parameters.AddWithValue("@MaLuong", comboBoxMaLuong.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", comboBoxGioiTinh.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateTimeNgaySinh.Text);
                cmd.Parameters.AddWithValue("@TTHonNhan", comboBoxTTHonNhan.Text);
                cmd.Parameters.AddWithValue("@CMTND", textBoxCMTND.Text);
                cmd.Parameters.AddWithValue("@NoiCap", textBoxNoiCap.Text);
                cmd.Parameters.AddWithValue("@ChucVu", comboBoxChucVu.Text);
                cmd.Parameters.AddWithValue("@LoaiHD", comboBoxHopDong.Text);
                cmd.Parameters.AddWithValue("@ThoiGian", textBoxThoiGian.Text);
                cmd.Parameters.AddWithValue("@NgayKy", dateBoxThoiGiaNgayKy.Text);
                cmd.Parameters.AddWithValue("@NgayHetHan", dateTimePickerNgayHetHan.Text);
                cmd.Parameters.AddWithValue("@GhiChu", textBoxGhiChu.Text);
                cmd.Parameters.AddWithValue("@AnhNV", b);
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                dataGridViewTTCoBan.Refresh();
                LoadDataGridView();
                MessageBox.Show("Sửa thảnh công");
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(strconnect);
                byte[] b = ConvertImageToBytes(pictureBoxAnhNV.Image);
                string update = "update TblTTNVCoBan set MaBoPhan=@MaBoPhan,MaPhong=@MaPhong,HoTen=@HoTen,MaLuong=@MaLuong,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh,TTHonNhan=@TTHonNhan,CMTND=@CMTND,NoiCap=@NoiCap,ChucVu=@ChucVu,LoaiHD=@LoaiHD,ThoiGian=@ThoiGian,NgayKy=@NgayKy,NgayHetHan=NgayHetHan,GhiChu=@GhiChu,AnhNV=@AnhNV where MaNV=@MaNV";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(update, sqlcon);
                cmd.Parameters.AddWithValue("@MaBoPhan", comboBoxMaBoPhan.Text);
                cmd.Parameters.AddWithValue("@MaPhong", comboBoxMaPhong.Text);
                cmd.Parameters.AddWithValue("@MaNV", textBoxMaNV.Text);
                cmd.Parameters.AddWithValue("@HoTen", textBoxHoTen.Text);
                cmd.Parameters.AddWithValue("@MaLuong", comboBoxMaLuong.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateTimeNgaySinh.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", comboBoxGioiTinh.Text);
                cmd.Parameters.AddWithValue("@TTHonNhan", comboBoxTTHonNhan.Text);
                cmd.Parameters.AddWithValue("@CMTND", textBoxCMTND.Text);
                cmd.Parameters.AddWithValue("@NoiCap", textBoxNoiCap.Text);
                cmd.Parameters.AddWithValue("@ChucVu", comboBoxChucVu.Text);
                cmd.Parameters.AddWithValue("@LoaiHD", comboBoxHopDong.Text);
                cmd.Parameters.AddWithValue("@ThoiGian", textBoxThoiGian.Text);
                cmd.Parameters.AddWithValue("@NgayKy", dateBoxThoiGiaNgayKy.Text);
                cmd.Parameters.AddWithValue("@NgayHetHan", dateTimePickerNgayHetHan.Text);
                cmd.Parameters.AddWithValue("@GhiChu", textBoxGhiChu.Text);
                cmd.Parameters.AddWithValue("@AnhNV", b);
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                dataGridViewTTCoBan.Refresh();
                LoadDataGridView();
                MessageBox.Show("Sửa thảnh công");
            }
            catch
            {
                MessageBox.Show("Sửa thất bại");
            }
            string update2 = "update TblCongKhoiDieuHanh set HoTen=N'" + textBoxHoTen.Text + "',MaLuong=N'" + comboBoxMaLuong.Text + "' where MaNV=N'" + textBoxMaNV.Text + "'";
            cn.makeConnected(update2);
            LoadDataGridView();
            string update3 = "update TblCongKhoiDieuHanh set TenPhong = (select top(1) TenPhong from TblPhongBan a,TblTTNVCoBan b where a.MaPhong=b.MaPhong and a.MaPhong=N'" + comboBoxMaPhong.Text + "' group by TenPhong) where MaNV='" + textBoxMaNV.Text + "'";
            cn.makeConnected(update3);
            dataGridViewTTCoBan.Refresh();
<<<<<<< HEAD
            string update4 = "update TblTTCaNhan set MaNV=N'" + textBoxMaNV.Text + "',HoTen=N'" + textBoxHoTen.Text + "' where MaNV=N'" + textBoxMaNV.Text + "'";
            cn.makeConnected(update4);
            dataGridViewTTCoBan.Refresh();
        }

        private void buttonXoa_Click_1(object sender, EventArgs e)
        {
            string insTV = "insert into tblThoiViec(MaNV,HoTen,CMTND,LyDo) select MaNV,HoTen,CMTND,GhiChu from TblTTNVCoBan where MaNV='" + textBoxMaNV.Text + "'";
            cn.makeConnected(insTV);
            LoadDataGridView();

            string deleteBH = "delete from TblSoBH where MaNV=N'" + textBoxMaNV.Text + "'";
            cn.makeConnected(deleteBH);

            string delete = "delete from TblTTNVCoBan where MaNV=N'" + textBoxMaNV.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cn.makeConnected(delete);
                LoadDataGridView();
                MessageBox.Show("Đã xóa dữ liệu");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
              exportExcel(dataGridViewTTCoBan, @"D:\", "ThongTinNhanSu");
            DialogResult dialog = MessageBox.Show("Xuất thành công. Bạn có muốn mở file Exel?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                System.Diagnostics.Process.Start(@"D:\");
            else if (dialog == DialogResult.No)
            {
                //
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxTTCB_Enter(object sender, EventArgs e)
        {

        }

        private void buttonMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBoxTTCB.Controls)
            {
                if ((ctr is System.Windows.Forms.TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void buttonThoat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
=======
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string insTV = "insert into tblThoiViec(MaNV,HoTen,CMTND,LyDo) select MaNV,HoTen,CMTND,GhiChu from TblTTNVCoBan where MaNV='" + textBoxMaNV.Text + "'";
            cn.makeConnected(insTV);
            LoadDataGridView();

            string delete = "delete from TblTTNVCoBan where MaNV=N'" + textBoxMaNV.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cn.makeConnected(delete);
                LoadDataGridView();
                MessageBox.Show("Đã xóa dữ liệu");
            }
        }

        private void dataGridViewTTCoBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewTTCoBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                comboBoxMaBoPhan.Text = dataGridViewTTCoBan.Rows[i].Cells[0].Value.ToString();
                comboBoxMaPhong.Text = dataGridViewTTCoBan.Rows[i].Cells[1].Value.ToString();
                textBoxMaNV.Text = dataGridViewTTCoBan.Rows[i].Cells[2].Value.ToString();
                textBoxHoTen.Text = dataGridViewTTCoBan.Rows[i].Cells[3].Value.ToString();
                comboBoxMaLuong.Text = dataGridViewTTCoBan.Rows[i].Cells[4].Value.ToString();
                dateTimeNgaySinh.Text = dataGridViewTTCoBan.Rows[i].Cells[5].Value.ToString();
                comboBoxGioiTinh.Text = dataGridViewTTCoBan.Rows[i].Cells[6].Value.ToString();
                comboBoxTTHonNhan.Text = dataGridViewTTCoBan.Rows[i].Cells[7].Value.ToString();
                textBoxCMTND.Text = dataGridViewTTCoBan.Rows[i].Cells[8].Value.ToString();
                textBoxNoiCap.Text = dataGridViewTTCoBan.Rows[i].Cells[9].Value.ToString();
                comboBoxChucVu.Text = dataGridViewTTCoBan.Rows[i].Cells[10].Value.ToString();
                comboBoxHopDong.Text = dataGridViewTTCoBan.Rows[i].Cells[11].Value.ToString();
                textBoxThoiGian.Text = dataGridViewTTCoBan.Rows[i].Cells[12].Value.ToString();
                dateBoxThoiGiaNgayKy.Text = dataGridViewTTCoBan.Rows[i].Cells[13].Value.ToString();
                dateTimePickerNgayHetHan.Text = dataGridViewTTCoBan.Rows[i].Cells[14].Value.ToString();
                textBoxGhiChu.Text = dataGridViewTTCoBan.Rows[i].Cells[15].Value.ToString();
                byte[] b = (byte[])dataGridViewTTCoBan.Rows[i].Cells[16].Value;
                pictureBoxAnhNV.Image = ByteToImage(b);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không tải được dữ liệu");
            }
        }

        private void FrmTTCoBan_Load(object sender, EventArgs e)
        {
            string connections = ConfigurationManager.ConnectionStrings["QuanLyNhanSu.Properties.Settings.QLNSConnectionString"].ConnectionString;//goi den connection trong app.config de ket noi voi database
            SqlConnection con = new SqlConnection(connections);
            con.Open();
            FillCombobox("SELECT MaBoPhan FROM TblBoPhan", comboBoxMaBoPhan, "MaBoPhan", "MaBoPhan");
            comboBoxMaBoPhan.SelectedIndex = -1; //set index = -1 de ko hien ma bo phan khi load form
            LoadDataGridView();
            cn.loadcombobox(comboBoxMaLuong, "Select MaLuong from TblBangLuongCTy", 0);
            cn.loadcombobox(comboBoxChucVu, "select ChucVu from tblChucVu", 0);
            cn.loadcombobox(comboBoxHopDong, "select LoaiHD from tblLoaiHD", 0);


            //FillCombobox("SELECT MaChucVu FROM tblChucVu", comboBoxChucVu, "MaChucVu", "MaChucVu");
            //comboBoxChucVu.DisplayMember = "MaChucVu";
            //comboBoxChucVu.ValueMember = "MaChucVu";


            dateTimeNgaySinh.CustomFormat = "MM / dd / yyyy";
            dateBoxThoiGiaNgayKy.CustomFormat = "MM / dd / yyyy";
            dateTimePickerNgayHetHan.CustomFormat = "MM / dd / yyyy";
        }

        public static void FillCombobox(string query, ComboBox cb, string ma, string ten) // do du lieu vao combobox
        {
            string connections = ConfigurationManager.ConnectionStrings["QuanLyNhanSu.Properties.Settings.QLNSConnectionString"].ConnectionString;//goi den connection trong app.config de ket noi voi database
            SqlConnection con = new SqlConnection(connections);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            cb.DataSource = dt;
            cb.ValueMember = ma; //Trường giá trị
            cb.DisplayMember = ten; //Trường hiển thị
        }

        private void comboBoxMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxCMTND_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCMTND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void comboBoxHopDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxHopDong.Text == "Không thời hạn")
            {
                dateTimePickerNgayHetHan.Enabled = false;
                dateTimePickerNgayHetHan.CustomFormat = " ";
                textBoxThoiGian.Text = "";
                textBoxThoiGian.Enabled = false;
            }
            else
            {
                dateTimePickerNgayHetHan.Enabled = true;
                dateTimePickerNgayHetHan.CustomFormat = "MM / dd / yyyy";
                textBoxThoiGian.Enabled = true;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG files(*.png)|*.png|JPG files (*.jpg|*.jpg|All files (*.*)|*.*";
            openFileDialog.FilterIndex = -1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxAnhNV.ImageLocation = openFileDialog.FileName;
                this.Text = openFileDialog.FileName;
            }
        }

        private void exprotExcel(DataGridView dg, string path, string fileName)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < dg.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = dg.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                for (int j = 0; j < dg.Columns.Count; j++)
                {
                    if (dg.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = dg.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(path + fileName + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exprotExcel(dataGridViewTTCoBan, @"D:\", "ThongTinNhanSu");
            DialogResult dialog = MessageBox.Show("Xuất thành công. Bạn có muốn mở file Exel?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                System.Diagnostics.Process.Start(@"D:\");
            else if (dialog == DialogResult.No)
            {
                //
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxTTCB_Enter(object sender, EventArgs e)
        {

>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
        }
    }
}
