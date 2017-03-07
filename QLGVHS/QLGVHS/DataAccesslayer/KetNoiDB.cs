using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace QLGVHS_DATA
{
    public class KetNoiDB
    {
        public static SqlConnection connect;
        public static string connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        //Mo ket noi
        public static void MoKetNoi()
        {
            if(KetNoiDB.connect == null)
            {
                KetNoiDB.connect = new SqlConnection(connectionString);
            }                                           
            if(KetNoiDB.connect.State != ConnectionState.Open )
            {
                KetNoiDB.connect.Open();
            }
        }
        //Dong ket noi
        public void DongKetNoi()
        {
            if(KetNoiDB.connect.State != null)
            {
                if (KetNoiDB.connect.State == ConnectionState.Open)
                {
                    KetNoiDB.connect.Close();
                }
            }
        }
        //Thuc thi cau lenh SQL: insert, update, delete
        public void ThucThiCauLenhSQL(string strSql)
        {
            try
            {
                MoKetNoi();
                SqlCommand sqlCmd = new SqlCommand(strSql, connect);
                sqlCmd.ExecuteNonQuery();
                DongKetNoi();
            }
            catch{}
        }
        
        //Lay du lieu ra bang: select
        public DataTable getDatatable(string strSql)
        {
            try 
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDa = new SqlDataAdapter(strSql, connect);
                sqlDa.Fill(dt);
                DongKetNoi();
                return dt;
            }
            catch { return null; }
        }

        //Lay gia tri dau cua bang khi select
        public string getValue(string strSql)
        {
            string temp = null;
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand(strSql, connect);
            SqlDataReader sqlDr = sqlCmd.ExecuteReader();
            while(sqlDr.Read())
            {
                temp = sqlDr[0].ToString();
            }
            DongKetNoi();
            return temp;

        }
    }
}
