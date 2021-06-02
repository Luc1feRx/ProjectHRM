namespace QuanLyNhanSu
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuQLTK = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinNhânSựToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTaiKhoan,
            this.MenuDanhMuc,
            this.MenuChucNang,
            this.MenuQuanLy,
            this.MenuTroGiup});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1056, 31);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // MenuTaiKhoan
            // 
            this.MenuTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDangNhap,
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.MenuQLTK});
            this.MenuTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTaiKhoan.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.MenuTaiKhoan.Name = "MenuTaiKhoan";
            this.MenuTaiKhoan.Size = new System.Drawing.Size(96, 27);
            this.MenuTaiKhoan.Text = "&Tài khoản";
            this.MenuTaiKhoan.Click += new System.EventHandler(this.MenuTaiKhoan_Click);
            // 
            // MenuDangNhap
            // 
            this.MenuDangNhap.Image = global::QuanLyNhanSu.Properties.Resources.d2678io_4c8877cf_9c0a_4914_adca_b6b4d037be10;
            this.MenuDangNhap.ImageTransparentColor = System.Drawing.Color.Black;
            this.MenuDangNhap.Name = "MenuDangNhap";
            this.MenuDangNhap.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuDangNhap.Size = new System.Drawing.Size(259, 28);
            this.MenuDangNhap.Text = "&Đăng nhập";
            this.MenuDangNhap.Click += new System.EventHandler(this.DangNhap);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::QuanLyNhanSu.Properties.Resources.pw_icon;
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(259, 28);
            this.openToolStripMenuItem.Text = "&Đổi mật khẩu";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.DoiMatKhau);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(256, 6);
            // 
            // MenuQLTK
            // 
            this.MenuQLTK.Enabled = false;
            this.MenuQLTK.Image = global::QuanLyNhanSu.Properties.Resources.d2678io_4c8877cf_9c0a_4914_adca_b6b4d037be10;
            this.MenuQLTK.Name = "MenuQLTK";
            this.MenuQLTK.Size = new System.Drawing.Size(259, 28);
            this.MenuQLTK.Text = "&Quản lý tài khoản";
            this.MenuQLTK.Click += new System.EventHandler(this.QuanLyTaiKhoan);
            // 
            // MenuDanhMuc
            // 
            this.MenuDanhMuc.CheckOnClick = true;
            this.MenuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinNhânSựToolStripMenuItem});
            this.MenuDanhMuc.Enabled = false;
            this.MenuDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuDanhMuc.Name = "MenuDanhMuc";
            this.MenuDanhMuc.Size = new System.Drawing.Size(103, 27);
            this.MenuDanhMuc.Text = "&Danh mục";
            // 
            // MenuChucNang
            // 
            this.MenuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.MenuChucNang.Enabled = false;
            this.MenuChucNang.Name = "MenuChucNang";
            this.MenuChucNang.Size = new System.Drawing.Size(93, 27);
            this.MenuChucNang.Text = "&Chức năng";
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(158, 28);
            this.toolBarToolStripMenuItem.Text = "&Toolbar";
            this.toolBarToolStripMenuItem.Click += new System.EventHandler(this.toolBarToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(158, 28);
            this.statusBarToolStripMenuItem.Text = "&Status Bar";
            // 
            // MenuQuanLy
            // 
            this.MenuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.MenuQuanLy.Enabled = false;
            this.MenuQuanLy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuQuanLy.Name = "MenuQuanLy";
            this.MenuQuanLy.Size = new System.Drawing.Size(83, 27);
            this.MenuQuanLy.Text = "&Quản lý";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(154, 28);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // MenuTroGiup
            // 
            this.MenuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.MenuTroGiup.Enabled = false;
            this.MenuTroGiup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTroGiup.Name = "MenuTroGiup";
            this.MenuTroGiup.Size = new System.Drawing.Size(87, 27);
            this.MenuTroGiup.Text = "&Trợ giúp";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(229, 28);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(229, 28);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(229, 28);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(226, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(229, 28);
            this.aboutToolStripMenuItem.Text = "&About ... ...";
            // 
            // thôngTinNhânSựToolStripMenuItem
            // 
            this.thôngTinNhânSựToolStripMenuItem.Name = "thôngTinNhânSựToolStripMenuItem";
            this.thôngTinNhânSựToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.thôngTinNhânSựToolStripMenuItem.Text = "&Thông tin nhân sự";
            this.thôngTinNhânSựToolStripMenuItem.Click += new System.EventHandler(this.thôngTinNhânSựToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyNhanSu.Properties.Resources._3744720;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1056, 687);
            this.Controls.Add(this.menuStrip);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem MenuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MenuQLTK;
        private System.Windows.Forms.ToolStripMenuItem MenuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem MenuChucNang;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinNhânSựToolStripMenuItem;
    }
}