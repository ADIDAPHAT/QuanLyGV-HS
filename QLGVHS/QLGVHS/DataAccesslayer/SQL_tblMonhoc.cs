using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGCHS_ValueObject;
using System.Data;

namespace QLGVHS_DATA
{
    public class SQL_tblMonhoc
    {
        KetNoiDB cn = new KetNoiDB();
        //Them du lieu
        public void addMonhoc(EC_tblMonhoc et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO tblMonhoc	");
        }
        //Sua du lieu
        public void updateMonhoc(EC_tblMonhoc et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE	tblMonhoc	SET   ");
        }
        //Xoa du lieu
        public void delMonhoc(EC_tblMonhoc et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE FROM tblMonhoc WHERE MaMon= '" + et.MaMon + "'");
        }
        //select
        public DataTable getAllMonhoc()
        {
            return cn.getDatatable(@"SELECT * FROM tblMonhoc ");
        }
        public DataTable getMonhoc(string dk)
        {
            return cn.getDatatable(@"SELECT * FROM tblMonhoc " + dk);
        }
        public DataTable TenMon(string dk)
        {
            return cn.getDatatable(@"SELECT TenMon FROM tblMonhoc " + dk);
        }
    }
}
