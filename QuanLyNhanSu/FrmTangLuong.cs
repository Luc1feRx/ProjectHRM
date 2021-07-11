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
    public partial class FrmTangLuong : Form
    {
        Connect cn = new Connect();
        public FrmTangLuong()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            
=======
            foreach (Control ctr in this.groupBox4.Controls)
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
            string query = "select * from TblTangLuong";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dg2.DataSource = dt;
            dg2.Columns[0].HeaderText = "Mã NV";
            dg2.Columns[1].HeaderText = "Họ tên";
            dg2.Columns[2].HeaderText = "Giới tính";
            dg2.Columns[3].HeaderText = "Chức vụ";
            dg2.Columns[4].HeaderText = "Mã lương cũ";
            dg2.Columns[5].HeaderText = "Mã lương mới";
            dg2.Columns[6].HeaderText = "Ngày tăng";
            dg2.Columns[7].HeaderText = "Lý do";
        }


        private void button4_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmTangLuong_Load(object sender, EventArgs e)
        {
            dateTimePickerNgayTang.CustomFormat = " MM / dd / yyyy ";
            cn.loadcombobox(comboBoxMaNV, "select * from TblTTNVCoBan", 2);
            LoadDataGridView();
           // cn.loadcombobox(txtchucvu, "select * from tblChucVu", 1);
           // cn.loadcombobox(comboBoxMLC, "select * from TblBangLuongCTy", 0);
            cn.loadcombobox(comboBoxMLM, "select * from TblBangLuongCTy", 0);
        }

        private void dg2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            comboBoxMaNV.Text = dg2.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dg2.Rows[i].Cells[1].Value.ToString();
            txtgioitinh.Text = dg2.Rows[i].Cells[2].Value.ToString();
            txtchucvu.Text = dg2.Rows[i].Cells[3].Value.ToString();
            txtmaluong.Text = dg2.Rows[i].Cells[4].Value.ToString();
            comboBoxMLM.Text = dg2.Rows[i].Cells[5].Value.ToString();
            dateTimePickerNgayTang.Text = dg2.Rows[i].Cells[6].Value.ToString();
            txtLyDo.Text = dg2.Rows[i].Cells[7].Value.ToString();
        }

        private void comboBoxMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.loadtextbox(txtHoTen, "select * from TblTTNVCoBan where MaNV='" + comboBoxMaNV.Text + "'", 3);
            cn.loadtextbox(txtgioitinh, "select * from TblTTNVCoBan where MaNV='" + comboBoxMaNV.Text + "'", 6);
            cn.loadtextbox(txtchucvu, "select * from TblTTNVCoBan where MaNV='" + comboBoxMaNV.Text + "'", 10);
            cn.loadtextbox(txtmaluong, "select * from TblTTNVCoBan where MaNV='" + comboBoxMaNV.Text + "'", 4);
            cn.loadcombobox(comboBoxMLM, "select MaLuongMoi from TblTangLuong where MaNV='" + comboBoxMaNV.Text + "'", 0);
        }

        private void buttonMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox4.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                string insert = "insert into TblTangLuong values(N'" + comboBoxMaNV.Text + "',N'" + txtHoTen.Text + "',N'" + txtgioitinh.Text + "',N'" + txtchucvu.Text + "',N'" + txtmaluong.Text + "',N'" + comboBoxMLM.Text + "',N'" + dateTimePickerNgayTang.Text + "',N'" + txtLyDo.Text + "')";
