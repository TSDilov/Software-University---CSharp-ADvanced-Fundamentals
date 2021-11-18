using System;
using System.Collections.Generic;
using System.Linq;

namespace TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chest = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();
            List<string> stolenItems = new List<string>();

            while (input != "Yohoho!")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Loot":
                        for (int i = 1; i < command.Length; i++)
                        {
                            if (!chest.Contains(command[i]))
                            {
                                chest.Insert(0, command[i]);
                            }
                        }
                        break;
                    case "Drop":
                        if (int.Parse(command[1]) < chest.Count && int.Parse(command[1]) >= 0)
                        {
                            string currentPosition = chest[int.Parse(command[1])];
                            chest.RemoveAt(int.Parse(command[1]));
                            chest.Add(currentPosition);
                        }
                        break;
                    case "Steal":
                        int itemsToSteal = int.Parse(command[1]);
                        if (itemsToSteal > chest.Count)
                        {
                            itemsToSteal = chest.Count;
                        }
                        stolenItems = chest.TakeLast(itemsToSteal).ToList();
                        chest.RemoveRange(chest.Count - itemsToSteal, itemsToSteal);
                        Console.WriteLine(string.Join(", ", stolenItems));
                        break;
                }


                input = Console.ReadLine();
            }
            if (chest.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
                return;
            }                
                double averageSum = 0;
            foreach (var item in chest)
            {
                averageSum += item.Length;
            }
            averageSum /= chest.Count;
                Console.WriteLine($"Average treasure gain: {averageSum:F2} pirate credits.");
        }
    }
}
