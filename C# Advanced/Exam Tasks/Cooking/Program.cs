﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            var liquids = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            var ingredients = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            var breadCount = 0;
            var cakeCount = 0;
            var pastryCount = 0;
            var fruitPieCount = 0;
            while (liquids.Count != 0 && ingredients.Count != 0)
            {
                var currentLiquid = liquids.Peek();
                var currentIngredient = ingredients.Peek();
                var sum = currentIngredient + currentLiquid;
                if (sum == 25)
                {
                    breadCount++;
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else if (sum == 50)
                {
                    cakeCount++;
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else if (sum == 75)
                {
                    pastryCount++;
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else if (sum == 100)
                {
                    fruitPieCount++;
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    currentIngredient += 3;
                    ingredients.Push(currentIngredient);
                }
            }
            if (breadCount > 0 && cakeCount > 0 && pastryCount > 0 && fruitPieCount > 0)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }
            if (liquids.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.Write("Liquids left: ");
                Console.WriteLine(string.Join(", ", liquids));
            }
            if (ingredients.Count == 0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                Console.Write("Ingredients left: ");
                Console.WriteLine(string.Join(", ", ingredients));
            }
            Console.WriteLine($"Bread: {breadCount}");
            Console.WriteLine($"Cake: {cakeCount}");
            Console.WriteLine($"Fruit Pie: {fruitPieCount}");
            Console.WriteLine($"Pastry: {pastryCount}");
        }
    }
}
