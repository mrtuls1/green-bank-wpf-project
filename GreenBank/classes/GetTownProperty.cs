using GreenBank.classes.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GreenBank.classes
{
    public class GetTownProperty
    {
        public static bool FillTowns(Towns cities, string name)
        {

            byte state = 1;
            DatabaseConnection conn = new DatabaseConnection();
            SqlCommand command = new SqlCommand("select * from Towns as tw Inner join Cities as ct on ct.id = tw.city_id where ct.city_name =@name", conn.SqlConnect());
            try
            {
                command.Parameters.AddWithValue("@name", name);
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    cities.TownNameCollection.Add(dr[1].ToString());
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
            if (state > 0) return true; else return false;
        }
    }
}
