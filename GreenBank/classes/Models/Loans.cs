using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBank.classes.Models
{
    public class Loans
    {
        private int id;
        private int expiry;
        private decimal interest;
        private decimal quantity;
        private int installment;
        private DateTime starting_date;
        private DateTime end_date;

        public int Id { get => id; set => id = value; }
        public int Expiry { get => expiry; set => expiry = value; }
        public decimal Interest { get => interest; set => interest = value; }
        public decimal Quantity { get => quantity; set => quantity = value; }
        public int Installment { get => installment; set => installment = value; }
        public DateTime Starting_date { get => starting_date; set => starting_date = value; }
        public DateTime End_date { get => end_date; set => end_date = value; }
    }
}
