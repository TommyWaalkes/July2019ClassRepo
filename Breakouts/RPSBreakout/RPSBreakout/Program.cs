using System;

namespace RPSBreakout
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RPSEnum.Rock);
            Rocky r = new Rocky("Rock");
            Human h = new Human("Dywane Johnson");

            //string output = h.GetRPS();
            //Console.WriteLine(output);
            //Console.WriteLine(r.GetRPS());

            Random rando = new Random();
            Random randy = new Random();

            RandomPlayer rp = new RandomPlayer("Bob", randy);
            for (int i = 0; i < 100; i++)
            {
                //int num = rando.Next(1, 4);
                //Console.WriteLine("Random 1: " + num);

                //int num2 = randy.Next(1, 4);
                //Console.WriteLine("Random 2: "+num2);
                Console.WriteLine(rp.GetRPS());
            }
        }
    }
}
