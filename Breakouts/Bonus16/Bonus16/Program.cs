using System;

namespace Bonus16
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            //c.Price = 10;
            Console.WriteLine(c.Make);
            Console.WriteLine(c.Model);
            Console.WriteLine(c.Price);
            Console.WriteLine(c.Year);
        }
    }
}
