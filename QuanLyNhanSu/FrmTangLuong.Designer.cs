namespace QuanLyNhanSu
{
    partial class FrmTangLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTangLuong));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtmaluong = new System.Windows.Forms.TextBox();
            this.txtchucvu = new System.Windows.Forms.TextBox();
            this.txtgioitinh = new System.Windows.Forms.TextBox();
            this.comboBoxMLM = new System.Windows.Forms.ComboBox();
            this.comboBoxMaNV = new System.Windows.Forms.ComboBox();
            this.dateTimePickerNgayTang = new System.Windows.Forms.DateTimePicker();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonMoi = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.dg2 = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.txtmaluong);
            this.groupBox4.Controls.Add(this.txtchucvu);
            this.groupBox4.Controls.Add(this.txtgioitinh);
            this.groupBox4.Controls.Add(this.comboBoxMLM);
            this.groupBox4.Controls.Add(this.comboBoxMaNV);
            this.groupBox4.Controls.Add(this.dateTimePickerNgayTang);
            this.groupBox4.Controls.Add(this.txtLyDo);
            this.groupBox4.Controls.Add(this.txtHoTen);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Location = new System.Drawing.Point(13, 13);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(944, 151);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin về tăng lương nhân viên";
            // 
            // txtmaluong
            // 
            this.txtmaluong.Enabled = false;
            this.txtmaluong.Location = new System.Drawing.Point(352, 65);
            this.txtmaluong.Name = "txtmaluong";
            this.txtmaluong.Size = new System.Drawing.Size(148, 22);
            this.txtmaluong.TabIndex = 17;
            // 
            // txtchucvu
            // 
            this.txtchucvu.Enabled = false;
            this.txtchucvu.Location = new System.Drawing.Point(352, 26);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.Size = new System.Drawing.Size(148, 22);
            this.txtchucvu.TabIndex = 16;
            // 
            // txtgioitinh
            // 
            this.txtgioitinh.Enabled = false;
            this.txtgioitinh.Location = new System.Drawing.Point(121, 104);
            this.txtgioitinh.Name = "txtgioitinh";
            this.txtgioitinh.Size = new System.Drawing.Size(117, 22);
            this.txtgioitinh.TabIndex = 15;
            // 
            // comboBoxMLM
            // 
            this.comboBoxMLM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMLM.FormattingEnabled = true;
            this.comboBoxMLM.Location = new System.Drawing.Point(352, 103);
            this.comboBoxMLM.Name = "comboBoxMLM";
            this.comboBoxMLM.Size = new System.Drawing.Size(148, 24);
            this.comboBoxMLM.TabIndex = 13;
            this.comboBoxMLM.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBoxMaNV
            // 
            this.comboBoxMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaNV.FormattingEnabled = true;
            this.comboBoxMaNV.Location = new System.Drawing.Point(123, 36);
            this.comboBoxMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMaNV.Name = "comboBoxMaNV";
            this.comboBoxMaNV.Size = new System.Drawing.Size(116, 24);
            this.comboBoxMaNV.TabIndex = 11;
            this.comboBoxMaNV.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaNV_SelectedIndexChanged);
            // 
            // dateTimePickerNgayTang
            // 
            this.dateTimePickerNgayTang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayTang.Location = new System.Drawing.Point(631, 33);
            this.dateTimePickerNgayTang.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerNgayTang.Name = "dateTimePickerNgayTang";
            this.dateTimePickerNgayTang.Size = new System.Drawing.Size(121, 22);
            this.dateTimePickerNgayTang.TabIndex = 9;
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(595, 76);
            this.txtLyDo.Margin = new System.Windows.Forms.Padding(4);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(295, 51);
            this.txtLyDo.TabIndex = 10;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Location = new System.Drawing.Point(121, 71);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(117, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(280, 32);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Chức vụ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(548, 76);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "Lí do";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(248, 108);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 17);
            this.label17.TabIndex = 0;
            this.label17.Text = "Mã Lương mới";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(51, 107);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 17);
            this.label18.TabIndex = 0;
            this.label18.Text = "Giới tính";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(548, 39);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 17);
            this.label19.TabIndex = 0;
            this.label19.Text = "Ngày tăng";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(248, 71);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 17);
            this.label20.TabIndex = 0;
            this.label20.Text = "Mã Lương cũ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(61, 75);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 17);
            this.label21.TabIndex = 0;
            this.label21.Text = "Họ tên";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(17, 39);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(93, 17);
            this.label24.TabIndex = 0;
            this.label24.Text = "Mã nhân viên";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.buttonThem);
            this.groupBox3.Controls.Add(this.buttonMoi);
            this.groupBox3.Controls.Add(this.buttonThoat);
            this.groupBox3.Controls.Add(this.buttonXoa);
            this.groupBox3.Controls.Add(this.buttonSua);
            this.groupBox3.Location = new System.Drawing.Point(13, 182);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(944, 65);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Các chức năng";
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
            this.buttonThem.Location = new System.Drawing.Point(336, 14);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(119, 43);
            this.buttonThem.TabIndex = 11;
            this.buttonThem.Text = "Thêm ";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
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
            this.buttonMoi.Location = new System.Drawing.Point(184, 14);
            this.buttonMoi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMoi.Name = "buttonMoi";
            this.buttonMoi.Size = new System.Drawing.Size(112, 43);
            this.buttonMoi.TabIndex = 7;
            this.buttonMoi.Text = "Mới   ";
            this.buttonMoi.UseVisualStyleBackColor = true;
            this.buttonMoi.Click += new System.EventHandler(this.buttonMoi_Click);
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
            this.buttonThoat.Location = new System.Drawing.Point(810, 14);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(116, 43);
            this.buttonThoat.TabIndex = 10;
            this.buttonThoat.Text = "Thoát ";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
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
            this.buttonXoa.Location = new System.Drawing.Point(666, 14);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(101, 43);
            this.buttonXoa.TabIndex = 9;
            this.buttonXoa.Text = "Xóa   ";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
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
            this.buttonSua.Location = new System.Drawing.Point(501, 14);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(120, 43);
            this.buttonSua.TabIndex = 8;
            this.buttonSua.Text = "Sửa   ";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // dg2
            // 
            this.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg2.Location = new System.Drawing.Point(17, 267);
            this.dg2.Margin = new System.Windows.Forms.Padding(4);
            this.dg2.Name = "dg2";
            this.dg2.RowHeadersWidth = 51;
            this.dg2.Size = new System.Drawing.Size(944, 171);
            this.dg2.TabIndex = 7;
            this.dg2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg2_CellClick);
            // 
            // FrmTangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyNhanSu.Properties.Resources.blue_moving_flowing_abstract_waves_on_white_background_blurred_smooth_graphic_motion_design_video_animation_1920x1080_vhhueydte__F0000;
            this.ClientSize = new System.Drawing.Size(974, 455);
            this.Controls.Add(this.dg2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTangLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTangLuong";
            this.Load += new System.EventHandler(this.FrmTangLuong_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBoxMaNV;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayTang;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dg2;
        private System.Windows.Forms.ComboBox comboBoxMLM;
        private System.Windows.Forms.TextBox txtgioitinh;
        private System.Windows.Forms.TextBox txtchucvu;
        private System.Windows.Forms.TextBox txtmaluong;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonMoi;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
    }
}