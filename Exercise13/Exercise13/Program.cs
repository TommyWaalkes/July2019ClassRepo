using System;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number");
            int num;
            string input = Console.ReadLine();
            num = int.Parse(input);

            Console.WriteLine("Ascending");
           for(int i = 0; i <= num; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("Descending");
            for(int i = num; i >= 0; i--)
            {
                Console.WriteLine(i);
                if(i == 1)
                {
                    Console.WriteLine("We have lift off");
                }
            }

        }
    }
}
