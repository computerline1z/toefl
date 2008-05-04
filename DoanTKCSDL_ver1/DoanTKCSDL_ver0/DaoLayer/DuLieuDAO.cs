using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;


namespace DaoLayer
{
    class DuLieuDAO : AbstractDAO
    {
        /*
        private XmlDocument TaiLieu = KetNoiXML();

        // Ghi gia tri cua Node xuong xml
        private void GhiDuLieu(string TenNode, int GiaTri)
        {

            // Lay thong tin cua node co ten la TenNode
            XmlNode node = TaiLieu.GetElementsByTagName(TenNode)(0);
            XmlNode node1 = node.Clone();
            node1.FirstChild.Value = GiaTri;
            TaiLieu.DocumentElement.ReplaceChild(node1, node);
            TaiLieu.Save(TaiLieu.BaseURI.ToString().Replace("file:///", ""));
        }

        private void LayThongTinNode(string TenNode, ref string Chuoi, ref int ChieuDai, ref int GiaTri)
        {
            //Dim TaiLieu As XmlDocument

            //TaiLieu = KetNoiXML()
            // Lay thong tin cua node co ten la TenNode
            XmlNode node = TaiLieu.GetElementsByTagName(TenNode)(0);
            Chuoi = node.Attributes("Chuoi").Value;
            ChieuDai = node.Attributes("ChieuDai").Value;
            GiaTri = node.FirstChild.Value;
        }

        //Lay so lon nhat co n chu so
        private int SoLonNhat(int n)
        {
            int KetQua = 1;
            for (int i = 1; i <= n; i++)
            {
                KetQua *= 10;
            }
            return KetQua - 1;
        }
        // Sinh ma moi, ma do la ma strMa trong bang strBang
        private string TaoMa(string strMa, string strBang)
        {
            string KetQua = "";
            string Chuoi = "";
            int ChieuDai;
            int GiaTri;
            LayThongTinNode(strMa, Chuoi, ChieuDai, GiaTri);
            int ChieuDaiChuoiSo = ChieuDai - Chuoi.Length();
            int Max = SoLonNhat(ChieuDaiChuoiSo);
            string format;
            //Dim cn As OleDbConnection = KetNoiCoSoDuLieu()
            int GiaTriCu = GiaTri - 1;
            // Luu lai gia tri vua moi doc

            if ((GiaTriCu < 0))
            {
                GiaTriCu = Max;
            }

            while (GiaTriCu != GiaTri)
            {
                format = Chuoi + "{0," + ChieuDaiChuoiSo.ToString() + ":D}";
                KetQua = string.Format(format, GiaTri);
                KetQua = KetQua.Replace(" ", "0");

                string strSQL;
                strSQL = "select count(*) from " + strBang + " where " + strMa + "='" + KetQua + "'";
                OleDbCommand cmd = new OleDbCommand(strSQL, cn);

                int gt = cmd.ExecuteScalar();
                if (gt == 0)
                {
                    // Ma nay chua co trong csdl
                    break; // TODO: might not be correct. Was : Exit While
                }

                GiaTri += 1;
                if (GiaTri > Max)
                {
                    GiaTri = 0;
                }
            }

            if ((GiaTri == GiaTriCu))
            {
                KetQua = "";
            }
            else
            {
                GhiDuLieu(strMa, GiaTri);
            }

            return KetQua;
        }
        // Sinh ma giao vien moi
        // Neu khong the tao ra ma moi thi tra ve chuoi rong
        // Nguoc lai tra ve ma moi
        public string TaoMaGiaoVien()
        {
            return TaoMa("MaGiaoVien", "GiaoVien");
        }
        // Sinh ma lich lop hoc moi
        // Neu khong the tao ra ma moi thi tra ve chuoi rong
        // Nguoc lai tra ve ma moi
        public string TaoMaLichLopHoc()
        {
            return TaoMa("MaLichLopHoc", "LichLopHoc");
        }
        // Sinh ma lop hoc moi
        // Neu khong the tao ra ma moi thi tra ve chuoi rong
        // Nguoc lai tra ve ma moi
        public string TaoMaLopHoc()
        {
            return TaoMa("MaLopHoc", "LopHoc");
        }
        // Sinh ma mon hoc moi
        // Neu khong the tao ra ma moi thi tra ve chuoi rong
        // Nguoc lai tra ve ma moi
        public string TaoMaMonHoc()
        {
            return TaoMa("MaMonHoc", "MonHoc");
        }
        // Sinh ma phan cong moi
        // Neu khong the tao ra ma moi thi tra ve chuoi rong
        // Nguoc lai tra ve ma moi
        public string TaoMaPhanCong()
        {
            return TaoMa("MaPhanCong", "PhanCong");
        }
        // Sinh ma phu trach moi
        // Neu khong the tao ra ma moi thi tra ve chuoi rong
        // Nguoc lai tra ve ma moi
        public string TaoMaPhuTrach()
        {
            return TaoMa("MaPhuTrach", "PhuTrach");
        }
        // Sinh ma rang buoc giao vien moi
        // Neu khong the tao ra ma moi thi tra ve chuoi rong
        // Nguoc lai tra ve ma moi
        public string TaoMaRangBuocGiaoVien()
        {
            return TaoMa("MaRangBuocGiaoVien", "RangBuocGiaoVien");
        }
        // Sinh ma rang buoc lop hoc moi
        // Neu khong the tao ra ma moi thi tra ve chuoi rong
        // Nguoc lai tra ve ma moi
        public string TaoMaRangBuocLopHoc()
        {
            return TaoMa("MaRangBuocLopHoc", "RangBuocLopHoc");
        }

        // Ghi ma giao vien xuong xml
        public bool GhiMaGiaoVien(int Ma)
        {
            GhiDuLieu("MaGiaoVien", Ma);
            return true;
        }
        // Ghi ma Lich lop hoc xuong xml
        public bool GhiMaLichLopHoc(int Ma)
        {
            GhiDuLieu("MaLichLopHoc", Ma);
            return true;
        }
        // Ghi ma Lop hoc xuong xml
        public bool GhiMaLopHoc(int Ma)
        {
            GhiDuLieu("MaLopHoc", Ma);
            return true;
        }
        // Ghi ma Mon hoc xuong xml
        public bool GhiMaMonHoc(int Ma)
        {
            GhiDuLieu("MaMonHoc", Ma);
            return true;
        }
        // Ghi ma Phan cong xuong xml
        public bool GhiMaPhanCong(int Ma)
        {
            GhiDuLieu("MaPhanCong", Ma);
            return true;
        }
        // Ghi ma Phu trach xuong xml
        public bool GhiMaPhuTrach(int Ma)
        {
            GhiDuLieu("MaPhuTrach", Ma);
            return true;
        }
        // Ghi ma Rang buoc giao vien xuong xml
        public bool GhiMaRangBuocGiaoVien(int Ma)
        {
            GhiDuLieu("MaRangBuocGiaoVien", Ma);
            return true;
        }
        // Ghi ma Rang buoc lop hoc xuong xml
        public bool GhiMaRangBuocLopHoc(int Ma)
        {
            GhiDuLieu("MaRangBuocLopHoc", Ma);
            return true;
        }*/
    }
         
}
