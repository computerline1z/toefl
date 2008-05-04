using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ChiTietDotThiDTO
    {
        #region "Attributes"
        private string _maChiTietDotThi;        
        private string _maDotThi;       
        private string _maDiaDiem;        
        private int _soLuongDangKi;       
        #endregion
        #region "Properties"
        public string MaChiTietDotThi
        {
            get { return _maChiTietDotThi; }
            set { _maChiTietDotThi = value; }
        }
        public string MaDotThi
        {
            get { return _maDotThi; }
            set { _maDotThi = value; }
        }
        public string MaDiaDiem
        {
            get { return _maDiaDiem; }
            set { _maDiaDiem = value; }
        }
        public int SoLuongDangKi
        {
            get { return _soLuongDangKi; }
            set { _soLuongDangKi = value; }
        }
        #endregion
        #region "Constructor"
        public ChiTietDotThiDTO()
        {
            MaChiTietDotThi = "";
            MaDotThi = "";
            MaDiaDiem = "";
            SoLuongDangKi = 0;
        }
        #endregion
    }
}
