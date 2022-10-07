using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBank.classes.Models
{
    public class Cities
    {
        private int id;
        private int country_id;
        private string city_name;

        public List<string> CityNameCollection = new List<string>();

        public int Id { get => id; set => id = value; }
        public int Country_id { get => country_id; set => country_id = value; }
        public string City_name { get => city_name; set => city_name = value; }
    }
}
