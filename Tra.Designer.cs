namespace aa
{
    partial class Tra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTienphong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDSPhong = new System.Windows.Forms.DataGridView();
            this.clMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTivi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMayLanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.grDichvu = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.slGiatui = new System.Windows.Forms.NumericUpDown();
            this.slMassage = new System.Windows.Forms.NumericUpDown();
            this.slGoidau = new System.Windows.Forms.NumericUpDown();
            this.lbTongtien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Giatui = new System.Windows.Forms.CheckBox();
            this.cb_Massage = new System.Windows.Forms.CheckBox();
            this.cb_Goidau = new System.Windows.Forms.CheckBox();
            this.grTongtien = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhong)).BeginInit();
            this.grDichvu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slGiatui)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slMassage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slGoidau)).BeginInit();
            this.grTongtien.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grTongtien);
            this.panel1.Controls.Add(this.dgvKhachHang);
            this.panel1.Controls.Add(this.dgvDSPhong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 413);
            this.panel1.TabIndex = 2;
            // 
            // lbTienphong
            // 
            this.lbTienphong.AutoSize = true;
            this.lbTienphong.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienphong.Location = new System.Drawing.Point(198, 18);
            this.lbTienphong.Name = "lbTienphong";
            this.lbTienphong.Size = new System.Drawing.Size(25, 24);
            this.lbTienphong.TabIndex = 37;
            this.lbTienphong.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tổng tiền phòng :";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvKhachHang.Location = new System.Drawing.Point(8, 196);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(899, 147);
            this.dgvKhachHang.TabIndex = 36;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Ma";
            this.Column6.HeaderText = "Mã";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ThoiGianRa";
            this.Column7.HeaderText = "Thời Gian Ra";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "GioiTinh";
            this.Column8.HeaderText = "Giới Tính";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Hoten";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Ngaysinh";
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Soluong";
            this.Column4.HeaderText = "Số lượng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ThoiGianVao";
            this.Column5.HeaderText = "Thời gian vào";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // dgvDSPhong
            // 
            this.dgvDSPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDSPhong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDSPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaPhong,
            this.clBan,
            this.clGhe,
            this.clTivi,
            this.clMayLanh,
            this.clGiaTien,
            this.clTinhTrang});
            this.dgvDSPhong.GridColor = System.Drawing.Color.White;
            this.dgvDSPhong.Location = new System.Drawing.Point(11, 26);
            this.dgvDSPhong.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSPhong.Name = "dgvDSPhong";
            this.dgvDSPhong.ReadOnly = true;
            this.dgvDSPhong.RowHeadersWidth = 51;
            this.dgvDSPhong.RowTemplate.Height = 24;
            this.dgvDSPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSPhong.Size = new System.Drawing.Size(896, 141);
            this.dgvDSPhong.TabIndex = 35;
            // 
            // clMaPhong
            // 
            this.clMaPhong.DataPropertyName = "MaPhong";
            this.clMaPhong.HeaderText = "Mã Phòng";
            this.clMaPhong.MinimumWidth = 6;
            this.clMaPhong.Name = "clMaPhong";
            this.clMaPhong.ReadOnly = true;
            this.clMaPhong.Width = 125;
            // 
            // clBan
            // 
            this.clBan.DataPropertyName = "Ban";
            this.clBan.HeaderText = "Bàn";
            this.clBan.MinimumWidth = 6;
            this.clBan.Name = "clBan";
            this.clBan.ReadOnly = true;
            this.clBan.Width = 125;
            // 
            // clGhe
            // 
            this.clGhe.DataPropertyName = "Ghe";
            this.clGhe.HeaderText = "Ghế";
            this.clGhe.MinimumWidth = 6;
            this.clGhe.Name = "clGhe";
            this.clGhe.ReadOnly = true;
            this.clGhe.Width = 125;
            // 
            // clTivi
            // 
            this.clTivi.DataPropertyName = "Tivi";
            this.clTivi.HeaderText = "Tivi";
            this.clTivi.MinimumWidth = 6;
            this.clTivi.Name = "clTivi";
            this.clTivi.ReadOnly = true;
            this.clTivi.Width = 125;
            // 
            // clMayLanh
            // 
            this.clMayLanh.DataPropertyName = "MayLanh";
            this.clMayLanh.HeaderText = "Máy Lạnh";
            this.clMayLanh.MinimumWidth = 6;
            this.clMayLanh.Name = "clMayLanh";
            this.clMayLanh.ReadOnly = true;
            this.clMayLanh.Width = 125;
            // 
            // clGiaTien
            // 
            this.clGiaTien.DataPropertyName = "GiaTien";
            this.clGiaTien.HeaderText = "Giá Tiền";
            this.clGiaTien.MinimumWidth = 6;
            this.clGiaTien.Name = "clGiaTien";
            this.clGiaTien.ReadOnly = true;
            this.clGiaTien.Width = 125;
            // 
            // clTinhTrang
            // 
            this.clTinhTrang.DataPropertyName = "TinhTrang";
            this.clTinhTrang.HeaderText = "Tình Trạng";
            this.clTinhTrang.MinimumWidth = 6;
            this.clTinhTrang.Name = "clTinhTrang";
            this.clTinhTrang.ReadOnly = true;
            this.clTinhTrang.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thông Tin Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông Tin Phòng";
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnTraPhong.Image")));
            this.btnTraPhong.Location = new System.Drawing.Point(1054, 383);
            this.btnTraPhong.Margin = new System.Windows.Forms.Padding(2);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(145, 37);
            this.btnTraPhong.TabIndex = 5;
            this.btnTraPhong.Text = "Trả Phòng";
            this.btnTraPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTraPhong.UseVisualStyleBackColor = true;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // btnTroLai
            // 
            this.btnTroLai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroLai.Image = ((System.Drawing.Image)(resources.GetObject("btnTroLai.Image")));
            this.btnTroLai.Location = new System.Drawing.Point(1226, 383);
            this.btnTroLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(110, 37);
            this.btnTroLai.TabIndex = 6;
            this.btnTroLai.Text = "Quay lại";
            this.btnTroLai.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // grDichvu
            // 
            this.grDichvu.BackColor = System.Drawing.SystemColors.Info;
            this.grDichvu.Controls.Add(this.pictureBox3);
            this.grDichvu.Controls.Add(this.pictureBox2);
            this.grDichvu.Controls.Add(this.pictureBox1);
            this.grDichvu.Controls.Add(this.slGiatui);
            this.grDichvu.Controls.Add(this.slMassage);
            this.grDichvu.Controls.Add(this.slGoidau);
            this.grDichvu.Controls.Add(this.lbTongtien);
            this.grDichvu.Controls.Add(this.label3);
            this.grDichvu.Controls.Add(this.cb_Giatui);
            this.grDichvu.Controls.Add(this.cb_Massage);
            this.grDichvu.Controls.Add(this.cb_Goidau);
            this.grDichvu.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grDichvu.Location = new System.Drawing.Point(986, 18);
            this.grDichvu.Name = "grDichvu";
            this.grDichvu.Size = new System.Drawing.Size(350, 334);
            this.grDichvu.TabIndex = 7;
            this.grDichvu.TabStop = false;
            this.grDichvu.Text = "Dịch vụ thêm";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 209);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 68);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 71);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 73);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // slGiatui
            // 
            this.slGiatui.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slGiatui.Location = new System.Drawing.Point(303, 226);
            this.slGiatui.Name = "slGiatui";
            this.slGiatui.Size = new System.Drawing.Size(41, 26);
            this.slGiatui.TabIndex = 7;
            this.slGiatui.ValueChanged += new System.EventHandler(this.slGiatui_ValueChanged);
            // 
            // slMassage
            // 
            this.slMassage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slMassage.Location = new System.Drawing.Point(303, 138);
            this.slMassage.Name = "slMassage";
            this.slMassage.Size = new System.Drawing.Size(41, 26);
            this.slMassage.TabIndex = 6;
            this.slMassage.ValueChanged += new System.EventHandler(this.slMassage_ValueChanged);
            // 
            // slGoidau
            // 
            this.slGoidau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slGoidau.Location = new System.Drawing.Point(303, 51);
            this.slGoidau.Name = "slGoidau";
            this.slGoidau.Size = new System.Drawing.Size(41, 26);
            this.slGoidau.TabIndex = 5;
            this.slGoidau.ValueChanged += new System.EventHandler(this.slGoidau_ValueChanged);
            // 
            // lbTongtien
            // 
            this.lbTongtien.AutoSize = true;
            this.lbTongtien.Location = new System.Drawing.Point(248, 296);
            this.lbTongtien.Name = "lbTongtien";
            this.lbTongtien.Size = new System.Drawing.Size(25, 24);
            this.lbTongtien.TabIndex = 4;
            this.lbTongtien.Text = "...";
            this.lbTongtien.Click += new System.EventHandler(this.lbTongtien_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tổng tiền dịch vụ :";
            // 
            // cb_Giatui
            // 
            this.cb_Giatui.AutoSize = true;
            this.cb_Giatui.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Giatui.Location = new System.Drawing.Point(87, 228);
            this.cb_Giatui.Name = "cb_Giatui";
            this.cb_Giatui.Size = new System.Drawing.Size(67, 23);
            this.cb_Giatui.TabIndex = 2;
            this.cb_Giatui.Text = "Giặt ủi";
            this.cb_Giatui.UseVisualStyleBackColor = true;
            // 
            // cb_Massage
            // 
            this.cb_Massage.AutoSize = true;
            this.cb_Massage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Massage.Location = new System.Drawing.Point(87, 139);
            this.cb_Massage.Name = "cb_Massage";
            this.cb_Massage.Size = new System.Drawing.Size(119, 23);
            this.cb_Massage.TabIndex = 1;
            this.cb_Massage.Text = "Massage Body";
            this.cb_Massage.UseVisualStyleBackColor = true;
            // 
            // cb_Goidau
            // 
            this.cb_Goidau.AutoSize = true;
            this.cb_Goidau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Goidau.Location = new System.Drawing.Point(87, 54);
            this.cb_Goidau.Name = "cb_Goidau";
            this.cb_Goidau.Size = new System.Drawing.Size(146, 23);
            this.cb_Goidau.TabIndex = 0;
            this.cb_Goidau.Text = "Gội đầu dưỡng sinh";
            this.cb_Goidau.UseVisualStyleBackColor = true;
            // 
            // grTongtien
            // 
            this.grTongtien.BackColor = System.Drawing.SystemColors.Control;
            this.grTongtien.Controls.Add(this.label4);
            this.grTongtien.Controls.Add(this.lbTienphong);
            this.grTongtien.Location = new System.Drawing.Point(604, 356);
            this.grTongtien.Name = "grTongtien";
            this.grTongtien.Size = new System.Drawing.Size(303, 45);
            this.grTongtien.TabIndex = 38;
            this.grTongtien.TabStop = false;
            // 
            // Tra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1352, 426);
            this.Controls.Add(this.grDichvu);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.btnTraPhong);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Tra";
            this.Text = "TRẢ PHÒNG";
            this.Load += new System.EventHandler(this.Tra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhong)).EndInit();
            this.grDichvu.ResumeLayout(false);
            this.grDichvu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slGiatui)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slMassage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slGoidau)).EndInit();
            this.grTongtien.ResumeLayout(false);
            this.grTongtien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.DataGridView dgvDSPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTivi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMayLanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTinhTrang;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox grDichvu;
        private System.Windows.Forms.CheckBox cb_Giatui;
        private System.Windows.Forms.CheckBox cb_Massage;
        private System.Windows.Forms.CheckBox cb_Goidau;
        private System.Windows.Forms.NumericUpDown slGiatui;
        private System.Windows.Forms.NumericUpDown slMassage;
        private System.Windows.Forms.NumericUpDown slGoidau;
        private System.Windows.Forms.Label lbTongtien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbTienphong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grTongtien;
    }
}