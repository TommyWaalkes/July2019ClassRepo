using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPicker
{
    class StudentPicker
    {
        private List<string> students = new List<string>();
        public List<string> Students { get { return students; } }
        private Random rando = new Random();
        public StudentPicker(List<string> students)
        {
            this.students = students;
        }

        public StudentPicker(string[] students)
        {
            this.students = students.ToList();
        }

        public StudentPicker()
        {

        }

        public void Add(string name)
        {
            students.Add(name);
        }

        public string GetRandomStudent()
        {
            int r = rando.Next(0, students.Count);
            string output = students[r];
            return output;
        }

        public string GetAndExcludeStudent()
        {
            if (students.Count > 0)
            {
                int r = rando.Next(0, students.Count);
                string output = students[r];

                students.RemoveAt(r);

                return output;
            }
            else
            {
                return "There are no more students left!";
            }
        }

        public List<string> MakeGroup(int size)
        {
            List<string> group = new List<string>();
            int i = 0;
            while(i<size && students.Count > 0)
            {
                string student = GetAndExcludeStudent();
                group.Add(student);
                i++;
            }

            return group;
        }

        public List<List<string>> MakeManyGroups(int groupSize)
        {
            List<List<string>> groups = new List<List<string>>();
            while(students.Count > 0)
            {
                List<string> group = MakeGroup(groupSize);
                if (students.Count == 1)
                {
                    string last = GetAndExcludeStudent();
                    group.Add(last);
                }
                groups.Add(group);

               
            }

            return groups;
        }



    }
}
