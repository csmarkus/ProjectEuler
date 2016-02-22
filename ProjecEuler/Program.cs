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
            double time = 0.00;
            int runs = 1000;
            for (int i = 1; i <= runs; i++)
            { 
                DateTime start = DateTime.Now;
                _5.Solve();
                TimeSpan elapsed = DateTime.Now - start;
                time += elapsed.TotalSeconds;

                Console.WriteLine("Time Elapsed: {0} seconds", elapsed.TotalSeconds);
            }
            Console.WriteLine("Average time over {0} runs: {1} seconds", runs, time / runs);
            Console.ReadLine();
        }
    }
}
