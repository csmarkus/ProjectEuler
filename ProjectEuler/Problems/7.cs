using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
 * 
 * What is the 10 001st prime number?
 */

namespace ProjectEuler.Problems
{
    class _7 : ISolution
    {
        public string Solve()
        {
            int primeCount = 0;
            int n = 0;

            for (int i = 1; primeCount < 10002; i++)
            {
                if (Utils.IsPrime(i)) { primeCount++; n = i; }
            }

            return n.ToString();
        }
    }
}
