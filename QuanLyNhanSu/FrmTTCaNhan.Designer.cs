
namespace QuanLyNhanSu
{
    partial class FrmTTCaNhan
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maNVLabel;
            System.Windows.Forms.Label hoTenLabel;
            System.Windows.Forms.Label noiSinhLabel;
            System.Windows.Forms.Label nguyenQuanLabel;
            System.Windows.Forms.Label dCThuongChuLabel;
            System.Windows.Forms.Label dCTamChuLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label danTocLabel;
            System.Windows.Forms.Label tonGiaoLabel;
            System.Windows.Forms.Label quocTichLabel;
            System.Windows.Forms.Label hocVanLabel;
            System.Windows.Forms.Label ghiChuLabel;
            this.qLNSDataSet = new QuanLyNhanSu.QLNSDataSet();
            this.tblTTCaNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblTTCaNhanTableAdapter = new QuanLyNhanSu.QLNSDataSetTableAdapters.TblTTCaNhanTableAdapter();
            this.tableAdapterManager = new QuanLyNhanSu.QLNSDataSetTableAdapters.TableAdapterManager();
            this.hoTenTextBox = new System.Windows.Forms.TextBox();
            this.noiSinhTextBox = new System.Windows.Forms.TextBox();
            this.nguyenQuanTextBox = new System.Windows.Forms.TextBox();
            this.dCThuongChuTextBox = new System.Windows.Forms.TextBox();
            this.dCTamChuTextBox = new System.Windows.Forms.TextBox();
            this.sDTTextBox = new System.Windows.Forms.TextBox();
            this.danTocTextBox = new System.Windows.Forms.TextBox();
            this.tonGiaoTextBox = new System.Windows.Forms.TextBox();
            this.quocTichTextBox = new System.Windows.Forms.TextBox();
            this.hocVanTextBox = new System.Windows.Forms.TextBox();
            this.ghiChuTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxMa = new System.Windows.Forms.ComboBox();
            this.groupBoxTTCN = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btlammoi = new System.Windows.Forms.Button();
            this.dataGridViewTTCN = new System.Windows.Forms.DataGridView();
            maNVLabel = new System.Windows.Forms.Label();
            hoTenLabel = new System.Windows.Forms.Label();
            noiSinhLabel = new System.Windows.Forms.Label();
            nguyenQuanLabel = new System.Windows.Forms.Label();
            dCThuongChuLabel = new System.Windows.Forms.Label();
            dCTamChuLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            danTocLabel = new System.Windows.Forms.Label();
            tonGiaoLabel = new System.Windows.Forms.Label();
            quocTichLabel = new System.Windows.Forms.Label();
            hocVanLabel = new System.Windows.Forms.Label();
            ghiChuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTTCaNhanBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTTCN)).BeginInit();
            this.SuspendLayout();
            // 
            // maNVLabel
            // 
            maNVLabel.AutoSize = true;
            maNVLabel.Location = new System.Drawing.Point(69, 77);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(54, 17);
            maNVLabel.TabIndex = 1;
            maNVLabel.Text = "Mã NV:";
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Location = new System.Drawing.Point(64, 114);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(59, 17);
            hoTenLabel.TabIndex = 3;
            hoTenLabel.Text = "Họ Tên:";
            // 
            // noiSinhLabel
            // 
            noiSinhLabel.AutoSize = true;
            noiSinhLabel.Location = new System.Drawing.Point(58, 151);
            noiSinhLabel.Name = "noiSinhLabel";
            noiSinhLabel.Size = new System.Drawing.Size(65, 17);
            noiSinhLabel.TabIndex = 5;
            noiSinhLabel.Text = "Nơi Sinh:";
            noiSinhLabel.Click += new System.EventHandler(this.noiSinhLabel_Click);
            // 
            // nguyenQuanLabel
            // 
            nguyenQuanLabel.AutoSize = true;
            nguyenQuanLabel.Location = new System.Drawing.Point(328, 188);
            nguyenQuanLabel.Name = "nguyenQuanLabel";
            nguyenQuanLabel.Size = new System.Drawing.Size(100, 17);
            nguyenQuanLabel.TabIndex = 7;
            nguyenQuanLabel.Text = "Nguyên Quán:";
            nguyenQuanLabel.Click += new System.EventHandler(this.nguyenQuanLabel_Click);
            // 
            // dCThuongChuLabel
            // 
            dCThuongChuLabel.AutoSize = true;
            dCThuongChuLabel.Location = new System.Drawing.Point(323, 114);
            dCThuongChuLabel.Name = "dCThuongChuLabel";
            dCThuongChuLabel.Size = new System.Drawing.Size(105, 17);
            dCThuongChuLabel.TabIndex = 9;
            dCThuongChuLabel.Text = "ĐC Thường trú:";
            dCThuongChuLabel.Click += new System.EventHandler(this.dCThuongChuLabel_Click);
            // 
            // dCTamChuLabel
            // 
            dCTamChuLabel.AutoSize = true;
            dCTamChuLabel.Location = new System.Drawing.Point(339, 153);
            dCTamChuLabel.Name = "dCTamChuLabel";
            dCTamChuLabel.Size = new System.Drawing.Size(89, 17);
            dCTamChuLabel.TabIndex = 11;
            dCTamChuLabel.Text = "ĐC Tạm Trú:";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(711, 151);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(40, 17);
            sDTLabel.TabIndex = 13;
            sDTLabel.Text = "SĐT:";
            sDTLabel.Click += new System.EventHandler(this.sDTLabel_Click);
            // 
            // danTocLabel
            // 
            danTocLabel.AutoSize = true;
            danTocLabel.Location = new System.Drawing.Point(57, 188);
            danTocLabel.Name = "danTocLabel";
            danTocLabel.Size = new System.Drawing.Size(66, 17);
            danTocLabel.TabIndex = 15;
            danTocLabel.Text = "Dân Tộc:";
            danTocLabel.Click += new System.EventHandler(this.danTocLabel_Click);
            // 
            // tonGiaoLabel
            // 
            tonGiaoLabel.AutoSize = true;
            tonGiaoLabel.Location = new System.Drawing.Point(357, 77);
            tonGiaoLabel.Name = "tonGiaoLabel";
            tonGiaoLabel.Size = new System.Drawing.Size(71, 17);
            tonGiaoLabel.TabIndex = 17;
            tonGiaoLabel.Text = "Tôn Giáo:";
            // 
            // quocTichLabel
            // 
            quocTichLabel.AutoSize = true;
            quocTichLabel.Location = new System.Drawing.Point(674, 77);
            quocTichLabel.Name = "quocTichLabel";
            quocTichLabel.Size = new System.Drawing.Size(77, 17);
            quocTichLabel.TabIndex = 19;
            quocTichLabel.Text = "Quốc Tịch:";
            // 
            // hocVanLabel
            // 
            hocVanLabel.AutoSize = true;
            hocVanLabel.Location = new System.Drawing.Point(685, 114);
            hocVanLabel.Name = "hocVanLabel";
            hocVanLabel.Size = new System.Drawing.Size(66, 17);
            hocVanLabel.TabIndex = 21;
            hocVanLabel.Text = "Học Vấn:";
            // 
            // ghiChuLabel
            // 
            ghiChuLabel.AutoSize = true;
            ghiChuLabel.Location = new System.Drawing.Point(688, 188);
            ghiChuLabel.Name = "ghiChuLabel";
            ghiChuLabel.Size = new System.Drawing.Size(63, 17);
            ghiChuLabel.TabIndex = 23;
            ghiChuLabel.Text = "Ghi Chú:";
            ghiChuLabel.Click += new System.EventHandler(this.ghiChuLabel_Click);
            // 
            // qLNSDataSet
            // 
            this.qLNSDataSet.DataSetName = "QLNSDataSet";
            this.qLNSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTTCaNhanBindingSource
            // 
            this.tblTTCaNhanBindingSource.DataMember = "TblTTCaNhan";
            this.tblTTCaNhanBindingSource.DataSource = this.qLNSDataSet;
            // 
            // tblTTCaNhanTableAdapter
            // 
            this.tblTTCaNhanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TblBangCongThuViecTableAdapter = null;
            this.tableAdapterManager.TblBangLuongCTyTableAdapter = null;
            this.tableAdapterManager.TblBoPhanTableAdapter = null;
            this.tableAdapterManager.tblChucVuTableAdapter = null;
            this.tableAdapterManager.TblCongKhoiDieuHanhTableAdapter = null;
            this.tableAdapterManager.TblHoSoThuViecTableAdapter = null;
            this.tableAdapterManager.tblLoaiHDTableAdapter = null;
            this.tableAdapterManager.TblNVThoiViecTableAdapter = null;
            this.tableAdapterManager.TblPhongBanTableAdapter = null;
            this.tableAdapterManager.tblQuyenTableAdapter = null;
            this.tableAdapterManager.TblSoBHTableAdapter = null;
            this.tableAdapterManager.TblTangLuongTableAdapter = null;
            this.tableAdapterManager.TblThaiSanTableAdapter = null;
            this.tableAdapterManager.tblThoiViecTableAdapter = null;
            this.tableAdapterManager.TblTTCaNhanTableAdapter = this.tblTTCaNhanTableAdapter;
            this.tableAdapterManager.TblTTNVCoBanTableAdapter = null;
            this.tableAdapterManager.tbuserTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyNhanSu.QLNSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hoTenTextBox
            // 
            this.hoTenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTCaNhanBindingSource, "HoTen", true));
            this.hoTenTextBox.Location = new System.Drawing.Point(137, 111);
            this.hoTenTextBox.Name = "hoTenTextBox";
            this.hoTenTextBox.Size = new System.Drawing.Size(142, 22);
            this.hoTenTextBox.TabIndex = 4;
            // 
            // noiSinhTextBox
            // 
            this.noiSinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTCaNhanBindingSource, "NoiSinh", true));
            this.noiSinhTextBox.Location = new System.Drawing.Point(137, 148);
            this.noiSinhTextBox.Name = "noiSinhTextBox";
            this.noiSinhTextBox.Size = new System.Drawing.Size(142, 22);
            this.noiSinhTextBox.TabIndex = 6;
            // 
            // nguyenQuanTextBox
            // 
            this.nguyenQuanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTCaNhanBindingSource, "NguyenQuan", true));
            this.nguyenQuanTextBox.Location = new System.Drawing.Point(448, 185);
            this.nguyenQuanTextBox.Name = "nguyenQuanTextBox";
            this.nguyenQuanTextBox.Size = new System.Drawing.Size(152, 22);
            this.nguyenQuanTextBox.TabIndex = 8;
            // 
            // dCThuongChuTextBox
            // 
            this.dCThuongChuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTCaNhanBindingSource, "DCThuongChu", true));
            this.dCThuongChuTextBox.Location = new System.Drawing.Point(448, 111);
            this.dCThuongChuTextBox.Name = "dCThuongChuTextBox";
            this.dCThuongChuTextBox.Size = new System.Drawing.Size(152, 22);
            this.dCThuongChuTextBox.TabIndex = 10;
            this.dCThuongChuTextBox.TextChanged += new System.EventHandler(this.dCThuongChuTextBox_TextChanged);
            // 
            // dCTamChuTextBox
            // 
            this.dCTamChuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTCaNhanBindingSource, "DCTamChu", true));
            this.dCTamChuTextBox.Location = new System.Drawing.Point(448, 150);
            this.dCTamChuTextBox.Name = "dCTamChuTextBox";
            this.dCTamChuTextBox.Size = new System.Drawing.Size(152, 22);
            this.dCTamChuTextBox.TabIndex = 12;
            // 
            // sDTTextBox
            // 
            this.sDTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTCaNhanBindingSource, "SDT", true));
            this.sDTTextBox.Location = new System.Drawing.Point(775, 148);
            this.sDTTextBox.Name = "sDTTextBox";
            this.sDTTextBox.Size = new System.Drawing.Size(148, 22);
            this.sDTTextBox.TabIndex = 14;
            this.sDTTextBox.TextChanged += new System.EventHandler(this.sDTTextBox_TextChanged);
            // 
            // danTocTextBox
            // 
            this.danTocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTCaNhanBindingSource, "DanToc", true));
            this.danTocTextBox.Location = new System.Drawing.Point(137, 185);
            this.danTocTextBox.Name = "danTocTextBox";
            this.danTocTextBox.Size = new System.Drawing.Size(142, 22);
            this.danTocTextBox.TabIndex = 16;
            this.danTocTextBox.TextChanged += new System.EventHandler(this.danTocTextBox_TextChanged);
            // 
            // tonGiaoTextBox
            // 
            this.tonGiaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTCaNhanBindingSource, "TonGiao", true));
            this.tonGiaoTextBox.Location = new System.Drawing.Point(448, 74);
            this.tonGiaoTextBox.Name = "tonGiaoTextBox";
            this.tonGiaoTextBox.Size = new System.Drawing.Size(152, 22);
            this.tonGiaoTextBox.TabIndex = 18;
            // 
            // quocTichTextBox
            // 
            this.quocTichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTCaNhanBindingSource, "QuocTich", true));
            this.quocTichTextBox.Location = new System.Drawing.Point(775, 74);
            this.quocTichTextBox.Name = "quocTichTextBox";
            this.quocTichTextBox.Size = new System.Drawing.Size(148, 22);
            this.quocTichTextBox.TabIndex = 20;
            // 
            // hocVanTextBox
            // 
            this.hocVanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTCaNhanBindingSource, "HocVan", true));
            this.hocVanTextBox.Location = new System.Drawing.Point(775, 111);
            this.hocVanTextBox.Name = "hocVanTextBox";
            this.hocVanTextBox.Size = new System.Drawing.Size(148, 22);
            this.hocVanTextBox.TabIndex = 22;
            // 
            // ghiChuTextBox
            // 
            this.ghiChuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTCaNhanBindingSource, "GhiChu", true));
            this.ghiChuTextBox.Location = new System.Drawing.Point(775, 185);
            this.ghiChuTextBox.Name = "ghiChuTextBox";
            this.ghiChuTextBox.Size = new System.Drawing.Size(148, 22);
            this.ghiChuTextBox.TabIndex = 24;
            this.ghiChuTextBox.TextChanged += new System.EventHandler(this.ghiChuTextBox_TextChanged);
            // 
            // comboBoxMa
            // 
            this.comboBoxMa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMa.FormattingEnabled = true;
            this.comboBoxMa.Location = new System.Drawing.Point(137, 77);
            this.comboBoxMa.Name = "comboBoxMa";
            this.comboBoxMa.Size = new System.Drawing.Size(142, 24);
            this.comboBoxMa.TabIndex = 25;
            this.comboBoxMa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBoxTTCN
            // 
            this.groupBoxTTCN.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTTCN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxTTCN.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxTTCN.Location = new System.Drawing.Point(49, 12);
            this.groupBoxTTCN.Name = "groupBoxTTCN";
            this.groupBoxTTCN.Size = new System.Drawing.Size(897, 202);
            this.groupBoxTTCN.TabIndex = 26;
            this.groupBoxTTCN.TabStop = false;
            this.groupBoxTTCN.Text = "Thông Tin Cá Nhân";
            this.groupBoxTTCN.Enter += new System.EventHandler(this.groupBoxTTCN_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btthoat);
            this.groupBox2.Controls.Add(this.btxoa);
            this.groupBox2.Controls.Add(this.btsua);
            this.groupBox2.Controls.Add(this.btlammoi);
            this.groupBox2.Location = new System.Drawing.Point(49, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(897, 66);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các Chức Năng";
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(665, 21);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(100, 39);
            this.btthoat.TabIndex = 3;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(511, 21);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(100, 39);
            this.btxoa.TabIndex = 2;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(373, 21);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(100, 39);
            this.btsua.TabIndex = 1;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btlammoi
            // 
            this.btlammoi.Location = new System.Drawing.Point(232, 21);
            this.btlammoi.Name = "btlammoi";
            this.btlammoi.Size = new System.Drawing.Size(100, 39);
            this.btlammoi.TabIndex = 0;
            this.btlammoi.Text = "Làm Mới";
            this.btlammoi.UseVisualStyleBackColor = true;
            this.btlammoi.Click += new System.EventHandler(this.button1_Click);
            this.btlammoi.Leave += new System.EventHandler(this.btlammoi_Leave);
            this.btlammoi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btlammoi_MouseMove);
            // 
            // dataGridViewTTCN
            // 
            this.dataGridViewTTCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTTCN.Location = new System.Drawing.Point(49, 292);
            this.dataGridViewTTCN.Name = "dataGridViewTTCN";
            this.dataGridViewTTCN.RowHeadersWidth = 51;
            this.dataGridViewTTCN.RowTemplate.Height = 24;
            this.dataGridViewTTCN.Size = new System.Drawing.Size(897, 150);
            this.dataGridViewTTCN.TabIndex = 28;
            this.dataGridViewTTCN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTTCN_CellClick);
            this.dataGridViewTTCN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FrmTTCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = global::QuanLyNhanSu.Properties.Resources.th;
            this.ClientSize = new System.Drawing.Size(1020, 505);
            this.Controls.Add(this.dataGridViewTTCN);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBoxMa);
            this.Controls.Add(maNVLabel);
            this.Controls.Add(hoTenLabel);
            this.Controls.Add(this.hoTenTextBox);
            this.Controls.Add(noiSinhLabel);
            this.Controls.Add(this.noiSinhTextBox);
            this.Controls.Add(nguyenQuanLabel);
            this.Controls.Add(this.nguyenQuanTextBox);
            this.Controls.Add(dCThuongChuLabel);
            this.Controls.Add(this.dCThuongChuTextBox);
            this.Controls.Add(dCTamChuLabel);
            this.Controls.Add(this.dCTamChuTextBox);
            this.Controls.Add(sDTLabel);
            this.Controls.Add(this.sDTTextBox);
            this.Controls.Add(danTocLabel);
            this.Controls.Add(this.danTocTextBox);
            this.Controls.Add(tonGiaoLabel);
            this.Controls.Add(this.tonGiaoTextBox);
            this.Controls.Add(quocTichLabel);
            this.Controls.Add(this.quocTichTextBox);
            this.Controls.Add(hocVanLabel);
            this.Controls.Add(this.hocVanTextBox);
            this.Controls.Add(ghiChuLabel);
            this.Controls.Add(this.ghiChuTextBox);
            this.Controls.Add(this.groupBoxTTCN);
            this.Name = "FrmTTCaNhan";
            this.Text = "FrmTTCaNhan";
            this.Load += new System.EventHandler(this.FrmTTCaNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTTCaNhanBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTTCN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLNSDataSet qLNSDataSet;
        private System.Windows.Forms.BindingSource tblTTCaNhanBindingSource;
        private QLNSDataSetTableAdapters.TblTTCaNhanTableAdapter tblTTCaNhanTableAdapter;
        private QLNSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox hoTenTextBox;
        private System.Windows.Forms.TextBox noiSinhTextBox;
        private System.Windows.Forms.TextBox nguyenQuanTextBox;
        private System.Windows.Forms.TextBox dCThuongChuTextBox;
        private System.Windows.Forms.TextBox dCTamChuTextBox;
        private System.Windows.Forms.TextBox sDTTextBox;
        private System.Windows.Forms.TextBox danTocTextBox;
        private System.Windows.Forms.TextBox tonGiaoTextBox;
        private System.Windows.Forms.TextBox quocTichTextBox;
        private System.Windows.Forms.TextBox hocVanTextBox;
        private System.Windows.Forms.TextBox ghiChuTextBox;
        private System.Windows.Forms.ComboBox comboBoxMa;
        private System.Windows.Forms.GroupBox groupBoxTTCN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btlammoi;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.DataGridView dataGridViewTTCN;
    }
}