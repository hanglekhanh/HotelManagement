using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.DTO
{
    public class LichSuThuePhong
    {
        #region Attribute
        private string _maPhong;
        private string _CMND;
        private DateTime _ngayDat;
        private DateTime _ngayTra;
        private string _maNV;
        private int _soNguoi;
        private double _tienPhong;
        private double _phuThu;
        private double _tongTien;
        #endregion

        #region Property
        public string MaPhong
        {
            get { return _maPhong; }
            set { _maPhong = value; }
        }

        public string CMND
        {
            get { return _CMND; }
            set { _CMND = value; }
        }

        public DateTime NgayDat
        {
            get { return _ngayDat; }
            set { _ngayDat = value; }
        }

        public DateTime NgayTra
        {
            get { return _ngayTra; }
            set { _ngayTra = value; }
        }

        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }

        public int SoNguoi
        {
            get { return _soNguoi; }
            set { _soNguoi = value; }
        }

        public double TienPhong
        {
            get { return _tienPhong; }
            set { _tienPhong = value; }
        }

        public double PhuThu
        {
            get { return _phuThu; }
            set { _phuThu = value; }
        }

        public double TongTien
        {
            get { return _tongTien; }
            set { _tongTien = value; }
        }
        #endregion

        #region Constructors
        public LichSuThuePhong(string maPhong, string CMND, DateTime ngayDat, DateTime ngayTra, string maNV, int soNguoi, double tienPhong, double phuThu, double tongTien)
        {
            this._maPhong = maPhong;
            this._CMND = CMND;
            this._ngayDat = ngayDat;
            this._ngayTra = ngayTra;
            this._maNV = maNV;
            this._soNguoi = soNguoi;
            this._tienPhong = tienPhong;
            this._phuThu = phuThu;
            this._tongTien = tongTien;
        }
        public LichSuThuePhong(LichSuThuePhong ls)
        {
            this._maPhong = ls._maPhong;
            this._CMND = ls._CMND;
            this._ngayDat = ls._ngayDat;
            this._ngayTra = ls._ngayTra;
            this._maNV = ls._maNV;
            this._soNguoi = ls._soNguoi;
            this._tienPhong = ls._tienPhong;
            this._phuThu = ls._phuThu;
            this._tongTien = ls._tongTien;
        }
        public LichSuThuePhong()
        {
            this._maPhong = "";
            this._CMND = "";
            this._ngayDat = DateTime.Now;
            this._ngayTra = DateTime.Now;
            this._maNV = "";
            this._soNguoi = 0;
            this._tienPhong = 0.0;
            this._phuThu = 0.0;
            this._tongTien = 0.0;
        }
        #endregion
    }
}
