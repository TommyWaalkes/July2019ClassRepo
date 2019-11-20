using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment7aSolution.Models
{
    public class AnimalInfo
    {
        public string Species { get; set; }
        public string Diet { get; set; }
        public string Habitat { get; set; }


        public AnimalInfo(JToken t)
        {
            this.Diet = t["diet"].ToString();
            this.Habitat = t["habitat"].ToString();
            this.Species = t["name"].ToString();
        }
    }
}
