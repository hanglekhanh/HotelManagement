using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.DTO
{
    public class NhanVien
    {
        #region Attributes
       private string _maNV;
       private string _ho;
       private string _ten;
       private DateTime _ngaySinh;
       private string _gioiTinh;
       private string _diaChi;
       private string _dienThoai;
       private string _chucVu;
       private string _matKhau;
       #endregion

       #region Properties
       public string MaNV
       {
           get { return _maNV; }
           set { _maNV = value; }
       }

       public string Ho
       {
           get { return _ho; }
           set { _ho = value; }
       }

       public string Ten
       {
           get { return _ten; }
           set { _ten = value; }
       }


       public DateTime NgaySinh
       {
           get { return _ngaySinh; }
           set { _ngaySinh = value; }
       }

       public string GioiTinh
       {
           get { return _gioiTinh; }
           set { _gioiTinh = value; }
       }

       public string DiaChi
       {
           get { return _diaChi; }
           set { _diaChi = value; }
       }

       public string DienThoai
       {
           get { return _dienThoai; }
           set { _dienThoai = value; }
       }

       public string ChucVu
       {
           get { return _chucVu; }
           set { _chucVu = value; }
       }

       public string MatKhau
       {
           get { return _matKhau; }
           set { _matKhau = value; }
       }   
       #endregion

       #region Constructors
       public NhanVien()
       {
           this._maNV = "";
           this._diaChi = "";
           this._dienThoai = "";
           this._gioiTinh = "";
           this._ho = "";
           this._ten = "";
           this._chucVu = "";
           this._matKhau = "";
           this._ngaySinh = DateTime.Today;
       }

       public NhanVien(string maNV, string ho,string ten, DateTime ngaySinh, string gioiTinh, string dienThoai, string diaChi, string chucVu, string matKhau)
       {
           this._maNV = maNV;
           this._diaChi = diaChi;
           this._dienThoai = dienThoai;
           this._gioiTinh = gioiTinh;
           this._ho = ho;
           this._ten = ten;
           this._chucVu = chucVu;
           this._matKhau = matKhau;
           this._ngaySinh = ngaySinh;
       }
       public NhanVien(NhanVien k)
       {
           this._maNV = k._maNV;
           this._diaChi = k._diaChi;
           this._dienThoai = k._dienThoai;
           this._gioiTinh = k._gioiTinh;
           this._ho = k._ho;
           this._ten = k._ten;
           this._chucVu = k._chucVu;
           this._matKhau = k._matKhau;
           this._ngaySinh = k._ngaySinh;
       }
       #endregion
    }
}
