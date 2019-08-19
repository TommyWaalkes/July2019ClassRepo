using System;
using System.Collections.Generic;
using System.Text;

namespace RPSBreakout
{
    class RPSApp
    {
        Player p1;
        Player p2;
        int wins = 0;
        int loses = 0;
        int draws = 0;

        public RPSApp()
        {
            Console.WriteLine("Hello, what is your name?");
            string input = Console.ReadLine();
            p1 = new Human(input);

            Console.WriteLine("Which opponent would you like to face? rocky or randy");

            string input2 = Console.ReadLine();

            if (input2 == "rocky")
            {
                p2 = new Rocky("Dywane");
            }
            else
            {
                p2 = new RandomPlayer("Randy", new Random());
            }
        }

        public void RunGame()
        {
            while (true)
            {
                Play();

                Console.WriteLine("Keep playing? y or n");
                string input = Console.ReadLine();
                if(input == "y")
                {
                    continue;
                }
                else if(input == "n")
                {
                    break;
                }

            }
        }

        public void Play()
        {
            string p1throw = p1.GetRPS();
            string p2throw = p2.GetRPS();

            Console.WriteLine(p1.Name +" throws "+p1throw);
            Console.WriteLine(p2.Name + "throws" + p2throw);

            if(p1throw == p2throw)
            {
                draws++;
            }
            else if(p1throw == RPSEnum.rock.ToString())
            {
                if(p2throw == RPSEnum.paper.ToString())
                {
                    Console.WriteLine("p1 loses");
                    loses++;
                }
                else
                {
                    Console.WriteLine("p1 wins");
                    wins++;
                }
            }
            else if(p1throw == RPSEnum.paper.ToString())
            {
                if(p2throw == RPSEnum.rock.ToString())
                {
                    Console.WriteLine("P1 wins");
                    wins++;
                }
                else
                {
                    Console.WriteLine("p1 loses");
                    loses++;
                }
            }
            else if(p1throw == RPSEnum.scissors.ToString())
            {
                if(p2throw == RPSEnum.rock.ToString())
                {
                    Console.WriteLine("p1 loses");
                    loses++;
                }
                else
                {
                    Console.WriteLine("p1 wins");
                    wins++;
                }

            }
                Console.WriteLine("Current Record: ");
                Console.WriteLine($"Wins: {wins}");
                Console.WriteLine($"Draws: {draws}");
                Console.WriteLine($"Loses: {loses}");
        }
    }
}
