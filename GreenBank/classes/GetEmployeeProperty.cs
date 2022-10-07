using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GreenBank.classes.Models
{
    public class GetEmployeeProperty
    {
        public static Employees GetEmployee(Employees employee,EmployeeTitles emplooye_titles,EmployeeUnits emplooye_units, string id)
        {
            byte state = 1;
            DatabaseConnection conn = new DatabaseConnection();
            SqlCommand command = new SqlCommand("select * from Employees as em inner join Employee_Titles as et on et.id=em.employee_title_id inner join Employee_Units as eu on et.id=em.employee_title_id where passaport_no=" + id, conn.SqlConnect());

            try
            {
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    employee.Name = dr[1].ToString();
                    employee.Surname = dr[2].ToString();
                    employee.Email = dr[3].ToString();
                    employee.Password = dr[4].ToString();
                    employee.Phone = dr[5].ToString();
                    employee.Adress = dr[6].ToString();
                    employee.Passaport_no = dr[7].ToString();
                    employee.Gender = dr[8].ToString();
                    employee.Birthday = dr[9].ToString();
                    employee.Country = dr[10].ToString();
                    employee.Province = dr[11].ToString();
                    employee.Distric = dr[12].ToString();
                    employee.Last_entry= dr[13].ToString();
                    employee.Account_id= Convert.ToInt32(dr[15].ToString());
                    employee.Salary= float.Parse(dr[16].ToString());
                    employee.Starting_date= dr[17].ToString();
                    employee.Working_hour= dr[18].ToString();
                    employee.Bonus= float.Parse(dr[19].ToString());
                    employee.Employee_unit_id= int.Parse(dr[20].ToString());
                    employee.Employee_title_id= int.Parse(dr[21].ToString());
                    emplooye_units.Name= dr[23].ToString();
                    emplooye_titles.Name= dr[25].ToString();
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
            return employee;
        }
    }
}
