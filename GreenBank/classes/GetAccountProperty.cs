using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace GreenBank.classes.Models
{
    public class GetAccountProperty
    {
        #region Employee
        public static bool FillBranches(List<Branches> branches_list)
        {

            byte state = 1;
            DatabaseConnection conn = new DatabaseConnection();
            SqlCommand command = new SqlCommand("select * from Branches", conn.SqlConnect());
            try
            {
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    branches_list.Add(new Branches { Name = dr[1].ToString(), Id = int.Parse(dr[0].ToString()) });
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
        public static bool FillCustomers(List<Customers> customersList)
        {

            byte state = 1;
            DatabaseConnection conn = new DatabaseConnection();
            SqlCommand command = new SqlCommand("select * from Customers", conn.SqlConnect());
            try
            {

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    customersList.Add(new Customers { Name = dr[1].ToString(), Id = int.Parse(dr[0].ToString()) });
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
        public static bool FillAccountTypes(List<AccountTypes> account_types)
        {

            byte state = 1;
            DatabaseConnection conn = new DatabaseConnection();
            SqlCommand command = new SqlCommand("select * from Account_Types", conn.SqlConnect());
            try
            {

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    account_types.Add(new AccountTypes { Name = dr[1].ToString(), Id = int.Parse(dr[0].ToString()) });
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
        public static bool EditAccount(Accounts account, string id)
        {
            byte state = 1;
            DatabaseConnection conn = new DatabaseConnection();
            SqlCommand command = new SqlCommand("update Accounts set name=@name, account_type_id=@account_type_id, branch_id=@branch_id, description=@description where id="+id, conn.SqlConnect());

            try
            {
                command.Parameters.AddWithValue("name",account.Name);
                command.Parameters.AddWithValue("account_type_id", account.Account_type_id);
                command.Parameters.AddWithValue("branch_id", account.Branch_id);
                command.Parameters.AddWithValue("description",account.Description);
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
        public static bool GetAccounts(DataGrid grd)
        {
            byte state = 1;
            DatabaseConnection conn = new DatabaseConnection();
            SqlCommand command = new SqlCommand("exec sel_Customer_Accounts", conn.SqlConnect());

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
        public static bool AddCustomers(Accounts account, Customers customer)
        {
            sbyte state = 1;
            DatabaseConnection conn = new DatabaseConnection();
            try
            {
                SqlCommand command = new SqlCommand("insert into Accounts (name,description,account_type_id,opening_date,branch_id,customer_id) values (@name,@description,@account_type_id,@opening_date,@branch_id,@customer_id)", conn.SqlConnect());

                command.Parameters.AddWithValue("@name", account.Name);
                command.Parameters.AddWithValue("@description", account.Description);
                command.Parameters.AddWithValue("@account_type_id", account.Account_type_id);
                command.Parameters.AddWithValue("@opening_date", account.Opening_date);
                command.Parameters.AddWithValue("@branch_id", account.Branch_id);
                command.Parameters.AddWithValue("@customer_id", customer.Id);

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
        public static bool FillPage(Accounts account, string id)
        {
            byte state = 1;
            DatabaseConnection conn = new DatabaseConnection();
            SqlCommand command = new SqlCommand("select * from Accounts where id=" + id, conn.SqlConnect());

            try
            {
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    account.Name = dr[1].ToString();
                    account.Account_type_id = int.Parse(dr[5].ToString());
                    account.Branch_id = int.Parse(dr[8].ToString());
                    account.Description = dr[9].ToString();
                    account.Customer_id = int.Parse(dr[10].ToString());
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
        public static bool DeleteAccounts(Accounts account, string id)
        {
            byte state = 1;
            DatabaseConnection conn = new DatabaseConnection();
            SqlCommand command = new SqlCommand("Delete from Accounts where id=" + id, conn.SqlConnect());
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
        #endregion Employee

        #region Customer
        public static bool GetAccounts(DataGrid grd, string id)
        {
            byte state = 1;
            DatabaseConnection conn = new DatabaseConnection();
            SqlCommand command = new SqlCommand("select * from accounts where customer_id="+id, conn.SqlConnect());

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
        #endregion Customer
    }
}
