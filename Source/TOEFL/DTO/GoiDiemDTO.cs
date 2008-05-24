using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class GoiDiemDTO
    {
        #region "Attributes"
        private int _maGoiDiem;        
        private string _maDangKi;        
        private int _maTruong;
        private decimal _phiGoiDiem;        
        #endregion
        #region "Properties"
        public int MaGoiDiem
        {
            get { return _maGoiDiem; }
            set { _maGoiDiem = value; }
        }
        public string MaDangKi
        {
            get { return _maDangKi; }
            set { _maDangKi = value; }
        }
        public int MaTruong
        {
            get { return _maTruong; }
            set { _maTruong = value; }
        }
        public decimal PhiGoiDiem
        {
            get { return _phiGoiDiem; }
            set { _phiGoiDiem = value; }
        }
        #endregion
        #region "Constructor"
        public GoiDiemDTO()
        {
            MaGoiDiem = 0;
            MaDangKi = "";
            MaTruong = 0;
            PhiGoiDiem = 0;
        }
        #endregion

    }
}
