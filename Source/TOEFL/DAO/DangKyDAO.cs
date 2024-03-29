using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DTO;

namespace DAO
{
    public class DangKyDAO : AbstractDAO
    {
        public static DataTable ThongKeSoLuongDangKyTheoDiaDiem(string strconnect, DateTime thangnam)
        {
            DataTable Kq = new DataTable();

            SqlConnection cnn = KetNoiCSDL(strconnect);
            SqlTransaction tran = cnn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("spThongKeThiSinhTheoDiaDiem", cnn, tran);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ngaythi", SqlDbType.DateTime);
                cmd.Parameters["@ngaythi"].Value = thangnam;


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(Kq);

                tran.Commit();
            }
            catch (SqlException e)
            {
                tran.Rollback();
                throw;
            }

            cnn.Close();
            return Kq;
        }
    }
}
