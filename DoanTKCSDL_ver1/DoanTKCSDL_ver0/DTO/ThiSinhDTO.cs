using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ThiSinhDTO
    {
        #region "Attributes"
        private string _maThiSinh;        
        private string _ho;        
        private string _tenLot;        
        private string _ten;       
        private DateTime _ngaySinh;        
        private string _cmnd;        
        private string _passportID;       
        private string _diaChi;        
        private string _email;      

        # endregion
        #region "Properties"
        public string MaThiSinh
        {
            get { return _maThiSinh; }
            set { _maThiSinh = value; }
        }
        public string Ho
        {
            get { return _ho; }
            set { _ho = value; }
        }
        public string TenLot
        {
            get { return _tenLot; }
            set { _tenLot = value; }
        }
        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }
        public DateTime NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }
        public string Cmnd
        {
            get { return _cmnd; }
            set { _cmnd = value; }
        }
        public string PassportID
        {
            get { return _passportID; }
            set { _passportID = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        #endregion
        #region "Constructor"
        public ThiSinhDTO()
        {
            MaThiSinh = "";
            Ho = "";
            TenLot = "";
            Ten = "";
            NgaySinh = new DateTime();
            Cmnd = "";
            PassportID = "";
            DiaChi = "";
            Email = "";
        }
        #endregion
    }
}
