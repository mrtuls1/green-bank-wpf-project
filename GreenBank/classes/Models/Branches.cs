using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBank.classes.Models
{
    public class Branches
    {
        private int id;
        private string name;
        private string phone;
        private string adress;
        private float branch_case;
        public List<string> BranchesNameCollection = new List<string>();       
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Adress { get => adress; set => adress = value; }
        public float Branch_case { get => branch_case; set => branch_case = value; }
    }
}
