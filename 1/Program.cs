using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
 * Find the sum of all the multiples of 3 or 5 below 1000.
 */


namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int belowNum = 1000;
            var sum = Enumerable.Range(1, belowNum - 1).Where(i => i % 5 == 0 || i % 3 == 0).Sum().ToString();
            Console.WriteLine(sum);
        }
    }
}
