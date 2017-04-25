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
            return (new NhanVienDAO().LoginChecking(user,pass));
        }

        public bool IsAdmin(string user, string pass)
        {
            return (new NhanVienDAO().IsAdmin(user, pass));
        }

        public string GetFullName(string maNV)
        {
            return (new NhanVienDAO().GetFullName(maNV));
        }

        public List<NhanVien> LoadData()
        {
            return (new NhanVienDAO().LoadData());
        }

        public void Insert(NhanVien nv)
        {
            new NhanVienDAO().Insert(nv);
        }

        public void Delete(string maNV)
        {
            new NhanVienDAO().Delete(maNV);
        }

        public void Update(NhanVien nv)
        {
            new NhanVienDAO().Update(nv);
        }

        public bool UpdatePass(string user, string pass)
        {
            return new NhanVienDAO().UpdatePass(user, pass);
        }
    }
}
