using System;

namespace ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {           
            double price = 0;
            string input = string.Empty;

            while (true)
            {
                input = Console.ReadLine();
                if (input == "special" || input == "regular")
                {
                    break;
                }
                double priceForPart = double.Parse(input);
                if (priceForPart < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                price += priceForPart;              
            }
            double taxes = price / 5;
            double totalPrice = price + taxes;
            if (input == "special")
            {
                totalPrice = totalPrice - totalPrice / 10;
            }
            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {price:F2}$");
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:F2}$");
            }

        }
    }
}
