using System;
using System.Collections.Generic;

namespace Lab8Breakout
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = { "Jill", "jaime", "james" };
            //string[] homeTowns = { "Raleigh", "Scranton", "George Town" };
            //string[] foods = { "Chicken", "Ketchup", "Cheese" };

            Student s1 = new Student("Jill", "Raleigh", "Chicken");
            Student s2 = new Student("Jaime", "Scranton", "Ketchup");
            Student s3 = new Student("James", "George Town", "Cheese");

            List<Student> students = new List<Student>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            Console.WriteLine("Which student would you like to learn about: 0-2");
            for(int i = 0; i < students.Count; i++)
            {
                Student stu = students[i];
                Console.WriteLine(i + " " + stu.GetName());
            }
            int pick = 0; 
            try
            {
                string input = Console.ReadLine();
                pick = int.Parse(input);
            }
            catch(FormatException e)
            {
                Console.WriteLine("A valid int was not given");
            }
            Student s;
            try
            {
                s = students[pick];
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Incorrect input I'm assuming you want the person at index 0");
                s = students[0];
            }
            string name = s.GetName();
            Console.WriteLine(name);
            Console.WriteLine($"What would you like to learn about {name}?");
            Console.WriteLine("1) Favorie Food ff");
            Console.WriteLine("2) Home Town ht");
            string input2 = Console.ReadLine().ToLower().Trim();

            if(input2 == "1" || input2 == "ff")
            {
                Console.WriteLine(s.FavoriteFood);
            }
            else if(input2 == "2"|| input2 == "ht")
            {
                Console.WriteLine(s.HomeTown);
            }


            
        }
    }
}
