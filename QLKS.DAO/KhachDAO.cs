using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using QLKS.DTO;

namespace QLKS.DAO
{
    public class KhachDAO
    {
        private DataProvider dp;
        public KhachDAO()
        {
            dp = new DataProvider();
        }
        #region Retrieving
        //public List<Khach> LoadData()
        //{
        //    try
        //    {
        //        dp.Connect();
        //        string sql = "Select * From Khach";
        //        SqlDataReader dr = dp.ExecuteReader(sql);
        //        List<Khach> list = new List<Khach>();
        //        while (dr.Read())
        //        {
        //            string CMND = dr.GetValue(0).ToString();
        //            string HoTen = dr.GetValue(1).ToString();
        //            DateTime NgaySinh = Convert.ToDateTime(dr.GetValue(2).ToString());
        //            string GioiTinh = dr.GetValue(3).ToString();
        //            string DiaChi = dr.GetValue(4).ToString();
        //            string DienThoai = dr.GetValue(5).ToString();
        //            Khach k = new Khach(CMND, HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai);
        //            list.Add(k);
        //        }
        //        dr.Close();
        //        return list;

        //    }
        //    catch (SqlException ex)
        //    {

        //        throw ex;
        //    }
        //    finally
        //    {
        //        dp.Disconnect();
        //    }
        //}

        public string GetFullName(string CMND)
        {
            try
            {
                dp.Connect();
                string sql = "SELECT TOP 1 * FROM Khach WHERE CMND = '" + CMND + "'";
                SqlDataReader rd = dp.ExecuteReader(sql);
                rd.Read();
                string hoten = rd["HoTen"].ToString();
                rd.Close();
                return hoten;
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

        #region Insert,Find
        public bool CheckExist(string CMND)
        {
            try
            {
                dp.Connect();
                string sql = "Select CMND From Khach  Where CMND = '" + CMND + "' ";
                SqlDataReader dr = dp.ExecuteReader(sql);
                if (dr.HasRows)
                {
                    dr.Close();
                    return true;
                }
                else
                {
                    dr.Close();
                    return false;
                }

            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public void Insert(Khach k)
        {
            try
            {
                dp.Connect();
                if (!CheckExist(k.CMND))
                {
                    string sql = "Insert Into Khach Values(@CMND,@HoTen,@NgaySinh,@GioiTinh,@DiaChi,@DienThoai)";
                    SqlCommand cmd = new SqlCommand(sql, dp.CN);
                    cmd.Parameters.Add("@CMND", k.CMND);
                    cmd.Parameters.Add("@HoTen", k.HoTen);
                    cmd.Parameters.Add("@NgaySinh", k.NgaySinh);
                    cmd.Parameters.Add("@GioiTinh", k.GioiTinh);
                    cmd.Parameters.Add("@DiaChi", k.DiaChi);
                    cmd.Parameters.Add("@DienThoai", k.DienThoai);
                    dp.ExecuteQuery(cmd);
                }
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

        public List<Khach> Find (string key)
        {
            try
            {
                dp.Connect();
                string sql = "Select * From Khach Where HoTen Like N'%" + key + "%' OR CMND Like '%" + key +"%'";
                SqlDataReader dr = dp.ExecuteReader(sql);
                List<Khach> list = new List<Khach>();
                while (dr.Read())
                {
                    string CMND = dr.GetValue(0).ToString();
                    string HoTen = dr.GetValue(1).ToString();
                    DateTime NgaySinh = Convert.ToDateTime(dr.GetValue(2).ToString());
                    string GioiTinh = dr.GetValue(3).ToString();
                    string DiaChi = dr.GetValue(4).ToString();
                    string DienThoai = dr.GetValue(5).ToString();
                    Khach k = new Khach(CMND, HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai);
                    list.Add(k);
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

    }
}
