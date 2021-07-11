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
            this.MenuDMK = new System.Windows.Forms.ToolStripMenuItem();
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
<<<<<<< HEAD
=======
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
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
            this.MenuDMK,
            this.toolStripSeparator3,
            this.MenuQLTK});
            this.MenuTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTaiKhoan.Image = global::QuanLyNhanSu.Properties.Resources.Folders_OS_User_No_Frame_Metro_icon;
            this.MenuTaiKhoan.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.MenuTaiKhoan.Name = "MenuTaiKhoan";
            this.MenuTaiKhoan.Size = new System.Drawing.Size(116, 27);
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
            // MenuDMK
            // 
            this.MenuDMK.Enabled = false;
            this.MenuDMK.Image = global::QuanLyNhanSu.Properties.Resources.pw_icon;
            this.MenuDMK.ImageTransparentColor = System.Drawing.Color.Black;
            this.MenuDMK.Name = "MenuDMK";
            this.MenuDMK.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuDMK.Size = new System.Drawing.Size(259, 28);
            this.MenuDMK.Text = "&Đổi mật khẩu";
            this.MenuDMK.Click += new System.EventHandler(this.DoiMatKhau);
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
            this.MenuDanhMuc.Image = global::QuanLyNhanSu.Properties.Resources.Actions_contact_new_icon;
            this.MenuDanhMuc.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MenuDanhMuc.ImageTransparentColor = System.Drawing.Color.White;
            this.MenuDanhMuc.Name = "MenuDanhMuc";
            this.MenuDanhMuc.Size = new System.Drawing.Size(123, 27);
            this.MenuDanhMuc.Text = "&Danh mục";
            this.MenuDanhMuc.Click += new System.EventHandler(this.MenuDanhMuc_Click);
            // 
            // thôngTinNhânSựToolStripMenuItem
            // 
<<<<<<< HEAD
            this.thôngTinNhânSựToolStripMenuItem.Image = global::QuanLyNhanSu.Properties.Resources.khachhang;
=======
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
            this.thôngTinNhânSựToolStripMenuItem.Name = "thôngTinNhânSựToolStripMenuItem";
            this.thôngTinNhânSựToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.thôngTinNhânSựToolStripMenuItem.Text = "&Thông tin nhân sự";
            this.thôngTinNhânSựToolStripMenuItem.Click += new System.EventHandler(this.thôngTinNhânSựToolStripMenuItem_Click);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
<<<<<<< HEAD
            this.thôngTinCáNhânToolStripMenuItem.Image = global::QuanLyNhanSu.Properties.Resources.khachhang2;
=======
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.thôngTinCáNhânToolStripMenuItem.Text = "&Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // chếĐộToolStripMenuItem
            // 
            this.chếĐộToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thaiSảnToolStripMenuItem,
            this.bảoHiểmToolStripMenuItem});
<<<<<<< HEAD
            this.chếĐộToolStripMenuItem.Image = global::QuanLyNhanSu.Properties.Resources.hopdong2;
=======
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
            this.chếĐộToolStripMenuItem.Name = "chếĐộToolStripMenuItem";
            this.chếĐộToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.chếĐộToolStripMenuItem.Text = "Chế độ";
            this.chếĐộToolStripMenuItem.Click += new System.EventHandler(this.chếĐộToolStripMenuItem_Click);
            // 
            // thaiSảnToolStripMenuItem
            // 
<<<<<<< HEAD
            this.thaiSảnToolStripMenuItem.Image = global::QuanLyNhanSu.Properties.Resources._10686_pregnant_woman_light_skin_tone_icon;
            this.thaiSảnToolStripMenuItem.Name = "thaiSảnToolStripMenuItem";
            this.thaiSảnToolStripMenuItem.Size = new System.Drawing.Size(166, 28);
=======
            this.thaiSảnToolStripMenuItem.Name = "thaiSảnToolStripMenuItem";
            this.thaiSảnToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
            this.thaiSảnToolStripMenuItem.Text = "Thai sản";
            this.thaiSảnToolStripMenuItem.Click += new System.EventHandler(this.thaiSảnToolStripMenuItem_Click);
            // 
            // bảoHiểmToolStripMenuItem
            // 
<<<<<<< HEAD
            this.bảoHiểmToolStripMenuItem.Image = global::QuanLyNhanSu.Properties.Resources.bhiem;
            this.bảoHiểmToolStripMenuItem.Name = "bảoHiểmToolStripMenuItem";
            this.bảoHiểmToolStripMenuItem.Size = new System.Drawing.Size(166, 28);
=======
            this.bảoHiểmToolStripMenuItem.Name = "bảoHiểmToolStripMenuItem";
            this.bảoHiểmToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
            this.bảoHiểmToolStripMenuItem.Text = "Bảo hiểm";
            this.bảoHiểmToolStripMenuItem.Click += new System.EventHandler(this.bảoHiểmToolStripMenuItem_Click);
            // 
            // hồSơXinViệcToolStripMenuItem
            // 
