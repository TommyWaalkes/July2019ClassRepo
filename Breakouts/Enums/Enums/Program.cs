using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please input a number");
            int pick = int.Parse(Console.ReadLine()) % 6;
            Console.WriteLine($"The day you picked is {Enum.GetName(typeof(WeekDays), pick)}");

            House h = new House();
            while (true)
            {
                h.PrintCurrentRoom();
                Console.WriteLine("Which direction would you like to go?");
                string[] directions = Enum.GetNames(typeof(Directions));
                for(int i = 0; i < directions.Length; i++)
                {
                    Console.WriteLine($"{i}: {directions[i]}");
                }
                //int input = int.Parse(Console.ReadLine());
                int input = int.Parse(Console.ReadLine());
                Directions d = (Directions)input;
                h.MoveToRoom(d);
                Console.WriteLine();
                
            }
            
        }
    }
}
