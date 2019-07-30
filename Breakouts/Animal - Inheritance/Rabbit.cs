using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Inheritance
{
    class Rabbit : Animal
    {
        public Rabbit(string name) : base(name)
        {
        }

        public override string GetFood()
        {
            return "Carrots and pellets";
        }


    }
}
