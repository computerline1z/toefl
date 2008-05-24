using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DangKyDTO
    {
        #region "Attributes"
        private string _maDangKi;
        private string _maThiSinh;
        private int _maChiTietDotThi;
        private int _maLoaiThe;        
        private string _soThe;        
        private DateTime _ngayHetHan;
        private decimal _tongTienGoiDiem;
        private decimal _tongTienThu;
        #endregion

        #region "Properties"
        public string MaDangKi
        {
            get { return _maDangKi; }
            set { _maDangKi = value; }
        }
        public string MaThiSinh
        {
            get { return _maThiSinh; }
            set { _maThiSinh = value; }
        }
        public int MaChiTietDotThi
        {
            get { return _maChiTietDotThi; }
            set { _maChiTietDotThi = value; }
        }
        public int MaLoaiThe
        {
            get { return _maLoaiThe; }
            set { _maLoaiThe = value; }
        }
        public string SoThe
        {
            get { return _soThe; }
            set { _soThe = value; }
        }
        public DateTime NgayHetHan
        {
            get { return _ngayHetHan; }
            set { _ngayHetHan = value; }
        }
        public decimal TongTienGoiDiem
        {
            get { return _tongTienGoiDiem; }
            set { _tongTienGoiDiem = value; }
        }
        public decimal TongTienThu
        {
            get { return _tongTienThu; }
            set { _tongTienThu = value; }
        }
        #endregion
        #region "Constructor"
        public DangKyDTO()
        {
            MaDangKi = "";
            MaThiSinh = "";
            MaChiTietDotThi = 0;
            MaLoaiThe = 0;
            SoThe = "";
            NgayHetHan = new DateTime();
            TongTienGoiDiem = 0;
            TongTienThu = 0;
        }
        #endregion
    }
}
