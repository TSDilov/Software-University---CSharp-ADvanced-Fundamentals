using System;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int[]> reverse = i =>
            {
                for (int j = 0; j < i.Length / 2; j++)
                {
                    int temp = i[j];
                    i[j] = i[i.Length - 1 - j];
                    i[i.Length - 1 - j] = temp;
                }
            };
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numberToDevide = int.Parse(Console.ReadLine());
            Predicate<int> filter = num => num % numberToDevide != 0;
            reverse(numbers);
            Console.WriteLine(string.Join(" ", numbers.ToList().FindAll(filter)));
        }
    }
}
