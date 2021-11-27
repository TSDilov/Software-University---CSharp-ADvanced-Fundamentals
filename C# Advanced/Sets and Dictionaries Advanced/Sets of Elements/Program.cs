using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsofElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lengthOfSets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            HashSet<string> numbersInBothSets = new HashSet<string>();
            for (int i = 0; i < lengthOfSets[0]; i++)
            {
                int numberForFirstSet = int.Parse(Console.ReadLine());
                firstSet.Add(numberForFirstSet);
            }
            for (int i = 0; i < lengthOfSets[1]; i++)
            {
                int numberForSecondSet = int.Parse(Console.ReadLine());
                secondSet.Add(numberForSecondSet);
            }
            foreach (var number in firstSet)
            {
                if (firstSet.Contains(number) && secondSet.Contains(number))
                {
                    numbersInBothSets.Add(number.ToString());
                }
            }
            Console.WriteLine(string.Join(" ", numbersInBothSets));
        }
    }
}
