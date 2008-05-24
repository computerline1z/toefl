using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class ThiSinhBUS
    {
        public static string DangKyTaiKhoan(string strconnect, ThiSinhDTO thisinh)
        {
            //return mã đăng ký
            return ThiSinhDAO.DangKyTaiKhoan(strconnect, thisinh);
        }

        public static ThiSinhDTO DangNhap(string strconnect, string username, string password)
        {
            return ThiSinhDAO.DangNhap(strconnect, username, password);
        }
    }
}
