using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<List<int>> add = i =>
            {
                for (int j = 0; j < i.Count; j++)
                {
                    i[j]++;
                }
            };
            Action<List<int>> multiply = i =>
            {
                for (int j = 0; j < i.Count; j++)
                {
                    i[j] *= 2;
                }
            };
            Action<List<int>> subtract = i =>
            {
                for (int j = 0; j < i.Count; j++)
                {
                    i[j]--;
                }
            };
            Action<List<int>> print = i => Console.WriteLine(string.Join(" ", i));
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "add")
                {
                    add(numbers);
                }
                else if (command == "multiply")
                {
                    multiply(numbers);
                }
                else if (command == "subtract")
                {
                    subtract(numbers);
                }
                else if (command == "print")
                {
                    print(numbers);
                }
                
                command = Console.ReadLine();
            }
        }
    }
}
