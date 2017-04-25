using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLKS.DAO;
using QLKS.DTO;

namespace QLKS.BUS
{
    public class LichSuBanSPBUS
    {
        public void Insert(LichSuBanSP ls)
        {
            new LichSuBanSPDAO().Insert(ls);
        }
    }
}
