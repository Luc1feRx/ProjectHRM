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
    public partial class FrmBangLuongNVCT : Form
    {
        Connect cn = new Connect();
        public FrmBangLuongNVCT()
        {
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        public void LoadDataGridView()
        {
            string connections = ConfigurationManager.ConnectionStrings["QuanLyNhanSu.Properties.Settings.QLNSConnectionString"].ConnectionString;//goi den connection trong app.config de ket noi voi database
            SqlConnection con = new SqlConnection(connections);
            con.Open();
            string query = "select * from TblCongKhoiDieuHanh where TenPhong = N'" + comboBoxTenPhong.SelectedValue + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridViewLuongNVCT.DataSource = dt;
            dataGridViewLuongNVCT.Columns[0].HeaderText = "Mã NV";
            dataGridViewLuongNVCT.Columns[1].HeaderText = "Mã Lương";
            dataGridViewLuongNVCT.Columns[2].HeaderText = "Họ tên";
            dataGridViewLuongNVCT.Columns[3].HeaderText = "Tên Phòng";
            dataGridViewLuongNVCT.Columns[4].HeaderText = "Lương CB";
            dataGridViewLuongNVCT.Columns[5].HeaderText = "Phụ cấp";
            dataGridViewLuongNVCT.Columns[6].HeaderText = "Phụ cấp khác";
            dataGridViewLuongNVCT.Columns[7].HeaderText = "Thưởng";
            dataGridViewLuongNVCT.Columns[8].HeaderText = "Kỷ luật";
            dataGridViewLuongNVCT.Columns[9].HeaderText = "Tháng";
            dataGridViewLuongNVCT.Columns[10].HeaderText = "Số ngày nghỉ";
            dataGridViewLuongNVCT.Columns[11].HeaderText = "Số giờ làm thêm";
            dataGridViewLuongNVCT.Columns[12].HeaderText = "Năm";
            dataGridViewLuongNVCT.Columns[13].HeaderText = "Số ngày công";
            dataGridViewLuongNVCT.Columns[14].HeaderText = "Lương";
            dataGridViewLuongNVCT.Columns[15].HeaderText = "Ghi chú";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblCongKhoiDieuHanh set MaNV='" + cbMaNV.Text + "', MaLuong=N'" + txtMaLuong.Text + "',TenPhong=N'" + comboBoxTenPhong.Text + "', HoTen=N'" + txtHoTen.Text + "',LCB=N'" + txtLCB.Text + "',PCChucVu=N'" + txtPC.Text + "',PCapKhac=N'" + txtPCK.Text + "',Thuong=N'" + textBoxThuong.Text + "',KyLuat='" + textBoxThuong.Text + "',Thang=N'" + txtThang.Text + "',Nam='" + txtNam.Text + "',SoNgayCongThang=N'" + txtNgayCong.Text + "',SoNgayNghi=N'" + txtSoNgayNghi.Text + "',SoGioLamThem=N'" + txtLamThem.Text + "',Luong=N'" + txtLuong.Text + "',GhiChu='" + txtGhiChu.Text + "' where MaNV=N'" + cbMaNV.Text + "'";
                cn.makeConnected(update);
                LoadDataGridView();
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void txt18_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmBangLuongNVCT_Load(object sender, EventArgs e)
        {
            FillCombobox("SELECT TenPhong FROM TblPhongBan", comboBoxTenPhong, "TenPhong", "TenPhong");
            comboBoxTenPhong.SelectedIndex = -1;
            LoadDataGridView();

        }

        private void comboBoxTenPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCombobox("select MaNV from TblCongKhoiDieuHanh where TenPhong=(select top(1) TenPhong from TblPhongBan a, TblTTNVCoBan b where a.MaPhong=b.MaPhong and a.TenPhong=N'" + comboBoxTenPhong.SelectedValue + "' group by TenPhong)", cbMaNV, "MaNV", "MaNV");
            cbMaNV.DisplayMember = "MaNV";
            cbMaNV.ValueMember = "MaNV";
            LoadDataGridView();
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

        private void buttonMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox4.Controls)
            {
                if ((ctr is System.Windows.Forms.TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.loadtextbox(txtMaLuong, "select * from TblTTNVCoBan where MaNV='" + cbMaNV.Text + "'", 4);
            cn.loadtextbox(txtLCB, "select * from TblBangLuongCTy l where l.MaLuong='" + txtMaLuong.Text + "'", 1);
            cn.loadtextbox(txtPC, "select * from TblBangLuongCTy l where l.MaLuong='" + txtMaLuong.Text + "'", 2);
            cn.loadtextbox(txtHoTen, "select * from TblCongKhoiDieuHanh where MaNV='" + cbMaNV.Text + "'", 2);
            cn.loadtextbox(txtPCK, "select * from TblCongKhoiDieuHanh where MaNV='" + cbMaNV.Text + "'", 6);
            cn.loadtextbox(textBoxThuong, "select * from TblCongKhoiDieuHanh where MaNV='" + cbMaNV.Text + "'", 7);
            cn.loadtextbox(textBoxKyLuat, "select * from TblCongKhoiDieuHanh where MaNV='" + cbMaNV.Text + "'", 8);
            cn.loadtextbox(txtThang, "select * from TblCongKhoiDieuHanh where MaNV='" + cbMaNV.Text + "'", 9);
            cn.loadtextbox(txtNam, "select * from TblCongKhoiDieuHanh where MaNV='" + cbMaNV.Text + "'", 10);
            cn.loadtextbox(txtNgayCong, "select * from TblCongKhoiDieuHanh where MaNV='" + cbMaNV.Text + "'", 11);
            cn.loadtextbox(txtSoNgayNghi, "select * from TblCongKhoiDieuHanh where MaNV='" + cbMaNV.Text + "'", 12);
            cn.loadtextbox(txtLamThem, "select * from TblCongKhoiDieuHanh where MaNV='" + cbMaNV.Text + "'", 13);
            cn.loadtextbox(txtLuong, "select * from TblCongKhoiDieuHanh where MaNV='" + cbMaNV.Text + "'", 14);
            cn.loadtextbox(txtGhiChu, "select * from TblCongKhoiDieuHanh where MaNV='" + cbMaNV.Text + "'", 15);
        }

        private void dataGridViewLuongNVCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cbMaNV.Text = dataGridViewLuongNVCT.Rows[i].Cells[0].Value.ToString();
            txtLCB.Text = dataGridViewLuongNVCT.Rows[i].Cells[4].Value.ToString();
            txtHoTen.Text = dataGridViewLuongNVCT.Rows[i].Cells[2].Value.ToString();
            txtMaLuong.Text = dataGridViewLuongNVCT.Rows[i].Cells[3].Value.ToString();
            comboBoxTenPhong.Text = dataGridViewLuongNVCT.Rows[i].Cells[1].Value.ToString();
            txtPC.Text = dataGridViewLuongNVCT.Rows[i].Cells[5].Value.ToString();
            txtPCK.Text = dataGridViewLuongNVCT.Rows[i].Cells[6].Value.ToString();
            textBoxThuong.Text = dataGridViewLuongNVCT.Rows[i].Cells[7].Value.ToString();
            textBoxKyLuat.Text = dataGridViewLuongNVCT.Rows[i].Cells[8].Value.ToString();
            txtThang.Text = dataGridViewLuongNVCT.Rows[i].Cells[9].Value.ToString();
            txtNam.Text = dataGridViewLuongNVCT.Rows[i].Cells[10].Value.ToString();
            txtNgayCong.Text = dataGridViewLuongNVCT.Rows[i].Cells[11].Value.ToString();
            txtSoNgayNghi.Text = dataGridViewLuongNVCT.Rows[i].Cells[12].Value.ToString();
            txtLamThem.Text = dataGridViewLuongNVCT.Rows[i].Cells[13].Value.ToString();
            txtLuong.Text = dataGridViewLuongNVCT.Rows[i].Cells[14].Value.ToString();
            txtGhiChu.Text = dataGridViewLuongNVCT.Rows[i].Cells[15].Value.ToString();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "delete from TblCongKhoiDieuHanh where MaNV=N'" + cbMaNV.Text + "'";
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
            int lcb = Convert.ToInt32(txtLCB.Text);
            int pc = Convert.ToInt32(txtPC.Text);
            int pck = Convert.ToInt32(txtPCK.Text);
            int nc = Convert.ToInt32(txtNgayCong.Text);
            int lt = Convert.ToInt32(txtLamThem.Text);
            int th = Convert.ToInt32(textBoxThuong.Text);
            int kl = Convert.ToInt32(textBoxKyLuat.Text);

            float luong = ((lcb / 26) * nc + (lt * 40000) + pc + pck + th - kl);
            txtLuong.Text = luong.ToString(); //convert từ float sang string để hiện thị lên màn hình
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
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


        private void button3_Click(object sender, EventArgs e)
        {
            exprotExcel(dataGridViewLuongNVCT, @"D:\", "BangLuongNhanVien");
            DialogResult dialog = MessageBox.Show("Xuất thành công. Bạn có muốn mở file Exel?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                System.Diagnostics.Process.Start(@"D:\");
            else if (dialog == DialogResult.No)
            {
                //
            }
        }
    }
}
