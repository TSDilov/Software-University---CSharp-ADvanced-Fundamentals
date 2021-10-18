using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int givenPower = int.Parse(Console.ReadLine());

            double result = MethodRaisePower(num, givenPower);
            Console.WriteLine(result);
        }

        static double MethodRaisePower(double num, int givenPower)
        {
            double result = 1.0;
            for (int i = 0; i < givenPower; i++)
            {
                result *= num;
            }
            return (double)result;
        }
    }
}
