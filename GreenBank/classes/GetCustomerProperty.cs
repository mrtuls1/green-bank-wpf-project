using GreenBank.classes.Models;
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
    public class GetCustomerProperty
    {
        public static bool GetCustomers(DataGrid grd)
        {
            byte state = 1;
            DatabaseConnection conn = new DatabaseConnection();
            SqlCommand command = new SqlCommand("select * from Customers", conn.SqlConnect());

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
        public static bool GetCustomers(Customers customers, string id)
        {
            byte state = 1;
            DatabaseConnection conn = new DatabaseConnection();
            SqlCommand command = new SqlCommand("select * from Customers where id=" + id, conn.SqlConnect());

            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    customers.Name = reader[1].ToString();
                    customers.Surname = reader[2].ToString();
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
        public static bool FillCustomers(Customers customers, string id)
        {
            byte state = 1;
            DatabaseConnection conn = new DatabaseConnection();
            SqlCommand command = new SqlCommand("select * from Customers where id=" + id, conn.SqlConnect());

            try
            {
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    customers.Name = dr[1].ToString();
                    customers.Surname = dr[2].ToString();
                    customers.Email = dr[3].ToString();
                    customers.Password = dr[4].ToString();
                    customers.Phone = dr[5].ToString();
                    customers.Adress = dr[6].ToString();
                    customers.Passaport_no = dr[7].ToString();
                    customers.Gender = dr[8].ToString();
                    customers.Birthday = dr[9].ToString();
                    customers.Country = dr[10].ToString();
                    customers.Province = dr[11].ToString();
                    customers.Distric = dr[12].ToString();
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
        public static bool AddCustomers(Customers customers)
        {
            sbyte state = 1;
            DatabaseConnection conn = new DatabaseConnection();
            SqlCommand command = new SqlCommand("insert into Customers(name, surname, email, password, phone, adress, passaport_no, gender, birthday,country,province,distric) values (@name, @surname, @email, @password, @phone, @adress, @passaport_no, @gender, @birthday, @country, @province, @distric)", conn.SqlConnect());

            command.Parameters.AddWithValue("@name", customers.Name);
            command.Parameters.AddWithValue("@surname", customers.Surname);
            command.Parameters.AddWithValue("@email", customers.Email);
            command.Parameters.AddWithValue("@password", customers.Password);
            command.Parameters.AddWithValue("@phone", customers.Phone);
            command.Parameters.AddWithValue("@adress", customers.Adress);
            command.Parameters.AddWithValue("@passaport_no", customers.Passaport_no);
            command.Parameters.AddWithValue("@gender", customers.Gender);
            command.Parameters.AddWithValue("@birthday", customers.Birthday);
            command.Parameters.AddWithValue("@country", customers.Country);
            command.Parameters.AddWithValue("@province", customers.Province);
            command.Parameters.AddWithValue("@distric", customers.Distric);
            try
            {
                state = (sbyte)command.ExecuteNonQuery();
                conn.SqlConnect().Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.SqlConnect().Dispose();
            }
            if (state > 0) return true; else return false;

        }
        public static bool EditCustomer(Customers customers, string id)
        {
            sbyte state = 1;
            DatabaseConnection conn = new DatabaseConnection();
            SqlCommand command = new SqlCommand("update Customers set name=@name, surname=@surname, email=@email, password=@password, phone=@phone, adress=@adress, passaport_no=@passaport_no, gender=@gender, birthday=@birthday, country=@country, province=@province, distric=@distric where id=" + id, conn.SqlConnect());
            command.Parameters.AddWithValue("@name", customers.Name);
            command.Parameters.AddWithValue("@surname", customers.Surname);
            command.Parameters.AddWithValue("@email", customers.Email);
            command.Parameters.AddWithValue("@password", customers.Password);
            command.Parameters.AddWithValue("@phone", customers.Phone);
            command.Parameters.AddWithValue("@adress", customers.Adress);
            command.Parameters.AddWithValue("@passaport_no", customers.Passaport_no);
            command.Parameters.AddWithValue("@gender", customers.Gender);
            command.Parameters.AddWithValue("@birthday", customers.Birthday);
            command.Parameters.AddWithValue("@country", customers.Country);
            command.Parameters.AddWithValue("@province", customers.Province);
            command.Parameters.AddWithValue("@distric", customers.Distric);
            try
            {
                state = (sbyte)command.ExecuteNonQuery();
                conn.SqlConnect().Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.SqlConnect().Dispose();
            }
            if (state > 0) return true; else return false;

        }
        public static bool DeleteCustomers(Customers customer, string id)
        {
            byte state = 1;
            DatabaseConnection conn = new DatabaseConnection();
            SqlCommand command = new SqlCommand("Delete from Customers where id=" + id, conn.SqlConnect());

            try
            {
                command.ExecuteNonQuery();
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
