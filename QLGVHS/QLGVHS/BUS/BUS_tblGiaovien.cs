using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGVHS_DATA;
using QLGCHS_ValueObject;
using System.Data;

namespace QLGVHS_BUS
{
    public class BUS_tblGiaovien
    {
        SQL_tblGiaovien bus = new SQL_tblGiaovien();
        public void addGiaovien(EC_tblGiaovien et)
        {
            bus.addGiaovien(et);
        }
        //Sua du lieu
        public void updateGiaovien(EC_tblGiaovien et)
        {
            bus.updateGiaovien(et);
        }
        //Xoa du lieu
        public void delGiaovien(EC_tblGiaovien et)
        {
            bus.delGiaovien(et);
        }
        //select
        public DataTable getAllgiaovien()
        {
            return bus.getAllgiaovien();
        }
        public DataTable getgiaovien(string dk)
        {
            return bus.getGiaovien(dk);
        }
        public DataTable getField(string Field)
        {
            return bus.getField(Field);
        }
    }
}
