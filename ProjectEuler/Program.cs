﻿using System;
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
            int solved = 9;

            Console.WriteLine("Project Euler Solutions");
            Console.WriteLine("- Enter a problem number to run that problem\n- Enter 'answers' to list all the solved anwers\n- Enter 'exit' to close the application\n- Enter 'all' to run all the problems");

            while (true)
            {
                Console.Write("\n\nProject Euler Problem: ");
                string problem = Console.ReadLine();

                int number;

                if (problem.Length == 0) { continue; }
                if (problem == "exit") { break; }
                if (problem == "answers") { ListAnswers(solved); continue; }
                if (problem == "all") { RunAll(solved); continue; }
                if (!int.TryParse(problem, out number)) { continue; }
                if (int.Parse(problem) > solved) { continue; }

                Console.Write("Runs: ");
                string temp = Console.ReadLine();

                if (int.TryParse(temp, out runs)) { Run(problem, runs); }
            }
        }

        private static void RunAll(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                Run(i.ToString());
                Console.Write("\n");
            }
        }

        private static void Run(string problem, int runs = 1000)
        {
            double time = 0.00;
            string answer = "";

            Console.Write("\nProblem {0}\t0%", problem);

            for (int i = 1; i <= runs; i++)
            {
                DateTime start = DateTime.Now;
                string result = CreateSolution(problem).Solve();
                TimeSpan elapsed = DateTime.Now - start;
                time += elapsed.TotalSeconds;

                Console.Write("\rProblem {1}\t{0:P}      ", ((float)i / (float)runs), problem);

                if (i == 1) { answer = result; }
            }
            Console.Write("Answer: {0}\t", answer);
            Console.Write("Average time over {0} runs: {1} seconds", runs, time / runs);
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
