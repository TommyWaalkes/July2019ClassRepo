using System;
using System.Collections.Generic;
using System.Text;

namespace Enums
{
    public enum Directions
    {
        North,
        East, 
        South, 
        West
    }
    public class Room
    {
        public string Name { get; set; }
        public string Desc { get; set; }

       
        public Room(string Name, string Desc)
        {
            this.Name = Name;
            this.Desc = Desc;
        }
    }

    public class House
    {
        public Room NorthRoom { get; set; }
        public Room SouthRoom { get; set; }
        public Room EastRoom { get; set; }
        public Room WestRoom { get; set; }
        public Room CenterRoom { get; set; }
        public Room CurrentRoom;

        public House()
        {
            this.NorthRoom = new Room("Living Room", "A warm fire place, with candles and stuff");
            this.SouthRoom = new Room("Bathroom", "A nice clean bathroom with nice smelling soaps");
            this.WestRoom = new Room("Office", "A messy office with papers scattered about on a desk");
            this.EastRoom = new Room("Bed Room","A bedroom with clothes strewn about and a nice queen sized bed");
            this.CenterRoom = new Room("Hallway", "an empty hallway");
            this.CurrentRoom = CenterRoom;
        }

        public void PrintCurrentRoom()
        {
            Console.WriteLine($"You are in the {CurrentRoom.Name}");
            Console.WriteLine($"Room Description: {CurrentRoom.Desc}");
        }

        public void MoveToRoom(Directions d)
        {
            switch (d)
            {
                case Directions.North:
                    CurrentRoom = NorthRoom;
                    break;
                case Directions.South:
                    CurrentRoom = SouthRoom;
                    break;
                case Directions.East:
                    CurrentRoom = EastRoom;
                    break;
                case Directions.West:
                    CurrentRoom = WestRoom;
                    break;
            }
        }

    }
}
