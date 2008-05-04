using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DiaDiemDTO
    {
        #region "Attributes"
        private string _maDiaDiem;        
        private string _QuocGia;        
        private string _tenDiaDiem;       
        private int _soLuongCho;        
        #endregion
        #region "Properties"
        public string MaDiaDiem
        {
            get { return _maDiaDiem; }
            set { _maDiaDiem = value; }
        }
        public string QuocGia
        {
            get { return _QuocGia; }
            set { _QuocGia = value; }
        }
        public string TenDiaDiem
        {
            get { return _tenDiaDiem; }
            set { _tenDiaDiem = value; }
        }
        public int SoLuongCho
        {
            get { return _soLuongCho; }
            set { _soLuongCho = value; }
        }
        #endregion
        #region "Constructor"
        public DiaDiemDTO()
        {
            MaDiaDiem = "";
            QuocGia = "";
            TenDiaDiem = "";
            SoLuongCho = 0;
        }
        #endregion
    }
}
