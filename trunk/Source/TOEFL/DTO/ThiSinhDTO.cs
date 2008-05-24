using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ThiSinhDTO
    {
        #region "Attributes"
        private string _maThiSinh;
        private string _username;
        private string _password;
        private string _ho;        
        private string _tenLot;        
        private string _ten;       
        private DateTime _ngaySinh;  
        private string _cmnd_passportID;       
        private string _diaChi;        
        private string _email;
        private DateTime _ngayThiGanNhat;

        # endregion
        #region "Properties"
        public string MaThiSinh
        {
            get { return _maThiSinh; }
            set { _maThiSinh = value; }
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
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
       
        public string CMND_PassportID
        {
            get { return _cmnd_passportID; }
            set { _cmnd_passportID = value; }
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
        public DateTime NgayThiGanNhat
        {
            get { return _ngayThiGanNhat; }
            set { _ngayThiGanNhat = value; }
        }
        #endregion
        #region "Constructor"
        public ThiSinhDTO()
        {
            MaThiSinh = "";
            Username = "";
            Password = "";
            Ho = "";
            TenLot = "";
            Ten = "";
            NgaySinh = new DateTime();
            CMND_PassportID = "";
            DiaChi = ""; 
            Email = "";
            NgayThiGanNhat = new DateTime();        
        }
        #endregion
    }
}
