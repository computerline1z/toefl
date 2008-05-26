using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TOEFL
{
    public partial class frmServer : Form
    {
        public string strconnect = "";
        public frmServer()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            strconnect = "Initial Catalog=" + txtCSDL.Text + "; ";
            strconnect += "Data Source=" + txtIP.Text + "; ";
            strconnect += "user=" + txtUsername.Text + "; ";
            strconnect += "password=" + txtPassword.Text + "; ";

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}