using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8Breakout
{
    class Student
    {
        public string Name;
        public string HomeTown;
        public string FavoriteFood;

        public Student(string name, string homeTown, string favoriteFood)
        {
            Name = name;
            HomeTown = homeTown;
            FavoriteFood = favoriteFood;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetHomeTown()
        {
            return HomeTown;
        }

        public string GetFavoriteFood()
        {
            return FavoriteFood;
        }
    }
}
