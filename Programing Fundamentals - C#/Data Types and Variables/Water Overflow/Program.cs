using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPours = int.Parse(Console.ReadLine());
            int liters;
            int sumLiters = 0;
            for (int i = 1; i <= numberPours;  i++)
            {
                liters = int.Parse(Console.ReadLine());
                sumLiters += liters;
                if (sumLiters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sumLiters = sumLiters - liters;
                }
            }
            Console.WriteLine(sumLiters);
        }
    }
}
