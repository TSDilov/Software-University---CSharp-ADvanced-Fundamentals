using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string noMore = Console.ReadLine();
            double total = 0;
            while (noMore != "NoMoreMoney")
            {
                double sum = double.Parse(noMore);
                if (sum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                total += sum;
                Console.WriteLine($"Increase: {sum:F2}");
                noMore = Console.ReadLine();
            }
            Console.WriteLine($"Total: {total:F2}");
        }
    }
}
