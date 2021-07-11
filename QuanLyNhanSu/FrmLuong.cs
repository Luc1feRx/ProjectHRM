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
    public partial class FrmLuong : Form
    {
        Connect cn = new Connect();
        public FrmLuong()
        {
            InitializeComponent();
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

        public void LoadDataGridView()
        {
            string connections = ConfigurationManager.ConnectionStrings["QuanLyNhanSu.Properties.Settings.QLNSConnectionString"].ConnectionString;//goi den connection trong app.config de ket noi voi database
            SqlConnection con = new SqlConnection(connections);
            con.Open();
            string query = "select * from TblBangLuongCTy";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridViewLuong.DataSource = dt;
            dataGridViewLuong.Columns[0].HeaderText = "Mã Lương";
            dataGridViewLuong.Columns[1].HeaderText = "LCB";
            dataGridViewLuong.Columns[2].HeaderText = "PCCV";
            dataGridViewLuong.Columns[3].HeaderText = "Ngày Nhập";
            dataGridViewLuong.Columns[4].HeaderText = "LCB Mới";
            dataGridViewLuong.Columns[5].HeaderText = "Ngày sửa";
            dataGridViewLuong.Columns[6].HeaderText = "Lý do";
            dataGridViewLuong.Columns[7].HeaderText = "PCCV Mới";
            dataGridViewLuong.Columns[8].HeaderText = "Ngày sửa PC";
            dataGridViewLuong.Columns[9].HeaderText = "Ghi Chú";
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblBangLuongCTy set LCB=N'" + txtLCB.Text + "',PCChucVu=N'" + txtPCCV.Text + "',NgayNhap='" + dateTimePickerNgayNhap.Text + "',LCBMoi=N'" + txtM.Text + "',NgaySua=N'" + dateTimePickerNgaySua.Text + "',LyDo=N'" + txtLyDo.Text + "',PCCVuMoi='" + txtPCCVMoi.Text + "',NgaySuaPC=N'" + dateTimePickerNgayPCCVMoi.Text + "',GhiChu=N'" + txtGhiChu.Text + "' where MaLuong=N'" + txtMaLuong.Text + "'";
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
            string delete = "delete from TblBangLuongCTy where MaLuong=N'" + txtMaLuong.Text + "'";
            string delete1 = "delete from TblSoBH where MaLuong=N'" + txtMaLuong.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cn.makeConnected(delete1);
                cn.makeConnected(delete);
                LoadDataGridView();
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
        }

        private void FrmLuong_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void buttonThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                string insert = "insert into TblBangLuongCTy values(N'" + txtMaLuong.Text + "',N'" + txtLCB.Text + "',N'" + txtPCCV.Text + "',N'" + dateTimePickerNgayNhap.Text + "',N'" + txtM.Text + "',N'" + dateTimePickerNgaySua.Text + "',N'" + txtLyDo.Text + "',N'" + txtPCCVMoi.Text + "',N'" + dateTimePickerNgayPCCVMoi.Text + "',N'" + txtGhiChu.Text + "')";
                if (!cn.Exitsted(txtMaLuong.Text, "select MaLuong from TblBangLuongCTy"))
                {
                    if (txtMaLuong.Text != "")
                    {
                        cn.makeConnected(insert);
                        dataGridViewLuong.Refresh();
                        LoadDataGridView();
                        MessageBox.Show("Thêm thành công");
                    }
                    else MessageBox.Show("Bạn chưa nhập Mã Lương");
                }
                else
                    MessageBox.Show("Mã Lương này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void dataGridViewLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                txtMaLuong.Text = dataGridViewLuong.Rows[i].Cells[0].Value.ToString();
                txtLCB.Text = dataGridViewLuong.Rows[i].Cells[1].Value.ToString();
                txtPCCV.Text = dataGridViewLuong.Rows[i].Cells[2].Value.ToString();
                dateTimePickerNgayNhap.Text = dataGridViewLuong.Rows[i].Cells[3].Value.ToString();
                txtM.Text = dataGridViewLuong.Rows[i].Cells[4].Value.ToString();
                dateTimePickerNgaySua.Text = dataGridViewLuong.Rows[i].Cells[5].Value.ToString();
                txtLyDo.Text = dataGridViewLuong.Rows[i].Cells[6].Value.ToString();
                txtPCCVMoi.Text = dataGridViewLuong.Rows[i].Cells[7].Value.ToString();
                dateTimePickerNgayPCCVMoi.Text = dataGridViewLuong.Rows[i].Cells[8].Value.ToString();
                txtGhiChu.Text = dataGridViewLuong.Rows[i].Cells[9].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
