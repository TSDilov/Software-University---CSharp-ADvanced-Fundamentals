using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split('!', StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();
            while (command != "Go Shopping!")
            {
                string[] commands = command.Split();

                switch (commands[0])
                {
                    case "Urgent":
                        if (!groceries.Contains(commands[1]))
                        {
                            groceries.Insert(0, commands[1]);
                        }
                        break;
                    case "Unnecessary":
                        if (groceries.Contains(commands[1]))
                        {
                            groceries.Remove(commands[1]);
                        }
                        break;
                    case "Correct":
                        if (groceries.Contains(commands[1]))
                        {
                            int index = groceries.FindIndex(g => g == commands[1]);
                            groceries.RemoveAt(index);
                            groceries.Insert(index, commands[2]);
                        }
                        break;
                    case "Rearrange":
                        if (groceries.Contains(commands[1]))
                        {
                            groceries.Remove(commands[1]);
                            groceries.Add(commands[1]);
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
