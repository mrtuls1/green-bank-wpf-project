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
    public class GetPaymentsProperty
    {
        public static bool GetAccount(DataGrid grd)
        {
            byte state = 1;
            DatabaseConnection conn = new DatabaseConnection();
            SqlCommand command = new SqlCommand("exec sel_Loan_Payments", conn.SqlConnect());

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                grd.ItemsSource = null;
                grd.ItemsSource = dt.DefaultView;
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
        public static bool GetPayment(DataGrid grd,string id)
        {
            byte state = 1;
            DatabaseConnection conn = new DatabaseConnection();
            SqlCommand command = new SqlCommand("select * from Payments where loan_id="+id, conn.SqlConnect());

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                grd.ItemsSource = null;
                grd.ItemsSource = dt.DefaultView;
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
