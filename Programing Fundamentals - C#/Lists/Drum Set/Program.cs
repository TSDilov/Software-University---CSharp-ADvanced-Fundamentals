using System;
using System.Collections.Generic;
using System.Linq;

namespace DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> drums = drumSet.ToList();
            string command = Console.ReadLine();

            while (command != "Hit it again, Gabsy!")
            {
                int power = int.Parse(command);
                for (int i = 0; i < drumSet.Count; i++)
                {
                    drums[i] -= power;
                    if (drums[i] <= 0)
                    {
                        if (savings >= drumSet[i] * 3)
                        {
                            drums[i] = drumSet[i];
                            savings -= drumSet[i] * 3;
                        }
                        else
                        {
                            drums.RemoveAt(i);
                            drumSet.RemoveAt(i);
                            i--;
                        }
                    }
                }
                command = Console.ReadLine();               
            }
            Console.WriteLine(string.Join(" ",drums));
            Console.WriteLine($"Gabsy has {savings:F2}lv.");
        }
    }
}
