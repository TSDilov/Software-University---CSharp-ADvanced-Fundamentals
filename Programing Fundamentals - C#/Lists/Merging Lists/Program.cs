using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            List<int> secondNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int maxCount = Math.Max(firstNumbers.Count, secondNumbers.Count);
            for (int i = 0; i < maxCount; i++)
            {
                if (i < firstNumbers.Count)
                {
                    result.Add(firstNumbers[i]);
                }
                if (i < secondNumbers.Count)
                {
                    result.Add(secondNumbers[i]);
                }
            }
                       
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
