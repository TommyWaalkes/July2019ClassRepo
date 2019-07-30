using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingGarage
{
    class Vehicle
    {
        public int size; 

        public virtual bool CanPark(ParkingSpot p)
        {
            return false;
        }

    }
}
