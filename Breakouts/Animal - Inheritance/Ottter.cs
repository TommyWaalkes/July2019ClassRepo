using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Inheritance
{
    class Otter : Animal
    {
        public Otter(string name) : base(name)
        {

        }

        public override void PrintFood()
        {
            base.PrintFood();
            Console.WriteLine($"Otter {name} eats fish and clams and seaweed");
        }
    }
}
