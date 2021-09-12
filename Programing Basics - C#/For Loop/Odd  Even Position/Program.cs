using System;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double minEven = double.MaxValue;
            double maxEven = double.MinValue;
            double minOdd = double.MaxValue;
            double maxOdd = double.MinValue;
            double sumEven = 0.0;
            double sumOdd = 0.0;
            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i%2 ==0)
                {
                    sumEven += num;
                    if (num>maxEven)
                    {
                        maxEven = num;
                    }
                    if (num<minEven)
                    {
                        minEven = num;
                    }
                }
                else
                {
                    sumOdd += num;
                    if (num>maxOdd)
                    {
                        maxOdd = num;
                    }
                    if (num<minOdd)
                    {
                        minOdd = num;
                    }
                }
            }
            if (n==0)
            {
                Console.WriteLine("OddSum="+$"{sumOdd:F2},");
                Console.WriteLine("OddMin="+"No,");
                Console.WriteLine("OddMax="+"No,");
                Console.WriteLine("EvenSum="+$"{sumEven:F2},");
                Console.WriteLine("EvenMin="+"No,");
                Console.WriteLine("EvenMax="+"No");
            }
            else if (n==1)
            {
                Console.WriteLine("OddSum="+$"{sumOdd:F2},");
                Console.WriteLine("OddMin="+$"{minOdd:F2},");
                Console.WriteLine("OddMax="+$"{maxOdd:F2},");
                Console.WriteLine("EvenSum="+$"{sumEven:F2},");
                Console.WriteLine("EvenMin="+"No,");
                Console.WriteLine("EvenMax="+"No");
            }
            else
            {
                Console.WriteLine("OddSum="+$"{sumOdd:F2},");
                Console.WriteLine("OddMin="+$"{minOdd:F2},");
                Console.WriteLine("OddMax="+$"{maxOdd:F2},");
                Console.WriteLine("EvenSum="+$"{sumEven:F2},");
                Console.WriteLine("EvenMin="+$"{minEven:F2},");
                Console.WriteLine("EvenMax="+$"{maxEven:F2}");
            }
        }
    }
}
