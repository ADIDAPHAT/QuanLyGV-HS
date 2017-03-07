using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGCHS_ValueObject;
using System.Data;

namespace QLGVHS_DATA
{
    public class SQL_tblGiaovien
    {
        KetNoiDB cn = new KetNoiDB();
        //Them du lieu
        public void addGiaovien(EC_tblGiaovien et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO tblGiaovien	(MaGV, TenHS, GT, SDT, NgaySinh, DiaChi, Luong, MaMon)    VALUES   ( '"+et.MaGV+"' , N'"+et.TenGV+"', N'"+et.GT+"', '"+et.SDT+"', '"+et.NgaySinh+"', N'"+et.DiaChi+"', "+et.Luong+", '"+et.MaMon+"')");
        }
        //Sua du lieu
        public void updateGiaovien(EC_tblGiaovien et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE   tblGiaovien   SET TenHS =N'"+et.TenGV+"', GT =N'"+et.GT+"', NgaySinh = '"+et.NgaySinh+"', SDT = '"+et.SDT+"', Luong = '"+et.Luong+"', DiaChi = N'"+et.DiaChi+"', MaMon = '"+et.MaMon+"' WHERE MaGV = '"+et.MaGV+"'");
        }
        //Xoa du lieu
        public void delGiaovien(EC_tblGiaovien et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE FROM tblGiaovien WHERE MaGV = '"+et.MaGV+"'");
        }
        //select
        public DataTable getAllgiaovien()
        {
            return cn.getDatatable(@"SELECT * FROM tblGiaovien ");
        }
        public DataTable getAllgiaovien(string dk)
        {
            return cn.getDatatable(@"SELECT * FROM tblGiaovien " + dk);
        }
        //select chi tiet
        public DataTable getThongTinGV()
        {
            return cn.getDatatable(@"SELECT MaGV, TenHS as HoTen, GT, NgaySinh, SDT, DiaChi, Luong, MaMon FROM tblGiaovien");
        }
        public DataTable getThongTinGV(string dk)
        {
            return cn.getDatatable(@"SELECT MaGV, TenHS as HoTen, GT, NgaySinh, SDT, DiaChi, Luong, MaMon FROM tblGiaovien where " + dk);
        }
        public DataTable getField(string Field)
        {
            return cn.getDatatable(String.Format(@"SELECT distinct {0} FROM tblGiaovien", Field));
        }
        public DataTable getGiaovien(string dk)
        {
            return cn.getDatatable(@"SELECT * FROM tblGiaovien " + dk);
        }
        public DataTable getGT()
        {
            return cn.getDatatable(@"SELECT distinct GT FROM tblGiaovien");
        }
    }
}
