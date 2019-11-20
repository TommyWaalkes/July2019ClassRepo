using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Student
    {
        public string Name { get { return name; } }
        public int Age { get { return age; } }

        private string name;
        private int age;
        public int creditCardNumber;

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
