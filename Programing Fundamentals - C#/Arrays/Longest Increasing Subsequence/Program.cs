using System;
using System.Linq;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequance = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] lis;
            int[] len = new int[sequance.Length];
            int[] prev = new int[sequance.Length];
            int maxLenght = 0;
            int lastIndex = -1;

            for (int i = 0; i < sequance.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (sequance[j] < sequance[i] && len[j] >= len[i])
                    {
                        len[i] = 1 + len[j];
                        prev[i] = j;
                    }
                }
                if (maxLenght < len[i])
                {
                    maxLenght = len[i];
                    lastIndex = i;
                }
            }
            lis = new int[maxLenght];
            for (int i = 0; i < maxLenght; i++)
            {
                lis[i] = sequance[lastIndex];
                lastIndex = prev[lastIndex];
            }
            Array.Reverse(lis);
            Console.WriteLine(string.Join(" ",lis));
        }
    }
}
