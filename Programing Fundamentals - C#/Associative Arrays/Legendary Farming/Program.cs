using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legendaryFarm = new Dictionary<string, int>();
            legendaryFarm.Add("shards", 0);
            legendaryFarm.Add("fragments", 0);
            legendaryFarm.Add("motes", 0);

            while (legendaryFarm["shards"] < 250 && legendaryFarm["fragments"] < 250 && legendaryFarm["motes"] < 250)
            {
                List<string> materials = Console.ReadLine().ToLower().Split().ToList();
                while (materials.Count != 0)
                {
                    int quantity = int.Parse(materials[0]);
                    string material = materials[1];
                    if (!legendaryFarm.ContainsKey(material))
                    {
                        legendaryFarm.Add(material, quantity);
                        materials.RemoveRange(0, 2);
                        continue;
                    }


                    legendaryFarm[material] += quantity;
                    materials.RemoveRange(0, 2);
                    if (legendaryFarm["shards"] >= 250 || legendaryFarm["fragments"] >= 250 || legendaryFarm["motes"] >= 250)
                    {
                        break;
                    }
                }
            }

            Dictionary<string, int> legendaryMaterials = legendaryFarm.Take(3).ToDictionary(m => m.Key, m => m.Value);
            int winnerValue = legendaryMaterials.Values.Max();
            string winnerKey = legendaryMaterials.First(m => m.Value == winnerValue).Key;
            string winner = string.Empty;
            switch (winnerKey)
            {
                case "shards":
                    winner = "Shadowmourne";
                    break;
                case "fragments":
                    winner = "Valanyr";
                    break;
                case "motes":
                    winner = "Dragonwrath";
                    break;
            }
            Console.WriteLine($"{winner} obtained!");
            legendaryMaterials[winnerKey] -= 250;

            legendaryFarm.Remove("shards");
            legendaryFarm.Remove("fragments");
            legendaryFarm.Remove("motes");
            foreach (var material in legendaryMaterials.OrderByDescending(m => m.Value).ThenBy(m => m.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            foreach (var material in legendaryFarm.OrderBy(m => m.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}
