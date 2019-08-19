using System;
using System.Collections.Generic;
using System.Text;

namespace RPSBreakout
{
    class RandomPlayer : Player
    {
        Random Rando;
        public RandomPlayer( string Name, Random Rando) : base(Name)
        {
            this.Rando = Rando;
        }
        public override string GetRPS()
        {
            int pick = Rando.Next(1, 4);
            if(pick == 1)
            {
                return RPSEnum.rock.ToString();
            }
            else if(pick == 2)
            {
                return RPSEnum.paper.ToString();
            }
            else if(pick == 3)
            {
                return RPSEnum.scissors.ToString();
            }

            return "-1";
        }
    }
}
