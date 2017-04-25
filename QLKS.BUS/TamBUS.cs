using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLKS.DAO;
using QLKS.DTO;

namespace QLKS.BUS
{
    public class TamBUS
    {
        public List<Tam> LoadData()
        {
            return (new TamDAO().LoadData());
        }

        public void Insert(Tam t)
        {
            new TamDAO().Insert(t);
        }

        public Tam RoomInfo(string maPhong)
        {
            return (new TamDAO().RoomInfo(maPhong));
        }

        public void CancelRoom(string MaPhong)
        {
            new TamDAO().CancelRoom(MaPhong);
        }

        public string GetCMND(string cmnd)
        {
            return new TamDAO().GetCMND(cmnd);
        }
        public DateTime GetDate(string maphong)
        {
            return new TamDAO().GetDate(maphong);
        }
        public void Delete(string maPhong)
        {
            new TamDAO().Delete(maPhong);
        }
        public int GetSoNguoi(string maphong)
        {
            return new TamDAO().GetSoNguoi(maphong);
        }
    }
}
