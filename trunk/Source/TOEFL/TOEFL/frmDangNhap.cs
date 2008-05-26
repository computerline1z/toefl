using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace TOEFL
{
    public partial class frmDangNhap : Form
    {
        public string username = "";
        public string password = "";

        public ThiSinhDTO thisinhdto = new ThiSinhDTO();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;
            DialogResult = DialogResult.OK;
        }
    }
}