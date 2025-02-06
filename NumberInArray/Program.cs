using Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;

namespace NumberInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            The aim of this exercise is to check the presence of a number in an array.

Specifications:
            The items are integers arranged in ascending order.
The array can contain up to 1 million items
The array is never null
Implement the method boolean Answer.Exists(int[] ints, int k) so that it returns true if k belongs to ints, otherwise the method should return false.

Important note: Try to save CPU cycles if possible.

Example:
int[] ints = { -9, 14, 37, 102 };
            Answer.Exists(ints, 102) returns true
Answer.Exists(ints, 36) returns false
            */

            int[] ints = { -9, 14, 37, 102 };

            //var ff = new List<int>(10);// { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine(ff[0]);
            //Console.WriteLine(ff[9]);
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(ff[i]);
            //}

            Console.WriteLine($"{Answer.Exists(ints, 102)}");
            Console.WriteLine($"{Answer.Exists(ints, 36)}");

            ints = Array.Empty<int>();
            Console.WriteLine($"{Answer.Exists(ints, 3)}");

            Console.ReadKey();
        }
    }
}
