namespace TOEFL
{
    partial class frmXemDiemThi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnKhoiTao = new System.Windows.Forms.Button();
            this.txtMaThiSinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaDangKy = new System.Windows.Forms.TextBox();
            this.dtpNgayThi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiemNghe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiemNoi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiemDoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiemViet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpHieuLucDiemThi = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDatLoaiNghe = new System.Windows.Forms.TextBox();
            this.txtDatLoaiNoi = new System.Windows.Forms.TextBox();
            this.txtDatLoaiDoc = new System.Windows.Forms.TextBox();
            this.txtDatLoaiViet = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thí sinh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnKhoiTao
            // 
            this.btnKhoiTao.Location = new System.Drawing.Point(297, 463);
            this.btnKhoiTao.Name = "btnKhoiTao";
            this.btnKhoiTao.Size = new System.Drawing.Size(75, 23);
            this.btnKhoiTao.TabIndex = 5;
            this.btnKhoiTao.Text = "Khởi tạo";
            this.btnKhoiTao.UseVisualStyleBackColor = true;
            // 
            // txtMaThiSinh
            // 
            this.txtMaThiSinh.Location = new System.Drawing.Point(383, 40);
            this.txtMaThiSinh.Name = "txtMaThiSinh";
            this.txtMaThiSinh.Size = new System.Drawing.Size(123, 20);
            this.txtMaThiSinh.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày thi";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã đăng ký";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMaDangKy
            // 
            this.txtMaDangKy.Location = new System.Drawing.Point(111, 43);
            this.txtMaDangKy.Name = "txtMaDangKy";
            this.txtMaDangKy.Size = new System.Drawing.Size(123, 20);
            this.txtMaDangKy.TabIndex = 1;
            this.txtMaDangKy.Validated += new System.EventHandler(this.txtMaDangKy_Validated);
            // 
            // dtpNgayThi
            // 
            this.dtpNgayThi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThi.Location = new System.Drawing.Point(383, 66);
            this.dtpNgayThi.Name = "dtpNgayThi";
            this.dtpNgayThi.Size = new System.Drawing.Size(123, 20);
            this.dtpNgayThi.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điểm nghe";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDiemNghe
            // 
            this.txtDiemNghe.Enabled = false;
            this.txtDiemNghe.Location = new System.Drawing.Point(203, 261);
            this.txtDiemNghe.Name = "txtDiemNghe";
            this.txtDiemNghe.Size = new System.Drawing.Size(123, 20);
            this.txtDiemNghe.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Điểm nói";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDiemNoi
            // 
            this.txtDiemNoi.Enabled = false;
            this.txtDiemNoi.Location = new System.Drawing.Point(203, 296);
            this.txtDiemNoi.Name = "txtDiemNoi";
            this.txtDiemNoi.Size = new System.Drawing.Size(123, 20);
            this.txtDiemNoi.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Điểm đọc";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDiemDoc
            // 
            this.txtDiemDoc.Enabled = false;
            this.txtDiemDoc.Location = new System.Drawing.Point(203, 333);
            this.txtDiemDoc.Name = "txtDiemDoc";
            this.txtDiemDoc.Size = new System.Drawing.Size(123, 20);
            this.txtDiemDoc.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Điểm viết";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDiemViet
            // 
            this.txtDiemViet.Enabled = false;
            this.txtDiemViet.Location = new System.Drawing.Point(203, 370);
            this.txtDiemViet.Name = "txtDiemViet";
            this.txtDiemViet.Size = new System.Drawing.Size(123, 20);
            this.txtDiemViet.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Hiệu lực điểm thi";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpHieuLucDiemThi
            // 
            this.dtpHieuLucDiemThi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHieuLucDiemThi.Location = new System.Drawing.Point(334, 418);
            this.dtpHieuLucDiemThi.Name = "dtpHieuLucDiemThi";
            this.dtpHieuLucDiemThi.Size = new System.Drawing.Size(123, 20);
            this.dtpHieuLucDiemThi.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(354, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Đạt loại";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDatLoaiNghe
            // 
            this.txtDatLoaiNghe.Enabled = false;
            this.txtDatLoaiNghe.Location = new System.Drawing.Point(420, 261);
            this.txtDatLoaiNghe.Name = "txtDatLoaiNghe";
            this.txtDatLoaiNghe.Size = new System.Drawing.Size(123, 20);
            this.txtDatLoaiNghe.TabIndex = 2;
            // 
            // txtDatLoaiNoi
            // 
            this.txtDatLoaiNoi.Enabled = false;
            this.txtDatLoaiNoi.Location = new System.Drawing.Point(420, 296);
            this.txtDatLoaiNoi.Name = "txtDatLoaiNoi";
            this.txtDatLoaiNoi.Size = new System.Drawing.Size(123, 20);
            this.txtDatLoaiNoi.TabIndex = 2;
            // 
            // txtDatLoaiDoc
            // 
            this.txtDatLoaiDoc.Enabled = false;
            this.txtDatLoaiDoc.Location = new System.Drawing.Point(420, 331);
            this.txtDatLoaiDoc.Name = "txtDatLoaiDoc";
            this.txtDatLoaiDoc.Size = new System.Drawing.Size(123, 20);
            this.txtDatLoaiDoc.TabIndex = 2;
            // 
            // txtDatLoaiViet
            // 
            this.txtDatLoaiViet.Enabled = false;
            this.txtDatLoaiViet.Location = new System.Drawing.Point(420, 366);
            this.txtDatLoaiViet.Name = "txtDatLoaiViet";
            this.txtDatLoaiViet.Size = new System.Drawing.Size(123, 20);
            this.txtDatLoaiViet.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(354, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Đạt loại";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(354, 373);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Đạt loại";
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Enabled = false;
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(154, 163);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(165, 20);
            this.dtpNgaySinh.TabIndex = 17;
            // 
            // txtCMND
            // 
            this.txtCMND.Enabled = false;
            this.txtCMND.Location = new System.Drawing.Point(445, 164);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(165, 20);
            this.txtCMND.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(154, 199);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(165, 20);
            this.txtDiaChi.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(445, 199);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(165, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(399, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Email";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(100, 202);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Địa chỉ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(338, 167);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "CMND/Số hộ chiếu";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(86, 166);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Ngày sinh";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Location = new System.Drawing.Point(179, 129);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(162, 20);
            this.txtHoTen.TabIndex = 12;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(115, 132);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "Họ tên";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(159, 70);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 4;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(354, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Đạt loại";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmXemDiemThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.dtpHieuLucDiemThi);
            this.Controls.Add(this.dtpNgayThi);
            this.Controls.Add(this.txtMaDangKy);
            this.Controls.Add(this.txtDiemViet);
            this.Controls.Add(this.txtDiemDoc);
            this.Controls.Add(this.txtDatLoaiViet);
            this.Controls.Add(this.txtDatLoaiNoi);
            this.Controls.Add(this.txtDatLoaiDoc);
            this.Controls.Add(this.txtDiemNoi);
            this.Controls.Add(this.txtDatLoaiNghe);
            this.Controls.Add(this.txtDiemNghe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaThiSinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnKhoiTao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmXemDiemThi";
            this.Size = new System.Drawing.Size(672, 515);
            this.Load += new System.EventHandler(this.frmXemDiemThi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKhoiTao;
        private System.Windows.Forms.TextBox txtMaThiSinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaDangKy;
        private System.Windows.Forms.DateTimePicker dtpNgayThi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiemNghe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiemNoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiemDoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiemViet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpHieuLucDiemThi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDatLoaiNghe;
        private System.Windows.Forms.TextBox txtDatLoaiNoi;
        private System.Windows.Forms.TextBox txtDatLoaiDoc;
        private System.Windows.Forms.TextBox txtDatLoaiViet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label label10;
    }
}
