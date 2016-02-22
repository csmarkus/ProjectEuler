using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecEuler
{
    class _6
    {
        public static void Solve()
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

            Console.WriteLine(result);
        }
    }
}
