using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DTO;

namespace DAO
{
    public class ThiSinhDAO : AbstractDAO
    {
        public static string DangKyTaiKhoan(string strconnect, DangKyDTO dtodangky)
        {
            string Kq = ""; //mã thí sinh

            SqlConnection cnn = KetNoiCSDL(strconnect);
            SqlTransaction tran = cnn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("spDangKyTaiKhoan", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception e)
            {
                throw e;
                tran.Rollback();
            }

            cnn.Close();
            return Kq;
        }

        public static ThiSinhDTO DangNhap(string strconnect, string username, string password)
        {
            ThiSinhDTO Kq = new ThiSinhDTO();

            SqlConnection cnn = KetNoiCSDL(strconnect);
            SqlTransaction tran = cnn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("spDangNhap", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@username", SqlDbType.VarChar);
                cmd.Parameters.Add("@password", SqlDbType.VarChar);

                cmd.Parameters["@username"].Value = username;
                cmd.Parameters["@password"].Value = password;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    Kq.MaThiSinh = (string)dt.Rows[0]["MaThiSinh"];
                    Kq.Username = (string)dt.Rows[0]["Username"];
                    Kq.Password = (string)dt.Rows[0]["Password"];
                    Kq.Ho = (string)dt.Rows[0]["Ho"];
                    Kq.TenLot = (string)dt.Rows[0]["TenLot"];
                    Kq.Ten = (string)dt.Rows[0]["Ten"];
                    Kq.NgaySinh = (DateTime)dt.Rows[0]["NgaySinh"];
                    Kq.CMND_PassportID = (string)dt.Rows[0]["CMND_PassportID"];
                    Kq.DiaChi = (string)dt.Rows[0]["DiaChi"];
                    Kq.Email = (string)dt.Rows[0]["Email"];
                    Kq.NgayThiGanNhat = (DateTime)dt.Rows[0]["NgayThiGanNhat"];
                }
                
                tran.Commit();
            }
            catch (Exception e)
            {
                throw e;
                tran.Rollback();
            }

            return Kq;
        }
    }
}
