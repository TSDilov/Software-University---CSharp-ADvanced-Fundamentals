using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();
            List<string> productWithPriceAndQuantity = Console.ReadLine().Split().ToList();
            while (productWithPriceAndQuantity[0] != "buy")
            {
                string product = productWithPriceAndQuantity[0];
                double price = double.Parse(productWithPriceAndQuantity[1]);
                int quantity = int.Parse(productWithPriceAndQuantity[2]);

                if (!products.ContainsKey(product))
                {
                    products.Add(product, new List<double>());
                    products[product].Add(price);
                    products[product].Add(quantity);
                    productWithPriceAndQuantity = Console.ReadLine().Split().ToList();
                    continue;
                }
                products[product][0] = price;
                products[product][1] += quantity;
                
                productWithPriceAndQuantity = Console.ReadLine().Split().ToList();
            }
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value[0] * product.Value[1]:F2}");
            }
        }
    }
}
