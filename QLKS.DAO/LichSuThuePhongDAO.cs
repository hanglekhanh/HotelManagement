using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using QLKS.DTO;

namespace QLKS.DAO
{
    public class LichSuThuePhongDAO
    {
        DataProvider dp;
        public LichSuThuePhongDAO()
        {
            dp = new DataProvider();
        }
        #region Retrieving
        public List<LichSuThuePhong> LoadData()
        {
            try
            {
                dp.Connect();
                string sql = "Select * From LichSuThuePhong";
                SqlDataReader dr = dp.ExecuteReader(sql);
                List<LichSuThuePhong> list = new List<LichSuThuePhong>();
                while (dr.Read())
                {
                    string maPhong = dr.GetValue(0).ToString();
                    string cmnd = dr.GetValue(1).ToString();
                    DateTime ngayDat = Convert.ToDateTime(dr.GetValue(2));
                    DateTime ngayTra = Convert.ToDateTime(dr.GetValue(3));
                    string maNV = dr.GetValue(4).ToString();
                    int soNguoi = Convert.ToInt16(dr.GetValue(5));
                    double tienPhong = Convert.ToDouble(dr.GetValue(6));
                    double phuThu = Convert.ToDouble(dr.GetValue(7));
                    double tongTien = Convert.ToDouble(dr.GetValue(8));
                    LichSuThuePhong ls = new LichSuThuePhong(maPhong, cmnd, ngayDat, ngayTra, maNV, soNguoi, tienPhong, phuThu, tongTien);
                    list.Add(ls);
                }
                dr.Close();
                return list;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                dp.Disconnect();
            }
        }
        #endregion
        #region Insert,Delete
        public void Insert(LichSuThuePhong ls)
        {
            try
            {
                dp.Connect();
                string sql = "Insert Into LichSuThuePhong Values(@MaPhong,@CMND,@NgayDat,@NgayTra,@MaNV,@SoNguoi,@TienPhong,@PhuThu,@TongTien)";
                SqlCommand cmd = new SqlCommand(sql, dp.CN);
                cmd.Parameters.Add("@MaPhong", ls.MaPhong);
                cmd.Parameters.Add("@CMND", ls.CMND);
                cmd.Parameters.Add("@NgayDat", ls.NgayDat);
                cmd.Parameters.Add("@NgayTra", ls.NgayTra);
                cmd.Parameters.Add("@MaNV", ls.MaNV);
                cmd.Parameters.Add("@SoNguoi", ls.SoNguoi);
                cmd.Parameters.Add("@TienPhong", ls.TienPhong);
                cmd.Parameters.Add("@PhuThu", ls.PhuThu);
                cmd.Parameters.Add("@TongTien", ls.TongTien);
                dp.ExecuteQuery(cmd);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                dp.Disconnect();
            }
        }
        #endregion
    }
}
