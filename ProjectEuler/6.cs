using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * The sum of the squares of the first ten natural numbers is,
 * 
 * 12 + 22 + ... + 102 = 385
 * 
 * The square of the sum of the first ten natural numbers is,
 * 
 * (1 + 2 + ... + 10)2 = 552 = 3025
 * 
 * Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
 * 
 * Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
 */

namespace ProjectEuler
{
    class _6 : ISolution
    {
        public string Solve()
        {
            int sumOfSquares = 0;
            int squareOfSums = 0;

            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += i * i;
                squareOfSums += i;
            }

            squareOfSums = squareOfSums * squareOfSums;

            int result = squareOfSums - sumOfSquares;

            return result.ToString();
        }
    }
}
