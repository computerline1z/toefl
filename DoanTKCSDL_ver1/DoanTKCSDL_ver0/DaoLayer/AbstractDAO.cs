using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Xml;

namespace DaoLayer
{
    public class AbstractDAO
    {
        public SqlConnection KetNoiCSDL(string IPAddress, string user, string password, string database)
        {
            string cnnString = "";
            cnnString += "Initial Catalog="+database + "; ";
            cnnString += "Data Scource=" + IPAddress + "; ";
            cnnString +="user=" + user + "; ";
            cnnString += "password=" + password + "; ";
            SqlConnection cnn = new SqlConnection(cnnString);
            cnn.Open();
            return cnn;
        }
        public void NgatKetNoi(SqlConnection cnn)
        {
            cnn.Close();
        }
        public XmlDocument KetNoiXML()
        {
            // Cau truc cua file Dulieu.xml
            // Gom 9 dong, luu lai thong tin cua ma cua cac bang, vi du: MaGiaoVien, MaMonHoc...
            // Thong tin cua ma gom co 2 thuoc tinh
            // Chuoi: Luu dang cua ma, vi du: MaGiaoVien Chuoi = "GV"
            // ChieuDai: Luu chieu dai toi da cua ma, vi du MaGiaoVien ChieuDai = 4
            // Ma co gia tri value: cho biet hien tai ma da phat sinh den so nao
            XmlDocument KetQua = new XmlDocument();
            KetQua.Load("DuLieu.xml");
            return KetQua;
        }
    }
}
