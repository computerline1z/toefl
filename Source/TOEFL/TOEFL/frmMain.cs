using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BUS;

namespace TOEFL
{
    public partial class frmMain : Form
    {
        public string strconnect = ""; // Chuỗi kết nối CSDL
        private ThiSinhDTO glThiSinh = null;

        //danh sách các user control (toàn cục) được add vào các tabpage
        private frmDangKyTaiKhoan frmDKTK; //= new frmDangKyTaiKhoan(strcon);
        private frmDangKyDuThi frmDKDT = new frmDangKyDuThi();
        private frmXemDiemThi frmXDT = new frmXemDiemThi();
        private frmThongKe frmTK = new frmThongKe();
 
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDKTK = new frmDangKyTaiKhoan(strconnect);
            tabpageDKTaiKhoan.Controls.Add(frmDKTK);
            tabpageDKDuThi.Controls.Add(frmDKDT);
            tabpageXemDiemThi.Controls.Add(frmXDT);
            tabpageThongKe.Controls.Add(frmTK);
            KiemTraKetNoi();

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap DangNhapFrm = new frmDangNhap();
            DangNhapFrm.ShowDialog();
            if (DangNhapFrm.DialogResult == DialogResult.OK)
            {
                glThiSinh = ThiSinhBUS.DangNhap(strconnect, DangNhapFrm.username, DangNhapFrm.password);
            }
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            KiemTraKetNoi();
        }








        //Hàm xử lý
        public SqlConnection KiemTraKetNoi()
        {
            SqlConnection cnn = new SqlConnection();

            frmServer ServerFrm = new frmServer();
            ServerFrm.ShowDialog();

            if (ServerFrm.DialogResult == DialogResult.OK)
            {
                strconnect = ServerFrm.strconnect;

                try
                {
                    cnn = AbstractBUS.KetNoiCSDL(strconnect); // kiểm tra chuỗi kết nối
                    MessageBox.Show("Kết nối server thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }

            return cnn;
        }

        private void btnDKTaiKhoan_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabpageDKTaiKhoan;
        }

        private void btnDKDuThi_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabpageDKDuThi;
        }

        private void btnXemDiemThi_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabpageXemDiemThi;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabpageThongKe;
        }

    }
}