using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Configuration;
using System.Data.SqlClient;

namespace QuanLyNhanSu
{
    public partial class FrmTTCaNhan : Form
    {
        Connect cn = new Connect();
        public FrmTTCaNhan()
        {
            InitializeComponent();
        }

        private void tblTTCaNhanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }
        private void dataGridViewTTCN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                comboBoxMa.Text = dataGridViewTTCN.Rows[i].Cells[0].Value.ToString();
                hoTenTextBox.Text = dataGridViewTTCN.Rows[i].Cells[1].Value.ToString();
                noiSinhTextBox.Text = dataGridViewTTCN.Rows[i].Cells[2].Value.ToString();
                nguyenQuanTextBox.Text = dataGridViewTTCN.Rows[i].Cells[3].Value.ToString();
                dCThuongChuTextBox.Text = dataGridViewTTCN.Rows[i].Cells[4].Value.ToString();
                dCTamChuTextBox.Text = dataGridViewTTCN.Rows[i].Cells[5].Value.ToString();
                sDTTextBox.Text = dataGridViewTTCN.Rows[i].Cells[6].Value.ToString();
                danTocTextBox.Text = dataGridViewTTCN.Rows[i].Cells[7].Value.ToString();
                tonGiaoTextBox.Text = dataGridViewTTCN.Rows[i].Cells[8].Value.ToString();
                quocTichTextBox.Text = dataGridViewTTCN.Rows[i].Cells[9].Value.ToString();
                hocVanTextBox.Text = dataGridViewTTCN.Rows[i].Cells[10].Value.ToString();
                ghiChuTextBox.Text = dataGridViewTTCN.Rows[i].Cells[11].Value.ToString();

            }
            catch (Exception)
            { }
        }
        public void LoadDataGridView()
        {
            string connections = ConfigurationManager.ConnectionStrings["QuanLyNhanSu.Properties.Settings.QLNSConnectionString1"].ConnectionString;//goi den connection trong app.config de ket noi voi database
            SqlConnection con = new SqlConnection(connections);
            con.Open();
            string query = "SELECT * FROM TblTTCaNhan";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridViewTTCN.DataSource = dt;
            dataGridViewTTCN.Columns[0].HeaderText = "Mã NV";
            dataGridViewTTCN.Columns[1].HeaderText = "Họ Tên";
            dataGridViewTTCN.Columns[2].HeaderText = "Nơi Sinh";
            dataGridViewTTCN.Columns[3].HeaderText = "Nguyên Quán";
            dataGridViewTTCN.Columns[4].HeaderText = "ĐC Thường Trú";
            dataGridViewTTCN.Columns[5].HeaderText = "ĐC Tạm Trú";
            dataGridViewTTCN.Columns[6].HeaderText = "SĐT";
            dataGridViewTTCN.Columns[7].HeaderText = "Dân Tộc";
            dataGridViewTTCN.Columns[8].HeaderText = "Tôn Giáo";
            dataGridViewTTCN.Columns[9].HeaderText = "Quốc Tịch";
            dataGridViewTTCN.Columns[10].HeaderText = "Học Vấn";
            dataGridViewTTCN.Columns[11].HeaderText = "Ghi chú";    

        }
        private void FrmTTCaNhan_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            cn.loadcombobox(comboBoxMa, "select * from TblTTCaNhan", 0);
        }

        private void danTocLabel_Click(object sender, EventArgs e)
        {

        }

        private void danTocTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sDTLabel_Click(object sender, EventArgs e)
        {

        }

        private void sDTTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void noiSinhLabel_Click(object sender, EventArgs e)
        {

        }

        private void dCThuongChuLabel_Click(object sender, EventArgs e)
        {

        }

        private void dCThuongChuTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nguyenQuanLabel_Click(object sender, EventArgs e)
        {

        }

        private void ghiChuTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ghiChuLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBoxTTCN.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btthem_Click(object sender, EventArgs e)
        {
            
              
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
               // FillCombobox("SELECT MaNV FROM TblTTNVCoBan", comboBoxMa, "HoTen", "HoTen");
            cn.loadtextboxchiso(hoTenTextBox, "select * from TblTTCaNhan where MaNV='" + comboBoxMa.Text + "'", 1);
            cn.loadtextboxchiso(noiSinhTextBox, "select * from TblTTCaNhan where MaNV='" + comboBoxMa.Text + "'", 2);
            cn.loadtextboxchiso(nguyenQuanTextBox, "select * from TblTTCaNhan where MaNV='" + comboBoxMa.Text + "'", 3);
            cn.loadtextboxchiso(dCThuongChuTextBox, "select * from TblTTCaNhan where MaNV='" + comboBoxMa.Text + "'", 4);
            cn.loadtextboxchiso(dCTamChuTextBox, "select * from TblTTCaNhan where MaNV='" + comboBoxMa.Text + "'", 5);
            cn.loadtextboxchiso(sDTTextBox, "select * from TblTTCaNhan where MaNV='" + comboBoxMa.Text + "'", 6);
            cn.loadtextboxchiso(danTocTextBox, "select * from TblTTCaNhan where MaNV='" + comboBoxMa.Text + "'", 7);
            cn.loadtextboxchiso(tonGiaoTextBox, "select * from TblTTCaNhan where MaNV='" + comboBoxMa.Text + "'", 8);
            cn.loadtextboxchiso(quocTichTextBox, "select * from TblTTCaNhan where MaNV='" + comboBoxMa.Text + "'", 9);
            cn.loadtextboxchiso(hocVanTextBox, "select * from TblTTCaNhan where MaNV='" + comboBoxMa.Text + "'", 10);
            cn.loadtextboxchiso(ghiChuTextBox, "select * from TblTTCaNhan where MaNV='" + comboBoxMa.Text + "'", 11);
        }

        private void FillCombobox(string v1, object comboBoxMaPhong, string v2, string v3)
        {
            //throw new NotImplementedException();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblTTCaNhan set HoTen=N'" + hoTenTextBox.Text + "',NoiSinh=N'" + noiSinhTextBox.Text + "',NguyenQuan=N'" + nguyenQuanTextBox.Text + "',DCThuongChu=N'" + dCThuongChuTextBox.Text + "',DCTamChu=N'" + dCTamChuTextBox.Text + "',SDT=N'" + sDTTextBox.Text + "',DanToc=N'" + danTocTextBox.Text + "',TonGiao=N'" + tonGiaoTextBox.Text + "',QuocTich=N'" + quocTichTextBox.Text + "',HocVan=N'" + hocVanTextBox.Text + "',GhiChu=N'" + ghiChuTextBox.Text + "' where MaNV=N'" + comboBoxMa.Text + "'";
                cn.makeConnected(update);
                LoadDataGridView();
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
            
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "delete from TblTTCaNhan where MaNV=N'" + comboBoxMa.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cn.makeConnected(delete);
                    LoadDataGridView();
                }
            }
            catch
            {
                MessageBox.Show("không xóa được");
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
        }

        private void sDTTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void groupBoxTTCN_Enter(object sender, EventArgs e)
        {

        }

        private void btlammoi_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btlammoi_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
