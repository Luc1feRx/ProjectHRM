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

                string insert = "insert into FrmThaiSan values(N'" + txt5.Text + "',N'" + txt6.Text + "',N'"+ comboBox2.Text + "',N'" + txt7.Text + "',N'" + dt2.Text + "',N'" + dt3.Text + "',N'" + dt4.Text + "',N'" + dt5.Text + "',N'" + txt8.Text + "',N'" + txt9.Text +"')";
                if (Connect.kttrungkhoa(comboBox2.Text, "select Mã nhân viên from FrmThaiSan"))
                {
                    if (comboBox2.Text != "")
                    {
                        Connect.thucthiketnoi(insert);
                        dataGridView2.Refresh();
                        Connect.loaddatagridview(dataGridView2, "select * from FrmThaiSan");
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
                string update = "update FrmThaiSan set MaBP=N'" + txt5.Text + "',MaP=N'" + txt6.Text + "',MaNV=N'" + comboBox2.Text + "',HoTen=N'" + txt7.Text + "',NgSinh=N'" + dt2.Text + "',NgayVeSom=N'" + dt3.Text + "',NgVeSinh=N'" + dt4.Text + "',NgLamTL=N'" + dt5.Text + "',TroCap=N'" + txt8.Text + "' GhiChu=N'" + txt9.Text + "'";
                Connect.thucthiketnoi(update);
                Connect.loaddatagridview(dataGridView2, "select * from TblBangLuongCTy");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát ?", "chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

      