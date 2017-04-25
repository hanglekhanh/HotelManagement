using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLKS.DTO;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QLKS.DAO
{
    public class SanPhamPhuThuDAO
    {
        DataProvider dp;
        public SanPhamPhuThuDAO()
        {
            dp = new DataProvider();
        }
        #region 1.Retriving
        public List<SanPhamPhuThu> LoadData()
        {
            try
            {
                dp.Connect();
                string sql = "Select * from SanPhamPhuThu";
                SqlDataReader dr = dp.ExecuteReader(sql);
                List<SanPhamPhuThu> list = new List<SanPhamPhuThu>();
                while (dr.Read())
                {
                    string MaSP = dr.GetValue(0).ToString();
                    string TenSP = dr.GetValue(1).ToString();
                    string DonViTinh = dr.GetValue(2).ToString();
                    double DonGia = Convert.ToDouble(dr.GetValue(3).ToString());
                    SanPhamPhuThu sp = new SanPhamPhuThu(MaSP, TenSP, DonViTinh, DonGia);
                    list.Add(sp);
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
        public List<string> GetName()
        {
            try
            {
                dp.Connect();
                string sql = "Select * from SanPhamPhuThu";
                SqlDataReader dr = dp.ExecuteReader(sql);
                List<string> list = new List<string>();
                while (dr.Read())
                {

                    string TenSP = dr.GetString(1);


                    string sp = TenSP;
                    list.Add(sp);
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
        public double GetDonGia(string TenSP)
        {
            try
            {
                dp.Connect();
                string sql = string.Format("Select DonGia from SanPhamPhuThu where TenSP = N'{0}'", TenSP);
                return Convert.ToDouble(dp.ExecuteScalar(sql));
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
        public string GetCode(string name)
        {
            try
            {
                dp.Connect();
                string sql = "Select MaSP from SanPhamPhuThu where TenSP=N'"+name +"'";


                return dp.ExecuteScalar(sql).ToString();
              

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
        #region Insert,Delete,Update

        public bool Exist(string maSP)
        {
            try
            {
                string sql = "SELECT * FROM SanPhamPhuThu WHERE MaSP = '" + maSP + "'";
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

        public void Insert(SanPhamPhuThu sp)
        {
            try
            {
                dp.Connect();
                if(Exist(sp.MaSP))
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại!");
                    return;
                }

                string sql = "INSERT INTO SanPhamPhuThu VALUES(@MaSP,@TenSP,@DonViTinh,@DonGia)";
                SqlCommand cmd = new SqlCommand(sql, dp.CN);
                cmd.Parameters.Add("@MaSP", sp.MaSP);
                cmd.Parameters.Add("@TenSP", sp.TenSP);
                cmd.Parameters.Add("@DonViTinh", sp.DonViTinh);
                cmd.Parameters.Add("DonGia", sp.DonGia);
                dp.ExecuteQuery(cmd);
                MessageBox.Show("Thêm thành công!");
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

        public void Delete(string maSP)
        {
            try
            {
                dp.Connect();
                if(!Exist(maSP))
                {
                    MessageBox.Show("Mã sản phẩm không đúng!");
                    return;
                }

                string sql = "DELETE FROM SanPhamPhuThu WHERE MaSP = '" + maSP + "'";
                dp.ExecuteQuery(sql);
                MessageBox.Show("Xóa thành công!");
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

        public void Update(SanPhamPhuThu sp)
        {
            try
            {
                dp.Connect();
                if(!Exist(sp.MaSP))
                {
                    MessageBox.Show("Mã sản phẩm sai!");
                    return;
                }

                string sql = "UPDATE SanPhamPhuThu SET MaSP = @MaSP, TenSP = @TenSP, DonViTinh = @DonViTinh, DonGia = @DonGia WHERE MaSP = @MaSP";
                SqlCommand cmd = new SqlCommand(sql, dp.CN);
                cmd.Parameters.Add("@MaSP", sp.MaSP);
                cmd.Parameters.Add("@TenSP", sp.TenSP);
                cmd.Parameters.Add("@DonViTinh", sp.DonViTinh);
                cmd.Parameters.Add("@DonGia", sp.DonGia);
                dp.ExecuteQuery(cmd);
                MessageBox.Show("Cập nhật thành công");
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
