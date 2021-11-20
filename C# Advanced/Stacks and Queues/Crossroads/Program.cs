using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightTime = int.Parse(Console.ReadLine());
            int windowTime = int.Parse(Console.ReadLine());
            int count = 0;
            Queue<string> carsOnCrossroad = new Queue<string>();
            string carOrCommand = Console.ReadLine();
            while (carOrCommand != "END")
            {
                int greenLightTimeRemaining = greenLightTime;
                int windowTimeLEft = windowTime;
                
                switch (carOrCommand)
                {
                    case "green":
                        while (greenLightTimeRemaining > 0 && carsOnCrossroad.Any())
                        {
                            string carThatPasses = carsOnCrossroad.Dequeue();
                            greenLightTimeRemaining -= carThatPasses.Length;
                            if (greenLightTimeRemaining >= 0)
                            {
                                count++;
                            }
                            else
                            {
                                windowTimeLEft += greenLightTimeRemaining;
                                if (windowTimeLEft < 0)
                                {
                                    Console.WriteLine("A crash happened!");
                                    Console.WriteLine($"{carThatPasses} was hit at {carThatPasses[carThatPasses.Length + windowTimeLEft]}.");
                                    return;
                                }
                                count++;
                            }
                        }
                        break;
                    default:
                        carsOnCrossroad.Enqueue(carOrCommand);
                        break;
                }
                carOrCommand = Console.ReadLine();
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{count} total cars passed the crossroads.");
        }
    }
}
