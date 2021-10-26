using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> checkpoints = Console.ReadLine().Split().Select(int.Parse).ToList();
            int middleIndex = checkpoints.Count / 2;

            double leftRacerTime = 0;
            double rightRacerTime = 0;

            for (int i = 0; i < middleIndex; i++)
            {
                leftRacerTime += checkpoints[i];
                if (checkpoints[i] == 0)
                {
                    leftRacerTime *= 0.8;
                }
            }
            for (int i = checkpoints.Count - 1; i >= middleIndex + 1; i--)
            {
                rightRacerTime += checkpoints[i];
                if (checkpoints[i] == 0)
                {
                    rightRacerTime *= 0.8;
                }
            }
            if (leftRacerTime < rightRacerTime)
            {
                Console.WriteLine($"The winner is left with total time: {Math.Round(leftRacerTime, 1)}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {Math.Round(rightRacerTime, 1)}");
            }
 
        }
    }
}
