using System;
using System.Collections.Generic;
using System.Linq;

namespace LootBox
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstBox = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            var secondBox = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            var claimedItems = new List<int>();

            while (firstBox.Count > 0 && secondBox.Count > 0)
            {
                int currentItemFromFirst = firstBox.Peek();
                var currentItemFromSecond = secondBox.Peek();
                var sum = currentItemFromFirst + currentItemFromSecond;
                if (sum % 2 == 0)
                {
                    claimedItems.Add(sum);
                    firstBox.Dequeue();
                    secondBox.Pop();
                }
                else
                {
                    secondBox.Pop();
                    firstBox.Enqueue(currentItemFromSecond);
                }
            }
            if (firstBox.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
                if (claimedItems.Sum() >= 100)
                {
                    Console.WriteLine($"Your loot was epic! Value: {claimedItems.Sum()}");
                }
                else
                {
                    Console.WriteLine($"Your loot was poor... Value: {claimedItems.Sum()}");
                }
            }
            if (secondBox.Count == 0)
            {
                Console.WriteLine("Second lootbox is empty");
                if (claimedItems.Sum() >= 100)
                {
                    Console.WriteLine($"Your loot was epic! Value: {claimedItems.Sum()}");
                }
                else
                {
                    Console.WriteLine($"Your loot was poor... Value: {claimedItems.Sum()}");
                }
            }
        }
    }
}
