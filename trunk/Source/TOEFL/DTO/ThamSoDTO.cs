using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ThamSoDTO
    {
        #region "Attributes"
        private Int16 _sokytutoithieu;
        private Int16 _khoangcachthi;
        private Int16 _handangky;
        private Int16 _handongthemphi; 
        private decimal _phidangkytre;
        private Int16 _sotruongtoidagoidiemmienphi;
        private Int16 _hanhieulucdiemthi;
        private decimal _phigoidiem;
        private decimal _lephithi;
        #endregion

        #region "Properties"
        public Int16 SoKyTuToiThieu
        {
            get { return _sokytutoithieu; }
            set { _sokytutoithieu = value; }
        }
        public Int16 KhoangCachThi
        {
            get { return _khoangcachthi; }
            set { _khoangcachthi = value; }
        }
        public Int16 HanDangKy
        {
            get { return _handangky; }
            set { _handangky = value; }
        }
        public Int16 HanDongThemPhi
        {
            get { return _handongthemphi; }
            set { _handongthemphi = value; }
        }
        public decimal PhiDangKyTre
        {
            get { return _phidangkytre; }
            set { _phidangkytre = value; }
        }
        public Int16 SoTruongToiDaGoiDiemMienPhi
        {
            get { return _sotruongtoidagoidiemmienphi; }
            set { _sotruongtoidagoidiemmienphi = value; }
        }
        public Int16 HanHieuLucDiemThi
        {
            get { return _hanhieulucdiemthi; }
            set { _hanhieulucdiemthi = value; }
        }
        public decimal PhiGoiDiem
        {
            get { return _phigoidiem; }
            set { _phigoidiem = value; }
        }
        public decimal LePhiThi
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
