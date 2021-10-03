using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wagonArray = new int[n];
            int peopleCount = 0;
            for (int i = 0; i < n; i++)
            {
                int wagonPeople = int.Parse(Console.ReadLine());
                wagonArray[i] = wagonPeople;
                peopleCount += wagonPeople;
            }
            foreach (var item in wagonArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(peopleCount);
        }
    }
}
