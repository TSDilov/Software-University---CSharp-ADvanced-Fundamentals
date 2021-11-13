using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] exactCommand = command.Split();

                switch (exactCommand[0])
                {
                    case "Shoot":
                        int index = int.Parse(exactCommand[1]);
                        int power = int.Parse(exactCommand[2]);
                        if (index >= 0 && index < targets.Count)
                        {
                            targets[index] -= power;
                            if (targets[index] <= 0)
                            {
                                targets.RemoveAt(index);
                            }
                        }
                        break;
                    case "Add":
                        index = int.Parse(exactCommand[1]);
                        power = int.Parse(exactCommand[2]);
                        if (index >= 0 && index < targets.Count)
                        {
                            targets.Insert(index, power);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        break;
                    case "Strike":
                        index = int.Parse(exactCommand[1]);
                        int radius = int.Parse(exactCommand[2]);
                        if (index - radius >= 0 && index + radius < targets.Count)
                        {
                            targets.RemoveRange(index - radius, index + radius - (index - radius) + 1);
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }

                        break;

                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join("|", targets));
        }
    }
}
