using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLKS.DAO;
using QLKS.DTO;

namespace QLKS.BUS
{
    public class PhongBUS
    {
        public double GetGiaNgay(string maphong)
        {
            return new PhongDAO().GetDonGia(maphong);
        }

        public List<Phong> LoadData()
        {
            return new PhongDAO().LoadData();
        }

        public void Update(Phong p)
        {
            new PhongDAO().Update(p);
        }
    }
}
