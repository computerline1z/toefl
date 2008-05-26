using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class KetQuaThiBUS
    {
        public static KetQuaThiDTO XemBangDiem(string strconnect, string madangky)
        {
            return KetQuaThiDAO.XemBangDiem(strconnect, madangky);
        }

        public static KetQuaThiDTO XemBangDiem(string strconnect, string mathisinh, DateTime ngaythi)
        {
            return KetQuaThiDAO.XemBangDiem(strconnect, mathisinh, ngaythi);
        }

        public static string XepLoaiDiem(string strconnect, string phanthi, int diem)
        {
            return KetQuaThiDAO.XepLoaiDiem(strconnect, phanthi, diem);
        }

        public static DataTable ThongKeDiem(string strconnect, DateTime ngaythi, string quocgia)
        {
            return KetQuaThiDAO.ThongKeDiem(strconnect, ngaythi, quocgia);
        }
    }
}
