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
    public class GetCitiesProperty
    {
        public static bool FillCities(Cities cities, string name)
        {

            byte state = 1;
            DatabaseConnection conn = new DatabaseConnection();
            SqlCommand command = new SqlCommand("select * from Cities as ct Inner join Countries as cr on cr.id=ct.country_id where cr.country_name=@name", conn.SqlConnect());
            try
            {
                command.Parameters.AddWithValue("@name", name);
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    cities.CityNameCollection.Add(dr[1].ToString());
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
