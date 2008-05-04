using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class LoaiTheDTO
    {
        #region "Attributes"
        private string _maLoaiThe;       
        private string _tenLoaiThe;        
        #endregion
        #region "Properties"
        public string MaLoaiThe
        {
            get { return _maLoaiThe; }
            set { _maLoaiThe = value; }
        }
        public string TenLoaiThe
        {
            get { return _tenLoaiThe; }
            set { _tenLoaiThe = value; }
        }
        #endregion
        #region "Constructor"
        public LoaiTheDTO()
        {
            MaLoaiThe = "";
            TenLoaiThe = "";
        }
        #endregion
    }
}
