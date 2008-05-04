using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class GoiDiemDTO
    {
        #region "Attributes"
        private string _maDangKi;        
        private string _maTruong;       
        #endregion
        #region "Properties"
        public string MaDangKi
        {
            get { return _maDangKi; }
            set { _maDangKi = value; }
        }
        public string MaTruong
        {
            get { return _maTruong; }
            set { _maTruong = value; }
        }
        #endregion
        #region "Constructor"
        public GoiDiemDTO()
        {
            MaDangKi = "";
            MaTruong = "";
        }
        #endregion

    }
}
