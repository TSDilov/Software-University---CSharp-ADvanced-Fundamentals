using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> moreThanAverage = new List<int>();
            double averageNumber = integers.Average();
            moreThanAverage = integers.Where(i => i > averageNumber).OrderByDescending(i => i).ToList();
            while (moreThanAverage.Count > 5)
            {
                moreThanAverage.RemoveAt(moreThanAverage.Count - 1);
            }
            if (moreThanAverage.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ",moreThanAverage));
            }
            
        }
    }
}
