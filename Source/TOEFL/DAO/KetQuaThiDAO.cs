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
        public static KetQuaThiDTO XemBangDiem(string strconnect, string madangky)
        {
            KetQuaThiDTO Kq = new KetQuaThiDTO();

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
                        Kq.MaDangKy = (string)rd["MaDangKy"];
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
                rd.Close();
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

        public static KetQuaThiDTO XemBangDiem(string strconnect, string mathisinh, DateTime ngaythi)
        {
            //chưa test
            KetQuaThiDTO Kq = new KetQuaThiDTO(); 

            SqlConnection cnn = KetNoiCSDL(strconnect);
            SqlTransaction tran = cnn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("spXemBangDiem2", cnn, tran);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@mathisinh", SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@ngaythi", SqlDbType.DateTime);

                cmd.Parameters["@mathisinh"].Value = mathisinh;
                cmd.Parameters["@ngaythi"].Value = ngaythi;

                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    try
                    {
                        Kq.MaKQThi = (int)rd["MaKQThi"];
                        Kq.MaDangKy = (string)rd["MaDangKy"];
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
                rd.Close();
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


        public static string XepLoaiDiem(string strconnect, string phanthi, int diem)
        {
            string Kq = "";

            SqlConnection cnn = KetNoiCSDL(strconnect);
            SqlTransaction tran = cnn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("spXepLoaiDiem", cnn, tran);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@phanthi", SqlDbType.NVarChar, 20);
                cmd.Parameters.Add("@diem", SqlDbType.Int);

                cmd.Parameters["@phanthi"].Value = phanthi;
                cmd.Parameters["@diem"].Value = diem;

                Kq = (string)cmd.ExecuteScalar();
                tran.Commit();
            }
            catch (Exception)
            {
                tran.Rollback();
                throw;
            }

            return Kq;
        }


        public static DataTable ThongKeDiem(string strconnect, DateTime ngaythi, string quocgia)
        {
            DataTable Kq = new DataTable();

            SqlConnection cnn = KetNoiCSDL(strconnect);
            SqlTransaction tran = cnn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("spThongKeDiem", cnn, tran);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ngaythi", SqlDbType.Date);
                cmd.Parameters.Add("@quocgia", SqlDbType.NVarChar, 20);

                cmd.Parameters["@ngaythi"].Value = ngaythi;
                cmd.Parameters["@quocgia"].Value = quocgia;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(Kq);

                tran.Commit();
            }
            catch (SqlException e)
            {
                tran.Rollback();
                throw;
            }

            return Kq;
        }
    }
}
