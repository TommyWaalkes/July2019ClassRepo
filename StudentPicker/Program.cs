using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Manik", "Dakota", "Bob", "Kimvy", "James", "Moise", "Liz","Mari", "Sam", "Cody", "Flaka", "Josh", "Jason", "Mahruchi"};
            Console.WriteLine("Number of students: " + names.Length);
            StudentPicker sp = new StudentPicker(names);
            List<List<string>> groups = sp.MakeManyGroups(2);

            int i = 1;
            foreach (List<string> group in groups)
            {
                Console.WriteLine("Group " + i);
                PrintList(group);

                i++;
            }

            //string s =sp.GetAndExcludeStudent();
            //Console.WriteLine(s);

        }

        public static void PrintList(List<string> students)
        {
            foreach(string s in students)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }
    }
}
