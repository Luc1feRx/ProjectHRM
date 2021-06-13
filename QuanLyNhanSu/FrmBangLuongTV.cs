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
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace QuanLyNhanSu
{
    public partial class FrmBangLuongTV : Form
    {
        Connect cn = new Connect();
        public FrmBangLuongTV()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is System.Windows.Forms.TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
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
            string query = "select * from TblBangCongThuViec";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridViewLTV.DataSource = dt;
            dataGridViewLTV.Columns[0].HeaderText = "Tên Bộ Phận";
            dataGridViewLTV.Columns[1].HeaderText = "Tên Phòng";
            dataGridViewLTV.Columns[2].HeaderText = "Mã NVTV";
            dataGridViewLTV.Columns[3].HeaderText = "Lương Thử Việc";
            dataGridViewLTV.Columns[4].HeaderText = "Tháng";
            dataGridViewLTV.Columns[5].HeaderText = "Năm";
            dataGridViewLTV.Columns[6].HeaderText = "Số ngày công";
            dataGridViewLTV.Columns[7].HeaderText = "Số ngày nghỉ";
            dataGridViewLTV.Columns[8].HeaderText = "Số giờ làm thêm";
            dataGridViewLTV.Columns[9].HeaderText = "Lương";
            dataGridViewLTV.Columns[10].HeaderText = "Ghi chú";
        }


        private void buttonThem_Click(object sender, EventArgs e)
        {
            string insert = "insert into TblBangCongThuViec values(N'" + txtTenBP.Text + "',N'" + txtTenPhong.Text + "',N'" + cbMaNV.Text + "',N'" + txtThang.Text + "',N'" + txtNam.Text + "',N'" + textBoxLuong.Text + "',N'" + txtGioLamThem.Text + "',N'" + txtNgayCong.Text + "',N'" + txtNgayNghi.Text + "',N'" + textBoxLuong.Text + "',N'" + txtGhiChu.Text + "')";
            if (!cn.Exitsted(cbMaNV.Text, "select MaNVTV from TblBangCongThuViec"))
            {
                if (cbMaNV.Text != "")
                {
                    cn.makeConnected(insert);
                    dataGridViewLTV.Refresh();
                    LoadDataGridView();
                    MessageBox.Show("Thêm thành công");

                }
                else MessageBox.Show("Bạn chưa nhập Mã nhân viên");
            }
            else
                MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblBangCongThuViec set TenBoPhan=N'" + txtTenBP.Text + "',TenPhong=N'" + txtTenPhong.Text + "',LuongTViec=N'" + txtLTV.Text + "',Thang=N'" + txtThang.Text + "',Nam='" + txtNam.Text + "',SoNgayCong=N'" + txtNgayCong.Text + "',SoNgayNghi=N'" + txtNgayNghi.Text + "',SoGioLamThem=N'" + txtGioLamThem.Text + "',Luong=N'" + textBoxLuong.Text + "',GhiChu='" + txtGhiChu.Text + "' where MaNVTV=N'" + cbMaNV.Text + "'";
                cn.makeConnected(update);
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
                string delete = "delete from TblBangCongThuViec where MaNVTV=N'" + cbMaNV.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cn.makeConnected(delete);
                    LoadDataGridView();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void buttonTinhLuong_Click(object sender, EventArgs e)
        {
            int l = Convert.ToInt32(txtLTV.Text);
            int nc = Convert.ToInt32(txtNgayCong.Text);
            int lt = Convert.ToInt32(txtGioLamThem.Text);
            float luong = ((l / 26) * nc + (lt * 40000));
            textBoxLuong.Text = luong.ToString();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
        }

        //private void exprotExcel(DataGridView dg, string path, string fileName)
        //{
        //    app obj = new app();
        //    obj.Application.Workbooks.Add(Type.Missing);
        //    obj.Columns.ColumnWidth = 25;
        //    for (int i = 1; i < dg.Columns.Count + 1; i++)
        //    {
        //        obj.Cells[1, i] = dg.Columns[i - 1].HeaderText;
        //    }
        //    for (int i = 0; i < dg.Rows.Count; i++)
        //    {
        //        for (int j = 0; j < dg.Columns.Count; j++)
        //        {
        //            if (dg.Rows[i].Cells[j].Value != null)
        //            {
        //                obj.Cells[i + 2, j + 1] = dg.Rows[i].Cells[j].Value.ToString();
        //            }
        //        }
        //    }
        //    obj.ActiveWorkbook.SaveCopyAs(path + fileName + ".xlsx");
        //    obj.ActiveWorkbook.Saved = true;
        //}

        //private void buttonXuatExcel_Click(object sender, EventArgs e)
        //{
        //    exprotExcel(dataGridViewLTV, @"D:\", "BangLuongNhanVienThuViec");
        //    DialogResult dialog = MessageBox.Show("Xuất thành công. Bạn có muốn mở file Exel?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (dialog == DialogResult.Yes)
        //        System.Diagnostics.Process.Start(@"D:\");
        //    else if (dialog == DialogResult.No)
        //    {
        //        //
        //    }
        //}

        private void txtThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtLTV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtGioLamThem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNgayCong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNgayNghi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dataGridViewLTV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtTenBP.Text = dataGridViewLTV.Rows[i].Cells[0].Value.ToString();
            txtTenPhong.Text = dataGridViewLTV.Rows[i].Cells[1].Value.ToString();
            cbMaNV.Text = dataGridViewLTV.Rows[i].Cells[2].Value.ToString();
            txtLTV.Text = dataGridViewLTV.Rows[i].Cells[3].Value.ToString();
            txtThang.Text = dataGridViewLTV.Rows[i].Cells[4].Value.ToString();
            txtNam.Text = dataGridViewLTV.Rows[i].Cells[5].Value.ToString();
            txtNgayCong.Text = dataGridViewLTV.Rows[i].Cells[6].Value.ToString();
            txtNgayNghi.Text = dataGridViewLTV.Rows[i].Cells[7].Value.ToString();
            txtGioLamThem.Text = dataGridViewLTV.Rows[i].Cells[8].Value.ToString();
            textBoxLuong.Text = dataGridViewLTV.Rows[i].Cells[9].Value.ToString();
            txtGhiChu.Text = dataGridViewLTV.Rows[i].Cells[10].Value.ToString();
        }

        private void FrmBangLuongTV_Load(object sender, EventArgs e)
        {
            cn.loadcombobox(cbMaNV, "select MaNVTV from TblHoSoThuViec", 0);
            LoadDataGridView();

        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.loadtextbox(txtTenPhong, "select * from TblPhongBan b,TblHoSoThuViec a where a.MaPhong=b.MaPhong and MaNVTV='" + cbMaNV.Text + "'", 2);
            cn.loadtextbox(txtTenBP, "select * from TblBoPhan,TblPhongBan where TblPhongBan.MaBoPhan=TblBoPhan.MaBoPhan and TenPhong=N'" + txtTenPhong.Text + "'", 1);
            cn.loadtextbox(textBoxLuong, "select * from TblBangCongThuViec where MaNVTV='" + cbMaNV.Text + "'", 3);
            cn.loadtextbox(txtThang, "select * from TblBangCongThuViec where MaNVTV='" + cbMaNV.Text + "'", 4);
            cn.loadtextbox(txtNam, "select * from TblBangCongThuViec where MaNVTV='" + cbMaNV.Text + "'", 5);
            cn.loadtextbox(txtNgayCong, "select * from TblBangCongThuViec where MaNVTV='" + cbMaNV.Text + "'", 6);
            cn.loadtextbox(txtNgayNghi, "select * from TblBangCongThuViec where MaNVTV='" + cbMaNV.Text + "'", 7);
            cn.loadtextbox(txtGioLamThem, "select * from TblBangCongThuViec where MaNVTV='" + cbMaNV.Text + "'", 8);
            cn.loadtextbox(textBoxLuong, "select * from TblBangCongThuViec where MaNVTV='" + cbMaNV.Text + "'", 9);
            cn.loadtextbox(txtGhiChu, "select * from TblBangCongThuViec where MaNVTV='" + cbMaNV.Text + "'", 10);
        }
    }
}
