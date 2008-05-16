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
            frmDangNhap DangNhap = new frmDangNhap();
            frmDangNhap DangNhap2 = new frmDangNhap();

            pnMain.Controls.Add(DangNhap);
            pnMain.Controls.Add(DangNhap2);
            //pnMain.Controls["DangNhap"].Visible = false;

        }

        private void bDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnMain.Controls["frmDangNhap"].Visible = false;
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

       
    }
}