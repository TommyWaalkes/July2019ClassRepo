using System;
using System.Collections.Generic;

namespace MockAssessment2
{
    class Program
    {
        public static List<string> Tasks = new List<string>();
        static void Main(string[] args)
        {
            AddTask("Laundry");
            AddTask("Mowing");
            foreach (string task in Tasks)
            {
                Console.WriteLine(task);
            }


            FinishTask("Mowing");
            Console.WriteLine();
            Console.WriteLine("List after removing:");
            foreach(string task in Tasks)
            {
                Console.WriteLine(task);
            }
        }

        public static bool FinishTask(string taskToRemove)
        {
            if (Tasks.Contains(taskToRemove))
            {
                Tasks.Remove(taskToRemove);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static void AddTask(string task)
        {
            Tasks.Add(task);
        }

        public static string GetTask(int index)
        {
            try
            {
                return Tasks[index];
            }
            catch(Exception e)
            {
                return "Error";
            }
        }


    }
}
