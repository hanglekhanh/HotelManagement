using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.DTO
{
    public class Phong
    {
        #region Attribute
        private string _maPhong;
        private string _loai;
        private int _soGiuong;
        private double _giaTien;
        #endregion

        #region Properties
        public string MaPhong
        {
            get { return _maPhong; }
            set { _maPhong = value; }
        }

        public string Loai
        {
            get { return _loai; }
            set { _loai = value; }
        }


        public int SoGiuong
        {
            get { return _soGiuong; }
            set { _soGiuong = value; }
        }


        public double GiaTien
        {
            get { return _giaTien; }
            set { _giaTien = value; }
        }       
        #endregion

        #region Constructors
        public Phong(string maPhong, string Loai, int soGiuong, double giaTien)
        {
            this._maPhong = maPhong;
            this._loai = Loai;
            this._soGiuong = soGiuong;
            this._giaTien = giaTien;
        }
        public Phong()
        {
            this._maPhong = "";
            this._soGiuong = 2;
            this._loai = "Thường";
            this._giaTien = 200000;
        }
        public Phong(Phong p)
        {
            this._maPhong = p._maPhong;
            this._loai = p._loai;
            this._soGiuong = p._soGiuong;
            this._giaTien = p._giaTien;
        }
        #endregion
    }
}
