using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
 *
 * a2 + b2 = c2
 * For example, 32 + 42 = 9 + 16 = 25 = 52.
 *
 * There exists exactly one Pythagorean triplet for which a + b + c = 1000.
 * Find the product abc. 
 */

/**
 * https://www.mathsisfun.com/numbers/pythagorean-triples.html
 */
namespace ProjectEuler.Problems
{
    class _9 : ISolution
    {
        public class PythagoreanTriplet
        {
            public int A { get; set; }
            public int B { get; set; }
            public int C { get; set; }

            public PythagoreanTriplet(int m, int n, int k)
            {
                A = k * (int)(Math.Pow((double)n, 2) - Math.Pow((double)m, 2));
                B = k * (2 * n * m);
                C = k * (int)(Math.Pow((double)n, 2) + Math.Pow((double)m, 2));
            }

            public override string ToString()
            {
                return string.Format("A:{0} B:{1} C:{2}", A, B, C);
            }
        }

        public string Solve()
        {
            for (int i = 1; i < (int)Math.Sqrt(1000/2); i++)
            {
                for (int k = 1; k < i * 2; k += 2)
                {
                    PythagoreanTriplet pt = new PythagoreanTriplet(i, i + 1, k);

                    int t = pt.A + pt.B + pt.C;

                    Debug.WriteLine("{0} Sum:{1}", pt.ToString(), t);

                    if (t == 1000)
                    {
                        return pt.ToString();
                    }
                }
            }

            return "Not Found";
        }
    }
}
