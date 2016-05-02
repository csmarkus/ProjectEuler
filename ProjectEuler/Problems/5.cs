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

namespace ProjectEuler.Problems
{
    class _5 : ISolution
    {
        public string Solve()
        {
            int n = 20;
            List<Utils.PrimeFactor> primes = new List<Utils.PrimeFactor>();
            int result = 1;

            for (int i = 11; i <= n; i++)
            {
                if (!Utils.IsPrime(i))
                {
                    var primeFactors = Utils.GetPrimeFactors(i);
                    foreach (Utils.PrimeFactor primeFactor in primeFactors)
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
                    primes.Add(new Utils.PrimeFactor(i));
                }
            }

            foreach (Utils.PrimeFactor prime in primes)
            {
                result *= (int)Math.Pow(prime.number, prime.power);
            }

            return result.ToString();
        }
    }
}
