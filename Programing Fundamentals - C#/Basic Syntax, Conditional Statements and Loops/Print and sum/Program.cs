using System;

namespace Printandsum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int finishNum = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = startNum; i <= finishNum; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine("");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
