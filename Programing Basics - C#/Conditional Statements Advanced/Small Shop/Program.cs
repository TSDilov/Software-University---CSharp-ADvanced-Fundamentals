using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double num = double.Parse(Console.ReadLine());
            switch (product)
            {
                case "coffee":
                    if (town=="Sofia")
                    {
                        Console.WriteLine(num*0.5);
                    }
                    else if (town=="Plovdiv")
                    {
                        Console.WriteLine(num * 0.4);
                    }
                    else
                    {
                        Console.WriteLine(num*0.45);
                    }
                    break;
                case "water":
                    if (town == "Sofia")
                    {
                        Console.WriteLine(num * 0.8);
                    }
                    else if (town == "Plovdiv")
                    {
                        Console.WriteLine(num * 0.7);
                    }
                    else
                    {
                        Console.WriteLine(num * 0.7);
                    }
                    break;
                case "beer":
                    if (town == "Sofia")
                    {
                        Console.WriteLine(num * 1.2);
                    }
                    else if (town == "Plovdiv")
                    {
                        Console.WriteLine(num * 1.15);
                    }
                    else
                    {
                        Console.WriteLine(num * 1.1);
                    }
                    break;
                case "sweets":
                    if (town == "Sofia")
                    {
                        Console.WriteLine(num * 1.45);
                    }
                    else if (town == "Plovdiv")
                    {
                        Console.WriteLine(num * 1.3);
                    }
                    else
                    {
                        Console.WriteLine(num * 1.35);
                    }
                    break;
                default:
                    if (town == "Sofia")
                    {
                        Console.WriteLine(num * 1.6);
                    }
                    else if (town == "Plovdiv")
                    {
                        Console.WriteLine(num * 1.5);
                    }
                    else
                    {
                        Console.WriteLine(num * 1.55);
                    }
                    break;

            }
        }
    }
}
