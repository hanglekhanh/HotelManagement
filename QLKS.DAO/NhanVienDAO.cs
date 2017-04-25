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
        public List<NhanVien> LoadData()
        {
            try
            {
                dp.Connect();
                string sql = "SELECT * FROM NhanVien";
                SqlDataReader dr = dp.ExecuteReader(sql);
                List<NhanVien> list = new List<NhanVien>();
                while(dr.Read())
                {
                    string maNV = dr.GetValue(0).ToString();
                    string ho = dr.GetValue(1).ToString();
                    string ten = dr.GetValue(2).ToString();
                    DateTime ngaySinh = Convert.ToDateTime(dr.GetValue(3).ToString());
                    string gioiTinh = dr.GetValue(4).ToString();
                    string dienThoai = dr.GetValue(5).ToString();
                    string diaChi = dr.GetValue(6).ToString();
                    string chucVu = dr.GetValue(7).ToString();
                    string matKhau = dr.GetValue(8).ToString();
                    NhanVien nv = new NhanVien(maNV, ho, ten, ngaySinh, gioiTinh, dienThoai, diaChi, chucVu, matKhau);
                    list.Add(nv);
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

        public bool LoginChecking(string user, string pass)
        {
            try
            {
                dp.Connect();
                string sql = "Select MaNV from NhanVien where MaNV = '" + user + "' and MatKhau = '" + pass + "'";
                if (Exist(sql))
                    return true;
                else MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo");
                    return false;

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

        public bool IsAdmin(string user, string pass)
        {
            try
            {
                dp.Connect();
                if(user == "AD001" || user == "ad001")
                {
                    string sql = "SELECT * FROM NhanVien WHERE MaNV = 'AD001' AND MatKhau = '" + pass + "'";
                    if (Exist(sql))
                    {
                        return true;
                    }
                }
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                return false;
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

        public string GetFullName(string maNV)
        {
            try
            {
                dp.Connect();
                string sql = "SELECT Ho + ' ' + Ten as HoTen FROM NhanVien WHERE MaNV = '" + maNV + "'";
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

        #region 2.Insert, Update, Delete
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
        
        public void Insert(NhanVien nv)
        {
            try
            {
                dp.Connect();
                string check = "SELECT MaNV from NhanVien WHERE MaNV = '" + nv.MaNV + "'";
                if(!Exist(check))
                {
                    string sql = "INSERT INTO NhanVien Values(@MaNV,@Ho,@Ten,@NgaySinh,@GioiTinh,@DienThoai,@DiaChi,@ChucVu,@MatKhau)";
                    SqlCommand cmd = new SqlCommand(sql, dp.CN);
                    cmd.Parameters.Add("@MaNV", nv.MaNV);
                    cmd.Parameters.Add("@Ho", nv.Ho);
                    cmd.Parameters.Add("@Ten", nv.Ten);
                    cmd.Parameters.Add("@NgaySinh", nv.NgaySinh.ToString());
                    cmd.Parameters.Add("@GioiTinh", nv.GioiTinh);                 
                    cmd.Parameters.Add("@DienThoai", nv.DienThoai);
                    cmd.Parameters.Add("@DiaChi", nv.DiaChi);
                    cmd.Parameters.Add("@ChucVu", nv.ChucVu);
                    cmd.Parameters.Add("@MatKhau", nv.MatKhau);
                    dp.ExecuteQuery(cmd);
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại!");
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

        public void Delete(string maNV)
        {
            try
            {
                dp.Connect();
                string check = "SELECT MaNV from NhanVien WHERE MaNV = '" + maNV + "'";
                if(Exist(check))
                {
                    string sql = "DELETE FROM NhanVien WHERE MaNV = '" + maNV + "'";
                    dp.ExecuteQuery(sql);
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Mã nhân viên không đúng!");
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

        public void Update(NhanVien nv)
        {
            try
            {
                dp.Connect();
                string check = "SELECT MaNV FROM NhanVien WHERE MaNV = '" + nv.MaNV + "'";
                if (Exist(check))
                {
                    string sql = "UPDATE NhanVien SET MaNV =@MaNV,Ho = @Ho, Ten = @Ten,NgaySinh = @NgaySinh,GioiTinh = @GioiTinh,DienThoai = @DienThoai, DiaChi = @DiaChi, ChucVu = @ChucVu, MatKhau = @MatKhau WHERE MaNV = '" + nv.MaNV+"'";
                    SqlCommand cmd = new SqlCommand(sql, dp.CN);
                    cmd.Parameters.Add("@MaNV", nv.MaNV);
                    cmd.Parameters.Add("@Ho", nv.Ho);
                    cmd.Parameters.Add("@Ten", nv.Ten);
                    cmd.Parameters.Add("@NgaySinh", nv.NgaySinh.ToString());
                    cmd.Parameters.Add("@GioiTinh", nv.GioiTinh);
                    cmd.Parameters.Add("@DienThoai", nv.DienThoai);
                    cmd.Parameters.Add("@DiaChi", nv.DiaChi);
                    cmd.Parameters.Add("@ChucVu", nv.ChucVu);
                    cmd.Parameters.Add("@MatKhau", nv.MatKhau);
                    dp.ExecuteQuery(cmd);
                    MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Mã nhân viên không tồn tại");
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
