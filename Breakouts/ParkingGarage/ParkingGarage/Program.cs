using System;
using System.Collections.Generic;

namespace ParkingGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle m = new Motorcycle();
            Console.WriteLine("Motorcycle Tries to Park in small space: "+m.CanPark(new SmallSpot()));
            Console.WriteLine("Motorcycle Tries to Park in Compact space: " + m.CanPark(new CompactSpot()));
            Console.WriteLine("Motorcycle Tries to Park in Large space: " + m.CanPark(new LargeSpot()));

            Console.WriteLine();
            Car c = new Car();
            Console.WriteLine("Car Tries to Park in small space: " + c.CanPark(new SmallSpot()));
            Console.WriteLine("Car Tries to Park in compact space: " + c.CanPark(new CompactSpot()));
            Console.WriteLine("Car Tries to Park in Large space: " + c.CanPark(new LargeSpot()));

            List<ParkingSpot> Spots = new List<ParkingSpot>();
            Bus b = new Bus();
            Spots.Add(new LargeSpot());
            Spots.Add(new LargeSpot());
            Spots.Add(new LargeSpot());
            Spots.Add(new LargeSpot());
            Spots.Add(new LargeSpot());
            Console.WriteLine(b.BusParking(Spots));


        }
    }
}
