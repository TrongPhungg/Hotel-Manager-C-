namespace aa
{
    partial class TimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiem));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTimTheoMaPhong = new System.Windows.Forms.Button();
            this.btnTimPhongTrong = new System.Windows.Forms.Button();
            this.btnTimPhongCoKhach = new System.Windows.Forms.Button();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnTimTheoMaPhong);
            this.flowLayoutPanel1.Controls.Add(this.btnTimPhongTrong);
            this.flowLayoutPanel1.Controls.Add(this.btnTimPhongCoKhach);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(116, 43);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(415, 64);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnTimTheoMaPhong
            // 
            this.btnTimTheoMaPhong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTheoMaPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnTimTheoMaPhong.Image")));
            this.btnTimTheoMaPhong.Location = new System.Drawing.Point(2, 2);
            this.btnTimTheoMaPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimTheoMaPhong.Name = "btnTimTheoMaPhong";
            this.btnTimTheoMaPhong.Size = new System.Drawing.Size(143, 56);
            this.btnTimTheoMaPhong.TabIndex = 2;
            this.btnTimTheoMaPhong.Text = "Tìm Theo Mã Phòng";
            this.btnTimTheoMaPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTimTheoMaPhong.UseVisualStyleBackColor = true;
            this.btnTimTheoMaPhong.Click += new System.EventHandler(this.btnTimTheoMaPhong_Click);
            // 
            // btnTimPhongTrong
            // 
            this.btnTimPhongTrong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimPhongTrong.Image = ((System.Drawing.Image)(resources.GetObject("btnTimPhongTrong.Image")));
            this.btnTimPhongTrong.Location = new System.Drawing.Point(149, 2);
            this.btnTimPhongTrong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimPhongTrong.Name = "btnTimPhongTrong";
            this.btnTimPhongTrong.Size = new System.Drawing.Size(128, 56);
            this.btnTimPhongTrong.TabIndex = 3;
            this.btnTimPhongTrong.Text = "Tìm Phòng Trống";
            this.btnTimPhongTrong.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTimPhongTrong.UseVisualStyleBackColor = true;
            this.btnTimPhongTrong.Click += new System.EventHandler(this.btnTimPhongTrong_Click);
            // 
            // btnTimPhongCoKhach
            // 
            this.btnTimPhongCoKhach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimPhongCoKhach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimPhongCoKhach.Image = ((System.Drawing.Image)(resources.GetObject("btnTimPhongCoKhach.Image")));
            this.btnTimPhongCoKhach.Location = new System.Drawing.Point(281, 2);
            this.btnTimPhongCoKhach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimPhongCoKhach.Name = "btnTimPhongCoKhach";
            this.btnTimPhongCoKhach.Size = new System.Drawing.Size(128, 56);
            this.btnTimPhongCoKhach.TabIndex = 5;
            this.btnTimPhongCoKhach.Text = "Tìm Phòng Có Khách";
            this.btnTimPhongCoKhach.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTimPhongCoKhach.UseVisualStyleBackColor = true;
            this.btnTimPhongCoKhach.Click += new System.EventHandler(this.btnTimPhongCoKhach_Click);
            // 
            // btnTroLai
            // 
            this.btnTroLai.BackColor = System.Drawing.SystemColors.Control;
            this.btnTroLai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroLai.Image = ((System.Drawing.Image)(resources.GetObject("btnTroLai.Image")));
            this.btnTroLai.Location = new System.Drawing.Point(555, 181);
            this.btnTroLai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(113, 31);
            this.btnTroLai.TabIndex = 3;
            this.btnTroLai.Text = "Quay lại";
            this.btnTroLai.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTroLai.UseVisualStyleBackColor = false;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(679, 223);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TimKiem";
            this.Text = "TÌM KIẾM";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnTimTheoMaPhong;
        private System.Windows.Forms.Button btnTimPhongTrong;
        private System.Windows.Forms.Button btnTimPhongCoKhach;
        private System.Windows.Forms.Button btnTroLai;
    }
}