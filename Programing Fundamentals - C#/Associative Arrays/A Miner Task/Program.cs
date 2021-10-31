using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var quantityOFResources = new Dictionary<string, int>();
            while (true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (!quantityOFResources.ContainsKey(resource))
                {
                    quantityOFResources.Add(resource, quantity);
                    continue;
                }
                quantityOFResources[resource] += quantity;               
            }
            foreach (var resource in quantityOFResources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
