using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();
            int countOfMoves = 0;
            while (command != "end")
            {
                string[] indexes = command.Split();
                int firstIndex = int.Parse(indexes[0]);
                int secondIndex = int.Parse(indexes[1]);
                countOfMoves++;
                if (secondIndex < 0 || secondIndex >= elements.Count
                    || firstIndex < 0 || firstIndex >= elements.Count)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    elements.Insert(elements.Count / 2, $"-{countOfMoves}a");
                    elements.Insert(elements.Count / 2, $"-{countOfMoves}a");
                }
                else if (elements[firstIndex] == elements[secondIndex])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {elements[firstIndex]}!");
                    string deleteItem = elements[firstIndex];
                    elements.RemoveAll(e => e == deleteItem);
                }
                else if (elements[firstIndex] != elements[secondIndex])
                {
                    Console.WriteLine("Try again!");
                }
                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {countOfMoves} turns!");
                    return;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
