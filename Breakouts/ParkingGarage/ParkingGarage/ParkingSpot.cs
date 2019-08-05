using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingGarage
{
    class ParkingSpot
    {
        public int Size { get; set; } 
        public bool IsOpen { get; set; }

        public ParkingSpot()
        {
            this.IsOpen = true;
        }
    }
}
