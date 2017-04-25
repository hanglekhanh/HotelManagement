using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
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

        public Tam RoomInfo(string maPhong)
        {
            try
            {
                dp.Connect();
                string sql = "SELECT * FROM Tam WHERE MaPhong = '" + maPhong + "'";
                SqlDataReader dr = dp.ExecuteReader(sql);
                Tam t = new Tam();
                dr.Read();
                t.MaPhong = dr.GetValue(0).ToString();
                t.CMND = dr.GetValue(1).ToString();
                t.NgayDat = Convert.ToDateTime(dr.GetValue(2).ToString());
                t.MaNV = dr.GetValue(3).ToString();
                t.SoNguoi = Convert.ToInt32(dr.GetValue(4).ToString());
                return t;
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

        public string GetCMND(string maphong)
        {
            try
            {
                dp.Connect();
                string sql = "SELECT CMND FROM Tam WHERE MaPhong = '" + maphong + "'";
                SqlDataReader rd = dp.ExecuteReader(sql);
                rd.Read();
                string CMND = rd["CMND"].ToString();
                rd.Close();
                return CMND;
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

        public DateTime GetDate(string maphong)
        {
            try
            {
                dp.Connect();
                string sql = "SELECT NgayDat FROM Tam WHERE MaPhong = '" + maphong + "'";
                SqlDataReader rd = dp.ExecuteReader(sql);
                rd.Read();
                DateTime NgayDat = Convert.ToDateTime(rd["NgayDat"]);
                rd.Close();
                return NgayDat;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dp.Disconnect();
            }
        }
        public int GetSoNguoi(string maphong)
        {
            try
            {
                dp.Connect();
                string sql = "SELECT SoNguoi FROM Tam WHERE MaPhong = '" + maphong + "'";
                SqlDataReader rd = dp.ExecuteReader(sql);
                rd.Read();
                int _SoNguoi =Convert.ToInt16(rd["SoNguoi"]);
                rd.Close();
                return _SoNguoi;

            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region Insert,Delete
        public bool CheckExist(string MaPhong)
        {
            try
            {
                dp.Connect();
                string sql = "Select MaPhong From Tam  Where MaPhong = '" + MaPhong + "' ";
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

        public void Insert(Tam t)
        {
            try
            {
                dp.Connect();
                if (!CheckExist(t.MaPhong))
                {
                    string sql = "Insert Into Tam Values(@MaPhong,@CMND,@NgayDat,@MaNV,@SoNguoi)";
                    SqlCommand cmd = new SqlCommand(sql, dp.CN);
                    cmd.Parameters.Add("@MaPhong", t.MaPhong);
                    cmd.Parameters.Add("@CMND", t.CMND);
                    cmd.Parameters.Add("@NgayDat", t.NgayDat);
                    cmd.Parameters.Add("@MaNV", t.MaNV);
                    cmd.Parameters.Add("@SoNguoi", t.SoNguoi);
                    dp.ExecuteQuery(cmd);
                    MessageBox.Show("Đặt phòng thành công!");
                }
                else
                    MessageBox.Show("Lỗi dữ liệu!");
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

        public void CancelRoom(string MaPhong)
        {
            try
            {
                dp.Connect();
                if (CheckExist(MaPhong))
                {
                    string sql = "DELETE FROM Tam WHERE MaPhong = '" + MaPhong + "'";
                    dp.ExecuteQuery(sql);
                    MessageBox.Show("Hủy thành công");
                }
                else
                    MessageBox.Show("Lỗi dữ liệu!");
            }
            catch (SqlException ex)
            {          
                throw ex;
            }
        }

        public void Delete(string maPhong)
        {
            try
            {
                dp.Connect();
                string sql = "Delete From Tam Where MaPhong = @MaPhong";
                SqlCommand cmd = new SqlCommand(sql, dp.CN);
                cmd.Parameters.Add("@MaPhong", maPhong.ToString());
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
