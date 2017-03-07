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
    public class BUS_tblHocSinh
    {
        SQL_tblHocsinh bus = new SQL_tblHocsinh();
        public void addHocsinh(EC_tblHocsinh et)
        {
            bus.addHocsinh(et);
        }
        //Sua du lieu
        public void updateHocsinh(EC_tblHocsinh et)
        {
            bus.updateHocsinh(et);
        }
        //Xoa du lieu
        public void delHocsinh(EC_tblHocsinh et)
        {
            bus.delHocsinh(et);
        }
        //select
        public DataTable getAllHocsinh()
        {
            return bus.getAllHocsinh();
        }
        public DataTable getHocsinh(string dk)
        {
            return bus.getHocsinh(dk);
        }
        public DataTable getField(string Field)
        {
            return bus.getField(Field);
        }
        public DataTable DoDLMaLop(string dk)
        {
            return bus.DoDLMaLop(dk);
        }
        public DataTable LayMaHS()
        {
            return bus.LayRaMaHS();
        }
    }
}
