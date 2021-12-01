using System;
using System.Collections.Generic;
using System.Linq;

namespace SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            List<int> evenNumbers = new List<int>();
            evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            Console.WriteLine(string.Join(", ", evenNumbers.OrderBy(n => n)));
        }
    }
}
