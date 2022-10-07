using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBank.classes.Models
{
    public class Towns
    {
        private int id;
        private int city_id;
        private string town_name;

        public List<string> TownNameCollection = new List<string>();

        public int Id { get => id; set => id = value; }
        public int City_id { get => city_id; set => city_id = value; }
        public string Town_name { get => town_name; set => town_name = value; }
    }
}
