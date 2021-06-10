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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuQLTK = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinNhânSựToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chếĐộToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thaiSảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảoHiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hồSơXinViệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.bộPhậnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lươngNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lươngThửViệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lươngNhânViênĐiềuHànhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngLươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lươngCôngTyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vấnĐềTăngLươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTaiKhoan,
            this.MenuDanhMuc,
            this.MenuQuanLy,
            this.MenuTroGiup});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(843, 31);
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
            this.thôngTinNhânSựToolStripMenuItem,
            this.thôngTinCáNhânToolStripMenuItem,
            this.chếĐộToolStripMenuItem,
            this.hồSơXinViệcToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem});
            this.MenuDanhMuc.Enabled = false;
            this.MenuDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuDanhMuc.Name = "MenuDanhMuc";
            this.MenuDanhMuc.Size = new System.Drawing.Size(103, 27);
            this.MenuDanhMuc.Text = "&Danh mục";
            // 
            // thôngTinNhânSựToolStripMenuItem
            // 
            this.thôngTinNhânSựToolStripMenuItem.Name = "thôngTinNhânSựToolStripMenuItem";
            this.thôngTinNhânSựToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.thôngTinNhânSựToolStripMenuItem.Text = "&Thông tin nhân sự";
            this.thôngTinNhânSựToolStripMenuItem.Click += new System.EventHandler(this.thôngTinNhânSựToolStripMenuItem_Click);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.thôngTinCáNhânToolStripMenuItem.Text = "&Thông tin cá nhân";
            // 
            // chếĐộToolStripMenuItem
            // 
            this.chếĐộToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thaiSảnToolStripMenuItem,
            this.bảoHiểmToolStripMenuItem});
            this.chếĐộToolStripMenuItem.Name = "chếĐộToolStripMenuItem";
            this.chếĐộToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.chếĐộToolStripMenuItem.Text = "Chế độ";
            this.chếĐộToolStripMenuItem.Click += new System.EventHandler(this.chếĐộToolStripMenuItem_Click);
            // 
            // thaiSảnToolStripMenuItem
            // 
            this.thaiSảnToolStripMenuItem.Name = "thaiSảnToolStripMenuItem";
            this.thaiSảnToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.thaiSảnToolStripMenuItem.Text = "Thai sản";
            // 
            // bảoHiểmToolStripMenuItem
            // 
            this.bảoHiểmToolStripMenuItem.Name = "bảoHiểmToolStripMenuItem";
            this.bảoHiểmToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.bảoHiểmToolStripMenuItem.Text = "Bảo hiểm";
            // 
            // hồSơXinViệcToolStripMenuItem
            // 
            this.hồSơXinViệcToolStripMenuItem.Name = "hồSơXinViệcToolStripMenuItem";
            this.hồSơXinViệcToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.hồSơXinViệcToolStripMenuItem.Text = "Hồ sơ xin việc";
            this.hồSơXinViệcToolStripMenuItem.Click += new System.EventHandler(this.hồSơXinViệcToolStripMenuItem_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm Kiếm";
            this.tìmKiếmToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmToolStripMenuItem_Click_1);
            // 
            // MenuQuanLy
            // 
            this.MenuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bộPhậnToolStripMenuItem,
            this.phòngBanToolStripMenuItem,
            this.lươngNhânViênToolStripMenuItem,
            this.bảngLươngToolStripMenuItem,
            this.chứcVụToolStripMenuItem});
            this.MenuQuanLy.Enabled = false;
            this.MenuQuanLy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuQuanLy.Name = "MenuQuanLy";
            this.MenuQuanLy.Size = new System.Drawing.Size(83, 27);
            this.MenuQuanLy.Text = "&Quản lý";
            // 
            // bộPhậnToolStripMenuItem
            // 
            this.bộPhậnToolStripMenuItem.Name = "bộPhậnToolStripMenuItem";
            this.bộPhậnToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.bộPhậnToolStripMenuItem.Text = "Bộ phận";
            this.bộPhậnToolStripMenuItem.Click += new System.EventHandler(this.bộPhậnToolStripMenuItem_Click);
            // 
            // phòngBanToolStripMenuItem
            // 
            this.phòngBanToolStripMenuItem.Name = "phòngBanToolStripMenuItem";
            this.phòngBanToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.phòngBanToolStripMenuItem.Text = "Phòng ban";
            this.phòngBanToolStripMenuItem.Click += new System.EventHandler(this.phòngBanToolStripMenuItem_Click);
            // 
            // lươngNhânViênToolStripMenuItem
            // 
            this.lươngNhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lươngThửViệcToolStripMenuItem,
            this.lươngNhânViênĐiềuHànhToolStripMenuItem});
            this.lươngNhânViênToolStripMenuItem.Name = "lươngNhânViênToolStripMenuItem";
            this.lươngNhânViênToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.lươngNhânViênToolStripMenuItem.Text = "Lương nhân viên";
            this.lươngNhânViênToolStripMenuItem.Click += new System.EventHandler(this.lươngNhânViênToolStripMenuItem_Click);
            // 
            // lươngThửViệcToolStripMenuItem
            // 
            this.lươngThửViệcToolStripMenuItem.Name = "lươngThửViệcToolStripMenuItem";
            this.lươngThửViệcToolStripMenuItem.Size = new System.Drawing.Size(304, 28);
            this.lươngThửViệcToolStripMenuItem.Text = "Lương thử việc";
            this.lươngThửViệcToolStripMenuItem.Click += new System.EventHandler(this.lươngThửViệcToolStripMenuItem_Click);
            // 
            // lươngNhânViênĐiềuHànhToolStripMenuItem
            // 
            this.lươngNhânViênĐiềuHànhToolStripMenuItem.Name = "lươngNhânViênĐiềuHànhToolStripMenuItem";
            this.lươngNhânViênĐiềuHànhToolStripMenuItem.Size = new System.Drawing.Size(304, 28);
            this.lươngNhânViênĐiềuHànhToolStripMenuItem.Text = "Lương nhân viên điều hành";
            this.lươngNhânViênĐiềuHànhToolStripMenuItem.Click += new System.EventHandler(this.lươngNhânViênĐiềuHànhToolStripMenuItem_Click);
            // 
            // bảngLươngToolStripMenuItem
            // 
            this.bảngLươngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lươngCôngTyToolStripMenuItem,
            this.vấnĐềTăngLươngToolStripMenuItem});
            this.bảngLươngToolStripMenuItem.Name = "bảngLươngToolStripMenuItem";
            this.bảngLươngToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.bảngLươngToolStripMenuItem.Text = "Bảng lương";
            // 
            // lươngCôngTyToolStripMenuItem
            // 
            this.lươngCôngTyToolStripMenuItem.Name = "lươngCôngTyToolStripMenuItem";
            this.lươngCôngTyToolStripMenuItem.Size = new System.Drawing.Size(244, 28);
            this.lươngCôngTyToolStripMenuItem.Text = "Bảng lương công ty";
            this.lươngCôngTyToolStripMenuItem.Click += new System.EventHandler(this.lươngCôngTyToolStripMenuItem_Click);
            // 
            // vấnĐềTăngLươngToolStripMenuItem
            // 
            this.vấnĐềTăngLươngToolStripMenuItem.Name = "vấnĐềTăngLươngToolStripMenuItem";
            this.vấnĐềTăngLươngToolStripMenuItem.Size = new System.Drawing.Size(244, 28);
            this.vấnĐềTăngLươngToolStripMenuItem.Text = "Vấn đề tăng lương";
            // 
            // chứcVụToolStripMenuItem
            // 
            this.chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
            this.chứcVụToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.chứcVụToolStripMenuItem.Text = "Chức vụ";
            this.chứcVụToolStripMenuItem.Click += new System.EventHandler(this.chứcVụToolStripMenuItem_Click);
            // 
            // MenuTroGiup
            // 
            this.MenuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.toolStripSeparator8});
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
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(226, 6);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyNhanSu.Properties.Resources._3744720;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 508);
            this.Controls.Add(this.menuStrip);
            this.Name = "FrmMain";
            this.Text = "Quản lý nhân sự";
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
        private System.Windows.Forms.ToolStripMenuItem MenuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem MenuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem thôngTinNhânSựToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chếĐộToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thaiSảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảoHiểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hồSơXinViệcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bộPhậnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lươngNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảngLươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lươngCôngTyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vấnĐềTăngLươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lươngThửViệcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lươngNhânViênĐiềuHànhToolStripMenuItem;
    }
}