using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockAssessment7.Models
{
    public class Donut
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public string PhotoUrl { get; set; }
        public List<string> Extras { get; set; }

        public Donut()
        {

        }

        public Donut(JToken t)
        {
            this.Name = t["name"].ToString();
            this.Id = int.Parse(t["id"].ToString());
            this.Calories = int.Parse(t["calories"].ToString());
            this.Extras = new List<string>();
            if (t["extras"] != null)
            {
                foreach (JToken extra in t["extras"].ToList())
                {
                    this.Extras.Add(extra.ToString());
                }
            }

            if (t["photo"] != null)
            {
                this.PhotoUrl = t["photo"].ToString();
            }
            
        }
    }
}
