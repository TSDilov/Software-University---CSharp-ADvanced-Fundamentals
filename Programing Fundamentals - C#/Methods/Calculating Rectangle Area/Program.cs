using System;

namespace CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double area = MethodArea(height,width);
            Console.WriteLine(area);
        }

        static double MethodArea(double height, double width)
        {
            return height * width;
        }
    }
}
