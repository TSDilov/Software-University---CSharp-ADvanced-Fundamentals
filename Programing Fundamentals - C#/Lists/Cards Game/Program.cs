using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            List<int> secondDeck = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            while (firstDeck.Count > 0 && secondDeck.Count > 0)
            {

                int firstCard1 = 0;
                int firstCard2 = 0;
                if (firstDeck[0] > secondDeck[0])
                {
                    firstCard1 = firstDeck[0];
                    firstCard2 = secondDeck[0];
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                    firstDeck.Add(firstCard1);
                    firstDeck.Add(firstCard2);
                }
                else if (secondDeck[0] > firstDeck[0])
                {
                    firstCard1 = secondDeck[0];
                    firstCard2 = firstDeck[0];
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                    secondDeck.Add(firstCard1);
                    secondDeck.Add(firstCard2);
                }
                else if (firstDeck[0] == secondDeck[0])
                {
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                }
            }
            if (firstDeck.Count > secondDeck.Count)
            {
                Console.WriteLine($"First player wins! Sum: {firstDeck.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondDeck.Sum()}");
            }
        }
    }
}
