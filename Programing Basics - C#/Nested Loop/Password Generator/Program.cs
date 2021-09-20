using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            string letters = "abcdefghi";
            for (int m = 1; m <= n; m++)
            {
                for (int h = 1; h <= n; h++)
                {
                    for (int k = 0; k < l; k++)
                    {
                        for (int j = 0; j < l; j++)
                        {
                            if (m >= h)
                            {
                                for (int i = m + 1; i <= n; i++)
                                {
                                    Console.Write($"{m}{h}{letters[k]}{letters[j]}{i} ");
                                }
                            }
                            else if (h > m)
                            {
                                for (int i = h + 1; i <= n; i++)
                                {
                                    Console.Write($"{m}{h}{letters[k]}{letters[j]}{i} ");
                                }
                            }
                        }
                    }
                }
            }           
        }
    }
}
