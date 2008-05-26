using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DAO;


namespace BUS
{
    public class DangKyBUS
    {
        public static DataTable ThongKeSoLuongDangKyTheoDiaDiem(string strconnect, DateTime thangnam)
        {
            return DangKyDAO.ThongKeSoLuongDangKyTheoDiaDiem(strconnect, thangnam);
        }
    }
}
