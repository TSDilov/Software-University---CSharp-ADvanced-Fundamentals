using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double X = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());
            int sum = 1;
            double sumE = 0;
            double sumO = 0;
            for (int i = 1; i <=N; i++)
            {
                if (i % 2 ==0)
                {
                    sumE += (10*sum++)-1;
                }
                else
                {
                    sumO += P;
                }
            }
            double sumAll = sumE + sumO;
            if (sumAll >= X)
            {
                Console.WriteLine($"Yes! {sumAll-X:F2}");
            }
            else
            {
                Console.WriteLine($"No! {X-sumAll:F2}");
            }
           
        }
    }
}
