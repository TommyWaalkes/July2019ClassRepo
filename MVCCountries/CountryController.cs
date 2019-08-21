using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    class CountryController
    {
        public void CountryDetails(Country c)
        {
            CountryDetails cd = new CountryDetails(c);
            cd.Display();
        }

        public void CountryMenu()
        {
            Console.WriteLine("What Continent Would you like to learn about?");
            Console.WriteLine("asia");
            Console.WriteLine("north america");
            string input = Console.ReadLine();
            List<Country> countries = new List<Country>(); 
            if(input.ToLower() == "north america")
            {
                NorthAmericaDB nadb = new NorthAmericaDB();
                countries = nadb.Countries;
            }
            else if(input.ToLower() == "asia")
            {
                AsiaDB aDb = new AsiaDB();
                countries = aDb.Countries;
            }

            int index = 0; 
            CountryMenuView menu = new CountryMenuView(countries);
            menu.Display();
            Country c;
            try
            {
                index = int.Parse(Console.ReadLine());
                c = countries[index];
                if (index < 0 || index > countries.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                

            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Index is out of range, it has been set to 0");
                c = countries[0];
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Index is out of range, it has been set to 0");
                c = countries[0];
            }

            CountryDetails(c);

        }

        
    }
}
