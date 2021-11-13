using System;

namespace CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            string distance = Console.ReadLine();
            int countOfWonBattles = 0;
            bool dead = false;
            while (distance != "End of battle")
            {
                if (initialEnergy < int.Parse(distance))
                {
                    Console.WriteLine($"Not enough energy! Game ends with {countOfWonBattles} won battles and {initialEnergy} energy");
                    dead = true;
                    break;
                }
                initialEnergy -= int.Parse(distance);
                countOfWonBattles++;
                if (countOfWonBattles % 3 == 0)
                {
                    initialEnergy += countOfWonBattles;
                }
              
                distance = Console.ReadLine();
            }
            if (!dead)
            {
                Console.WriteLine($"Won battles: {countOfWonBattles}. Energy left: {initialEnergy}");
            }
      
        }
    }
}
