using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string typePersons = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0.0;

            switch (typePersons)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        price = num * 8.45;
                        if (num >= 30)
                        {
                            price = price - price * 0.15;
                        }
                    }
                    else if (day == "Saturday")
                    {
                        price = num * 9.8;
                        if (num >= 30)
                        {
                            price = price - price * 0.15;
                        }
                    }
                    else
                    {
                        price = num * 10.46;
                        if (num >= 30)
                        {
                            price = price - price * 0.15;
                        }
                    }
                    break;
                case "Business":
                    if (day == "Friday")
                    {
                        price = num * 10.9;
                        if (num >= 100)
                        {
                            price = price - 10*10.9;
                        }
                    }
                    else if (day == "Saturday")
                    {
                        price = num * 15.6;
                        if (num >= 100)
                        {
                            price = price - 10*15.6;
                        }
                    }
                    else
                    {
                        price = num * 16;
                        if (num >= 100)
                        {
                            price = price - 10*16;
                        }
                    }
                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        price = num * 15;
                        if (num >= 10 && num <= 20)
                        {
                            price = price - price * 0.05;
                        }
                    }
                    else if (day == "Saturday")
                    {
                        price = num * 20;
                        if (num >= 10 && num <= 20)
                        {
                            price = price - price * 0.05;
                        }
                    }
                    else
                    {
                        price = num * 22.5;
                        if (num >= 10 && num <= 20)
                        {
                            price = price - price * 0.05;
                        }
                    }
                    break;
            }
            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}
