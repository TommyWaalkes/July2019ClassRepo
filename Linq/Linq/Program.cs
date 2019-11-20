using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = { 13, 21, 30, 53, 15, 16, 63, 33, 10 };

            List<int> oddAges = ages.Where(n => n % 2 == 1).ToList();
            //Console.WriteLine("The number of ages that are odd is: " + oddAges);
            //Console.WriteLine("It should be: 6");
            Console.WriteLine("Here is a list of ages that are odd: ");
            oddAges.Sort();
            foreach (int age in oddAges)
            {
                Console.WriteLine(age);
            }

            Console.WriteLine("Okay let's try with Query Syntax");

            //Okay this query gets all ages that are 
            var evens = from n in ages
                        where n % 2 == 1 && n > 20
                        select n;
            Console.WriteLine("Here are all the even ages over 20");
            foreach (int age in evens)
            {
                Console.WriteLine(age);
            }

            //Now we want the count so we can just use .count like on a list
            Console.WriteLine("The number of ages that are odd is: " + evens.Count());
            Console.WriteLine("It should be: 6");
            PrintBreak();
            List<int> oldestAge = ages.Where(n => n % 2 == 0).ToList();
            oldestAge.Sort();
            int index = oldestAge.Count() - 2;
            Console.WriteLine(index);
            Console.WriteLine("The second oldest even age in our list is: " + oldestAge[index]);
            PrintBreak();
            List<int> teenAges = ages.Where(n => (n > 12 && n < 20)).ToList();

            Console.WriteLine("Here's the list of teenagers!");
            foreach (int i in teenAges)
            {
                Console.WriteLine(i);
            }
            PrintBreak();

            Console.WriteLine("Okay now let's try the same thing but with student objects!");
            Console.WriteLine("And query syntax!");
            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            var teenAgerStudent = from s in students
                                  where s.Age > 20
                                  select s;
            foreach (Student s in teenAgerStudent)
            {
                Console.WriteLine(s.Name + ": " + s.Age + " Years Old");
            }
            PrintBreak();

            Console.WriteLine("Okay let's add in a second Phillip and grab all Phillips from the list");
            students.Add(new Student("Phillip", 20));
            students.Add(new Student("Phillip", 44));
            students.Add(new Student("Phillip", 44));
            students.Add(new Student("Phillip", 12));

            List<Student> phils = students
                .Where(s => s.Name == "Phillip")
                .OrderByDescending(s => s.Age)
                .ToList();

            Console.WriteLine("The oldest Phil is " + phils[0].Age);

            foreach (Student s in phils)
            {
                Console.WriteLine("This Phil is " + s.Age + " Years old");
            }

            Console.WriteLine("We should have " + phils.Count());

            Console.WriteLine();

        }

        public static void PrintBreak()
        {
            Console.WriteLine("-------------------");
        }
    }
}