=======
            try
            {
                string insert = "insert into TblTangLuong values(N'" + comboBoxMaNV.Text + "',N'" + txtHoTen.Text + "',N'" + comboBoxGioiTinh.Text + "',N'" + comboBoxChucVu.Text + "',N'" + comboBoxMLC.Text + "',N'" + comboBoxMLM.Text + "',N'" + dateTimePickerNgayTang.Text + "',N'" + txtLyDo.Text + "')";
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
                if (!cn.Exitsted(comboBoxMaNV.Text, "select MaNV from TblTangLuong"))
                {
                    if (comboBoxMaNV.Text != "")
                    {
                        cn.makeConnected(insert);
                        dg2.Refresh();
                        LoadDataGridView();
                        MessageBox.Show("Thêm thành công");
                    }
                    else MessageBox.Show("Bạn chưa chọn mà nhân viên");
                }
                else
                    MessageBox.Show("Nhân viên này bạn đã nhập dữ liêu rồi", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
            string up = "update TblTTNVCoBan set MaLuong=N'" + comboBoxMLM.Text + "' where MaNV='" + comboBoxMaNV.Text + "'";
            cn.makeConnected(up);
            LoadDataGridView();
        }

<<<<<<< HEAD
        private void buttonSua_Click(object sender, EventArgs e)
=======
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
        {
            try
            {

<<<<<<< HEAD
                string update = "update TblTangLuong set HoTen=N'" + txtHoTen.Text + "',GioiTinh=N'" + txtgioitinh.Text + "',ChucVu=N'" + txtchucvu.Text + "',MaLuongCu='" + txtmaluong.Text + "',MaLuongMoi=N'" + comboBoxMLM.Text + "',NgayTang='" + dateTimePickerNgayTang.Text + "',LyDo=N'" + txtLyDo.Text + "' where MaNV=N'" + comboBoxMaNV.Text + "'";
=======
                string update = "update TblTangLuong set HoTen=N'" + txtHoTen.Text + "',GioiTinh=N'" + comboBoxGioiTinh.Text + "',ChucVu=N'" + comboBoxChucVu.Text + "',MaLuongCu='" + comboBoxMLC.Text + "',MaLuongMoi=N'" + comboBoxMLM.Text + "',NgayTang='" + dateTimePickerNgayTang.Text + "',LyDo=N'" + txtLyDo.Text + "' where MaNV=N'" + comboBoxMaNV.Text + "'";
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
                cn.makeConnected(update);
                LoadDataGridView();
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
            string up = "update TblTTNVCoBan set MaLuong=N'" + comboBoxMLM.Text + "' where MaNV='" + comboBoxMaNV.Text + "'";
            cn.makeConnected(up);
            LoadDataGridView();
        }

<<<<<<< HEAD
        private void buttonXoa_Click(object sender, EventArgs e)
=======
        private void button10_Click(object sender, EventArgs e)
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
        {
            string delete = "delete from TblTangLuong where MaNV=N'" + comboBoxMaNV.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cn.makeConnected(delete);
                LoadDataGridView();
            }
        }

<<<<<<< HEAD
        private void buttonThoat_Click(object sender, EventArgs e)
=======
        private void button8_Click(object sender, EventArgs e)
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
        {
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
        }
<<<<<<< HEAD
=======

        private void FrmTangLuong_Load(object sender, EventArgs e)
        {
            dateTimePickerNgayTang.CustomFormat = " MM / dd / yyyy ";
            cn.loadcombobox(comboBoxMaNV, "select * from TblTTNVCoBan", 2);
            LoadDataGridView();
            cn.loadcombobox(comboBoxChucVu, "select * from tblChucVu", 1);
            cn.loadcombobox(comboBoxMLC, "select * from TblBangLuongCTy", 0);
            cn.loadcombobox(comboBoxMLM, "select * from TblBangLuongCTy", 0);
        }

        private void dg2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            comboBoxMaNV.Text = dg2.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dg2.Rows[i].Cells[1].Value.ToString();
            comboBoxGioiTinh.Text = dg2.Rows[i].Cells[2].Value.ToString();
            comboBoxChucVu.Text = dg2.Rows[i].Cells[3].Value.ToString();
            comboBoxMLC.Text = dg2.Rows[i].Cells[4].Value.ToString();
            comboBoxMLM.Text = dg2.Rows[i].Cells[5].Value.ToString();
            dateTimePickerNgayTang.Text = dg2.Rows[i].Cells[6].Value.ToString();
            txtLyDo.Text = dg2.Rows[i].Cells[7].Value.ToString();
        }

        private void comboBoxMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.loadtextbox(txtHoTen, "select HoTen from TblTTNVCoBan where MaNV='" + comboBoxMaNV.Text + "'", 0);
            cn.loadcomboboxText(comboBoxGioiTinh, "select GioiTinh from TblTTNVCoBan where MaNV='" + comboBoxMaNV.Text + "'");
            cn.loadcomboboxText(comboBoxChucVu, "select ChucVu from TblTTNVCoBan where MaNV='" + comboBoxMaNV.Text + "'");
            cn.loadcomboboxText(comboBoxMLC, "select MaLuong from TblCongKhoiDieuHanh where MaNV='" + comboBoxMaNV.Text + "'");
            cn.loadcomboboxText(comboBoxMLM, "select MaLuongMoi from TblTangLuong where MaNV='" + comboBoxMaNV.Text + "'");
            cn.loadtextbox(txtLyDo, "select LyDo from TblTangLuong where MaNV='" + comboBoxMaNV.Text + "'", 0);
            cn.loaddatetime(dateTimePickerNgayTang, "select NgayTang from TblTangLuong where MaNV='" + comboBoxMaNV.Text + "'", 0);
        }
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
    }
}
