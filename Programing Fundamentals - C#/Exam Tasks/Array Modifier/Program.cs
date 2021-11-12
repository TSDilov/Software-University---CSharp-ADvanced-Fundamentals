using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split();

                switch (command[0])
                {
                    case "swap":
                        int index1 = int.Parse(command[1]);
                        int index2 = int.Parse(command[2]);
                        int temp = integers[index1];
                        integers[index1] = integers[index2];
                        integers[index2] = temp;
                        break;
                    case "multiply":
                        index1 = int.Parse(command[1]);
                        index2 = int.Parse(command[2]);
                        integers[index1] *= integers[index2];                        
                        break;
                    case "decrease":
                        for (int i = 0; i < integers.Count; i++)
                        {
                            integers[i] -= 1;
                        }
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", integers));
        }
    }
}
