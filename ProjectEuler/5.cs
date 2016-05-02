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

namespace ProjectEuler
{
    class _5 : ISolution
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

        public bool IsPrime(long n)
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

        public List<PrimeFactor> GetPrimeFactors(int number)
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

        public string Solve()
        {
            int n = 20;
            List<PrimeFactor> primes = new List<PrimeFactor>();
            int result = 1;

            for (int i = 11; i <= n; i++)
            {
                if (!IsPrime(i))
                {
                    var primeFactors = GetPrimeFactors(i);
                    foreach (PrimeFactor primeFactor in primeFactors)
                    {
                        var index = primes.FindIndex(x => x.number == primeFactor.number);

                        if (index > -1)
                        {
                            if (primeFactor.power > primes[index].power)
                                primes[index].power = primeFactor.power;
                        }
                        else
                        {
                            primes.Add(primeFactor);
                        }
                    }
                }
                else
                {
                    primes.Add(new PrimeFactor(i));
                }
            }

            foreach (PrimeFactor prime in primes)
            {
                result *= (int)Math.Pow(prime.number, prime.power);
            }

            return result.ToString();
        }
    }
}
