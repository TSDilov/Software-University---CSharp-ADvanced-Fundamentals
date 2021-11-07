using System;
using System.Text;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder();
            input.Append(Console.ReadLine());
            int power = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (power > 0 && input[i] != '>' )
                {
                    input.Remove(i, 1);
                    i--;
                    power--;
                }
                else if (input[i] == '>')
                {
                    power += int.Parse(input[i + 1].ToString());

                }
            }
            Console.WriteLine(input);
        }
    }
}
