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
        public List<Khach> LoadData()
        {
            try
            {
                dp.Connect();
                string sql = "Select * From Khach";
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

        #region Insert,Delete
        public bool CheckExist(Khach k)
        {
            try
            {
                dp.Connect();
                string sql = "Select CMND From Khach  Where CMND = '" + k.CMND + "' ";
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

        public void Insert(Khach k)
        {
            try
            {
                dp.Connect();
                string sql = "Insert Into Khach Values('" + k.CMND + "',N'" + k.HoTen + "',@NgaySinh,N'" + k.GioiTinh + "',N'" + k.DiaChi + "','"+k.DienThoai+"')";
                
                SqlCommand cmd = new SqlCommand(sql,new SqlConnection(DataProvider._cnstr));
                cmd.Parameters.Add("@NgaySinh", k.NgaySinh);
                //dp.ExecuteQuery(sql);
                cmd.ExecuteNonQuery();
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
