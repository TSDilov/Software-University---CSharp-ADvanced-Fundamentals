using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfListsOfElements = int.Parse(Console.ReadLine());
            SortedSet<string> compounds = new SortedSet<string>();
            for (int i = 0; i < numberOfListsOfElements; i++)
            {
                string[] elements = Console.ReadLine().Split();
                for (int j = 0; j < elements.Length; j++)
                {
                    compounds.Add(elements[j]);
                }
            }
            Console.WriteLine(string.Join(" ", compounds));
        }
    }
}
