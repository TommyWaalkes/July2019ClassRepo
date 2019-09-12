using System;

namespace MockAssessment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Town t = new Town();
            Console.WriteLine(t.Harvest());
            Console.WriteLine(t.CalcFoodConsumption());

            Console.WriteLine(t.SurviveTheWinter());
        }
    }
}
