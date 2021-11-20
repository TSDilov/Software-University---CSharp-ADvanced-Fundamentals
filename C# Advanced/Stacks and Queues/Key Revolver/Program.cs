using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int sizeOfBarrel = int.Parse(Console.ReadLine());
            int[] bulletsSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locksSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int valueOfIntelligence = int.Parse(Console.ReadLine());
            int bulletsCount = 0;
            int bulletsForBarel = 0;
            Stack<int> bullets = new Stack<int>();
            Queue<int> locks = new Queue<int>();
            for (int i = 0; i < bulletsSize.Length; i++)
            {
                bullets.Push(bulletsSize[i]);
            }
            for (int i = 0; i < locksSize.Length; i++)
            {
                locks.Enqueue(locksSize[i]);
            }
            while (bullets.Count > 0 && locks.Count > 0)
            {
                int currentBullet = bullets.Pop();
                bulletsCount++;
                bulletsForBarel++;
                if (currentBullet <= locks.Peek())
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                if (bulletsForBarel == sizeOfBarrel && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    bulletsForBarel = 0;
                }
            }
            if (bullets.Count >= locks.Count)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${valueOfIntelligence - (priceOfBullet * bulletsCount)}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
