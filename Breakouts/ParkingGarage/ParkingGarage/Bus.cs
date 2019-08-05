using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingGarage
{
    class Bus : Vehicle
    {
        public bool BusParking(List<ParkingSpot> Spots)
        {
            if (Spots.Count < 4)
            {
                return false;
            }
            else
            {
                int largeSpotTogether = 0;
                for(int i = 0; i < Spots.Count; i++)
                {
                    Console.WriteLine(i);
                    ParkingSpot p = Spots[i];
                    if(largeSpotTogether >= 4)
                    {
                        return true;
                    }
                    else if(p.Size == 2)
                    {
                        largeSpotTogether++;
                    }
                    else
                    {
                        largeSpotTogether = 0;
                        continue;
                    }
                }
            }
            return false;
        }
    }
}
