using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfReadLines = int.Parse(Console.ReadLine());
            Dictionary<int, int> ocurrancesOfNumber = new Dictionary<int, int>();
            for (int i = 0; i < numberOfReadLines; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!ocurrancesOfNumber.ContainsKey(number))
                {
                    ocurrancesOfNumber.Add(number, 0);
                }
                ocurrancesOfNumber[number]++;
            }
            Console.WriteLine(ocurrancesOfNumber.First(n => n.Value % 2 == 0).Key);
        }
    }
}
