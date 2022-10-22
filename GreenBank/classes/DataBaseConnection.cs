using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBank.classes
{
    class DatabaseConnection
    {
        public static string ConnectionString = "Data Source=DESKTOP-VSJSA5G\\SQLSERVER;Initial Catalog=GreenBank;Integrated Security=True";
        public static string ConnState="";

        public SqlConnection SqlConnect()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    ConnState = "Veritabanına Bağlanıldı";
                    return conn;
                }
                catch (Exception)
                {
                    ConnState = "Veritabanı Bağlantı Hatası...";
                }
            }
            else { ConnState = "Veritabanına Bağlanıldı";}
            return conn;
        }
        public static void SqlConnectTest()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    try
                    {
                        conn.Open();
                        ConnState = "Veritabanına Bağlanıldı";
                    }
                    catch (Exception)
                    {
                        ConnState = "Veritabanı Bağlantı Hatası...";
                    }
                }
                else { ConnState = "Veritabanına Bağlanıldı"; }
            }
        }

      

    }
}
