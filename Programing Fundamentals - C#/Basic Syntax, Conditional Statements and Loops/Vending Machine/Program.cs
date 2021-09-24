using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string start=Console.ReadLine();
            double sum = 0;
            while (start != "Start")
            {
                double coin = double.Parse(start);
                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                {
                    sum += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                start = Console.ReadLine();
            }
            start = Console.ReadLine();
            while (start != "End")
            {
                double price = 0.0;
                if (start == "Nuts")
                {
                    price = 2.0;
                    Console.WriteLine("Purchased nuts");
                }
                else if (start == "Water")
                {
                    price = 0.7;
                    Console.WriteLine("Purchased water");
                }
                else if (start == "Crisps")
                {
                    price = 1.5;
                    Console.WriteLine("Purchased crisps");
                }
                else if (start == "Soda")
                {
                    price = 0.8;
                    Console.WriteLine("Purchased soda");
                }
                else if (start == "Coke")
                {
                    price = 1.0;
                    Console.WriteLine("Purchased coke");
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                if (sum >= price)
                {
                    sum -= price;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                start = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:F2}");
        }
    }
}
