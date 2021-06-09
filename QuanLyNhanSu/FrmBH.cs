using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FrmBH : Form
    {
        public FrmBH()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button3.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
           // Load_data();
            textBox1.Text = "";
            textBox2.Text = "BH";
            dateTimePicker1.Text = "1/1/2016";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox1.Enabled = true;
        }

        private void FrmBH_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            button1.Enabled = false;
            //Load_data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                dateTimePicker1.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[5].Value.ToString();
            }
            catch (Exception)
            { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string upLuonng = "cap nhat tblBaoHiemXH SET MaSoBH=N'" + textBox2.Text + "',NgayCap='" + dateTimePicker1.Text + "',NoiCap=N'" + textBox4.Text  + "',GhiChu=N'" + textBox5.Text + "'WHERE(MaNV=N'" + textBox1.Text + "')";
            string upTTNV = "cap nhat tblTTNhanVien set MaBHXH='" + textBox2.Text + "' where MaNV='" + textBox1.Text + "'";
           //Conn.executeQuery(upLuonng);
           //Conn.executeQuery(upTTNV);
            //Load_data();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // --- Xóa nhân viên ở bảng BHXH
            string delBH = "DELETE FROM tblBaoHiemXH WHERE MaNV='" + textBox1.Text + "'";
            // --- Xóa nhân viên ở bảng Nhân Viên
            string delTTNV = "DELETE FROM tblTTNhanVien WHERE MaNV='" + textBox1.Text + "'";
            // --- Xóa nhân viên ở bảng Lương
            string delLuong = "DELETE FROM tblLuong WHERE MaNV='" + textBox1.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa BHXH nhân viên: " + textBox1.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string delThue = "delete from tblThueThuNhapCaNhan where MaNV='" + textBox1.Text + "'";
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    /*Conn.executeQuery(delBH);
                    Conn.executeQuery(delTTNV);
                    Conn.executeQuery(delLuong);
                    Conn.executeQuery(delThue);
                    Load_data();*/
                }
                catch (Exception)
                {
                }
            }
            else if (dialog == DialogResult.No)
            {
                //
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "BH" + textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát ?", "chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
