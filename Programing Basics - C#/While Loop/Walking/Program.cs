using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {            
            int allSteps = 0;
            string input;
            while (allSteps <= 10000)
            {
                input = Console.ReadLine();
                if (input == "Going home")
                {
                    input = Console.ReadLine();
                    allSteps += int.Parse(input);
                    break;
                }
                allSteps += int.Parse(input);
            }
            int diff = 10000 - allSteps;
            if (diff >0)
            {
                Console.WriteLine($"{diff} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{Math.Abs(diff)} steps over the goal!");
            }
        }
    }
}
