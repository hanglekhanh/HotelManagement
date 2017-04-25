using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using QLKS.DTO;

namespace QLKS.DAO
{
    public class NhanVienDAO
    {
        private DataProvider dp;
        public NhanVienDAO()
        {
            dp = new DataProvider();
        }

        #region 1.Retriving
        //---------------//
        public string GetFullName(string maNV)
        {
            try
            {
                dp.Connect();
                string sql = "SELECT Ho + ' ' + Ten as HoTen FROM NhanVien WHERE MaNV = '" + maNV + "'";
                SqlDataReader rd = dp.ExecuteReader(sql);
                rd.Read();
                string hoten = rd["HoTen"].ToString();
                return hoten;
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }
        #endregion

        #region 2.Insert, Delete
        public bool Exist(string sql)
        {
            try
            {
                dp.Connect();
                SqlDataReader rd = dp.ExecuteReader(sql);
                if(rd.HasRows)
                {
                    rd.Close();
                    return true;
                }
                rd.Close();
                return false;
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }
        
        public bool LoginChecking(string user, string pass)
        {
            try
            {
                dp.Connect();
                string sql = "Select MaNV from NhanVien where MaNV = '" + user + "' and MatKhau = '" + pass + "'";
                if (Exist(sql))
                    return true;
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo");
                return false;
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }

        public bool UpdatePass(string user, string pass)
        {
            try
            {
                dp.Connect();
                string sql = string.Format("Update NhanVien Set MatKhau = '{0}' Where MaNV ='{1}'", pass, user);
                dp.ExecuteQuery(sql);
                return true;

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

