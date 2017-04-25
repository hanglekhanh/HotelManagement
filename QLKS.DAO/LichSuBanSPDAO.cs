using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using QLKS.DTO;

namespace QLKS.DAO
{
    public class LichSuBanSPDAO
    {
        DataProvider dp;
        public LichSuBanSPDAO()
        {
            dp =new DataProvider();
        }
        #region Insert
        public void Insert(LichSuBanSP ls)
        {
            try
            {
                dp.Connect();
                string sql = "Insert Into LichSuBanSP Values(@MaSP,@NgayBan,@TenSP,@SoLuong,@DonGia,@TongTien)";
                SqlCommand cmd = new SqlCommand(sql, dp.CN);
                cmd.Parameters.Add("@MaSP", ls.MaSP);
                cmd.Parameters.Add("@NgayBan", ls.NgayBan);
                cmd.Parameters.Add("@TenSP", ls.TenSP);
                cmd.Parameters.Add("@SoLuong", ls.SoLuong);
                cmd.Parameters.Add("@DonGia", ls.DonGia);
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
