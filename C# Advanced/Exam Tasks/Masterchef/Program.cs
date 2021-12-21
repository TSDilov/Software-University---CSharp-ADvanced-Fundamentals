using System;
using System.Collections.Generic;
using System.Linq;

namespace Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredientsValues = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            var freshnessLevelValues = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Dictionary<string, int> dishes = new Dictionary<string, int>();

            while (freshnessLevelValues.Count > 0 && ingredientsValues.Count > 0)
            {
                if (ingredientsValues.Peek() * freshnessLevelValues.Peek() == 150)
                {
                    if (!dishes.ContainsKey("Dipping sauce"))
                    {
                        dishes.Add("Dipping sauce", 0);
                    }
                    dishes["Dipping sauce"]++;
                    ingredientsValues.Dequeue();
                    freshnessLevelValues.Pop();
                }
                else if (ingredientsValues.Peek() * freshnessLevelValues.Peek() == 250)
                {
                    if (!dishes.ContainsKey("Green salad"))
                    {
                        dishes.Add("Green salad", 0);
                    }
                    dishes["Green salad"]++;
                    ingredientsValues.Dequeue();
                    freshnessLevelValues.Pop();
                }
                else if (ingredientsValues.Peek() * freshnessLevelValues.Peek() == 300)
                {
                    if (!dishes.ContainsKey("Chocolate cake"))
                    {
                        dishes.Add("Chocolate cake", 0);
                    }
                    dishes["Chocolate cake"]++;
                    ingredientsValues.Dequeue();
                    freshnessLevelValues.Pop();
                }
                else if (ingredientsValues.Peek() * freshnessLevelValues.Peek() == 400)
                {
                    if (!dishes.ContainsKey("Lobster"))
                    {
                        dishes.Add("Lobster", 0);
                    }
                    dishes["Lobster"]++;
                    ingredientsValues.Dequeue();
                    freshnessLevelValues.Pop();
                }
                else if (ingredientsValues.Peek() == 0)
                {
                    ingredientsValues.Dequeue();
                }
                else
                {
                    var ingredient = ingredientsValues.Peek();
                    freshnessLevelValues.Pop();
                    ingredient = ingredient + 5;
                    ingredientsValues.Dequeue();
                    ingredientsValues.Enqueue(ingredient);
                }

            }
            if (dishes.ContainsKey("Dipping sauce") && dishes.ContainsKey("Green salad")
                && dishes.ContainsKey("Chocolate cake") && dishes.ContainsKey("Lobster"))
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
                foreach (var dish in dishes.OrderBy(d => d.Key))
                {
                    Console.WriteLine($"# {dish.Key} --> {dish.Value}");
                }
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
                if (ingredientsValues.Sum() > 0)
                {
                    Console.WriteLine($"Ingredients left: {ingredientsValues.Sum()}");
                }
                foreach (var dish in dishes.OrderBy(d => d.Key))
                {
                    Console.WriteLine($"# {dish.Key} --> {dish.Value}");
                }
            }
        }
    }
}
