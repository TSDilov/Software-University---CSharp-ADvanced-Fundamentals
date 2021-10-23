using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesandReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                int number = numbers[i];
                numbers.RemoveAll(number => number < 0);
            }
            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                numbers.Reverse();
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
