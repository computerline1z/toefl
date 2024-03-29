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
        public static string DangKyTaiKhoan(string strconnect, ThiSinhDTO thisinh)
        {
            string Kq = ""; //mã thí sinh

            SqlConnection cnn = KetNoiCSDL(strconnect);
            SqlTransaction tran = cnn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("spDangKyTaiKhoan", cnn, tran);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Username", SqlDbType.VarChar);
                cmd.Parameters.Add("@Password", SqlDbType.VarChar);
                cmd.Parameters.Add("@Ho", SqlDbType.NVarChar);
                cmd.Parameters.Add("@TenLot", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar);
                cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime);
                cmd.Parameters.Add("@Cmnd_pid", SqlDbType.VarChar);
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Email", SqlDbType.VarChar);
                cmd.Parameters.Add("@NgayThiGanNhat", SqlDbType.DateTime);

                cmd.Parameters["@Username"].Value = thisinh.Username;
                cmd.Parameters["@Password"].Value = thisinh.Password;
                cmd.Parameters["@Ho"].Value = thisinh.Ho;
                cmd.Parameters["@TenLot"].Value = thisinh.TenLot;
                cmd.Parameters["@Ten"].Value = thisinh.Ten;
                cmd.Parameters["@NgaySinh"].Value = thisinh.NgaySinh;
                cmd.Parameters["@Cmnd_pid"].Value = thisinh.CMND_PassportID;
                cmd.Parameters["@DiaChi"].Value = thisinh.DiaChi;
                cmd.Parameters["@Email"].Value = thisinh.Email;
                cmd.Parameters["@NgayThiGanNhat"].Value = new DateTime(1900, 1, 1);
                
                cmd.Parameters.Add("@MaThiSinh", SqlDbType.VarChar, 10);
                cmd.Parameters["@MaThiSinh"].Direction = ParameterDirection.Output;
                
                cmd.ExecuteNonQuery();
                Kq = (string)cmd.Parameters["@MaThiSinh"].Value;

                tran.Commit();
            }
            catch (SqlException)
            {
                throw;
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
                SqlCommand cmd = new SqlCommand("spDangNhap", cnn, tran);
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
                    if (dt.Rows[0]["NgayThiGanNhat"] is DBNull)
                        Kq.NgayThiGanNhat = new DateTime(); // 1/1/01
                    else
                        Kq.NgayThiGanNhat = (DateTime)dt.Rows[0]["NgayThiGanNhat"];
                }
                
                tran.Commit();
            }
            catch (Exception e)
            {
                throw;
                tran.Rollback();
            }

            return Kq;
        }

        public static ThiSinhDTO LayThongTinThiSinh(string strconnect, string mathisinh)
        {
            ThiSinhDTO Kq = new ThiSinhDTO();

            SqlConnection cnn = KetNoiCSDL(strconnect);
            SqlTransaction tran = cnn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("spLayThongTinThiSinh", cnn, tran);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@mathisinh", SqlDbType.VarChar, 10);
                cmd.Parameters["@mathisinh"].Value = mathisinh;

                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    Kq.MaThiSinh = (string)rd["MaThiSinh"];
                    Kq.Username = (string)rd["Username"];
                    Kq.Password = (string)rd["Password"];
                    Kq.Ho = (string)rd["Ho"];
                    Kq.TenLot = (string)rd["TenLot"];
                    Kq.Ten = (string)rd["Ten"];
                    Kq.NgaySinh = (DateTime)rd["NgaySinh"];
                    Kq.CMND_PassportID = (string)rd["CMND_PassportID"];
                    Kq.DiaChi = (string)rd["DiaChi"];
                    Kq.Email = (string)rd["Email"];
                    if (rd["NgayThiGanNhat"] is DBNull)
                        Kq.NgayThiGanNhat = new DateTime(); // 1/1/01
                    else
                        Kq.NgayThiGanNhat = (DateTime)rd["NgayThiGanNhat"];
                }

                rd.Close();
                tran.Commit();
            }
            catch(Exception)
            {
                tran.Rollback();
                throw;
            }
            return Kq;
        }
    }
}
