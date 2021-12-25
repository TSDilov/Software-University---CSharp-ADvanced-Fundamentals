using System;
using System.Collections.Generic;
using System.Linq;

namespace TheFightforGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWaves = int.Parse(Console.ReadLine());
            var plates = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            var orcs = new Stack<int>();
            var count = 1;

            for (int i = 0; i < numberOfWaves; i++)
            {
                int[] orcWave = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < orcWave.Length; j++)
                {
                    if (plates.Count > 0)
                    {
                        orcs.Push(orcWave[j]);
                    }
                }
                if (count % 3 == 0 && plates.Count > 0)
                {
                    var newPlate = int.Parse(Console.ReadLine());
                    plates.Enqueue(newPlate);
                }
                count++;
                while (true)
                {
                    if (plates.Count == 0)
                    {
                        break;
                    }
                    if (orcs.Count == 0)
                    {
                        break;
                    }
                    var currentPlate = plates.Peek();
                    var currentOrc = orcs.Peek();
                    if (currentPlate > currentOrc)
                    {
                        orcs.Pop();
                        currentPlate -= currentOrc;
                        plates.Dequeue();
                        plates.Enqueue(currentPlate);
                        for (int k = 0; k < plates.Count - 1; k++)
                        {
                            var plate = plates.Dequeue();
                            plates.Enqueue(plate);
                        }
                    }
                    else if (currentOrc > currentPlate)
                    {
                        plates.Dequeue();
                        currentOrc -= currentPlate;
                        orcs.Pop();
                        orcs.Push(currentOrc);
                    }
                    else
                    {
                        plates.Dequeue();
                        orcs.Pop();
                    }
                }
            }
            if (plates.Count > 0)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
            if (orcs.Count > 0)
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ", orcs)}"); ;
            }          
        }
    }
}
