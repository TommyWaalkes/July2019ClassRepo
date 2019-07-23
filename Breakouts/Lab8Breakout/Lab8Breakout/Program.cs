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

            Student s = students[pick];
            string name = s.GetName();
            Console.WriteLine(name);

        }
    }
}
