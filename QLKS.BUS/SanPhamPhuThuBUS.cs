using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLKS.DAO;
using QLKS.DTO;

namespace QLKS.BUS
{
    public class SanPhamPhuThuBUS
    {
        public List<SanPhamPhuThu> LoadData()
        {
            return new SanPhamPhuThuDAO().LoadData();
        }
        public List<string> GetName()
        {
            return new SanPhamPhuThuDAO().GetName();
        }
        public double GetDonGia(string tensp)
        {
            return new SanPhamPhuThuDAO().GetDonGia(tensp);
        }

        public void Insert(SanPhamPhuThu sp)
        {
            new SanPhamPhuThuDAO().Insert(sp);
        }

        public void Delete(string maSP)
        {
            new SanPhamPhuThuDAO().Delete(maSP);
        }

        public void Update(SanPhamPhuThu sp)
        {
            new SanPhamPhuThuDAO().Update(sp);
        }
        public string getcode(string name)
        {
            return new SanPhamPhuThuDAO().GetCode(name);
        }
    }
}
