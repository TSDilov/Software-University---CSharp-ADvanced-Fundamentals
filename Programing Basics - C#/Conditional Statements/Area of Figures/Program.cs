using System;

namespace AreaofFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string fig = Console.ReadLine();
            double area = 0.0;
            if (fig == "square")
            {
                double sideS = double.Parse(Console.ReadLine());
                area = sideS * sideS;
            }
            else if (fig == "rectangle")
            {
                double sideR1 = double.Parse(Console.ReadLine());
                double sideR2 = double.Parse(Console.ReadLine());
                area = sideR1 * sideR2;
            }
            else if (fig == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI*radius*radius;
            }
            else if (fig == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double Hside = double.Parse(Console.ReadLine());
                area = (side*Hside)/2;
            }
            Console.WriteLine($"{area:F3}");
        }
    }
}
