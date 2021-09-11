using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double sumFlowers = 0.0;
            double residue = 0.0;
            switch (flowers)
            {
                case "Roses":
                    sumFlowers = num * 5;
                    if (num > 80)
                    {
                        sumFlowers = sumFlowers - sumFlowers * 0.1;
                    }
                    break;
                case "Dahlias":
                    sumFlowers = num * 3.8;
                    if (num>90)
                    {
                        sumFlowers = sumFlowers - sumFlowers * 0.15;
                    }
                    break;
                case "Tulips":
                    sumFlowers = num * 2.8;
                    if (num > 80)
                    {
                        sumFlowers = sumFlowers - sumFlowers * 0.15;
                    }
                    break;
                case "Narcissus":
                    sumFlowers = num * 3;
                    if (num < 120)
                    {
                        sumFlowers = sumFlowers + sumFlowers * 0.15;
                    }
                    break;
                case "Gladiolus":
                    sumFlowers = num * 2.5;
                    if (num < 80)
                    {
                        sumFlowers = sumFlowers + sumFlowers * 0.2;
                    }
                    break;
            }
            if (budget >= sumFlowers)
            {
                residue = budget - sumFlowers;
                Console.WriteLine($"Hey, you have a great garden with {num} {flowers} and {residue:F2} leva left.");
            }
            else
            {
                residue = sumFlowers - budget;
                Console.WriteLine($"Not enough money, you need {residue:F2} leva more.");
            }
        }
    }
}
