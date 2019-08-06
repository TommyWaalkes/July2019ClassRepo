using System;
using System.Collections.Generic;
using System.Text;

namespace RPSBreakout
{
    class Rocky : Player
    {

        public Rocky(string Name) : base(Name)
        {

        }
        public override string GetRPS()
        {
            return RPSEnum.Rock.ToString();
        }
    }
}
