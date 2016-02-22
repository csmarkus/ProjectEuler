using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
 * 
 * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
 */

/*
 * Honeslty this one could be done with simple math, but that isn't the point here. I did find that checking if i % j == 0 took far longer than i % j != 0. Like 3-4 seconds longer. Lesson learned? 
 */

namespace ProjecEuler
{
    class _5
    {
        public static void Solve()
        {
            int result = int.MinValue;

            bool found = false;

            for (int i = 20; !found; i++)
            {
                for (int j = 1; j <= 20; j++)
                {
                    if (i % j != 0)
                    {
                        break;
                    }
                    else 
                    {
                        found = true;
                        result = i;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
