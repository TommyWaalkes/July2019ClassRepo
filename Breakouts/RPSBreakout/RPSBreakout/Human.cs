using System;
using System.Collections.Generic;
using System.Text;

namespace RPSBreakout
{
    class Human : Player
    {
        public Human(string Name) : base(Name)
        {

        }
        public override string GetRPS()
        {
            Console.WriteLine("Hello there! Please select from the following: ");
            Console.WriteLine("1) Rock");
            Console.WriteLine("2) Paper");
            Console.WriteLine("3) Scissors");

            string input = Console.ReadLine().Trim();

            if (input == "1")
            {
                return RPSEnum.Rock.ToString();
            }
            else if(input == "2")
            {
                return RPSEnum.Paper.ToString();
            }
            else if(input == "3")
            {
                return RPSEnum.Scissors.ToString();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("I'm sorry I didn't follow that response. Let's try again");
                return GetRPS();
            }
        }
    }
}