<<<<<<< HEAD
            this.hồSơXinViệcToolStripMenuItem.Image = global::QuanLyNhanSu.Properties.Resources.baocaohoadondichvu1;
=======
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
            this.hồSơXinViệcToolStripMenuItem.Name = "hồSơXinViệcToolStripMenuItem";
            this.hồSơXinViệcToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.hồSơXinViệcToolStripMenuItem.Text = "Hồ sơ xin việc";
            this.hồSơXinViệcToolStripMenuItem.Click += new System.EventHandler(this.hồSơXinViệcToolStripMenuItem_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
<<<<<<< HEAD
            this.tìmKiếmToolStripMenuItem.Image = global::QuanLyNhanSu.Properties.Resources.Other_Search_Metro_icon;
=======
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
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
<<<<<<< HEAD
            this.MenuQuanLy.Image = global::QuanLyNhanSu.Properties.Resources.hoadon2;
            this.MenuQuanLy.Name = "MenuQuanLy";
            this.MenuQuanLy.Size = new System.Drawing.Size(103, 27);
=======
            this.MenuQuanLy.Name = "MenuQuanLy";
            this.MenuQuanLy.Size = new System.Drawing.Size(83, 27);
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
            this.MenuQuanLy.Text = "&Quản lý";
            // 
            // bộPhậnToolStripMenuItem
            // 
<<<<<<< HEAD
            this.bộPhậnToolStripMenuItem.Image = global::QuanLyNhanSu.Properties.Resources.choo;
=======
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
            this.bộPhậnToolStripMenuItem.Name = "bộPhậnToolStripMenuItem";
            this.bộPhậnToolStripMenuItem.Size = new System.Drawing.Size(222, 28);
            this.bộPhậnToolStripMenuItem.Text = "Bộ phận";
            this.bộPhậnToolStripMenuItem.Click += new System.EventHandler(this.bộPhậnToolStripMenuItem_Click);
            // 
            // phòngBanToolStripMenuItem
            // 
<<<<<<< HEAD
            this.phòngBanToolStripMenuItem.Image = global::QuanLyNhanSu.Properties.Resources.diadiem;
=======
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
            this.phòngBanToolStripMenuItem.Name = "phòngBanToolStripMenuItem";
            this.phòngBanToolStripMenuItem.Size = new System.Drawing.Size(222, 28);
            this.phòngBanToolStripMenuItem.Text = "Phòng ban";
            this.phòngBanToolStripMenuItem.Click += new System.EventHandler(this.phòngBanToolStripMenuItem_Click);
            // 
            // lươngNhânViênToolStripMenuItem
            // 
            this.lươngNhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lươngThửViệcToolStripMenuItem,
            this.lươngNhânViênĐiềuHànhToolStripMenuItem});
<<<<<<< HEAD
            this.lươngNhânViênToolStripMenuItem.Image = global::QuanLyNhanSu.Properties.Resources.cash_icon;
=======
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
            this.lươngNhânViênToolStripMenuItem.Name = "lươngNhânViênToolStripMenuItem";
            this.lươngNhânViênToolStripMenuItem.Size = new System.Drawing.Size(222, 28);
            this.lươngNhânViênToolStripMenuItem.Text = "Lương nhân viên";
            this.lươngNhânViênToolStripMenuItem.Click += new System.EventHandler(this.lươngNhânViênToolStripMenuItem_Click);
            // 
            // lươngThửViệcToolStripMenuItem
            // 
<<<<<<< HEAD
            this.lươngThửViệcToolStripMenuItem.Image = global::QuanLyNhanSu.Properties.Resources.usd_dollar_money_cash;
=======
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
            this.lươngThửViệcToolStripMenuItem.Name = "lươngThửViệcToolStripMenuItem";
            this.lươngThửViệcToolStripMenuItem.Size = new System.Drawing.Size(304, 28);
            this.lươngThửViệcToolStripMenuItem.Text = "Lương thử việc";
            this.lươngThửViệcToolStripMenuItem.Click += new System.EventHandler(this.lươngThửViệcToolStripMenuItem_Click);
<<<<<<< HEAD
            // 
            // lươngNhânViênĐiềuHànhToolStripMenuItem
            // 
            this.lươngNhânViênĐiềuHànhToolStripMenuItem.Image = global::QuanLyNhanSu.Properties.Resources.Tourist_industry;
            this.lươngNhânViênĐiềuHànhToolStripMenuItem.Name = "lươngNhânViênĐiềuHànhToolStripMenuItem";
            this.lươngNhânViênĐiềuHànhToolStripMenuItem.Size = new System.Drawing.Size(304, 28);
            this.lươngNhânViênĐiềuHànhToolStripMenuItem.Text = "Lương nhân viên điều hành";
            this.lươngNhânViênĐiềuHànhToolStripMenuItem.Click += new System.EventHandler(this.lươngNhânViênĐiềuHànhToolStripMenuItem_Click);
