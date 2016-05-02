using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler.Problems;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            int runs = 1000;
            int solved = 6;

            Console.WriteLine("Project Euler Solutions");
            Console.WriteLine("- Enter a problem number to run that problem\n- Enter 'answers' to list all the solved anwers\n- Enter 'exit' to close the application\n");

            while (true)
            {
                double time = 0.00;
                string answer = "";

                Console.Write("Project Euler Problem: ");
                string problem = Console.ReadLine();

                Console.WriteLine("");

                if (problem.Length == 0) { continue; }
                if (problem == "exit") { break; }
                if (problem == "answers") { ListAnswers(solved); continue; }

                Console.Write("0%");

                for (int i = 1; i <= runs; i++)
                {
                    DateTime start = DateTime.Now;
                    string result = CreateSolution(problem).Solve();
                    TimeSpan elapsed = DateTime.Now - start;
                    time += elapsed.TotalSeconds;

                    Console.Write("\r{0}%    ", ((float)i / (float)runs) * 100f);

                    if (i == 1) { answer = result; }
                }
                Console.WriteLine("\n\nAnswer: {0}", answer);
                Console.WriteLine("Average time over {0} runs: {1} seconds\n", runs, time / runs);
            }
        }

        public static ISolution CreateSolution(string problem)
        {
            Assembly assembly = typeof(ISolution).Assembly;
            Type type = assembly.GetType("ProjectEuler.Problems._" + problem);

            var solution = Activator.CreateInstance(type) as ISolution;

            return solution;
        }

        public static void ListAnswers(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Answer #{0}: {1}", i, CreateSolution(i.ToString()).Solve());
            }

            Console.WriteLine("");
        }
    }
}
