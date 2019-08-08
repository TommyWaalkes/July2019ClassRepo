using System;
using System.Collections.Generic;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            List<string> names = new List<string>{ "Jeff", "James", "Jane", "Jake" };
            for (int i = 0; i < 100; i++)
            {
                int indexRandom = r.Next(0, names.Count);
                string name = names[indexRandom];
                Console.WriteLine(name);
            }

            Console.WriteLine("Please input the number of sides for the dice you will roll");
            string input = Console.ReadLine();
            int sides = int.Parse(input);
            while (true) {
                int roll1 = RollDie(sides, r);
                int roll2 = RollDie(sides, r);

                Console.WriteLine(roll1);
                Console.WriteLine(roll2);

                Console.WriteLine("Would you like to roll again? y/n");
                string answer = Console.ReadLine();
                if(answer == "n")
                {
                    break;
                }
            }
        }

        public static int RollDie(int sides, Random r)
        {
            int output = r.Next(1, sides + 1);
            return output;
        }
    }
}
