using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class AccountDTO
    {
        #region "Attribute"
        private string _maThiSinh;
        private string _userName;       
        private string _password;        
        #endregion
        #region "Properties"
        public string MaThiSinh
        {
            get { return _maThiSinh; }
            set { _maThiSinh = value; }
        }
         public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        #endregion
        #region "Constructor"
        public AccountDTO()
        {
            MaThiSinh = "";
            Password = "";
            UserName = "";
        }
        #endregion

    }
}
