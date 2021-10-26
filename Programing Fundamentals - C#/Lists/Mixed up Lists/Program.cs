using System;
using System.Collections.Generic;
using System.Linq;

namespace MixedupLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            while (firstNumbers.Count > 0 && secondNumbers.Count > 0)
            {
                result.Add(firstNumbers[0]);
                firstNumbers.RemoveAt(0);
                result.Add(secondNumbers[secondNumbers.Count - 1]);
                secondNumbers.RemoveAt(secondNumbers.Count - 1);
            }

            if (firstNumbers.Count > 0)
            {
                firstNumbers.Sort();
                result.Sort();
                Console.WriteLine(string.Join(" ", result.Where(n => n > firstNumbers[0] && n < firstNumbers[1])));
            }
            else
            {
                secondNumbers.Sort();
                result.Sort();
                Console.WriteLine(string.Join(" ", result.Where(n => n > secondNumbers[0] && n < secondNumbers[1])));
            }
        }
    }
}
