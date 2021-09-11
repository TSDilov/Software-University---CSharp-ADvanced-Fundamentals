using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studio = 0.0;
            double apartment = 0.0;
            double discount = 0.0;
            double discountA = 0.0;
            if (month == "May" || month == "October")
            {
                studio = 50.0;
                apartment = 65.0;
                if (nights > 7 && nights <= 14)
                {
                    discount = studio * 0.05;
                    studio -= discount;
                }
                else if (nights > 14)
                {
                    discount = studio * 0.3;
                    studio -= discount;
                    discountA = apartment * 0.1;
                    apartment -= discountA;
                }
            }
            if (month == "June" || month == "September")
            {
                studio = 75.20;
                apartment = 68.70;
                if (nights > 14)
                {
                    discount = studio * 0.2;
                    studio -= discount;
                    discountA = apartment * 0.1;
                    apartment -= discountA;
                }
            }
            if (month == "July" || month == "August")
            {
                studio = 76.0;
                apartment = 77.0;
                if (nights > 14)
                {
                    discountA = apartment * 0.1;
                    apartment -= discountA;
                }
            }
            Console.WriteLine($"Apartment: {apartment*nights:F2} lv.");
            Console.WriteLine($"Studio: {studio * nights:F2} lv.");
        }
    }
}
