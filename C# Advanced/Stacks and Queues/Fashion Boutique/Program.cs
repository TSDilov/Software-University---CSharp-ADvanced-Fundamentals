using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int capacityOfRack = int.Parse(Console.ReadLine());
            int currentClothesOnRack = 0;
            int rackCounter = 1;
            int count = clothes.Count;
            for (int i = 0; i < count; i++)
            {
                if (currentClothesOnRack + clothes.Peek() > capacityOfRack)
                {
                    currentClothesOnRack = 0;
                    rackCounter++;
                }
                currentClothesOnRack += clothes.Pop();
            }
            Console.WriteLine(rackCounter);
        }
    }
}
