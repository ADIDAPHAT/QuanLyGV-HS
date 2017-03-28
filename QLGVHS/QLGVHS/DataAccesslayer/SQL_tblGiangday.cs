using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGCHS_ValueObject;
using System.Data;

namespace QLGVHS_DATA
{
    public class SQL_tblGiangday
    {
        KetNoiDB cn = new KetNoiDB();
        //Them du lieu
        public void addGiangday(EC_tblGiangday et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO tblGiangday(MaGV , MaLop, Thu, Tietday) values('" + et.MaGV + "','" + et.MaLop + "'," + et.Thu + ",'" + et.Tietday + "')");
        }
        //Sua du lieu
        public void updateGiangday(EC_tblGiangday et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE tblGiangday SET Thu = '" + et.Thu + "', Tietday = '" + et.Tietday + "' WHERE MaGV = '" + et.MaGV + "' and MaLop = '" + et.MaLop + "' and Thu = " + et.Thu + "");
        }
        //Xoa du lieu
        public void delGiangday(EC_tblGiangday et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE FROM tblGiangday WHERE MaGV = '" + et.MaGV + "' and MaLop = '" + et.MaLop + "' and Tietday = '" + et.Tietday + "' and Thu = " + et.Thu + "");
        }
        //select
        public DataTable getAllGiangday()
        {
            return cn.getDatatable(@"SELECT * FROM tblGiangday ");
        }
        public DataTable getAllGiangday(string dk)
        {
            return cn.getDatatable(@"SELECT * FROM tblGiangday " + dk);
        }
        //select chi tiet
        public DataTable getThongTinGD()
        {
            return cn.getDatatable(@"SELECT TenGV as HoTen , Thu, Tietday, TenLop FROM tblGiangday, tblGiaovien, tblLop where tblGiangday.MaGV = tblGiaoVien.MaGV and tblGiangday.MaLop = tblLop.MaLop order by HoTen, TenLop");
        }
        public DataTable getThongTinGD(string dk)
        {
            return cn.getDatatable(@"SELECT TenGV as HoTen , Thu, Tietday, TenLop FROM tblGiangday, tblGiaovien, tblLop where tblGiangday.MaGV = tblGiaoVien.MaGV and tblGiangday.MaLop = tblLop.MaLop " + dk + " order by HoTen, TenLop");
        }
    }
}
