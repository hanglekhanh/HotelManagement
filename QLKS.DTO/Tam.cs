using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.DTO
{
    public class Tam
    {
        #region Attribute
        private string _maPhong;
        private string _cmnd;
        private DateTime _ngayDat;
        private string _maNV;
        private int _soNguoi;
        #endregion

        #region Properties   
        public string MaPhong
        {
            get { return _maPhong; }
            set { _maPhong = value; }
        }

        public string CMND
        {
            get { return _cmnd; }
            set { _cmnd = value; }
        }

        public DateTime NgayDat
        {
            get { return _ngayDat; }
            set { _ngayDat = value; }
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
        #endregion

        #region Constructors
        public Tam(string maPhong, string CMND, DateTime NgayDat, string MaNV, int SoNguoi)
        {
            this._maPhong = maPhong;
            this._cmnd = CMND;
            this._ngayDat = NgayDat;
            this._maNV = MaNV;
            this._soNguoi = SoNguoi;
        }

        public Tam()
        {
            this._maPhong = "";
            this._cmnd = "";
            this._ngayDat = DateTime.Now;
            this._maNV = "";
            this._soNguoi = 0;
        }

        public Tam(Tam t)
        {
            this._maPhong = t._maPhong;
            this._cmnd = t._cmnd;
            this._ngayDat = t._ngayDat;
            this._maNV = t._maNV;
            this._soNguoi = t._soNguoi;
        }
        #endregion
    }
}
