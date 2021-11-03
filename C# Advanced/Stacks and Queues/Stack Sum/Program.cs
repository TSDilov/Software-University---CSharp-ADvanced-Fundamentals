using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                numbers.Push(input[i]);
            }
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] exactCommand = command.Split();
                if (exactCommand[0] == "add")
                {
                    numbers.Push(int.Parse(exactCommand[1]));
                    numbers.Push(int.Parse(exactCommand[2]));
                }
                else if (exactCommand[0] == "remove")
                {
                    if (int.Parse(exactCommand[1]) < numbers.Count)
                    {
                        for (int i = 0; i < int.Parse(exactCommand[1]); i++)
                        {
                            numbers.Pop();
                        }
                    }
                }
                
                command = Console.ReadLine();
            }
            Console.WriteLine($"Sum: {numbers.Sum()}");
        }
    }
}
