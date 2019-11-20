using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment7aSolution.Models
{
    public class AnimalListing
    {
        public string Name { get; set; }
        public string Species { get; set; }

        public AnimalListing()
        {

        }

        public AnimalListing(JToken t)
        {
            this.Name = t["name"].ToString();
            this.Species = t["species"]["name"].ToString();
        }
    }
}
