using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.DTO
{
    public class LichSuBanSP
    {
        #region Attribute
        private string _maSP;
        private DateTime _ngayBan;
        private string _tenSP;
        private int _soLuong;
        private double _donGia;
        private double _tongTien;
        #endregion
        #region Property

        public string MaSP
        {
            get { return _maSP; }
            set { _maSP = value; }
        }

        public DateTime NgayBan
        {
            get { return _ngayBan; }
            set { _ngayBan = value; }
        }

        public string TenSP
        {
            get { return _tenSP; }
            set { _tenSP = value; }
        }

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
   

        public double DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }


        public double TongTien
        {
            get { return _tongTien; }
            set { _tongTien = value; }
        }
        
        
        
        #endregion

        #region Constructors
        public LichSuBanSP()
        {
            this._maSP = "";
            this._ngayBan = DateTime.Now;
            this._tenSP = "";
            this._soLuong = 0;
            this._donGia = 0;
            this._tongTien = 0;
        }
        public LichSuBanSP(string maSP, DateTime ngayBan, string tenSP, int soLuong,double dongia, double tongtien )
        {
            this._maSP = maSP;
            this._ngayBan = ngayBan;
            this._tenSP = tenSP;
            this._soLuong = soLuong;
            this._donGia = dongia;
            this._tongTien = tongtien;
        }

        public LichSuBanSP(LichSuBanSP ls)
        {
            this._maSP = ls._maSP;
            this._ngayBan = ls._ngayBan;
            this._tenSP = ls._tenSP;
            this._soLuong = ls._soLuong;
            this._donGia = ls._donGia;
            this.TongTien = ls._tongTien;
        }
        #endregion
    }
}
