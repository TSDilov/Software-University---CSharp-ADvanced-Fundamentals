using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberKegs = int.Parse(Console.ReadLine());
            string largestKeg = "";
            double largestVol = 0;
            
            for (int i = 1; i <= numberKegs; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > largestVol)
                {
                    largestVol = volume;
                    largestKeg = model;
                }
            }
            Console.WriteLine(largestKeg);
        }
    }
}
