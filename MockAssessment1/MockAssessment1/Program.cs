using System;
using System.Linq;

namespace MockAssessment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsVowel('a'));
            Console.WriteLine(CountVowels("aaaaaardvark"));
            Console.WriteLine(TooManyVowels("aaa aaa a"));
        }

        public static bool IsVowel(char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            string vs = "aeiou";

            if (vs.Contains(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int CountVowels(string input)
        {
            char[] letters = input.ToArray();

            int total = 0;

            foreach (char letter in letters)
            {
                if(IsVowel(letter) == true)
                {
                    total++;
                }
            }

            return total;
        }

        public static string TooManyVowels(string input)
        {
            int totalVowels = CountVowels(input);
            if(totalVowels <= 4)
            {
                return "few vowels";
            }
            else if(totalVowels >=5 && totalVowels <= 7)
            {
                return "right amount of vowels";
            }
            else
            {
                return "too many vowels";
            }
        }
    }
}
