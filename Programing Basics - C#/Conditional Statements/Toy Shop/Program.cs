using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceH = double.Parse(Console.ReadLine());
            int puz = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());
            int num = puz + doll + bear + min + truck;
            double sum = (puz * 2.60) + (doll * 3) + (bear * 4.10) + (min * 8.20) + (truck * 2);
            if (num >= 50)
            {
                double withdiscount = sum - (sum * 1 / 4);
                double sumForRent = withdiscount * 1 /10;
                double profit = withdiscount - sumForRent;
                if (profit >= priceH)
                {
                    double high = profit - priceH;
                    Console.WriteLine($"Yes! {high:F2} lv left.");
                }
                else
                {
                    double low = priceH - profit;
                    Console.WriteLine($"Not enough money! {low:F2} lv needed.");
                }
            }
            else
            {
                double sumForRent2 = sum * 1 / 10;
                double profit2 = sum - sumForRent2;
                if (profit2 > priceH)
                {
                    double high2 = profit2 - priceH;
                    Console.WriteLine($"Yes! {high2:F2} lv left.");
                }
                else
                {
                    double low2 = priceH - profit2;
                    Console.WriteLine($"Not enough money! {low2:F2} lv needed.");
                }
            }        
        }
    }
}
