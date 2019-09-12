using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    class AsiaDB
    {
        public List<Country> Countries = new List<Country>();

        public AsiaDB()
        {
            string[] VietnamColors = { "Red", "Gold" };
            Countries.Add(new Country("Vietnam", "Vietnamese", "Du ma!", VietnamColors));
            string[] MyanmarColors = { "Gold", "Red", "Green" };
            Countries.Add(new Country("Myanmar", "Burmese", "Hi there!", MyanmarColors));
            string[] ThailandColors = { "Red", "White", "Blue" };
            Countries.Add(new Country("Thailand","Thai", "Hello! ", ThailandColors));

        }
    }
}
