using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = new List<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            int wagonCapacity = int.Parse(Console.ReadLine());
            var command = Console.ReadLine();
            while (command != "end")
            {
                var currentCommand = command.Split();
                if (currentCommand[0] == "Add")
                {
                    wagons.Add(int.Parse(currentCommand[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + int.Parse(currentCommand[0]) <= wagonCapacity)
                        {
                            wagons[i] += int.Parse(currentCommand[0]);
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
