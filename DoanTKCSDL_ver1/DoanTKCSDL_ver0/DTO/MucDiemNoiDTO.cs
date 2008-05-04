using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class MucDiemNoiDTO
    {
        #region "Attributes"
        private string _tenMucDiem;       
        private int _canDuoi;        
        private int _canTren;
        #endregion

        #region "Properties"
        public string TenMucDiem
        {
            get { return _tenMucDiem; }
            set { _tenMucDiem = value; }
        }
        public int CanDuoi
        {
            get { return _canDuoi; }
            set { _canDuoi = value; }
        }
         public int CanTren
        {
            get { return _canTren; }
            set { _canTren = value; }
        }
        #endregion

        #region "Constructor"
        public MucDiemNoiDTO()
        {
            TenMucDiem = "";
            CanDuoi = 0;
            CanTren = 0;
        }
        #endregion
    }
}
