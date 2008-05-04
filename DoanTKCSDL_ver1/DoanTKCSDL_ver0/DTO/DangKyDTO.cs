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
        private string _maChiTietDotThi;       
        private string _truong1;        
        private string _truong2;       
        private string _truong3;        
        private string _truong4;        
        private string _maLoaiThe;        
        private string _soThe;        
        private DateTime _ngayHetHan;     
        private double _tongTienThu;
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
        public string MaChiTietDotThi
        {
            get { return _maChiTietDotThi; }
            set { _maChiTietDotThi = value; }
        }
        public string Truong1
        {
            get { return _truong1; }
            set { _truong1 = value; }
        }
        public string Truong2
        {
            get { return _truong2; }
            set { _truong2 = value; }
        }
        public string Truong3
        {
            get { return _truong3; }
            set { _truong3 = value; }
        }
        public string Truong4
        {
            get { return _truong4; }
            set { _truong4 = value; }
        }
        public string MaLoaiThe
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
        public double TongTienThu
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
            MaChiTietDotThi = "";
            Truong1 = "";
            Truong2 = "";
            Truong3 = "";
            Truong4 = "";
            MaLoaiThe = "";
            SoThe = "";
            NgayHetHan = new DateTime();
            TongTienThu = 0;
        }
        #endregion
    }
}
