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
    public class BUS_tblUser
    {
        SQL_tblUser bus = new SQL_tblUser();
        public void addUser(EC_tblUser et)
        {
            bus.addUser(et);
        }
        //Sua du lieu
        public void updateUser(EC_tblUser et)
        {
            bus.updateUser(et);
        }
        //Xoa du lieu
        public void delUser(EC_tblUser et)
        {
            bus.delUser(et);
        }
        //select
        public DataTable getAlluser()
        {
            return bus.getAlluser();
        }
        public DataTable getUser(string dk)
        {
            return bus.getUser(dk);
        }
        // check login
        public string checkLogin(string Username, string Password)
        {
            return bus.checkLogin(Username, Password);
        }

        public DataTable getUserinfo(string dk)
        {
            return bus.getUserinfo(dk);
        }

        public string checkUser(string Username)
        {
            return bus.checkUser(Username);
        }

        public EC_tblUser getUser(string Username,string Password)
        {
            EC_tblUser ecUser = new EC_tblUser();
            DataTable tb = bus.getUser(@" where Username='" + Username + "' and Password = '" + Password + "'");
            if(tb.Rows.Count >=0 )
            {
                ecUser.Username = tb.Rows[0]["Username"].ToString();
                ecUser.Password = tb.Rows[0]["Password"].ToString();
                ecUser.MaGV = tb.Rows[0]["MaGV"].ToString();
                ecUser.Quyen = tb.Rows[0]["Quyen"].ToString();
            }
            return ecUser;
        }
    }

}
