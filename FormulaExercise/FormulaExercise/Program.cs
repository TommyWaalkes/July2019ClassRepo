using System;

namespace FormulaExercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            double d = GetRectangleArea(5,7);
            Console.WriteLine(d);
            double d2 = GetTriangleArea(3, 4);

            double d3 = GetTriangleArea(5, 4, 3);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            double d4 = PythagoreanFormula(6, 8);
            Console.WriteLine(d4);
        }

        public static double GetRectangleArea(double length, double height)
        {
            double result = length * height;
            return result;
        }

        public static double GetTriangleArea(double width, double height)
        {
            double result = width * height *.5;
            return result;
        }

        public static double GetTriangleArea(double side1, double side2, double side3)
        {
            double area = (side1 + side2 + side3) / 2;
            double result = area * (area - side1) * (area - side2) * (area - side3);
            
            return Math.Sqrt(result);
        }

        public static double PythagoreanFormula(double a, double b)
        {
            double aS = a * a;
            double bS = b * b;

            double total = aS + bS;
            return Math.Sqrt(total);
        }
    }
}
