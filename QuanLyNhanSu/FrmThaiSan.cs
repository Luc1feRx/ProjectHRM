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
    public partial class FrmThaiSan : Form
    {
        Connect cn = new Connect();
        public FrmThaiSan()
        {
            InitializeComponent();
        }

        private void FrmThaiSan_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            dt2.CustomFormat = " MM / dd / yyyy ";
            dt3.CustomFormat = " MM / dd / yyyy ";
            dt4.CustomFormat = " MM / dd / yyyy ";
            dt5.CustomFormat = " MM / dd / yyyy ";
            cn.loadcombobox(comboBox2, "select * from TblTTNVCoBan", 2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        public void LoadDataGridView()
        {
            string connections = ConfigurationManager.ConnectionStrings["QuanLyNhanSu.Properties.Settings.QLNSConnectionString1"].ConnectionString;//goi den connection trong app.config de ket noi voi database
            SqlConnection con = new SqlConnection(connections);
            con.Open();
            string query = "select * from TblThaiSan";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView2.DataSource = dt;
            dataGridView2.Columns[0].HeaderText = "Mã bộ phận";
            dataGridView2.Columns[1].HeaderText = "Mã phòng";
            dataGridView2.Columns[2].HeaderText = "Mã NV";
            dataGridView2.Columns[3].HeaderText = "Họ tên";
            dataGridView2.Columns[4].HeaderText = "Ngày về sớm";
            dataGridView2.Columns[5].HeaderText = "Ngày nghỉ sinh";
            dataGridView2.Columns[6].HeaderText = "Ngày làm trở lại";
            dataGridView2.Columns[7].HeaderText = "Trở cấp";
            dataGridView2.Columns[8].HeaderText = "Ghi chú";
        }


        private void button9_Click(object sender, EventArgs e)
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

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt5.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txt6.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            comboBox2.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            txt7.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            dt2.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
            dt3.Text = dataGridView2.Rows[i].Cells[5].Value.ToString();
            dt4.Text = dataGridView2.Rows[i].Cells[6].Value.ToString();
            dt5.Text = dataGridView2.Rows[i].Cells[7].Value.ToString();
            txt8.Text = dataGridView2.Rows[i].Cells[8].Value.ToString();
            txt9.Text = dataGridView2.Rows[i].Cells[9].Value.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.loadtextbox(txt5, "select * from TblTTNVCoBan where MaNV=N'" + comboBox2.Text + "'", 0);
            cn.loadtextbox(txt6, "select * from TblTTNVCoBan where MaNV=N'" + comboBox2.Text + "'", 1);
            cn.loadtextbox(txt7, "select * from TblTTNVCoBan where MaNV=N'" + comboBox2.Text + "'", 3);
            cn.loadtextbox(txt8, "select * from TblThaiSan where MaNV=N'" + comboBox2.Text + "'", 8);
            cn.loadtextbox(txt9, "select * from TblThaiSan where MaNV=N'" + comboBox2.Text + "'", 9);
            cn.loaddatetime(dt2, "select * from TblThaiSan where MaNV=N'" + comboBox2.Text + "'", 4);
            cn.loaddatetime(dt3, "select * from TblThaiSan where MaNV=N'" + comboBox2.Text + "'", 5);
            cn.loaddatetime(dt4, "select * from TblThaiSan where MaNV=N'" + comboBox2.Text + "'", 6);
            cn.loaddatetime(dt5, "select * from TblThaiSan where MaNV=N'" + comboBox2.Text + "'", 7);
        }

        private void txt8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                string insert = "insert into TblThaiSan values(N'" + txt5.Text + "',N'" + txt6.Text + "',N'" + comboBox2.Text + "',N'" + txt7.Text + "',N'" + dt2.Text + "',N'" + dt3.Text + "',N'" + dt4.Text + "',N'" + dt5.Text + "',N'" + txt8.Text + "',N'" + txt9.Text + "')";
                if (!cn.Exitsted(comboBox2.Text, "select MaNV from TblThaiSan"))
                {
                    if (comboBox2.Text != "")
                    {
                        cn.makeConnected(insert);
                        dataGridView2.Refresh();
                        LoadDataGridView();
                        MessageBox.Show("Thêm thành công");
                    }
                    else MessageBox.Show("Bạn chưa nhập Mã  nhân vien");
                }
                else
                    MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblThaiSan set NgayVeSom=N'" + dt3.Text + "',NgayNghiSinh=N'" + dt4.Text + "',NgayLamTroLai='" + dt5.Text + "',TroCapCTy=N'" + txt8.Text + "',GhiChu=N'" + txt9.Text + "' where MaNV=N'" + comboBox2.Text + "'";
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
            string delete = "delete from TblThaiSan where MaNV=N'" + comboBox2.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
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
    }
}
