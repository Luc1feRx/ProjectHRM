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
        string username, password;
        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(string user, string pass)
        {
            InitializeComponent();
            username = user;
            password = pass;
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
            FrmDoiMatKhau frmDoiMatKhau = new FrmDoiMatKhau(username, password);
            frmDoiMatKhau.ShowDialog();
            this.Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        { 
            if (Quyen == "Admin     ")
            {
                MenuDangNhap.Enabled = false;
                MenuDanhMuc.Enabled = true;
                MenuQuanLy.Enabled = true;
                MenuTroGiup.Enabled = true;
                MenuQLTK.Enabled = true;
            }
            else if (Quyen == "User      ")
            {
                MenuDangNhap.Enabled = false;
                MenuDanhMuc.Enabled = true;
                MenuQuanLy.Enabled = true;
                MenuTroGiup.Enabled = true;
                MenuQLTK.Enabled = false;
                MenuDMK.Enabled = true;
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
            FrmBangLuongNVCT frm = new FrmBangLuongNVCT(username, password);
            frm.ShowDialog();
        }

        private void hồSơXinViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHoSoThuViec frmHS = new FormHoSoThuViec();
            frmHS.ShowDialog();
        }

        private void MenuDanhMuc_Click(object sender, EventArgs e)
        {

        }

        private void vấnĐềTăngLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTangLuong frmTangLuong = new FrmTangLuong();
            frmTangLuong.ShowDialog();
        }

        private void bảoHiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBH frmBH = new FrmBH();
            frmBH.ShowDialog();
        }

        private void thaiSảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmThaiSan frmThaiSan = new FrmThaiSan();
            frmThaiSan.ShowDialog();
        }

        private void MenuTroGiup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Đăng xuất thành công", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MenuDangNhap.Enabled = true;
                MenuDanhMuc.Enabled = false;
                MenuQuanLy.Enabled = false;
                MenuTroGiup.Enabled = false;
                MenuQLTK.Enabled = false;
                MenuDMK.Enabled = false;
            }
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCaNhan frmCaNhan = new FrmCaNhan();
            frmCaNhan.ShowDialog();
        }
    }
}
