using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLKS.DTO;
using QLKS.DAO;

namespace QLKS.BUS
{
    public class NhanVienBUS
    {
        public bool LoginChecking(string user, string pass)
        {
            return new NhanVienDAO().LoginChecking(user,pass);
        }

        public string GetFullName(string maNV)
        {
            return new NhanVienDAO().GetFullName(maNV);
        }
        public bool UpdatePass(string user, string pass)
        {
            return new NhanVienDAO().UpdatePass(user, pass);
        }
    }
}
