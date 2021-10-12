using System;
using System.Linq;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[] array = new long[n];
            long[] newArray = new long[n];
            long[] print = null;

            array[0] = 1;
            newArray[0] = 1;
            Console.WriteLine(1);

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    newArray[j] = array[j] + array[j - 1];
                }
                array = newArray.ToArray();
                print = new long[array.Length - array.Count(x => x == int.Parse("0"))];
                for (int l = 0; l < print.Length; l++)
                {
                    print[l] = array[l];
                }
                Console.WriteLine(string.Join(" ",print));
            }
        }
    }
}
