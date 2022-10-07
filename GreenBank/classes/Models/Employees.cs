using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBank.classes.Models
{
    public class Employees
    {
        private string name;
        private string surname;
        private string email;
        private string password;
        private string phone;
        private string adress;
        private string passaport_no;
        private string gender;

        private int id;
        private string country;
        private string province;
        private string distric;
        private int account_id;

        private string last_entry;
        private string birthday;

        private float salary;
        private string starting_date;
        private string working_hour;
        private float bonus;
        private int employee_unit_id; 
        private int employee_title_id;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Adress { get => adress; set => adress = value; }
        public string Passaport_no { get => passaport_no; set => passaport_no = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Id { get => id; set => id = value; }
        public string Country { get => country; set => country = value; }
        public string Province { get => province; set => province = value; }
        public string Distric { get => distric; set => distric = value; }
        public int Account_id { get => account_id; set => account_id = value; }
        public string Last_entry { get => last_entry; set => last_entry = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public float Salary { get => salary; set => salary = value; }
        public string Starting_date { get => starting_date; set => starting_date = value; }
        public string Working_hour { get => working_hour; set => working_hour = value; }
        public float Bonus { get => bonus; set => bonus = value; }
        public int Employee_unit_id { get => employee_unit_id; set => employee_unit_id = value; }
        public int Employee_title_id { get => employee_title_id; set => employee_title_id = value; }
    }
}
