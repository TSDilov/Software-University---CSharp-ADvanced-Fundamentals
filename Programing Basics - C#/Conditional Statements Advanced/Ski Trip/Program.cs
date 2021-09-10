using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            bool isValid = (days > 0 && days < 365);
            string room = Console.ReadLine();
            string mark = Console.ReadLine();
            int nights = days - 1;
            double price = 0.0;
            double discount = 0.0;
            switch (room)
            {
                case "room for one person":
                    price = nights * 18;
                    break;
                case "apartment":
                    price = nights * 25;
                    if (nights<10)
                    {
                        discount = price * 0.3;
                    }
                    else if (nights>=10 && nights<=15)
                    {
                        discount = price * 0.35;
                    }
                    else if (nights>15)
                    {
                        discount = price * 0.5;
                    }
                    break;
                case "president apartment":
                    price = nights * 35;
                    if (nights<10)
                    {
                        discount = price * 0.1;
                    }
                    else if (nights>=10 && nights<=15)
                    {
                        discount = price * 0.15;
                    }
                    else if (nights>15)
                    {
                        discount = price * 0.2;
                    }
                    break;
            }
            price -= discount;
            switch (mark)
            {
                case "positive":
                    price = price + price * 1 / 4;
                    break;
                case "negative":
                    price = price - price * 1 / 10;
                    break;
            }
            Console.WriteLine($"{price:F2}");
        }
    }
}
