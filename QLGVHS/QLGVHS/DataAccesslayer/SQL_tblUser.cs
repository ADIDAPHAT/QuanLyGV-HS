using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGCHS_ValueObject;
using System.Data;

namespace QLGVHS_DATA
{
    public class SQL_tblUser
    {
        KetNoiDB cn = new KetNoiDB();
        //Them du lieu
        public void addUser(EC_tblUser et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO tblUser	(Username, Password, MaGV, Quyen)	VALUES('"+et.Username+"','"+et.Password+"','"+et.MaGV+"',"+et.Quyen+")");
        }
        //Sua du lieu
        public void updateUser(EC_tblUser et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE	tblUser	SET   MaGV ='" + et.MaGV + "', Quyen = " + et.Quyen + ",Password ='" + et.Password + "' WHERE Username ='" + et.Username + "'");
        }
        //Xoa du lieu
        public void delUser(EC_tblUser et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE FROM tblUser WHERE Username ='" + et.Username + "' and Password ='" + et.Password + "'");
        }
        //select
        public DataTable getAlluser()
        {
            return cn.getDatatable(@"SELECT * FROM tblUser ");
        }
        public DataTable getUser(string dk)
        {
            return cn.getDatatable(@"SELECT * FROM tblUser " + dk);
        }
        // check login
        public string checkLogin(string Username, string Password)
        {
            return cn.getValue(@"SELECT Quyen FROM tblUser WHERE Username ='" + Username + "' and Password ='" + Password + "'");
        }
        public DataTable getUserinfo(string dk)
        {
            return cn.getDatatable(@"Select u.Username, u.Password, u.MaGV, u.TenQuyen, g.Ho, g.TenHS 
                                    from (select Username,Password,MaGV,TenQuyen from tblUser,tblPhanquyen where tblUser.Quyen = tblPhanquyen.Quyen) u left join tblGiaovien g 
                                    on u.MaGV = g.MaGV " + dk);
        }

        public string checkUser(string Username)
        {
            return cn.getValue(@"select * from tblUser where Username = '"+Username+"'");
        }
    }
}
