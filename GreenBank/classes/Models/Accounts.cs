using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBank.classes.Models
{
    public class Accounts
    {
        private int id; 
        private string name;
        private decimal balance;
        private decimal debit;
        private decimal credit;
        private int account_type_id;
        private string opening_date;
        private int loan_id;
        private int branch_id;
        private string description;
        private int customer_id;
        private int employee_id;

        public int Id { get => id; set => id = value; }
        public decimal Balance { get => balance; set => balance = value; }
        public decimal Debit { get => debit; set => debit = value; }
        public decimal Credit { get => credit; set => credit = value; }
        public int Account_type_id { get => account_type_id; set => account_type_id = value; }
        public string Opening_date { get => opening_date; set => opening_date = value; }
        public int Loan_id { get => loan_id; set => loan_id = value; }
        public int Branch_id { get => branch_id; set => branch_id = value; }
        public string Description { get => description; set => description = value; }
        public string Name { get => name; set => name = value; }
        public int Customer_id { get => customer_id; set => customer_id = value; }
        public int Employee_id { get => employee_id; set => employee_id = value; }
    }
}
