using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBreakout.Models
{
    public class Planet
    {
        public string Name { get; set; }
        public string Climate { get; set; }
        public List<string> ResidentUrls { get; set; }

        public Planet()
        {

        }

        public Planet(JToken t)
        {
            this.Name = t["name"].ToString();
            this.Climate = t["climate"].ToString();
            List<JToken> residents = t["residents"].ToList();

            this.ResidentUrls = new List<string>();

            foreach(JToken resident in residents)
            {
                ResidentUrls.Add(resident.ToString());
            }
        }

    }
}
