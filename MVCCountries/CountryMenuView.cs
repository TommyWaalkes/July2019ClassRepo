using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    class CountryMenuView
    {
        public List<Country> countries;

        public CountryMenuView(List<Country> countries)
        {
            this.countries = countries;
        }

        public void Display()
        {
            for(int i = 0; i < countries.Count; i++)
            {
                Console.WriteLine(i + ":" + countries[i].Name);
            }

            Console.WriteLine("Please input a number to select a country");
        }
    }
}
