using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingGarage
{
    class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            size = 0;
        }
        public override bool CanPark(ParkingSpot p)
        {
            return true;
        }
    }
}
