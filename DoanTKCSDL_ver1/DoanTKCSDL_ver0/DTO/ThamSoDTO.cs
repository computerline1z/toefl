using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ThamSoDTO
    {
        #region "Attributes"
        private int _sokytutoithieu;        
        private int _khoangcachthi;        
        private int _handangky;       
        private int _handongthemphi; 
        private double _phidangkytre; 
        private int _sotruongtoidagoidiemmienphi; 
        private int _hanhieulucdiemthi; 
        private double _phigoidiem;
        private double _lephithi;
        #endregion

        #region "Properties"
        public int SoKyTuToiThieu
        {
            get { return _sokytutoithieu; }
            set { _sokytutoithieu = value; }
        }
        public int KhoangCachThi
        {
            get { return _khoangcachthi; }
            set { _khoangcachthi = value; }
        }
        public int HanDangKy
        {
            get { return _handangky; }
            set { _handangky = value; }
        }
        public int HanDongThemPhi
        {
            get { return _handongthemphi; }
            set { _handongthemphi = value; }
        }
         public double PhiDangKyTre
        {
            get { return _phidangkytre; }
            set { _phidangkytre = value; }
        }
         public int SoTruongToiDaGoiDiemMienPhi
        {
            get { return _sotruongtoidagoidiemmienphi; }
            set { _sotruongtoidagoidiemmienphi = value; }
        }
         public int HanHieuLucDiemThi
        {
            get { return _hanhieulucdiemthi; }
            set { _hanhieulucdiemthi = value; }
        }
         public double PhiGoiDiem
        {
            get { return _phigoidiem; }
            set { _phigoidiem = value; }
        }
        public double LePhiThi
        {
            get { return _lephithi; }
            set { _lephithi = value; }
        }
        #endregion

        #region "Constructor"
        public ThamSoDTO()
        {
            SoKyTuToiThieu = 0;
            KhoangCachThi = 0;
            HanDangKy = 0;
            HanDongThemPhi = 0;
            PhiDangKyTre = 0;
            SoTruongToiDaGoiDiemMienPhi = 0;
            HanHieuLucDiemThi = 0;
            PhiGoiDiem = 0;
            LePhiThi = 0;
        }
        #endregion
    }
}
