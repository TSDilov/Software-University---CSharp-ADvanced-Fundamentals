namespace SumOfCoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var coins = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());

            Dictionary<int, int> neededCoins = ChooseCoins(coins, sum);

            Console.WriteLine($"Number of coins to take: {neededCoins.Values.Sum()}");
            foreach (var coin in neededCoins.OrderByDescending(c => c.Key))
            {
                Console.WriteLine($"{coin.Value} coin(s) with value {coin.Key}");
            }
        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            coins = coins.OrderBy(c => c).ToList();
            Dictionary<int, int> coinsCount = new Dictionary<int, int>();
            int index = coins.Count - 1;

            while (index > - 1)
            {
                int currentCoin = coins[index];
                int neededCoins = targetSum / currentCoin;
                if (neededCoins < 1)
                {
                    index--;
                    continue;
                }
                coinsCount.Add(currentCoin, neededCoins);

                targetSum -= currentCoin * neededCoins;
                if (targetSum == 0)
                {
                    break;
                }
            }
            if (targetSum > 0)
            {
                throw new InvalidOperationException();
            }
            return coinsCount;
        }
    }
}