using System;
using System.Collections.Generic;
using System.Text;

namespace RPSBreakout
{
    abstract class Player
    {
        public string Name { get; set; }

        public Player(string Name)
        {
            this.Name = Name;
        }
        public abstract string GetRPS();
    }
}
