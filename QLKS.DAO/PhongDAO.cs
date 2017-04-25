using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using QLKS.DTO;
using System.Windows.Forms;
namespace QLKS.DAO
{
    public class PhongDAO
    {
        private DataProvider dp;
        public PhongDAO()
        {
            dp = new DataProvider();
        }
        #region 1.Retriving
        public double GetDonGia(string maphong)
        {
            try
            {
                dp.Connect();
                string sql = "SELECT GiaNgay FROM Phong WHERE MaPhong = '" + maphong + "'";
                SqlDataReader rd = dp.ExecuteReader(sql);
                rd.Read();
                double giangay = Convert.ToDouble(rd["GiaNgay"]);
                rd.Close();
                return giangay;

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

        public List<Phong> LoadData()
        {
            try
            {
                dp.Connect();
                string sql = "SELECT * FROM Phong";
                SqlDataReader rd = dp.ExecuteReader(sql);
                List<Phong> list = new List<Phong>();
                while(rd.Read())
                {
                    string maPhong = rd["MaPhong"].ToString();
                    string loai = rd["Loai"].ToString();
                    int soGiuong = Convert.ToInt32(rd["SoGiuong"]);
                    double giaNgay = Convert.ToDouble(rd["GiaNgay"]);
                    list.Add(new Phong(maPhong, loai, soGiuong, giaNgay));
                }
                rd.Close();
                return list;
            }
            catch (SqlException  ex)
            {
                
                throw ex;
            }
            finally
            {
                dp.Disconnect();
            }
        }
        #endregion
        #region Insert, Delete, Update
        public bool Exist(string maPhong)
        {
            try
            {
                string sql = "SELECT * FROM Phong WHERE MaPhong = '" + maPhong + "'";
                SqlDataReader dr = dp.ExecuteReader(sql);
                if(dr.HasRows)
                {
                    dr.Close();
                    return true;
                }
                dr.Close();
                return false;
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }
        public void Update(Phong p)
        {
            try
            {
                dp.Connect();
                if(!Exist(p.MaPhong))
                {
                    MessageBox.Show("Mã phòng sai!");
                    return;
                }
                string sql = "UPDATE Phong Set MaPhong = @MaPhong, Loai = @Loai, SoGiuong = @SoGiuong, GiaNgay = @GiaNgay WHERE MaPhong = @MaPhong";
                SqlCommand cmd = new SqlCommand(sql, dp.CN);
                cmd.Parameters.Add("@MaPhong", p.MaPhong);
                cmd.Parameters.Add("@Loai", p.Loai);
                cmd.Parameters.Add("@SoGiuong", p.SoGiuong);
                cmd.Parameters.Add("@GiaNgay", p.GiaTien);
                dp.ExecuteQuery(cmd);
                MessageBox.Show("Cập nhật thành công!");
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
