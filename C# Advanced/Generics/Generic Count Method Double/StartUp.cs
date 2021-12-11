using System;

namespace GenericCountMethodDouble
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var box = new Box<double>();
            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                box.Add(input);
            }
            double forCompare = double.Parse(Console.ReadLine());
            Console.WriteLine(box.GreaterCount(forCompare));
        }
    }
}
