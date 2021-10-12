using System;

namespace Encrypt_SortandPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] sums = new int[n];  
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int sum = 0;

                foreach (char letter in input)
                {
                    if (letter == 'a' || letter == 'A' || letter == 'e' || letter == 'E' || letter == 'o' ||
                        letter == 'O' || letter == 'i' || letter == 'I' || letter == 'u' || letter == 'U')
                        
                    {
                        sum += (int)letter * input.Length;
                    }
                    else
                    {
                        sum += (int)letter / input.Length;
                    }
                }
                sums[i] = sum;
            }
            Array.Sort(sums);
            foreach (var item in sums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
