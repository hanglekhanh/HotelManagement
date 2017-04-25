using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLKS.DAO;
using QLKS.DTO;

namespace QLKS.BUS
{
    public class KhachBUS
    {
        public void Insert(Khach k)
        {
             new KhachDAO().Insert(k);
        }


        public string GetFullName(string CMND)
        {
            return (new KhachDAO().GetFullName(CMND));
        }

        public List<Khach> Find(string hoTen)
        {
            return new KhachDAO().Find(hoTen);
        }
    }
}
