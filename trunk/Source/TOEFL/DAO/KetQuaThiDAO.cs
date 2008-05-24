using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DTO;

namespace DAO
{
    public class KetQuaThiDAO : AbstractDAO
    {
        public KetQuaThiDTO XemBangDiem(string strconnect, string madangky)
        {
            //chưa test
            KetQuaThiDTO Kq = new KetQuaThiDTO(); //mã thí sinh

            SqlConnection cnn = KetNoiCSDL(strconnect);
            SqlTransaction tran = cnn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("spXemBangDiem", cnn, tran);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@madangky", SqlDbType.VarChar, 10);
                cmd.Parameters["@madangky"].Value = madangky;

                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    try
                    {
                        Kq.MaKQThi = (int)rd["MaKQThi"];
                        Kq.MaDangKi = (string)rd["MaDangKi"];
                        Kq.DiemNghe = (int)rd["DiemNghe"];
                        Kq.DiemNoi = (int)rd["DiemNoi"];
                        Kq.DiemDoc = (int)rd["DiemDoc"];
                        Kq.DiemViet = (int)rd["DiemViet"];
                        Kq.HieuLucDiemThi = (DateTime)rd["HieuLucDiemThi"];
                    }
                    catch (SqlException ex)
                    {
                        throw;
                    }
                }
                tran.Commit();
            }
            catch (SqlException e)
            {   
                tran.Rollback();
                Kq = null;
                throw;
            }

            cnn.Close();
            return Kq;
        }
    }
}
