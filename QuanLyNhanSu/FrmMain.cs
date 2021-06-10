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
    public partial class FrmMain : Form
    {
        public static string Quyen = "";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void DangNhap(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap fDangNhap = new FrmDangNhap();
            fDangNhap.ShowDialog();
            this.Close();
        }

        private void toolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void DoiMatKhau(object sender, EventArgs e)
        {
            this.Hide();
            FrmDoiMatKhau frmDoiMatKhau = new FrmDoiMatKhau();
            frmDoiMatKhau.ShowDialog();
            this.Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        { 
            if (Quyen == "Admin     ")
            {
                MenuDanhMuc.Enabled = true;
                MenuQuanLy.Enabled = true;
                MenuTroGiup.Enabled = true;
                MenuQLTK.Enabled = true;
            }
            else if (Quyen == "User      ")
            {
                MenuDanhMuc.Enabled = true;
                MenuQuanLy.Enabled = true;
                MenuTroGiup.Enabled = true;
                MenuQLTK.Enabled = false;
            }
        }

        private void QuanLyTaiKhoan(object sender, EventArgs e)
        {
            this.Hide();
            FrmQLTK frmQLTK = new FrmQLTK();
            frmQLTK.ShowDialog();
        }

        private void MenuTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinNhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTTCoBan frmTTCoBan = new FrmTTCoBan();
            frmTTCoBan.ShowDialog();
        }

        private void lươngNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lươngNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tìmKiếmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmTimKiem frmTimKiem = new FrmTimKiem();
            frmTimKiem.ShowDialog();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmChucVu frmChucVu = new FrmChucVu();
            frmChucVu.ShowDialog();
        }

        private void bộPhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBoPhan frmBoPhan = new FrmBoPhan();
            frmBoPhan.ShowDialog();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPhongBan frmPhongBan = new FrmPhongBan();
            frmPhongBan.ShowDialog();
        }

        private void lươngCôngTyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLuong frmLuong = new FrmLuong();
            frmLuong.ShowDialog();
        }

        private void lươngThửViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBangLuongTV frmBangLuongTV = new FrmBangLuongTV();
            frmBangLuongTV.ShowDialog();
        }

        private void chếĐộToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lươngNhânViênĐiềuHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBangLuongNVCT frm = new FrmBangLuongNVCT();
            frm.ShowDialog();
        }

        private void hồSơXinViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHoSoThuViec frmHS = new FormHoSoThuViec();
            frmHS.ShowDialog();
        }
    }
}
