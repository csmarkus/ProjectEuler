using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
