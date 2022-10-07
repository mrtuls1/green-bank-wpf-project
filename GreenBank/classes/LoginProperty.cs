using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace GreenBank.classes
{
    public class LoginProperty
    {
        public static string LoginCheck(string passaport, string password)
        {
            string state="";
            DatabaseConnection conn = new DatabaseConnection();
            SqlCommand command = new SqlCommand("select passaport_no,password from Customers where passaport_no= @passaport_no and password= @password",conn.SqlConnect());
            SqlCommand command2 = new SqlCommand("select passaport_no,password from Employees where passaport_no= @passaport_no and password= @password", conn.SqlConnect());
            command.Parameters.AddWithValue("@passaport_no", passaport);
            command.Parameters.AddWithValue("@password", password);
            command2.Parameters.AddWithValue("@passaport_no", passaport);
            command2.Parameters.AddWithValue("@password", password);
            string tempPassaport="";
            string tempPassword="";

            try
            {
                SqlDataReader dr = command.ExecuteReader();
                
                while (dr.Read())
                {
                   tempPassaport = dr[0].ToString();
                   tempPassword= dr[1].ToString();
                }
                if (passaport == tempPassaport && password == tempPassword) state = "customer";
                else
                {
                    SqlDataReader dr2 = command2.ExecuteReader();
                    while (dr2.Read())
                    {
                        tempPassaport = dr2[0].ToString();
                        tempPassword = dr2[1].ToString();
                    }
                    if (passaport == tempPassaport && password == tempPassword) state = "employee";
                    else state = "error";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.SqlConnect().Dispose();
            }
            return state;
        }
    }
}
