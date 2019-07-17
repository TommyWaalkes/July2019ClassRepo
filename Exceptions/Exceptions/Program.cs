using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            OfferBeer();  
        }

        public static void OfferMoney()
        {
            //So high level: Exceptions are common errors that C# accounts for 
            //They'll stop the program and give you an error read-out
            //However, you can get the program to continue if you catch the exception 
            //And give variable default values to show there was an error 
            //(like -1 which is the universal sign for error)
            Console.WriteLine("How much money do you want?");
            string num = Console.ReadLine();
            //Want to learn more about the out keyword? Read more here: https://www.dotnetperls.com/out
            int money;
            //throw new Exception("I demand Princess treatment");
            bool parsed = int.TryParse(num, out money);

            if (parsed == false)
            {
                Console.WriteLine("I'm sorry that was not a number");
            }
            else
            {
                try
                {
                    if (money <= 0)
                    {
                        throw new Exception("Money must be > 0.");
                    }
                    else
                    {
                        Console.WriteLine("You get " + money + " dollars");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                 
                }
            }
        }

        public static void DuckHotel()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to the Duck Hotel");
                Console.WriteLine("Please select a room: 0-9");
                string input = Console.ReadLine();
                int roomNum = int.Parse(input);
                int[] ducks = new int[10];

                int d = ducks[roomNum];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Sorry we only have nine spaces in our duck quota");
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.Message);
                Console.WriteLine(e.HelpLink);
            }
            catch (FormatException e)
            {
                Console.WriteLine("That input was not a number, please input a number next time");
                Console.WriteLine(e.GetType());
            }
            Console.WriteLine();
        }

        public static void OfferBeer()
        {
            Console.WriteLine("Welcome to Tommy's bar, this is a duck free establishment");
            bool offerBeer = true;

            try
            {
                Console.WriteLine("What are you?");
                string input = Console.ReadLine();
                input = input.ToLower();

                if (input.Contains("duck"))
                {
                    throw new Exception("No ducks allowed!");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Hey I told you no ducks");
                Console.WriteLine("I know you're tricks now duck!");

                Console.WriteLine(e.StackTrace);
                offerBeer = false;
            }

            if (offerBeer == true)
            {
                int beers;
                Console.WriteLine("How many beers you want?");

                try
                {
                    beers = int.Parse(Console.ReadLine());
                    

                    if (beers <= 0)
                    {
                        throw new Exception("Hey I need a positive integer that is greater than zero. This is a math literate establishment.");
                    }
                    else
                    {
                        Console.WriteLine("I will give you " + beers + " beer");
                    }
                }

                catch (FormatException e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Hey that's not a number");
                    Console.WriteLine("You're drunk, I'm cutting you off");
                    beers = 0;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine(e.Message);
                    beers = 0;
                    Console.WriteLine("You're math is wrong, so you must be drunk");
                    Console.WriteLine("You get no beers");
                }
                Console.WriteLine("Have fun at the bar.");
                Console.WriteLine("here's " + beers + " beers");
            }
        }
    }
}

