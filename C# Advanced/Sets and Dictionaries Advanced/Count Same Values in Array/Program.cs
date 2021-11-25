using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> repeatingNumbers = new Dictionary<double, int>();
            foreach (var number in numbers)
            {
                if (!repeatingNumbers.ContainsKey(number))
                {
                    repeatingNumbers.Add(number, 0);
                }
                repeatingNumbers[number]++;
            }
            foreach (var number in repeatingNumbers)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
