using System;
using System.Linq;

namespace StackWithIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>();
            var command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "END")
            {
                if (command[0] == "Push")
                {
                    stack.Push(command.Skip(1).Select(e => e.Split(",").First()).ToArray());
                }
                else if (command[0] == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }
                }
                command = Console.ReadLine().Split();
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
