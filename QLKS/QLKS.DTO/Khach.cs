using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.DTO
{
   public class Khach
   {
       #region Attributes
       private string _cmnd;
       private string _hoTen;
       private DateTime _ngaySinh;
       private string _gioiTinh;
       private string _diaChi;
       private string _dienThoai;
       #endregion

       #region Properties
       public string CMND
       {
           get { return _cmnd; }
           set { _cmnd = value; }
       }

       public string HoTen
       {
           get { return _hoTen; }
           set { _hoTen = value; }
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
       #endregion

       #region Constructors
       public Khach()
       {
           this._cmnd = "";
           this._diaChi = "";
           this._dienThoai = "";
           this._gioiTinh = "";
           this._hoTen = "";
           this._ngaySinh = DateTime.Today;
       }

       public Khach(string CMND, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string dienThoai)
       {
           this._cmnd = CMND;
           this._diaChi = diaChi;
           this._dienThoai = dienThoai;
           this._gioiTinh = gioiTinh;
           this._hoTen = hoTen;
           this._ngaySinh = ngaySinh;
       }
       public Khach(Khach k)
       {
           this._cmnd = k._cmnd;
           this._diaChi = k._diaChi;
           this._dienThoai = k._dienThoai;
           this._gioiTinh = k._gioiTinh;
           this._hoTen = k._hoTen;
           this._ngaySinh = k._ngaySinh;
       }
       #endregion

   }
}
