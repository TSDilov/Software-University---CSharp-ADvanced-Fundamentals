using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int count = 0;
            bool flag = false;
            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    count++;
                    if (i + j == magic)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {magic})");
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine($"{count} combinations - neither equals {magic}");
            }
        }
    }
}
