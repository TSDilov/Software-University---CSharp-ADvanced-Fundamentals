using System;
using System.Collections.Generic;
using System.Linq;

namespace TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            List<int> lifts = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < lifts.Count; i++)
            {
                while (lifts[i] < 4)
                {
                    if (people <= 0)
                    {
                        break;
                    }
                    people--;
                    lifts[i]++;
                }
            }
            if (!lifts.All(w => w ==4) && people <= 0)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", lifts));
            }
            else if (lifts.All(w => w == 4) && people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", lifts));
            }
            else if (lifts.All(w => w == 4) && people <= 0)
            {
                Console.WriteLine(string.Join(" ", lifts));
            }
        }
    }
}
