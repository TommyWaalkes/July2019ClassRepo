using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBreakout.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public string BirthYear { get; set; }


        public Person()
        {

        }

        public Person(JToken t)
        {
            this.Name = t["name"].ToString();
            this.Height = int.Parse(t["height"].ToString());
            this.BirthYear = t["birth_year"].ToString();
        }
    }
}
