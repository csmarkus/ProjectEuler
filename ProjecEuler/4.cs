using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
 * 
 * Find the largest palindrome made from the product of two 3-digit numbers.
 */

namespace ProjecEuler
{
    class _4
    {
        public static void Solve()
        {
            int largestPalindrome = int.MinValue;

            for(int i = 999; i >= 100 && i * 999 > largestPalindrome; i--)
            {
                for(int j = 999; j > i; j--)
                {
                    int r = i * j;
                    if (r == reverseNumber(r))
                    {
                        if (r > largestPalindrome)
                        {
                            largestPalindrome = r;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(largestPalindrome);
        }

        public static int reverseNumber(int n)
        {
            int result = 0;
            while (n != 0)
            {
                result *= 10;
                result += n % 10;
                n /= 10;
            }
            return result;
        }
    }
}
