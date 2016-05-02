using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Utils
    {
        public class PrimeFactor
        {
            public PrimeFactor(int number, int power = 1)
            {
                this.number = number;
                this.power = power;
            }

            public int number { get; set; }
            public int power { get; set; }
        }

        public static bool IsPrime(long n)
        {
            if (n < 1)
                return false;
            else if (n <= 3)
                return true;
            else if (n % 2 == 0 || n % 3 == 0)
                return false;

            long i = 5;

            while (i * i <= n)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }

                i += 6;
            }

            return true;
        }

        public static List<PrimeFactor> GetPrimeFactors(int number)
        {
            List<PrimeFactor> results = new List<PrimeFactor>();

            for (int i = 2; number > 1; i++)
            {
                if (number % i == 0)
                {
                    int x = 0;
                    while (number % i == 0)
                    {
                        number /= i;
                        x++;
                    }
                    results.Add(new PrimeFactor(i, x));
                }
            }

            return results;
        }
    }
}
