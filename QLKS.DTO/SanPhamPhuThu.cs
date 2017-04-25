using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.DTO
{
    public class SanPhamPhuThu
    {
        #region Attributes
        string _MaSP;
        string _TenSP;
        string _DonViTinh;
        double _DonGia;
        #endregion
        #region Properties


        public string MaSP
        {
            get { return _MaSP; }
            set { _MaSP = value; }
        }


        public string TenSP
        {
            get { return _TenSP; }
            set { _TenSP = value; }
        }


        public string DonViTinh
        {
            get { return _DonViTinh; }
            set { _DonViTinh = value; }
        }


        public double DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }


        #endregion
        #region Constructor
        public SanPhamPhuThu()
        {
            _MaSP = "";
            _TenSP = "";
            _DonViTinh = "";
            _DonGia = 0;
        }
        public SanPhamPhuThu(string MaSP, string TenSP, string DonViTinh, double DonGia)
        {
            _MaSP = MaSP;
            _TenSP = TenSP;
            _DonViTinh = DonViTinh;
            _DonGia = DonGia;

        }
        public SanPhamPhuThu(SanPhamPhuThu k)
        {
            _MaSP = k._MaSP;
            _TenSP = k._TenSP;
            _DonViTinh = k._DonViTinh;
            _DonGia = k._DonGia;
        }
        #endregion
    }
}
