using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBank.classes.Models
{
    public class Customers
    {
        #region Static Parameters
        #endregion Static Parameters

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
        
        private string last_entry;
        private string birthday;

        public List<string> CustomersNameCollection = new List<string>();
        public List<string> CustomersSurnameCollection = new List<string>();

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Adress { get => adress; set => adress = value; }
        public string Passaport_no { get => passaport_no; set => passaport_no = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Id { get => id; set => id = value; }
        public string Country { get => country; set => country= value; }
        public string Province { get => province; set => province= value; }
        public string Distric { get => distric; set => distric= value; }
        public string Last_entry { get => last_entry; set => last_entry = value; }
        public string Birthday { get => birthday; set => birthday = value; }

       
    }
}
