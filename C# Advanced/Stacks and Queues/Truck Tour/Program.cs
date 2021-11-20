using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> petrolPumps = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] currentPump = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int fuel = currentPump[0];
                int distance = currentPump[1];
                petrolPumps.Enqueue(new int[] { fuel, distance });
            }
            
            int startIndex = 0;
            
            while (petrolPumps .Count == n)
            {
                int currentFuel = 0;
                foreach (var pump in petrolPumps)
                {
                    int petrolFromPump = pump[0];
                    int distanceToNextpump = pump[1];
                    currentFuel += petrolFromPump;
                    currentFuel -= distanceToNextpump;
                    if (currentFuel < 0)
                    {
                        int[] element = petrolPumps.Dequeue();
                        petrolPumps.Enqueue(element);
                        startIndex++;
                        break;
                    }
                }
                if (currentFuel >= 0)
                {
                    petrolPumps.Dequeue();
                    Console.WriteLine(startIndex);
                }
            }
        }
    }
}
