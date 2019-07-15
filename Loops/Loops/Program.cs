using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; 
            while (i<10)
            {
                Console.WriteLine(i);
                Console.WriteLine("Helloworld");
                i++;
            }

            Console.WriteLine();
            Console.WriteLine("For Loop Starting");
            
            for(int j = 0; j<10; j++)
            {
                if (j == 5 || j == 10)
                {
                    continue;
                }
                Console.WriteLine("Hello World");
                Console.WriteLine(j);
               
            }
        }
    }
}
