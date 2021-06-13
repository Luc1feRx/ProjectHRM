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
            foreach (Control ctr in this.groupBox4.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
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
            try
            {
                string insert = "insert into TblTangLuong values(N'" + comboBoxMaNV.Text + "',N'" + txtHoTen.Text + "',N'" + comboBoxGioiTinh.Text + "',N'" + comboBoxChucVu.Text + "',N'" + comboBoxMLC.Text + "',N'" + comboBoxMLM.Text + "',N'" + dateTimePickerNgayTang.Text + "',N'" + txtLyDo.Text + "')";
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {

                string update = "update TblTangLuong set HoTen=N'" + txtHoTen.Text + "',GioiTinh=N'" + comboBoxGioiTinh.Text + "',ChucVu=N'" + comboBoxChucVu.Text + "',MaLuongCu='" + comboBoxMLC.Text + "',MaLuongMoi=N'" + comboBoxMLM.Text + "',NgayTang='" + dateTimePickerNgayTang.Text + "',LyDo=N'" + txtLyDo.Text + "' where MaNV=N'" + comboBoxMaNV.Text + "'";
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

        private void button10_Click(object sender, EventArgs e)
        {
            string delete = "delete from TblTangLuong where MaNV=N'" + comboBoxMaNV.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cn.makeConnected(delete);
                LoadDataGridView();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
        }

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
    }
}
