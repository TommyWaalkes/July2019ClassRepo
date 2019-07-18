using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array lists will take in ANY data type, but note that it comes with the 
            //risk of C# not knowing what to with your data
            Console.WriteLine("ArrayList Example");
            ArrayList numbers = new ArrayList();
            for(int i = 1; i<=10; i++)
            {
                numbers.Add(i);
            }
            numbers.Add("Tommy");
            numbers.Add(true);
            //numbers.Add(true);
            //Console.WriteLine(numbers[0]+numbers[1]);
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("Hash Table Example");
            Hashtable ht = new Hashtable();

            ht.Add(1, "John");
            ht.Add(2, "John");
            ht.Add("crazy", true);
            ht.Add("002", "Paul");
            ht.Add(3, true);
            ht.Add(0, false);
            ht.Add(-1, "error");

            //Console.WriteLine(ht["tommy"] + " is what the tommy key gives us");
            Console.WriteLine(ht["002"]);
            //Console.WriteLine(ht[2]);
            //Console.WriteLine();
            Console.WriteLine("Trying to print hashtable");
            //Console.WriteLine(ht.Keys);
            foreach(object k in ht.Keys)
            {
                Console.WriteLine();
                Console.WriteLine("Key: " +k);
                Console.WriteLine("Value "+ht[k]);
            }
        }
    }
}
