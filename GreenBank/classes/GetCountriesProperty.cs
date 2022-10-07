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
    public class GetCountriesProperty
    {
   
        
        public static bool FillCountries(Countries countries)
        {
            
            byte state = 1;
            DatabaseConnection conn = new DatabaseConnection();
            SqlCommand command = new SqlCommand("select * from Countries", conn.SqlConnect());
            try
            {

                SqlDataReader dr = command.ExecuteReader();
                
                while (dr.Read())
                {
                    countries.CountryNameCollection.Add(dr[1].ToString());
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
