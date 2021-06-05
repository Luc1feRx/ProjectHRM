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
    public partial class FrmTTCoBan : Form
    {
        Connect cn = new Connect();
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
            string query = "SELECT * FROM TblTTNVCoBan";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridViewTTCoBan.DataSource = dt;
            dataGridViewTTCoBan.Columns[0].HeaderText = "Mã bộ phận";
            dataGridViewTTCoBan.Columns[1].HeaderText = "Mã phòng";
            dataGridViewTTCoBan.Columns[2].HeaderText = "Mã nhân viên";
            dataGridViewTTCoBan.Columns[3].HeaderText = "Họ tên";
            dataGridViewTTCoBan.Columns[4].HeaderText = "Mã lương";
            dataGridViewTTCoBan.Columns[5].HeaderText = "Ngày sinh";
            dataGridViewTTCoBan.Columns[6].HeaderText = "Giới tính";
            dataGridViewTTCoBan.Columns[7].HeaderText = "TTHôn nhân";
            dataGridViewTTCoBan.Columns[8].HeaderText = "CMTND";
            dataGridViewTTCoBan.Columns[9].HeaderText = "Nơi cấp";
            dataGridViewTTCoBan.Columns[10].HeaderText = "Chức vụ";
            dataGridViewTTCoBan.Columns[11].HeaderText = "Loại HĐ";
            dataGridViewTTCoBan.Columns[12].HeaderText = "Thời gian";
            dataGridViewTTCoBan.Columns[13].HeaderText = "Ngày ký";
            dataGridViewTTCoBan.Columns[14].HeaderText = "Ngày hết hạn";
            dataGridViewTTCoBan.Columns[15].HeaderText = "Ghi chú";

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                string queryinsert = "INSERT INTO TblTTNVCoBan VALUES(N'" + comboBoxMaBoPhan.Text + "',N'" + comboBoxMaPhong.Text + "',N'" + textBoxMaNV.Text + "',N'" + textBoxHoTen.Text + "',N'" + comboBoxMaLuong.Text + "',CONVERT(datetime,'" + dateTimeNgaySinh.Text + "', 103), N'" + comboBoxGioiTinh.Text + "',N'" + comboBoxTTHonNhan.Text + "',N'" + textBoxCMTND.Text + "',N'" + textBoxNoiCap.Text + "',N'" + comboBoxChucVu.Text + "',N'" + comboBoxHopDong.Text + "',N'" + textBoxThoiGian.Text + "',CONVERT(datetime,'" + dateBoxThoiGiaNgayKy.Text + "', 103),CONVERT(datetime,'" + dateTimePickerNgayHetHan.Text + "', 103),N'" + textBoxGhiChu.Text + "')";
                if (!cn.Exitsted(textBoxMaNV.Text, "SELECT MaNV FROM TblTTNVCoBan") && !cn.Exitsted(textBoxCMTND.Text, "SELECT CMTND FROM tblThoiViec"))
                {
                    //kiem tra nguoi dung da nhap hay chua
                    if(textBoxMaNV.Text != "" && textBoxCMTND.Text != "" && textBoxNoiCap.Text != "" && comboBoxChucVu.Text != "" && comboBoxHopDong.Text != "" && textBoxHoTen.Text != "")
                    {
                        cn.makeConnected(queryinsert);
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
                        cn.makeConnected(queryinsert);
                        dataGridViewTTCoBan.Refresh();
                        LoadDataGridView();
                        MessageBox.Show("Thêm thành công");
                        string delete = "delete from tblThoiViec where CMTND='" + textBoxCMTND.Text + "'";
                        cn.makeConnected(delete);
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
                }

                /*string queryins = "insert into TblCongKhoiDieuHanh(MaNV,HoTen,MaLuong) select MaNV,HoTen,MaLuong from TblTTNVCoBan where MaNV='" + textBoxMaNV.Text + "'";
                if ((!cn.Exitsted(textBoxMaNV.Text, "select MaNV from TblCongKhoiDieuHanh")))
                {
                    if (textBoxMaNV.Text != "")
                    {
                        cn.makeConnected(queryins);
                        dataGridViewTTCoBan.Refresh();
                    }
                }*/
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
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblTTNVCoBan set MaBoPhan=N'" + comboBoxMaBoPhan.Text + "',MaPhong=N'" + comboBoxMaPhong.Text + "',HoTen=N'" + textBoxHoTen.Text + "',MaLuong=N'" + comboBoxMaLuong.Text + "',NgaySinh= CONVERT(datetime,'" + dateTimeNgaySinh.Text + "', 103)" +  ",GioiTinh=N'" + comboBoxGioiTinh.Text + "',TTHonNhan=N'" + comboBoxTTHonNhan.Text + "',CMTND=N'" + textBoxCMTND.Text + "',NoiCap=N'" + textBoxNoiCap.Text + "',ChucVu=N'" + comboBoxChucVu.Text + "',LoaiHD=N'" + comboBoxHopDong.Text + "',ThoiGian=N'" + textBoxThoiGian.Text + "',NgayKy= CONVERT(datetime,'" + dateBoxThoiGiaNgayKy.Text + "', 103)" + ",NgayHetHan= CONVERT(datetime,'" + dateTimePickerNgayHetHan.Text + "', 103)" + ",GhiChu=N'" + textBoxGhiChu.Text + "' where MaNV=N'" + textBoxMaNV.Text + "'";
                cn.makeConnected(update);
                dataGridViewTTCoBan.Refresh();
                LoadDataGridView();
                MessageBox.Show("Sửa thảnh công");
            }
            catch
            {
                MessageBox.Show("Sửa thất bại");
            }

            /*
            string update2 = "update TblCongKhoiDieuHanh set HoTen=N'" + textBoxHoTen.Text + "',MaLuong=N'" + comboBoxMaLuong.Text + "' where MaNV=N'" + textBoxMaNV.Text + "'";
            cn.makeConnected(update2);
            LoadDataGridView();
            string update3 = "update TblCongKhoiDieuHanh set TenPhong = (select top(1) TenPhong from TblPhongBan a,TblTTNVCoBan b where a.MaPhong=b.MaPhong and a.MaPhong=N'" + comboBoxMaPhong.Text + "' group by TenPhong) where MaNV='" + textBoxMaNV.Text + "'";
            cn.makeConnected(update3);
            dataGridViewTTCoBan.Refresh();
            */
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


            dateTimeNgaySinh.CustomFormat = "dd/MM/yyyy";
            dateBoxThoiGiaNgayKy.CustomFormat = "dd/MM/yyyy";
            dateTimePickerNgayHetHan.CustomFormat = "dd/MM/yyyy";
        }

        public static void FillCombobox(string query, ComboBox cb, string ma, string ten) // do du lieu vao combobox
        {
            string connections = ConfigurationManager.ConnectionStrings["QuanLyNhanSu.Properties.Settings.QLNSConnectionString"].ConnectionString;//goi den connection trong app.config de ket noi voi database
            SqlConnection con = new SqlConnection(connections);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
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
                dateTimePickerNgayHetHan.CustomFormat = "dd/MM/yyyy";
                textBoxThoiGian.Enabled = true;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
