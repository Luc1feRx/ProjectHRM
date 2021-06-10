namespace QuanLyNhanSu
{
    partial class FrmBoPhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBoPhan));
            this.dataGridViewBoPhan = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonLamMoi = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerTL = new System.Windows.Forms.DateTimePicker();
            this.textBoxMaBoPhan = new System.Windows.Forms.TextBox();
            this.textBoxGhiChu = new System.Windows.Forms.TextBox();
            this.textBoxTenBP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoPhan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBoPhan
            // 
            this.dataGridViewBoPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBoPhan.Location = new System.Drawing.Point(13, 266);
            this.dataGridViewBoPhan.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewBoPhan.Name = "dataGridViewBoPhan";
            this.dataGridViewBoPhan.RowHeadersWidth = 51;
            this.dataGridViewBoPhan.Size = new System.Drawing.Size(911, 239);
            this.dataGridViewBoPhan.TabIndex = 2;
            this.dataGridViewBoPhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBoPhan_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.buttonLamMoi);
            this.groupBox2.Controls.Add(this.buttonThoat);
            this.groupBox2.Controls.Add(this.buttonXoa);
            this.groupBox2.Controls.Add(this.buttonThem);
            this.groupBox2.Controls.Add(this.buttonSua);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 160);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(911, 85);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "các chức năng";
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLamMoi.FlatAppearance.BorderSize = 0;
            this.buttonLamMoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLamMoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLamMoi.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonLamMoi.Location = new System.Drawing.Point(129, 18);
            this.buttonLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.Size = new System.Drawing.Size(112, 43);
            this.buttonLamMoi.TabIndex = 0;
            this.buttonLamMoi.Text = "Mới   ";
            this.buttonLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLamMoi.UseVisualStyleBackColor = true;
            this.buttonLamMoi.Click += new System.EventHandler(this.buttonLamMoi_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonThoat.BackgroundImage")));
            this.buttonThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonThoat.FlatAppearance.BorderSize = 0;
            this.buttonThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThoat.Location = new System.Drawing.Point(692, 18);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(112, 43);
            this.buttonThoat.TabIndex = 5;
            this.buttonThoat.Text = "Thoát ";
            this.buttonThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.buttonXoa.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonXoa.Location = new System.Drawing.Point(556, 18);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(112, 43);
            this.buttonXoa.TabIndex = 3;
            this.buttonXoa.Text = "Xóa   ";
            this.buttonXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonThem.BackgroundImage")));
            this.buttonThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonThem.FlatAppearance.BorderSize = 0;
            this.buttonThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThem.Location = new System.Drawing.Point(265, 18);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(112, 43);
            this.buttonThem.TabIndex = 1;
            this.buttonThem.Text = "Thêm ";
            this.buttonThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSua.BackgroundImage")));
            this.buttonSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSua.FlatAppearance.BorderSize = 0;
            this.buttonSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSua.Location = new System.Drawing.Point(411, 18);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(112, 43);
            this.buttonSua.TabIndex = 2;
            this.buttonSua.Text = "Sửa   ";
            this.buttonSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePickerTL);
            this.groupBox1.Controls.Add(this.textBoxMaBoPhan);
            this.groupBox1.Controls.Add(this.textBoxGhiChu);
            this.groupBox1.Controls.Add(this.textBoxTenBP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(911, 140);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin về bộ phận";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày thành lập";
            // 
            // dateTimePickerTL
            // 
            this.dateTimePickerTL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTL.Location = new System.Drawing.Point(160, 86);
            this.dateTimePickerTL.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerTL.Name = "dateTimePickerTL";
            this.dateTimePickerTL.Size = new System.Drawing.Size(207, 25);
            this.dateTimePickerTL.TabIndex = 4;
            // 
            // textBoxMaBoPhan
            // 
            this.textBoxMaBoPhan.Location = new System.Drawing.Point(160, 39);
            this.textBoxMaBoPhan.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaBoPhan.Name = "textBoxMaBoPhan";
            this.textBoxMaBoPhan.Size = new System.Drawing.Size(207, 25);
            this.textBoxMaBoPhan.TabIndex = 3;
            // 
            // textBoxGhiChu
            // 
            this.textBoxGhiChu.Location = new System.Drawing.Point(532, 82);
            this.textBoxGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGhiChu.Multiline = true;
            this.textBoxGhiChu.Name = "textBoxGhiChu";
            this.textBoxGhiChu.Size = new System.Drawing.Size(207, 36);
            this.textBoxGhiChu.TabIndex = 1;
            // 
            // textBoxTenBP
            // 
            this.textBoxTenBP.Location = new System.Drawing.Point(532, 39);
            this.textBoxTenBP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTenBP.Name = "textBoxTenBP";
            this.textBoxTenBP.Size = new System.Drawing.Size(207, 25);
            this.textBoxTenBP.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ghi chú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên bộ phận";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bộ phận";
            // 
            // FrmBoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 518);
            this.Controls.Add(this.dataGridViewBoPhan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmBoPhan";
            this.Text = "FrmBoPhan";
            this.Load += new System.EventHandler(this.FrmBoPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoPhan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBoPhan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonLamMoi;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerTL;
        private System.Windows.Forms.TextBox textBoxMaBoPhan;
        private System.Windows.Forms.TextBox textBoxGhiChu;
        private System.Windows.Forms.TextBox textBoxTenBP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}