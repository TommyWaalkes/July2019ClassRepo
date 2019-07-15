using System;

namespace ContinueLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;

            while (keepGoing == true)
            {
                Console.WriteLine("Please input 2 numbers to add");
                string input1 = Console.ReadLine();
                int num1 = int.Parse(input1);

                string input2 = Console.ReadLine();
                int num2 = int.Parse(input2);
                Console.WriteLine("Equals");
                Console.WriteLine(num1 + num2);

                bool goodAnswer = false;
                while (goodAnswer == false)
                {
                    Console.WriteLine("Would you like to continue? Y/N");
                    string answer = Console.ReadLine();
                    if (answer == "y")
                    {
                        break;
                    }
                    else if (answer == "n")
                    {
                        keepGoing = false;
                        Console.WriteLine("Goodbye! Thanks for using our app!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hey I didn't understand that input please try again");
                        continue;
                    }
                }
            }
        }
    }
}
