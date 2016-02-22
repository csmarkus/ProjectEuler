using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            _3.Solve();
            TimeSpan elapsed = DateTime.Now - start;
            Console.WriteLine("Time Elapsed: {0} seconds", elapsed.TotalSeconds.ToString());
            Console.ReadLine();
        }
    }
}
