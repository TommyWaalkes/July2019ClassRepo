using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    class Country
    {
        public string Name { get; }
        public string Lang { get; set; }
        public string Hello { get; set; }
        public string[] Colors { get; set; }

        public Country(string Name, string Lang, string Hello, string[] Colors)
        {
            this.Name = Name;
            this.Lang = Lang;
            this.Hello = Hello;
            this.Colors = Colors;
        }
    }
}
