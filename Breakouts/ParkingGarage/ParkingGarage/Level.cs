using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingGarage
{
    class Level
    {
        public List<ParkingSpot> Spots = new List<ParkingSpot>();
        public int Capacity;

        public Level(List<ParkingSpot> Spots)
        {
            Console.WriteLine(Capacity);
            this.Spots = Spots;
            foreach(ParkingSpot sp in Spots)
            {
                if (sp.IsOpen)
                {
                    Capacity++;
                }
            }
        }
    }
}
