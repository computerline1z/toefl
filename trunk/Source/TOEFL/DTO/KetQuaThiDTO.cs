using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class KetQuaThiDTO
    {
        #region "Attributes"
        private int _maKQThi;        
        private string _maDangKy;        
        private int _diemNghe;        
        private int _diemNoi;       
        private int _diemDoc;       
        private int _diemViet;
        private DateTime _hieuLucDiemThi;
        #endregion
        #region "Properties"
        public int MaKQThi
        {
            get { return _maKQThi; }
            set { _maKQThi = value; }
        }
        public string MaDangKy
        {
            get { return _maDangKy; }
            set { _maDangKy = value; }
        }
        public int DiemNghe
        {
            get { return _diemNghe; }
            set { _diemNghe = value; }
        }
        public int DiemNoi
        {
            get { return _diemNoi; }
            set { _diemNoi = value; }
        }
        public int DiemDoc
        {
            get { return _diemDoc; }
            set { _diemDoc = value; }
        }
        public int DiemViet
        {
            get { return _diemViet; }
            set { _diemViet = value; }
        }
         public DateTime HieuLucDiemThi
        {
            get { return _hieuLucDiemThi; }
            set { _hieuLucDiemThi = value; }
        }
        #endregion
        #region "Constructor"
        public KetQuaThiDTO()
        {
            MaKQThi = 0;
            MaDangKy = "";
            DiemDoc = 0;
            DiemNghe = 0;
            DiemNoi = 0;
            DiemViet = 0;
            HieuLucDiemThi = new DateTime();
         }
        #endregion
    }
}
