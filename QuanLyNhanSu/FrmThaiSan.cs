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
    public partial class FrmThaiSan : Form
    {
        public FrmThaiSan()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox3.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {

                string insert = "insert into FrmThaiSan values(N'" + txt5.Text + "',N'" + txt6.Text + "',N'"+ comboBox2.Text + "',N'" + txt7.Text + "',N'" + dt2.Text + "',N'" + dt3.Text + "',N'" + dt4.Text + "',N'" + dt5.Text + "',N'" + txt8.Text + "',N'" + txt9.Text "')";
                if (!cls.kttrungkhoa(comboBox2.Text, "select Mã nhân viên from FrmThaiSan"))
                {
                    if (comboBox2.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dataGridView2.Refresh();
                        cls.loaddatagridview(dataGridView2, "select * from FrmThaiSan");
                        MessageBox.Show("Thêm thành công");
                    }
                    else MessageBox.Show("Bạn chưa nhập Mã Nhân Viên");
                }
                else
                    MessageBox.Show("Mã Nhân Viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update FrmThaiSan set LCB=N'" + txt4.Text + "',PCChucVu=N'" + txt5.Text + "',NgayNhap='" + dateTimePicker1.Text + "',LCBMoi=N'" + txt6.Text + "',NgaySua=N'" + dateTimePicker2.Text + "',LyDo=N'" + txt7.Text + "',PCCVuMoi='" + txt8.Text + "',NgaySuaPC=N'" + dateTimePicker3.Text + "',GhiChu=N'" + txt9.Text + "' where MaLuong=N'" + txt1.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dataGridView2, "select * from TblBangLuongCTy");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

      