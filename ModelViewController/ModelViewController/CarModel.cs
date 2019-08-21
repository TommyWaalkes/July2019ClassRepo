using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewController
{
    class CarModel
    {
        List<string> CarNames { get; set; }
        public CarModel()
        {
            CarNames = new List<string>();
            CarNames.Add("Pope Mobile");
            CarNames.Add("Camry");
            CarNames.Add("Bat Mobile");
            CarNames.Add("Invisible Jet");
            CarNames.Add("Wienermobile");
        }

        public List<string> GetNames()
        {
            return CarNames;
        }
    }
}
