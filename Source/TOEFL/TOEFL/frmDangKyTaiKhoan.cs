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
    public partial class frmDangKyTaiKhoan : UserControl
    {
        private string strcnn = "";
        public string LayChuoiKetNoi
        {
            set
            {
                strcnn = value;
            }
        }

        public frmDangKyTaiKhoan(string strconnect)
        {
            InitializeComponent();
            LayChuoiKetNoi = strconnect;
        }


        private void btnDongY_Click(object sender, EventArgs e)
        {
            ThiSinhDTO thisinh = new ThiSinhDTO();
            thisinh.Username = txtUsername.Text;
            thisinh.Password = txtPassword.Text;
            thisinh.Ho = txtHo.Text;
            thisinh.TenLot = txtTenLot.Text;
            thisinh.Ten = txtTen.Text;
            thisinh.NgaySinh = dtpNgaySinh.Value;
            thisinh.CMND_PassportID = txtCMND.Text;
            thisinh.DiaChi = txtDiaChi.Text;
            thisinh.Email = txtEmail.Text;

            string strconnect = ((frmMain)((Panel)((TabControl)((TabPage)Parent).Parent).Parent).Parent).strconnect;
           
            try
            {
                thisinh.MaThiSinh = ThiSinhBUS.DangKyTaiKhoan(strconnect, thisinh);
                MessageBox.Show("Đăng nhập thành công !\nMã thí sinh của bạn là : " + thisinh.MaThiSinh);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
