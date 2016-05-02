using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * The prime factors of 13195 are 5, 7, 13 and 29.
 *
 * What is the largest prime factor of the number 600851475143 ?
 */

namespace ProjectEuler
{
    class _3 : ISolution
    {
        public string Solve()
        {
            long number = 600851475143;

            long largestFactor = 0;

            for(long i = 1; i < Math.Floor(Math.Sqrt(number)); i++)
            {
                if(IsPrime(i))
                {
                    if (number % i == 0)
                        if (i > largestFactor)
                            largestFactor = i;
                }
            }

            return largestFactor.ToString();
        }

        public static bool IsPrime(long n)
        {
            if(n < 1)
                return false;
            else if(n <= 3)
                return true;
            else if(n % 2 == 0 || n % 3 == 0)
                return false;

            long i = 5;

            while(i * i <= n)
            {
                if(n % i == 0 || n % (i+2) == 0)
                {
                    return false;
                }

                i += 6;
            }

            return true;
        }
    }
}
