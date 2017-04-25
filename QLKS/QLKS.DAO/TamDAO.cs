using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using QLKS.DTO;

namespace QLKS.DAO
{
    public class TamDAO
    {
        private DataProvider dp;
        public TamDAO()
        {
            dp = new DataProvider();
        }
        #region Retrieving
        public List<Tam> LoadData()
        {
            try
            {
                dp.Connect();
                string sql = "Select * From Tam";
                SqlDataReader dr = dp.ExecuteReader(sql);
                List<Tam> list = new List<Tam>();
                while (dr.Read())
                {
                    string maPhong = dr.GetValue(0).ToString();
                    string CMND = dr.GetValue(1).ToString();
                    DateTime NgayDat = Convert.ToDateTime(dr.GetValue(2).ToString());
                    string maNV = dr.GetValue(3).ToString();
                    int soNguoi = Convert.ToInt32(dr.GetValue(4).ToString());
                    Tam t = new Tam(maPhong, CMND, NgayDat, maNV, soNguoi);
                    list.Add(t);
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
        public bool CheckExist(Tam t)
        {
            try
            {
                dp.Connect();
                string sql = "Select MaPhong From Tam  Where MaPhong = '" + t.MaPhong + "' ";
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
            finally
            {
                dp.Disconnect();
            }
        }

        public void Insert(Tam t)
        {
            try
            {
                dp.Connect();
                
                string sql = "Insert Into Tam Values('" + t.MaPhong + "',N'" + t.CMND + "','" + "@NgayDat" + "','"+t.MaNV+"','"+t.SoNguoi+"')";
                SqlCommand connect = new SqlCommand(sql,new SqlConnection (DataProvider._cnstr));
                connect.Parameters.Add("@NgayDat", t.NgayDat);
                connect.ExecuteNonQuery();
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
