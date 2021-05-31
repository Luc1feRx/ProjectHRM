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
            if (Quyen == "Admin")
            {
                MenuDanhMuc.Enabled = true;
                MenuChucNang.Enabled = true;
                MenuQuanLy.Enabled = true;
                MenuTroGiup.Enabled = true;
                MenuQLTK.Enabled = true;
                DangXuatToolStripMenuItem.Enabled = true;
                MenuDangNhap.Enabled = false;
            }
            else if (Quyen == "User")
            {
                MenuDanhMuc.Enabled = true;
                MenuChucNang.Enabled = true;
                MenuQuanLy.Enabled = true;
                MenuTroGiup.Enabled = true;
                MenuQLTK.Enabled = false;
                DangXuatToolStripMenuItem.Enabled = true;
                MenuDangNhap.Enabled = false;
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

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Đăng xuất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                MenuDanhMuc.Enabled = false;
                MenuChucNang.Enabled = false;
                MenuQuanLy.Enabled = false;
                MenuTroGiup.Enabled = false;
                MenuQLTK.Enabled = false;
                DangXuatToolStripMenuItem.Enabled = false;
                MenuDangNhap.Enabled = true;
            }


        }
    }
}
