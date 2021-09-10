using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sum = double.Parse(Console.ReadLine());
            if (sum >= 0 & sum <= 500)
            {
                if (town == "Sofia")
                {
                    Console.WriteLine($"{sum * 5 / 100:F2}");
                }
                else if (town == "Varna")
                {
                    Console.WriteLine($"{sum * 45 / 1000:F2}");
                }
                else if (town == "Plovdiv")
                {
                    Console.WriteLine($"{sum * 55 / 1000:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (sum > 500 & sum <= 1000)
            {
                if (town == "Sofia")
                {
                    Console.WriteLine($"{sum * 7 / 100:F2}");
                }
                else if (town == "Varna")
                {
                    Console.WriteLine($"{sum * 75 / 1000:F2}");
                }
                else if (town == "Plovdiv")
                {
                    Console.WriteLine($"{sum * 8 / 100:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (sum > 1000 & sum <= 10000)
            {
                if (town == "Sofia")
                {
                    Console.WriteLine($"{sum * 8 / 100:F2}");
                }
                else if (town == "Varna")
                {
                    Console.WriteLine($"{sum * 10 / 100:F2}");
                }
                else if (town == "Plovdiv")
                {
                    Console.WriteLine($"{sum * 12 / 100:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (sum > 10000 & sum <= 1000000)
            {
                if (town == "Sofia")
                {
                    Console.WriteLine($"{sum * 12 / 100:F2}");
                }
                else if (town == "Varna")
                {
                    Console.WriteLine($"{sum * 13 / 100:F2}");
                }
                else if (town == "Plovdiv")
                {
                    Console.WriteLine($"{sum * 145 / 1000:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
