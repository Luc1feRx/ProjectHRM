namespace QuanLyNhanSu
{
    partial class FrmPhongBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhongBan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewPhongBan = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxMaBoPhan = new System.Windows.Forms.ComboBox();
            this.dateTimePickerNgayTL = new System.Windows.Forms.DateTimePicker();
            this.textBoxMaPhong = new System.Windows.Forms.TextBox();
            this.textBoxGhiChu = new System.Windows.Forms.TextBox();
            this.textBoxTenPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonMoi = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhongBan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewPhongBan);
            this.panel1.Location = new System.Drawing.Point(13, 268);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 225);
            this.panel1.TabIndex = 5;
            // 
            // dataGridViewPhongBan
            // 
            this.dataGridViewPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhongBan.Location = new System.Drawing.Point(8, 4);
            this.dataGridViewPhongBan.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPhongBan.Name = "dataGridViewPhongBan";
            this.dataGridViewPhongBan.RowHeadersWidth = 51;
            this.dataGridViewPhongBan.Size = new System.Drawing.Size(822, 208);
            this.dataGridViewPhongBan.TabIndex = 0;
            this.dataGridViewPhongBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhongBan_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.buttonThem);
            this.groupBox2.Controls.Add(this.buttonMoi);
            this.groupBox2.Controls.Add(this.buttonThoat);
            this.groupBox2.Controls.Add(this.buttonXoa);
            this.groupBox2.Controls.Add(this.buttonSua);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 194);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(838, 83);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các chức năng";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBoxMaBoPhan);
            this.groupBox1.Controls.Add(this.dateTimePickerNgayTL);
            this.groupBox1.Controls.Add(this.textBoxMaPhong);
            this.groupBox1.Controls.Add(this.textBoxGhiChu);
            this.groupBox1.Controls.Add(this.textBoxTenPhong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(838, 191);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng ban";
            // 
            // comboBoxMaBoPhan
            // 
            this.comboBoxMaBoPhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaBoPhan.FormattingEnabled = true;
            this.comboBoxMaBoPhan.Location = new System.Drawing.Point(177, 38);
            this.comboBoxMaBoPhan.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMaBoPhan.Name = "comboBoxMaBoPhan";
            this.comboBoxMaBoPhan.Size = new System.Drawing.Size(197, 25);
            this.comboBoxMaBoPhan.TabIndex = 3;
            // 
            // dateTimePickerNgayTL
            // 
            this.dateTimePickerNgayTL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayTL.Location = new System.Drawing.Point(499, 90);
            this.dateTimePickerNgayTL.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerNgayTL.Name = "dateTimePickerNgayTL";
            this.dateTimePickerNgayTL.Size = new System.Drawing.Size(196, 25);
            this.dateTimePickerNgayTL.TabIndex = 2;
            // 
            // textBoxMaPhong
            // 
            this.textBoxMaPhong.Location = new System.Drawing.Point(177, 92);
            this.textBoxMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaPhong.Name = "textBoxMaPhong";
            this.textBoxMaPhong.Size = new System.Drawing.Size(197, 25);
            this.textBoxMaPhong.TabIndex = 1;
            this.textBoxMaPhong.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxGhiChu
            // 
            this.textBoxGhiChu.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.textBoxGhiChu.AllowDrop = true;
            this.textBoxGhiChu.Location = new System.Drawing.Point(177, 130);
            this.textBoxGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGhiChu.Multiline = true;
            this.textBoxGhiChu.Name = "textBoxGhiChu";
            this.textBoxGhiChu.Size = new System.Drawing.Size(517, 27);
            this.textBoxGhiChu.TabIndex = 1;
            // 
            // textBoxTenPhong
            // 
            this.textBoxTenPhong.Location = new System.Drawing.Point(499, 39);
            this.textBoxTenPhong.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTenPhong.Name = "textBoxTenPhong";
            this.textBoxTenPhong.Size = new System.Drawing.Size(197, 25);
            this.textBoxTenPhong.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ghi chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày thành lập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bộ phận";
            // 
            // buttonThem
            // 
            this.buttonThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonThem.BackgroundImage")));
            this.buttonThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonThem.FlatAppearance.BorderSize = 0;
            this.buttonThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThem.Image = ((System.Drawing.Image)(resources.GetObject("buttonThem.Image")));
            this.buttonThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThem.Location = new System.Drawing.Point(247, 23);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(119, 43);
            this.buttonThem.TabIndex = 11;
            this.buttonThem.Text = "Thêm ";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click_1);
            // 
            // buttonMoi
            // 
            this.buttonMoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMoi.BackgroundImage")));
            this.buttonMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMoi.FlatAppearance.BorderSize = 0;
            this.buttonMoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoi.Image = ((System.Drawing.Image)(resources.GetObject("buttonMoi.Image")));
            this.buttonMoi.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonMoi.Location = new System.Drawing.Point(87, 23);
            this.buttonMoi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMoi.Name = "buttonMoi";
            this.buttonMoi.Size = new System.Drawing.Size(112, 43);
            this.buttonMoi.TabIndex = 7;
            this.buttonMoi.Text = "Mới   ";
            this.buttonMoi.UseVisualStyleBackColor = true;
            this.buttonMoi.Click += new System.EventHandler(this.buttonMoi_Click_1);
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonThoat.BackgroundImage")));
            this.buttonThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonThoat.FlatAppearance.BorderSize = 0;
            this.buttonThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThoat.Image = ((System.Drawing.Image)(resources.GetObject("buttonThoat.Image")));
            this.buttonThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThoat.Location = new System.Drawing.Point(696, 23);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(116, 43);
            this.buttonThoat.TabIndex = 10;
            this.buttonThoat.Text = "Thoát ";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click_1);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonXoa.BackgroundImage")));
            this.buttonXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonXoa.FlatAppearance.BorderSize = 0;
            this.buttonXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoa.Image = ((System.Drawing.Image)(resources.GetObject("buttonXoa.Image")));
            this.buttonXoa.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonXoa.Location = new System.Drawing.Point(560, 23);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(101, 43);
            this.buttonXoa.TabIndex = 9;
            this.buttonXoa.Text = "Xóa   ";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click_1);
            // 
            // buttonSua
            // 
            this.buttonSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSua.BackgroundImage")));
            this.buttonSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSua.FlatAppearance.BorderSize = 0;
            this.buttonSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSua.Image = ((System.Drawing.Image)(resources.GetObject("buttonSua.Image")));
            this.buttonSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSua.Location = new System.Drawing.Point(400, 23);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(120, 43);
            this.buttonSua.TabIndex = 8;
            this.buttonSua.Text = "Sửa   ";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click_1);
            // 
            // FrmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPhongBan";
            this.Text = "FrmPhongBan";
            this.Load += new System.EventHandler(this.FrmPhongBan_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhongBan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewPhongBan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxMaBoPhan;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayTL;
        private System.Windows.Forms.TextBox textBoxMaPhong;
        private System.Windows.Forms.TextBox textBoxGhiChu;
        private System.Windows.Forms.TextBox textBoxTenPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonMoi;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
    }
}