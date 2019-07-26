using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus16
{
    class Car
    {
        private int year;
        public int Year { get
            {
                return year;
            }
        }

        private string make;
        public string Make { get
            {
                return make;
            }
        }


        private string model;
        public string Model
        {
            get
            {
                return model;
            }
        }

        //private double price; 
        //public double Price{get{return price;}}

            public double Price { get; set; }

        public Car()
        {
            this.year = 1882;
            this.Price = 100.00;
            this.model = "Cart with wheels and a donkey";
            this.make = "Ford";
        }

        public Car(int year, string make, string model, double price)
        {
            this.year = year;
            this.make = make;
            this.model = model;
            this.Price = price;
        }

    }
}
