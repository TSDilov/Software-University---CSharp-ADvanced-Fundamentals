using System;
using System.Linq;

namespace CondenseArraytoNumber_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            int n = nums.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int[] condenced = new int[nums.Length - 1];
                for (int j = 0; j < condenced.Length; j++)
                {
                    condenced[j] = nums[j] + nums[j + 1];
                }
                nums = condenced;
            }
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
