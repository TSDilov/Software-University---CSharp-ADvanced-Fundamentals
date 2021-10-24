using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            List<int> bombNumberAndPower = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumberAndPower[0])
                {
                    for (int j  = i - bombNumberAndPower[1]; j  <= i + bombNumberAndPower[1]; j++)
                    {
                        if (j < 0 || j > numbers.Count)
                        {
                            continue;
                        }
                        numbers[j] = 0;
                    }
                }               
            }

            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
