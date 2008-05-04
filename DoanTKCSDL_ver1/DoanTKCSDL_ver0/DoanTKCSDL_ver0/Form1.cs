using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoanTKCSDL_ver0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            Form fTT = new frmThongTinChinh();
            fTT.TopLevel = false;
            pnMain.Controls.Add(fTT);
            fTT.Show();

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            Form fDN = new frmDangNhap();
            fDN.TopLevel = false;
            pnMain.Controls.Add(fDN);
            fDN.Show();
        }

        private void btnDKTaiKhoan_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            Form fDKTK = new frmDKTaiKhoan();
            fDKTK.TopLevel = false;
            pnMain.Controls.Add(fDKTK);
            fDKTK.Show();
        }

        private void btnDKDuThi_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            Form fDKDT = new frmDKDuThi();
            fDKDT.TopLevel = false;
            pnMain.Controls.Add(fDKDT);
            fDKDT.Show();
        }

        private void btnXemDiemThi_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            Form fXD = new frmXemDiemThi();
            fXD.TopLevel = false;
            pnMain.Controls.Add(fXD);
            fXD.Show();
        }

        private void btnTrangChinh_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            Form fTT = new frmThongTinChinh();
            fTT.TopLevel = false;
            pnMain.Controls.Add(fTT);
            fTT.Show();
        }

        private void btnTKSoLuong_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            Form fTKSL = new frmThongKeSoLuong();
            fTKSL.TopLevel = false;
            pnMain.Controls.Add(fTKSL);
            fTKSL.Show();
        }

        private void btnTKDiem_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            Form fTKD = new frmThongKeDiem();
            fTKD.TopLevel = false;
            pnMain.Controls.Add(fTKD);
            fTKD.Show();
        }
    }
}