using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Boolean run = true;
            while (run == true)
            {
                Console.WriteLine("Hello, Please Input a word");
                String input = Console.ReadLine();
                if (input == "" || input == null)
                {
                    Console.WriteLine("Please input a string, your input was empty");
                }
                else
                {
                    input = input.ToLower();
                    input = input.Trim();
                    Console.WriteLine(input);

                    string[] words = input.Split();
                    List<string> outputs = new List<string>();
                    foreach (string word in words)
                    {
                        string output = Translate(word);
                        outputs.Add(output);
                    }

                    foreach (string o in outputs)
                    {
                        Console.Write(o + " ");
                    }
                    Console.WriteLine();
                }
                run = Continue();
            }
        }

        public static string Translate(string input)
        {
            string firstLetter = input.Substring(0, 1);

            String output;
            if ((firstLetter == "a") || (firstLetter == "e") || (firstLetter == "i") || (firstLetter == "o") || (firstLetter == "u"))
            {
                output = input + "way";
            }
            else
            {
                char[] r = input.ToCharArray();
                string endString = "";
                for (int i = 0; i < r.Length; i++)
                {
                    // Console.WriteLine(r[i]);
                    bool isAVowel = IsVowel(r[i]);
                    if (isAVowel == true)
                    {
                        string startString = input.Substring(i);
                        //Console.WriteLine(startString + endString +"ay");   
                        break;
                    }
                    else
                    {
                        endString += r[i];
                        //Console.WriteLine(endString);
                    }
                }
                String ending = input.Substring(1, input.Length - 1);
                output = ending + firstLetter + "ay";
            }
            return output;
        }

        public static bool IsVowel(char letter)
        {
            string Vowels = "aeiou";
            //if (letter.Equals('a') || letter.Equals('e') || letter.Equals('i') || letter.Equals('o') || letter.Equals('u'))
            if (Vowels.Contains(letter.ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void HandlePunctuation()
        {

        }

        public static Boolean Continue()
        {
            Boolean run;
            Console.WriteLine("Continue? Y/N");
            String answer = Console.ReadLine();

            if ((answer == "Y") || (answer == "y"))
            {
                run = true;
            }
            else if ((answer == "N") || (answer == "n"))
            {
                run = false;
                Console.WriteLine("Good Bye!");
            }
            else
            {
                Console.WriteLine("I'm sorry I don't understand. Let's try again");
                run = Continue();
            }
            return run;
        }

    }
}