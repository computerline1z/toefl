namespace DoanTKCSDL_ver0
{
    partial class Form1
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
            this.btnTKDiem = new System.Windows.Forms.Button();
            this.btnTKSoLuong = new System.Windows.Forms.Button();
            this.btnXemDiemThi = new System.Windows.Forms.Button();
            this.btnDKDuThi = new System.Windows.Forms.Button();
            this.btnDKTaiKhoan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTrangChinh = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTKDiem
            // 
            this.btnTKDiem.Location = new System.Drawing.Point(19, 336);
            this.btnTKDiem.Name = "btnTKDiem";
            this.btnTKDiem.Size = new System.Drawing.Size(132, 47);
            this.btnTKDiem.TabIndex = 2;
            this.btnTKDiem.Text = "Thống kê điểm";
            this.btnTKDiem.UseVisualStyleBackColor = true;
            this.btnTKDiem.Click += new System.EventHandler(this.btnTKDiem_Click);
            // 
            // btnTKSoLuong
            // 
            this.btnTKSoLuong.Location = new System.Drawing.Point(19, 283);
            this.btnTKSoLuong.Name = "btnTKSoLuong";
            this.btnTKSoLuong.Size = new System.Drawing.Size(132, 47);
            this.btnTKSoLuong.TabIndex = 2;
            this.btnTKSoLuong.Text = "Thống kê số lượng";
            this.btnTKSoLuong.UseVisualStyleBackColor = true;
            this.btnTKSoLuong.Click += new System.EventHandler(this.btnTKSoLuong_Click);
            // 
            // btnXemDiemThi
            // 
            this.btnXemDiemThi.Location = new System.Drawing.Point(19, 230);
            this.btnXemDiemThi.Name = "btnXemDiemThi";
            this.btnXemDiemThi.Size = new System.Drawing.Size(132, 47);
            this.btnXemDiemThi.TabIndex = 2;
            this.btnXemDiemThi.Text = "Xem điểm thi";
            this.btnXemDiemThi.UseVisualStyleBackColor = true;
            this.btnXemDiemThi.Click += new System.EventHandler(this.btnXemDiemThi_Click);
            // 
            // btnDKDuThi
            // 
            this.btnDKDuThi.Location = new System.Drawing.Point(19, 177);
            this.btnDKDuThi.Name = "btnDKDuThi";
            this.btnDKDuThi.Size = new System.Drawing.Size(132, 47);
            this.btnDKDuThi.TabIndex = 2;
            this.btnDKDuThi.Text = "Đăng ký dự thi";
            this.btnDKDuThi.UseVisualStyleBackColor = true;
            this.btnDKDuThi.Click += new System.EventHandler(this.btnDKDuThi_Click);
            // 
            // btnDKTaiKhoan
            // 
            this.btnDKTaiKhoan.Location = new System.Drawing.Point(19, 124);
            this.btnDKTaiKhoan.Name = "btnDKTaiKhoan";
            this.btnDKTaiKhoan.Size = new System.Drawing.Size(132, 47);
            this.btnDKTaiKhoan.TabIndex = 2;
            this.btnDKTaiKhoan.Text = "Đăng ký tài khoản";
            this.btnDKTaiKhoan.UseVisualStyleBackColor = true;
            this.btnDKTaiKhoan.Click += new System.EventHandler(this.btnDKTaiKhoan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ DỮ LIỆU THÍ SINH THI TOEFL";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(19, 71);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(132, 47);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng nhập / Đăng xuất";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // pnMain
            // 
            this.pnMain.Location = new System.Drawing.Point(179, 75);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(696, 434);
            this.pnMain.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btnTKDiem);
            this.panel2.Controls.Add(this.btnTKSoLuong);
            this.panel2.Controls.Add(this.btnXemDiemThi);
            this.panel2.Controls.Add(this.btnDKDuThi);
            this.panel2.Controls.Add(this.btnDKTaiKhoan);
            this.panel2.Controls.Add(this.btnTrangChinh);
            this.panel2.Controls.Add(this.btnDangNhap);
            this.panel2.Location = new System.Drawing.Point(3, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 434);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 57);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "\"chào\"";
            // 
            // btnTrangChinh
            // 
            this.btnTrangChinh.Location = new System.Drawing.Point(19, 18);
            this.btnTrangChinh.Name = "btnTrangChinh";
            this.btnTrangChinh.Size = new System.Drawing.Size(132, 47);
            this.btnTrangChinh.TabIndex = 2;
            this.btnTrangChinh.Text = "Trang chính";
            this.btnTrangChinh.UseVisualStyleBackColor = true;
            this.btnTrangChinh.Click += new System.EventHandler(this.btnTrangChinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 528);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTKDiem;
        private System.Windows.Forms.Button btnTKSoLuong;
        private System.Windows.Forms.Button btnXemDiemThi;
        private System.Windows.Forms.Button btnDKDuThi;
        private System.Windows.Forms.Button btnDKTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTrangChinh;

    }
}

