using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForVacation = double.Parse(Console.ReadLine());
            double moneySheHas = double.Parse(Console.ReadLine());
            int days = 0;
            int spendDays = 0;
            string operation = "";
            double sum;
            while (moneySheHas < moneyForVacation && spendDays < 5)
            {
                operation = Console.ReadLine();
                sum = double.Parse(Console.ReadLine());
                if (operation == "spend")
                {
                    spendDays++;
                    if (moneySheHas <= sum)
                    {
                        moneySheHas = 0.0;
                    }
                    else
                    {
                        moneySheHas -= sum;
                    }
                }
                else
                {
                    moneySheHas += sum;
                    spendDays = 0;
                }
                days++;
            }
            if (spendDays == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
            else
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }

        }
    }
}
