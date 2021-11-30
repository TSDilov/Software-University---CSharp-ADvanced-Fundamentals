using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfClothes = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> colorsOfClothes = new Dictionary<string, Dictionary<string, int>>(); 
            for (int i = 0; i < numberOfClothes; i++)
            {
                string[] puttingClothes = Console.ReadLine().Split(" -> ");
                string color = puttingClothes[0];
                string[] typeOfClothe = puttingClothes[1].Split(',');
                if (!colorsOfClothes.ContainsKey(color))
                {
                    colorsOfClothes.Add(color, new Dictionary<string, int>());
                }
                foreach (var clothe in typeOfClothe)
                {
                    if (!colorsOfClothes[color].ContainsKey(clothe))
                    {
                        colorsOfClothes[color].Add(clothe, 0);
                    }
                    colorsOfClothes[color][clothe]++;
                }
            }   
            string[] lookingClothe = Console.ReadLine().Split();
            foreach (var color in colorsOfClothes)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var (clothe, count) in color.Value)
                {
                    if (clothe == lookingClothe[1] && color.Key == lookingClothe[0])
                    {
                        Console.WriteLine($"* {clothe} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothe} - {count}");
                    }
                }
            }
        }
    }
}
