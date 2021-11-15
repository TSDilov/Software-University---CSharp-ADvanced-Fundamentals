using System;
using System.Collections.Generic;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhood = Console.ReadLine().Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            string input = Console.ReadLine();
            int currentIndex = 0;
            while (input != "Love!")
            {
                string[] commands = input.Split();
                currentIndex += int.Parse(commands[1]);
                if (currentIndex > neighborhood.Count - 1)
                {
                    currentIndex = 0;
                }

                if (neighborhood[currentIndex]  == 0)
                {
                    Console.WriteLine($"Place {currentIndex} already had Valentine's day.");

                    input = Console.ReadLine();
                    continue;
                }
                neighborhood[currentIndex] -= 2;

                if (neighborhood[currentIndex] == 0)
                {
                    Console.WriteLine($"Place {currentIndex} has Valentine's day.");
                }               
                input = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {currentIndex}.");
            if (neighborhood.All(n => n == 0))
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {neighborhood.Count(n => n > 0)} places.");
            }
        }
    }
}
