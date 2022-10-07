using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBank.classes.Models
{
    public class AccountTypes
    {
        private int id;
        private string name;
        public List<string> AccountTypesNameCollection = new List<string>();
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
