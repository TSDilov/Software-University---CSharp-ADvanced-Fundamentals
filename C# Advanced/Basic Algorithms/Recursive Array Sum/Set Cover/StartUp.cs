namespace SetCover
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            List<int> universe = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            int numberOFSubSets = int.Parse(Console.ReadLine());
            List<int[]> sets = new List<int[]>();
            for (int i = 0; i < numberOFSubSets; i++)
            {
                int[] currentSubSet = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                sets.Add(currentSubSet);
            }
            var resultSets = ChooseSets(sets, universe);
            Console.WriteLine($"Sets to take ({resultSets.Count}):");
            foreach (var set in resultSets)
            {
                Console.WriteLine($"{{ {string.Join(", ", set)} }}");
            }
        }

        public static List<int[]> ChooseSets(IList<int[]> sets, IList<int> universe)
        {
            List<int[]> result = new List<int[]>();
            while (sets.Count > 0 && universe.Count > 0)
            {
                int[] largestSubSet = sets.OrderByDescending(s => s.Count(el => universe.Contains(el))).FirstOrDefault();

                foreach (var element in largestSubSet)
                {
                    universe.Remove(element);
                }

                result.Add(largestSubSet);
                sets.Remove(largestSubSet);
            }
            return result;
        }
    }
}
