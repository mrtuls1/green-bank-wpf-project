using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBank.classes.Models
{
    public class Payments
    {
        private int id;
        private DateTime payments_date;
        private decimal amount;
        private string detail;
        private bool is_it_paid;
        private int loan_id;

        public int Id { get => id; set => id = value; }
        public DateTime Payments_date { get => payments_date; set => payments_date = value; }
        public decimal Amount { get => amount; set => amount = value; }
        public string Detail { get => detail; set => detail = value; }
        public bool Is_it_paid { get => is_it_paid; set => is_it_paid = value; }
        public int Loan_id { get => loan_id; set => loan_id = value; }
    }
}
