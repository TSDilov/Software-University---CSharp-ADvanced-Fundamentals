using System;

namespace LeftandRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int sum1 = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
            for (int i = 1; i <= n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                sum1 += num1;
            }
            int dif = Math.Abs(sum - sum1);
            if (sum == sum1)
            {
                Console.WriteLine($"Yes, sum = {sum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {dif}");
            }
        }
    }
}
