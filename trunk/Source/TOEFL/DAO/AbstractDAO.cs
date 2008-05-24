using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Xml;

namespace DAO
{
    public class AbstractDAO
    {
        /*
        public SqlConnection KetNoiCSDL(string IPAddress, string user, string password, string database)
        {
            string cnnString = "";
            cnnString += "Initial Catalog="+database + "; ";
            cnnString += "Data Source=" + IPAddress + "; ";
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
         */

        public static SqlConnection KetNoiCSDL(string strconnect)
        {
            SqlConnection cnn = new SqlConnection(strconnect);
            cnn.Open();
            return cnn;
        }
    }
}
