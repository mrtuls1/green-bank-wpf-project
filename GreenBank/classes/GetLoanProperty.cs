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
    public class GetLoanProperty
    {
        public static bool FillPage(Accounts account, Loans loan, string id)
        {
            byte state = 1;
            DatabaseConnection conn = new DatabaseConnection();
            SqlCommand command = new SqlCommand("select * from Accounts as ac inner join Loans as ln on ac.loan_id = ln.id where ac.id=" + id, conn.SqlConnect());

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

                    loan.Id = int.Parse(dr[12].ToString());
                    loan.Expiry = int.Parse(dr[13].ToString());
                    loan.Interest = decimal.Parse(dr[14].ToString());
                    loan.Quantity = decimal.Parse(dr[15].ToString());
                    loan.Installment = int.Parse(dr[16].ToString());
                    loan.Starting_date = DateTime.Parse(dr[17].ToString());
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
        public static bool GetLoans(DataGrid grd)
        {
            byte state = 1;
            DatabaseConnection conn = new DatabaseConnection();
            SqlCommand command = new SqlCommand("exec sel_Customer_Account_Loan", conn.SqlConnect());

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
        public static bool AddLoans(Loans loan, Accounts account, Customers customer)
        {
            sbyte state = 1;
            DatabaseConnection conn = new DatabaseConnection();
            try
            {
                SqlCommand command = new SqlCommand("insert into Loans (expiry,interest,quantity,installment,starting_date,end_date) values (@expiry,@interest,@quantity,@insallment,@starting_date,@end_date)", conn.SqlConnect());
                SqlCommand command1 = new SqlCommand("select top 1 id from Loans order by id desc", conn.SqlConnect());
                SqlCommand command2 = new SqlCommand("insert into Accounts (name,description,account_type_id,opening_date,branch_id,customer_id,loan_id) values (@name,@description,@account_type_id,@opening_date,@branch_id,@customer_id,@loan_id)", conn.SqlConnect());
                SqlCommand command3 = new SqlCommand("exec ins_Loan_Payments @loan_id,@quantity,@expiry,@installment,@interest,@starting_date", conn.SqlConnect());
                command.Parameters.AddWithValue("@expiry", loan.Expiry);
                command.Parameters.AddWithValue("@interest", loan.Interest);
                command.Parameters.AddWithValue("@quantity", loan.Quantity);
                command.Parameters.AddWithValue("@insallment", loan.Installment);
                command.Parameters.AddWithValue("@starting_date", loan.Starting_date);
                command.Parameters.AddWithValue("@end_date", loan.End_date);

                state = (sbyte)command.ExecuteNonQuery();

                SqlDataReader dr = command1.ExecuteReader();
                while (dr.Read()) loan.Id = int.Parse(dr[0].ToString());

                command2.Parameters.AddWithValue("@name", account.Name);
                command2.Parameters.AddWithValue("@description", account.Description);
                command2.Parameters.AddWithValue("@account_type_id", account.Account_type_id);
                command2.Parameters.AddWithValue("@opening_date", account.Opening_date);
                command2.Parameters.AddWithValue("@branch_id", account.Branch_id);
                command2.Parameters.AddWithValue("@customer_id", customer.Id);
                command2.Parameters.AddWithValue("@loan_id", loan.Id);

                state = (sbyte)command2.ExecuteNonQuery();

                command3.Parameters.AddWithValue("@loan_id",loan.Id);
                command3.Parameters.AddWithValue("@quantity",loan.Quantity);
                command3.Parameters.AddWithValue("@expiry",loan.Expiry);
                command3.Parameters.AddWithValue("@installment",loan.Installment);
                command3.Parameters.AddWithValue("@interest",loan.Interest);
                command3.Parameters.AddWithValue("@starting_date",loan.Starting_date);

                state = (sbyte)command3.ExecuteNonQuery();

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
        public static bool EditLoans(Accounts account, Loans loan, string id)
        {
            byte state = 1;
            DatabaseConnection conn = new DatabaseConnection();
            SqlCommand command = new SqlCommand("update Accounts set name=@name, account_type_id=@account_type_id, branch_id=@branch_id, description=@description where id="+ id, conn.SqlConnect());
            SqlCommand command1 = new SqlCommand("select loan_id from Accounts where id=@account_id order by loan_id desc ", conn.SqlConnect());
            SqlCommand command2 = new SqlCommand("update Loans set expiry=@expiry, interest=@interest, quantity=@quantity, installment=@installment  where id=@loan_id", conn.SqlConnect());

            try
            {
                command.Parameters.AddWithValue("name", account.Name);
                command.Parameters.AddWithValue("account_type_id", account.Account_type_id);
                command.Parameters.AddWithValue("branch_id", account.Branch_id);
                command.Parameters.AddWithValue("description", account.Description);
                command.ExecuteNonQuery();

                command1.Parameters.AddWithValue("@account_id", id);
                SqlDataReader dr= command1.ExecuteReader();
                while (dr.Read())
                {
                    loan.Id = int.Parse(dr[0].ToString());
                }

                command2.Parameters.AddWithValue("expiry", loan.Expiry);
                command2.Parameters.AddWithValue("interest", loan.Interest);
                command2.Parameters.AddWithValue("quantity", loan.Quantity);
                command2.Parameters.AddWithValue("installment", loan.Installment);
                command2.Parameters.AddWithValue("loan_id", loan.Id);
                command2.ExecuteNonQuery();
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
