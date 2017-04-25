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
        public bool CheckExist(Tam t)
        {
            return (new TamDAO().CheckExist(t));
        }
        public void Insert(Tam t)
        {
            new TamDAO().Insert(t);
        }
    }
}
