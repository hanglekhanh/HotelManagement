using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLKS.DAO;
using QLKS.DTO;

namespace QLKS.BUS
{
    public class LichSuThuePhongBUS
    {
        public List<LichSuThuePhong> LoadData()
        {
            return new LichSuThuePhongDAO().LoadData();
        }
        public void Insert(LichSuThuePhong ls)
        {
            new LichSuThuePhongDAO().Insert(ls);
        }
    }
}
