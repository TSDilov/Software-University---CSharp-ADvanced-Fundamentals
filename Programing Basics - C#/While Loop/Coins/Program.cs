using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine()) * 100;
            int coins = 0;
            while (sum >0)
            {
                if (sum / 200 >=1)
                {
                    sum -= 200;
                    coins++;
                }
                else if (sum / 100 >=1)
                {
                    sum -= 100;
                    coins++;
                }
                else if (sum /50 >= 1)
                {
                    sum -= 50;
                    coins++;
                }
                else if (sum / 20 >= 1)
                {
                    sum -= 20;
                    coins++;
                }
                else if (sum / 10 >= 1)
                {
                    sum -= 10;
                    coins++;
                }
                else if (sum / 5 >= 1)
                {
                    sum -= 5;
                    coins++;
                }
                else if (sum / 2 >= 1)
                {
                    sum -= 2;
                    coins++;
                }
                else if (sum /1 >=1)
                {
                    sum -= 1;
                    coins++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(coins);
        }
    }
}
