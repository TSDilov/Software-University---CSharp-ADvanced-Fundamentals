using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            MethodOrders(product, quantity);

        }

        static void MethodOrders(string product, int quantity)
        {
            double priceOfProduct = 0.0;
            if (product == "coffee")
            {
                priceOfProduct = 1.5 * quantity;
                Console.WriteLine($"{priceOfProduct:F2}");
            }
            else if (product == "water")
            {
                priceOfProduct = 1.0 * quantity;
                Console.WriteLine($"{priceOfProduct:F2}");
            }
            else if (product == "coke")
            {
                priceOfProduct = 1.4 * quantity;
                Console.WriteLine($"{priceOfProduct:F2}");
            }
            else if (product == "snacks")
            {
                priceOfProduct = 2.00 * quantity;
                Console.WriteLine($"{priceOfProduct:F2}");
            }
        }
    }
}
