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
    public partial class FrmTimKiem : Form
    {
        public FrmTimKiem()
        {
            InitializeComponent();
        }
        int i = 0;

        private void txtKQTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMNV_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void LoadDataGridViewCoBan(DataGridView dg, string query)
        {
            string connections = ConfigurationManager.ConnectionStrings["QuanLyNhanSu.Properties.Settings.QLNSConnectionString"].ConnectionString;//goi den connection trong app.config de ket noi voi database
            SqlConnection con = new SqlConnection(connections);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dg.DataSource = dt;
            dg.Columns[0].HeaderText = "Mã bộ phận";
            dg.Columns[1].HeaderText = "Mã phòng";
            dg.Columns[2].HeaderText = "Mã nhân viên";
            dg.Columns[3].HeaderText = "Họ tên";
            dg.Columns[4].HeaderText = "Mã lương";
            dg.Columns[5].HeaderText = "Ngày sinh";
            dg.Columns[6].HeaderText = "Giới tính";
            dg.Columns[7].HeaderText = "TTHôn nhân";
            dg.Columns[8].HeaderText = "CMTND";
            dg.Columns[9].HeaderText = "Nơi cấp";
            dg.Columns[10].HeaderText = "Chức vụ";
            dg.Columns[11].HeaderText = "Loại HĐ";
            dg.Columns[12].HeaderText = "Thời gian";
            dg.Columns[13].HeaderText = "Ngày ký";
            dg.Columns[14].HeaderText = "Ngày hết hạn";
            dg.Columns[15].HeaderText = "Ghi chú";
            dg.Columns[16].HeaderText = "Avatar";
        }

        public void LoadDataGridViewCaNhan(DataGridView dg, string query)
        {
            string connections = ConfigurationManager.ConnectionStrings["QuanLyNhanSu.Properties.Settings.QLNSConnectionString"].ConnectionString;//goi den connection trong app.config de ket noi voi database
            SqlConnection con = new SqlConnection(connections);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dg.DataSource = dt;
            dg.Columns[0].HeaderText = "Mã nhân viên";
            dg.Columns[1].HeaderText = "Họ tên";
            dg.Columns[2].HeaderText = "Nơi sinh";
            dg.Columns[3].HeaderText = "Nguyên quán";
            dg.Columns[4].HeaderText = "DC thường trú";
            dg.Columns[5].HeaderText = "DC tạm trú";
            dg.Columns[6].HeaderText = "SDT";
            dg.Columns[7].HeaderText = "Dân tộc";
            dg.Columns[8].HeaderText = "Tôn giáo";
            dg.Columns[9].HeaderText = "Quốc tịch";
            dg.Columns[10].HeaderText = "Học vấn";
            dg.Columns[11].HeaderText = "Ghi chú";
        }

        public void LoadDataGridViewLuong(DataGridView dg, string query)
        {
            string connections = ConfigurationManager.ConnectionStrings["QuanLyNhanSu.Properties.Settings.QLNSConnectionString"].ConnectionString;//goi den connection trong app.config de ket noi voi database
            SqlConnection con = new SqlConnection(connections);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dg.DataSource = dt;
            dg.Columns[0].HeaderText = "Mã Lương";
            dg.Columns[1].HeaderText = "LCB";
            dg.Columns[2].HeaderText = "PCCV";
            dg.Columns[3].HeaderText = "Ngày Nhập";
            dg.Columns[4].HeaderText = "LCB Mới";
            dg.Columns[5].HeaderText = "Ngày sửa";
            dg.Columns[6].HeaderText = "Lý do";
            dg.Columns[7].HeaderText = "PCCV Mới";
            dg.Columns[8].HeaderText = "Ngày sửa PC";
            dg.Columns[9].HeaderText = "Ghi Chú";
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBoxTK.Text == "") || (textBoxTK.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    MessageBox.Show("bạn chưa nhập tù khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    if (i == 1)
                    {
                        LoadDataGridViewCoBan(dataGridViewTimKiem, "select * from TblTTNVCoBan where MaNV=N'" + textBoxTK.Text + "'");
                        int count = dataGridViewTimKiem.Rows.Count - 1;
                        txtKQTimKiem.Text = count.ToString();
                    }
                    if (i == 2)
                    {
                        LoadDataGridViewCoBan(dataGridViewTimKiem, "select * from TblTTNVCoBan where HoTen =N'" + textBoxTK.Text + "'");
                        int count = dataGridViewTimKiem.Rows.Count - 1;
                        txtKQTimKiem.Text = count.ToString();
                    }
                    if (i == 3)
                    {
                        LoadDataGridViewCoBan(dataGridViewTimKiem, "select * from TblTTNVCoBan where CMTND =N'" + textBoxTK.Text + "'");
                        int count = dataGridViewTimKiem.Rows.Count - 1;
                        txtKQTimKiem.Text = count.ToString();
                    }
                    if(i == 4)
                    {
                        LoadDataGridViewCaNhan(dataGridViewTimKiem, "select * from TblTTCaNhan where NoiSinh =N'" + textBoxTK.Text + "'");
                        int count = dataGridViewTimKiem.Rows.Count - 1;
                        txtKQTimKiem.Text = count.ToString();
                    }
                    if(i == 5)
                    {
                        LoadDataGridViewCaNhan(dataGridViewTimKiem, "select * from TblTTCaNhan where DanToc=N'" + textBoxTK.Text + "'");
                        int count = dataGridViewTimKiem.Rows.Count - 1;
                        txtKQTimKiem.Text = count.ToString();
                    }
                    //if(i == 6)
                    //{
                    //    LoadDataGridViewCaNhan(dataGridViewTimKiem, "select * from TblTTCaNhan where TonGiao like N'%" + textBoxTK.Text + "%'");
                    //    int count = dataGridViewTimKiem.Rows.Count - 1;
                    //    txtKQTimKiem.Text = count.ToString();
                    //}
                    //if(i == 7)
                    //{
                    //    LoadDataGridViewCaNhan(dataGridViewTimKiem, "select * from TblTTCaNhan where QuocTich like N'%" + textBoxTK.Text + "%'");
                    //    int count = dataGridViewTimKiem.Rows.Count - 1;
                    //    txtKQTimKiem.Text = count.ToString();
                    //}
                    //if(i == 8)
                    //{
                    //    LoadDataGridViewCoBan(dataGridViewTimKiem, "select * from TblTTNVCoBan where GioiTinh like N'%" + textBoxTK.Text + "%'");
                    //    int count = dataGridViewTimKiem.Rows.Count - 1;
                    //    txtKQTimKiem.Text = count.ToString();
                    //}
                    if(i == 9)
                    {
                        LoadDataGridViewCoBan(dataGridViewTimKiem, "select * from TblTTNVCoBan where ChucVu=N'" + textBoxTK.Text + "'");
                        int count = dataGridViewTimKiem.Rows.Count - 1;
                        txtKQTimKiem.Text = count.ToString();
                    }
                    if(textBoxTK.Text == "Nhân viên nào có lương cao nhất?" || textBoxTK.Text == "nhân viên nào có lương cao nhất?" || textBoxTK.Text == "lương cao nhất?")
                    {
                        LoadDataGridViewLuong(dataGridViewTimKiem, "SELECT * FROM TblCongKhoiDieuHanh  where Luong = (select max(Luong) from TblCongKhoiDieuHanh)");
                        int count = dataGridViewTimKiem.Rows.Count - 1;
                        txtKQTimKiem.Text = count.ToString();
                    }
                    if(textBoxTK.Text == "Nhân viên nào có lương thấp nhất?" || textBoxTK.Text == "nhân viên nào có lương thấp nhất?" || textBoxTK.Text == "lương thấp nhất?")
                    {
                        LoadDataGridViewLuong(dataGridViewTimKiem, "SELECT * FROM TblCongKhoiDieuHanh  where Luong = (select min(Luong) from TblCongKhoiDieuHanh)");
                        int count = dataGridViewTimKiem.Rows.Count - 1;
                        txtKQTimKiem.Text = count.ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Tìm kiếm sai");
            }
        }

        private void radioButtonHoTen_CheckedChanged(object sender, EventArgs e)
        {
            i = 2;
        }

        private void radioButtonCMTND_CheckedChanged(object sender, EventArgs e)
        {
            i = 3;
        }

        private void radNoiSinh_CheckedChanged(object sender, EventArgs e)
        {
            i = 4;
        }

        private void radDanToc_CheckedChanged(object sender, EventArgs e)
        {
            i = 5;
        }

        //private void radTonGiao_CheckedChanged(object sender, EventArgs e)
        //{
        //    i = 6;
        //}

        //private void radGioiTinh_CheckedChanged(object sender, EventArgs e)
        //{
        //    i = 8;
        //}

        //private void radQuocTich_CheckedChanged(object sender, EventArgs e)
        //{
        //    i = 7;
        //}

        private void radSDT_CheckedChanged(object sender, EventArgs e)
        {
            i = 9;
        }

        private void radioButtonNVLTN_CheckedChanged(object sender, EventArgs e)
        {
            //i = 11;
        }

        private void radNVLCN_CheckedChanged(object sender, EventArgs e)
        {
            //i = 10;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBoxTK.Text = "Nhân viên nào có lương cao nhất?";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBoxTK.Text = "Nhân viên nào có lương thấp nhất?";
        }

        private void textBoxTK_TextChanged(object sender, EventArgs e)
        {
            if (i == 1)
            {
                LoadDataGridViewCoBan(dataGridViewTimKiem, "select * from TblTTNVCoBan where MaNV like N'" + textBoxTK.Text + "%'");
                int count = dataGridViewTimKiem.Rows.Count - 1;
                txtKQTimKiem.Text = count.ToString();
            }
            if (i == 2)
            {
                LoadDataGridViewCoBan(dataGridViewTimKiem, "select * from TblTTNVCoBan where HoTen like N'" + textBoxTK.Text + "%'");
                int count = dataGridViewTimKiem.Rows.Count - 1;
                txtKQTimKiem.Text = count.ToString();
            }
            if (i == 3)
            {
                LoadDataGridViewCoBan(dataGridViewTimKiem, "select * from TblTTNVCoBan where CMTND like N'" + textBoxTK.Text + "%'");
                int count = dataGridViewTimKiem.Rows.Count - 1;
                txtKQTimKiem.Text = count.ToString();
            }
            if (i == 4)
            {
                LoadDataGridViewCaNhan(dataGridViewTimKiem, "select * from TblTTCaNhan where NoiSinh like N'" + textBoxTK.Text + "%'");
                int count = dataGridViewTimKiem.Rows.Count - 1;
                txtKQTimKiem.Text = count.ToString();
            }
            if (i == 5)
            {
                LoadDataGridViewCaNhan(dataGridViewTimKiem, "select * from TblTTCaNhan where DanToc like N'" + textBoxTK.Text + "%'");
                int count = dataGridViewTimKiem.Rows.Count - 1;
                txtKQTimKiem.Text = count.ToString();
            }
            //if (i == 6)
            //{
            //    LoadDataGridView(dataGridViewTimKiem, "select * from TblTTCaNhan where TonGiao=N'" + textBoxTK.Text + "'");
            //    int count = dataGridViewTimKiem.Rows.Count - 1;
            //    txtKQTimKiem.Text = count.ToString();
            //}
            //if (i == 7)
            //{
            //    LoadDataGridView(dataGridViewTimKiem, "select * from TblTTCaNhan where QuocTich=N'" + textBoxTK.Text + "'");
            //    int count = dataGridViewTimKiem.Rows.Count - 1;
            //    txtKQTimKiem.Text = count.ToString();
            //}
            //if (i == 8)
            //{
            //    LoadDataGridView(dataGridViewTimKiem, "select * from TblTTNVCoBan where GioiTinh=N'" + textBoxTK.Text + "'");
            //    int count = dataGridViewTimKiem.Rows.Count - 1;
            //    txtKQTimKiem.Text = count.ToString();
            //}
            if (i == 9)
            {
                LoadDataGridViewCoBan(dataGridViewTimKiem, "select * from TblTTNVCoBan where ChucVu like N'" + textBoxTK.Text + "%'");
                int count = dataGridViewTimKiem.Rows.Count - 1;
                txtKQTimKiem.Text = count.ToString();
            }
            if (textBoxTK.Text == "Nhân viên nào có lương cao nhất?" || textBoxTK.Text == "nhân viên nào có lương cao nhất?" || textBoxTK.Text == "lương cao nhất?")
            {
                LoadDataGridViewLuong(dataGridViewTimKiem, "SELECT * FROM TblCongKhoiDieuHanh  where LCB = (select max(LCB) from TblCongKhoiDieuHanh)");
                int count = dataGridViewTimKiem.Rows.Count - 1;
                txtKQTimKiem.Text = count.ToString();
            }
            if (textBoxTK.Text == "Nhân viên nào có lương thấp nhất?" || textBoxTK.Text == "nhân viên nào có lương thấp nhất?" || textBoxTK.Text == "lương thấp nhất?")
            {
                LoadDataGridViewLuong(dataGridViewTimKiem, "SELECT * FROM TblCongKhoiDieuHanh  where LCB = (select min(LCB) from TblCongKhoiDieuHanh)");
                int count = dataGridViewTimKiem.Rows.Count - 1;
                txtKQTimKiem.Text = count.ToString();
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
