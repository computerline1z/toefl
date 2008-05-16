using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TOEFL
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pnlDKTaiKhoan.Controls.Add(new frmDangKyTaiKhoan());
            pnlDKDuThi.Controls.Add(new frmDangKyDuThi());
            pnlXemBangDiem.Controls.Add(new frmXemBangDiem());
            pnlTKSoLuong.Controls.Add(new frmThongKeSoLuong());
            pnlTKDiem.Controls.Add(new frmTKDiem());
        }

      
    }
}