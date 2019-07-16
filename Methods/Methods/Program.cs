using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num1 = GetUserInput();
            int num2 = GetUserInput();
            string operation = GetOperation();
            int result = 0; 
            if(operation == "add")
            {
                result = Add(num1, num2);
            }
            else if(operation == "sub")
            {
                result = Subtract(num1, num2);
            }

            

            Console.WriteLine("Result: " + result);
        }

        public static int GetUserInput()
        {
            Console.WriteLine("Please input a valid int");
            string input = Console.ReadLine();
            int result = int.Parse(input);

            return result;
        }

        public static string GetOperation()
        {
            Console.WriteLine("Please select an opertation from this list: (1-4)");
            Console.WriteLine("1) Add");
            Console.WriteLine("2) Subtract");
            Console.WriteLine("3) Multiply");
            Console.WriteLine("4) Divide");

            string input = Console.ReadLine();

            switch (input.Trim())
            {
                case "1":
                    return "add";
                    break;
                case "2":
                    return "sub";
                    break;
                case "3":
                    return "multiply";
                    break;
                case "4":
                    return "divide";
                    break;
                default:
                    Console.WriteLine("I didn't understand that, let's try again.");
                    return GetOperation();
                    break;
            }
        }

        public static int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public static int Subtract(int a, int b)
        {
            int diff = a - b;
            return diff;
        }
    }
}
