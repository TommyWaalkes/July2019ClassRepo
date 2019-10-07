using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Models
{
    public class Fish
    {
        public string Name { get; set; }
        public int Scales { get; set; }
        public string Species { get; set; }
        public bool IsFreshWater { get; set; }

        public Fish()
        {

        }

        public Fish(string Name, int Scales, string Species, bool IsFreshWater)
        {
            this.Name = Name;
            this.Scales = Scales;
            this.Species = Species;
            this.IsFreshWater = IsFreshWater;
        }
    }
}
