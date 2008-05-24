using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ChiTietDotThiDTO
    {
        #region "Attributes"
        private int _maChiTietDotThi;        
        private int _maDotThi;       
        private int _maDiaDiem;        
        private int _soLuongDangKi;       
        #endregion
        #region "Properties"
        public int MaChiTietDotThi
        {
            get { return _maChiTietDotThi; }
            set { _maChiTietDotThi = value; }
        }
        public int MaDotThi
        {
            get { return _maDotThi; }
            set { _maDotThi = value; }
        }
        public int MaDiaDiem
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
            MaChiTietDotThi = 0;
            MaDotThi = 0;
            MaDiaDiem = 0;
            SoLuongDangKi = 0;
        }
        #endregion
    }
}
