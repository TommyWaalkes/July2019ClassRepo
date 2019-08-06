using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingGarage
{
    class Bus : Vehicle
    {
        public bool BusParking(List<ParkingSpot> Spots)
        {
            int spotsNum = 5;

            if (Spots.Count < spotsNum)
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
                    
                    if(p.Size == 2)
                    {
                        largeSpotTogether++;
                    }
                    else
                    {
                        largeSpotTogether = 0;
                        continue;
                    }

                    if (largeSpotTogether >= spotsNum)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
