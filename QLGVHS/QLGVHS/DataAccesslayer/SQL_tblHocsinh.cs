using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGCHS_ValueObject;
using System.Data;

namespace QLGVHS_DATA
{
    public class SQL_tblHocsinh
    {
        KetNoiDB cn = new KetNoiDB();
        //Them du lieu
        public void addHocsinh(EC_tblHocsinh et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO tblHocsinh ( MaHS, TenHS, GT,MaLop, NgaySinh, DiaChi, DanToc, TonGiao) 
values (N'" + et.MaHS + "',N'" + et.TenHS + "',N'" + et.GT + "', '"+et.MaLop+"' ,N'" + et.NgaySinh + "',N'" + et.DiaChi + "',N'" + et.DanToc + "',N'" + et.TonGiao  + "')");
        }
        //Sua du lieu
        public void updateHocsinh(EC_tblHocsinh et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE	tblHocsinh	SET TenHS ='" + et.TenHS + "', GT ='" + et.GT + "', NgaySinh =N'" + et.NgaySinh + "', DiaChi ='" + et.DiaChi + "', DanToc =N'" + et.DanToc + "', TonGiao =N'" + et.TonGiao + "'where MaHS = '"+et.MaHS+"'");
        }
        //Xoa du lieu
        public void delHocsinh(EC_tblHocsinh et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE FROM tblHocsinh WHERE MaHS = '" + et.MaHS + "'");
        }
        //select
        public DataTable getAllHocsinh()
        {
            return cn.getDatatable(@"SELECT * FROM tblHocsinh ");
        }
        public DataTable getHocsinh(string dk)
        {
            return cn.getDatatable(@"SELECT * FROM tblHocsinh " + dk);
        }
        public DataTable getField(string Field)
        {
            return cn.getDatatable(String.Format(@"SELECT distinct {0} FROM tblHocSinh",Field));
        }
        public DataTable DoDLMaLop(string dk)
        {
            return cn.getDatatable("SELECT MaLop FROM tblLop " + dk);
        }
        public DataTable LayRaMaHS()//lấy ra top 1 mã thiết bị có tên mã thiết bị là gì đó
        {
            return cn.getDatatable("select top 1  MaHS from tblHocSinh order by MaHS desc ");
        }
    }
}
