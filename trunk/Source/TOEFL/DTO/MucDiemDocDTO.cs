using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class MucDiemDTO
    {
        #region "Attributes"
        private int _maMucDiem;
        private string _phanThi;       
        private string _tenMucDiem;       
        private int _canDuoi;        
        private int _canTren;
        #endregion

        #region "Properties"
        public int MaMucDiem
        {
            get { return _maMucDiem; }
            set { _maMucDiem = value; }
        }
        public string PhanThi
        {
            get { return _phanThi; }
            set { _phanThi = value; }
        }
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
        public MucDiemDTO()
        {
            MaMucDiem = 0;
            PhanThi = "";
            TenMucDiem = "";
            CanDuoi = 0;
            CanTren = 0;
        }
        #endregion
    }
}
