using System;
using System.Collections.Generic;
using System.Linq;

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
            Student s4 = new Student("Alvin", "Rodeo Trash can", "Grits n Gravy");

            List<Student> students = new List<Student>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(new Student("Zeek", "A house", "Sausage"));
            students.Add(new Student("Aardvark", "Loveshack", "Fish"));
            Console.WriteLine("Okay let's alphabetize the list");

            students = students.OrderBy(x=>x.Name).ToList();

            Console.WriteLine("Which student would you like to learn about: 0-" +students.Count);
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

        public static List<Student> SortStringList(List<Student> unsortedList)
        {
            Student s1 = unsortedList[0];
            Student s2 = unsortedList[1];
            string name1 = s1.Name.ToLower();
            string name2 = s2.Name.ToLower();

            char c1 = name1[0];
            char c2 = name2[0];

            if (c1 > c2)
            {
                //name2 needs to be earlier in the list
            }
            else if(c1 < c2)
            {
                //they're in order so we can move on
            }
            else
            {
                //They're equal we need to check the next letter
            }
        }
    }
}
