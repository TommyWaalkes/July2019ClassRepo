using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    class CountryDetails
    {
        Country Country;
        public CountryDetails(Country Country)
        {
            this.Country = Country;
        }

        public void Display()
        {
            Console.WriteLine("Country: " + Country.Name);
            Console.WriteLine("Language: " + Country.Lang);
            Console.WriteLine("Greeting: " + Country.Hello);
            Console.WriteLine("Colors: ");
            foreach(string color in Country.Colors)
            {
                Console.WriteLine(color);
            }

        }
    }
}
