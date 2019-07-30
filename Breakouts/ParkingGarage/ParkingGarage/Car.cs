using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingGarage
{
    class Car : Vehicle
    {
        public Car()
        {
            size = 1;
        }
        public override bool CanPark(ParkingSpot p)
        {
            if(p.Size >= size)
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
