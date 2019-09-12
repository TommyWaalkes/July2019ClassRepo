using System;
using System.Collections.Generic;
using System.Text;

namespace MockAssessment3
{
    class Town
    {
        public List<Villager> Villagers { get; set; }

        public Town()
        {
            Villagers = new List<Villager>();
            Villagers.Add(new Farmer());
            Villagers.Add(new Farmer());
            Villagers.Add(new Farmer());
            Villagers.Add(new Slacker());
            //Villagers.Add(new Slacker());
            //Villagers.Add(new Slacker());
        }

        public int Harvest()
        {
            int total = 0;

            foreach(Villager v in Villagers)
            {
                total += v.Farm();
            }

            return total;
        }

        public int CalcFoodConsumption()
        {
            int total = 0;
            foreach(Villager v in Villagers)
            {
                total += v.Hunger;
            }
            return total;
        }

        public bool SurviveTheWinter()
        {
            int hungerTotal = CalcFoodConsumption();
            int totalFood = Harvest();

            if(totalFood >= hungerTotal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
