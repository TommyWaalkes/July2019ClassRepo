using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[3];

            names[0] = "tom";
            names[0] = "Sarah";
            Console.WriteLine(names[1]);

            int[] nums = { 32, 86, 91, 40, 900, 826, 363,28, 90 };

            //Console.WriteLine(nums[0]);
            //Console.WriteLine(nums[1]);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
