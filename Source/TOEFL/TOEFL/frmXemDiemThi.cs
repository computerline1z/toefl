using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace TOEFL
{
    public partial class frmXemDiemThi : UserControl
    {
        public frmXemDiemThi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmXemDiemThi_Load(object sender, EventArgs e)
        {

        }

        private void txtMaDangKy_Validated(object sender, EventArgs e)
        {
            txtMaDangKy.SelectAll();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            KetQuaThiDTO Kq = new KetQuaThiDTO();
            ThiSinhDTO Ts = new ThiSinhDTO();

            string strconnect = ((frmMain)((Panel)((TabControl)((TabPage)Parent).Parent).Parent).Parent).strconnect;

            if (txtMaDangKy.Text != "")
            {
                Kq = KetQuaThiBUS.XemBangDiem(strconnect, txtMaDangKy.Text);
            }
            else if (txtMaThiSinh.Text != "" && !(dtpNgayThi.Value is DBNull))
            {
                Kq = KetQuaThiBUS.XemBangDiem(strconnect, txtMaThiSinh.Text, dtpNgayThi.Value);
                Ts = ThiSinhBUS.LayThongTinThiSinh(strconnect, txtMaThiSinh.Text);

                txtHoTen.Text = Ts.Ho + ' ' + Ts.TenLot + ' ' + Ts.Ten;
                txtCMND.Text = Ts.CMND_PassportID;
                txtDiaChi.Text = Ts.DiaChi;
                txtEmail.Text = Ts.Email;
                dtpNgaySinh.Value = Ts.NgaySinh;

                txtDiemNghe.Text = Kq.DiemNghe.ToString();
                txtDiemNoi.Text = Kq.DiemNoi.ToString();
                txtDiemDoc.Text = Kq.DiemDoc.ToString();
                txtDiemViet.Text = Kq.DiemViet.ToString();
                dtpHieuLucDiemThi.Value = Kq.HieuLucDiemThi;

                txtDatLoaiNghe.Text = KetQuaThiBUS.XepLoaiDiem(strconnect, "Nghe", Kq.DiemNghe);
                txtDatLoaiNoi.Text = KetQuaThiBUS.XepLoaiDiem(strconnect, "Nói", Kq.DiemNoi);
                txtDatLoaiDoc.Text = KetQuaThiBUS.XepLoaiDiem(strconnect, "Đọc", Kq.DiemDoc);
                txtDatLoaiViet.Text = KetQuaThiBUS.XepLoaiDiem(strconnect, "Viết", Kq.DiemViet);
            }

            
            

           
        }

      
    }
}
