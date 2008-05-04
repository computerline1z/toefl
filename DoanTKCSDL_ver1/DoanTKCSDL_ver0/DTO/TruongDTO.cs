using System;
using System.Collections.Generic;
using System.Text;


namespace DTO
{
    public class TruongDTO
    {
        #region "Attribute"
        private string _maTruong;        
        private string _tenTruong;       
        #endregion
        #region "Properties"
        public string MaTruong
        {
            get { return _maTruong; }
            set { _maTruong = value; }
        }
        public string TenTruong
        {
            get { return _tenTruong; }
            set { _tenTruong = value; }
        }
        #endregion
        #region "Constructor"
        public TruongDTO()
        {
            MaTruong = "";
            TenTruong = "";
        }
        #endregion
    }
}
