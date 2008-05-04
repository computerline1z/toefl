using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DotThiDTO
    {
        #region "Attributes"
        private string _maDotThi;        
        private DateTime _ngayThi;        
        #endregion
        #region "Properties"
        public string MaDotThi
        {
            get { return _maDotThi; }
            set { _maDotThi = value; }
        }
        public DateTime NgayThi
        {
            get { return _ngayThi; }
            set { _ngayThi = value; }
        }
        #endregion
        #region "Constructor"
        public DotThiDTO()
        {
            MaDotThi = "";
            NgayThi = new DateTime();
        }
        #endregion
    }
}