=======
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
            this.bảngLươngToolStripMenuItem.Size = new System.Drawing.Size(222, 28);
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
            this.vấnĐềTăngLươngToolStripMenuItem.Click += new System.EventHandler(this.vấnĐềTăngLươngToolStripMenuItem_Click);
            // 
            // chứcVụToolStripMenuItem
            // 
            this.chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
            this.chứcVụToolStripMenuItem.Size = new System.Drawing.Size(222, 28);
            this.chứcVụToolStripMenuItem.Text = "Chức vụ";
            this.chứcVụToolStripMenuItem.Click += new System.EventHandler(this.chứcVụToolStripMenuItem_Click);
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
            // 
            // bảngLươngToolStripMenuItem
            // 
<<<<<<< HEAD
            this.bảngLươngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lươngCôngTyToolStripMenuItem,
            this.vấnĐềTăngLươngToolStripMenuItem});
            this.bảngLươngToolStripMenuItem.Image = global::QuanLyNhanSu.Properties.Resources.Money_2_icon;
            this.bảngLươngToolStripMenuItem.Name = "bảngLươngToolStripMenuItem";
            this.bảngLươngToolStripMenuItem.Size = new System.Drawing.Size(222, 28);
            this.bảngLươngToolStripMenuItem.Text = "Bảng lương";
=======
            this.MenuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.toolStripSeparator8});
            this.MenuTroGiup.Enabled = false;
            this.MenuTroGiup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTroGiup.Name = "MenuTroGiup";
            this.MenuTroGiup.Size = new System.Drawing.Size(87, 27);
            this.MenuTroGiup.Text = "&Trợ giúp";
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
            // 
            // lươngCôngTyToolStripMenuItem
            // 
            this.lươngCôngTyToolStripMenuItem.Image = global::QuanLyNhanSu.Properties.Resources.z;
            this.lươngCôngTyToolStripMenuItem.Name = "lươngCôngTyToolStripMenuItem";
            this.lươngCôngTyToolStripMenuItem.Size = new System.Drawing.Size(244, 28);
            this.lươngCôngTyToolStripMenuItem.Text = "Bảng lương công ty";
            this.lươngCôngTyToolStripMenuItem.Click += new System.EventHandler(this.lươngCôngTyToolStripMenuItem_Click);
            // 
<<<<<<< HEAD
            // vấnĐềTăngLươngToolStripMenuItem
            // 
            this.vấnĐềTăngLươngToolStripMenuItem.Image = global::QuanLyNhanSu.Properties.Resources.Document;
            this.vấnĐềTăngLươngToolStripMenuItem.Name = "vấnĐềTăngLươngToolStripMenuItem";
            this.vấnĐềTăngLươngToolStripMenuItem.Size = new System.Drawing.Size(244, 28);
            this.vấnĐềTăngLươngToolStripMenuItem.Text = "Vấn đề tăng lương";
            this.vấnĐềTăngLươngToolStripMenuItem.Click += new System.EventHandler(this.vấnĐềTăngLươngToolStripMenuItem_Click);
            // 
            // chứcVụToolStripMenuItem
            // 
            this.chứcVụToolStripMenuItem.Image = global::QuanLyNhanSu.Properties.Resources.user_group_icon;
            this.chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
            this.chứcVụToolStripMenuItem.Size = new System.Drawing.Size(222, 28);
            this.chứcVụToolStripMenuItem.Text = "Chức vụ";
            this.chứcVụToolStripMenuItem.Click += new System.EventHandler(this.chứcVụToolStripMenuItem_Click);
            // 
            // MenuTroGiup
            // 
            this.MenuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8});
            this.MenuTroGiup.Enabled = false;
            this.MenuTroGiup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTroGiup.Image = global::QuanLyNhanSu.Properties.Resources.nhanvien2;
            this.MenuTroGiup.Name = "MenuTroGiup";
            this.MenuTroGiup.Size = new System.Drawing.Size(123, 27);
            this.MenuTroGiup.Text = "&Đăng xuất";
            this.MenuTroGiup.Click += new System.EventHandler(this.MenuTroGiup_Click);
            // 
=======
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(226, 6);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyNhanSu.Properties.Resources.russia_95311_1920;
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
        private System.Windows.Forms.ToolStripMenuItem MenuDMK;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MenuQLTK;
        private System.Windows.Forms.ToolStripMenuItem MenuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem MenuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem MenuTroGiup;
<<<<<<< HEAD
=======
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
>>>>>>> 8a3a2072d6ce2659002aaed88b93b435dac162ba
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