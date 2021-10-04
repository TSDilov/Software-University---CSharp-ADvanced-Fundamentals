using System;
using System.Linq;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            if (input.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < input.Length; i++)
            {
                leftSum = 0;
                rightSum = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (j > i)
                    {
                        rightSum += input[j];
                    }
                    else if (j == i)
                    {
                        continue;
                    }
                    else if (j < i)
                    {
                        leftSum += input[j];
                    }
                }
                if (rightSum == leftSum && input.Length > 2)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            if (rightSum != leftSum)
                Console.WriteLine("no");
        }
    }
}
