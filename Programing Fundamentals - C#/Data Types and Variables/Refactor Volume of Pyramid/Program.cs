using System;

namespace RefactorVolumeofPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = length * width;
            double vol = (area * height) / 3;
            Console.Write("Length: ");
            Console.Write("Width: ");
            Console.Write("Height: ");
            Console.Write($"Pyramid Volume: {vol:f2}");


        }
    }
}
