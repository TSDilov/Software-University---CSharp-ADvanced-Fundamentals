using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandType = command.Split();

                if (commandType[0] == "Add")
                {
                    numbers.Add(int.Parse(commandType[1]));
                }
                else if (commandType[0] == "Insert")
                {
                    int number = int.Parse(commandType[1]);
                    int index = int.Parse(commandType[2]);
                    
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        command = Console.ReadLine();
                        continue;
                    }
                    numbers.Insert(index, number);
                }
                else if (commandType[0] == "Remove")
                {
                    int index = int.Parse(commandType[1]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        command = Console.ReadLine();
                        continue;
                    }
                    numbers.RemoveAt(index);
                }
                else if (commandType[1] == "left")
                {
                    int count = int.Parse(commandType[2]);
                    for (int i = 0; i < count; i++)
                    {
                        int firstNumber = numbers[0];
                        for (int j = 0; j < numbers.Count - 1; j++)
                        {
                            numbers[j] = numbers[j + 1];
                        }
                        numbers[numbers.Count - 1] = firstNumber;
                    }
                }
                else if (commandType[1] == "right")
                {
                    int count = int.Parse(commandType[2]);
                    for (int i = 0; i < count; i++)
                    {
                        int lastNumber = numbers[numbers.Count - 1];
                        for (int j = numbers.Count - 1; j >= 1; j--)
                        {
                            numbers[j] = numbers[j - 1];
                        }
                        numbers[0] = lastNumber;
                    }
                }
                               
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
