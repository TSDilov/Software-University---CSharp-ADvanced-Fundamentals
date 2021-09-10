using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double num = double.Parse(Console.ReadLine());
            switch (fruit)
            {
                case "banana":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            Console.WriteLine($"{num * 2.5:F2}");
                        break;
                        case "Saturday":
                        case "Sunday":
                            Console.WriteLine($"{num*2.7:F2}");
                        break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "apple":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            Console.WriteLine($"{num * 1.2:F2}");
                            break;
                        case "Saturday":
                        case "Sunday":
                            Console.WriteLine($"{num * 1.25:F2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "orange":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            Console.WriteLine($"{num * 0.85:F2}");
                            break;
                        case "Saturday":
                        case "Sunday":
                            Console.WriteLine($"{num * 0.9:F2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "grapefruit":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            Console.WriteLine($"{num * 1.45:F2}");
                            break;
                        case "Saturday":
                        case "Sunday":
                            Console.WriteLine($"{num * 1.6:F2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "kiwi":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            Console.WriteLine($"{num * 2.7:F2}");
                            break;
                        case "Saturday":
                        case "Sunday":
                            Console.WriteLine($"{num * 3.0:F2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "pineapple":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            Console.WriteLine($"{num * 5.5:F2}");
                            break;
                        case "Saturday":
                        case "Sunday":
                            Console.WriteLine($"{num * 5.6:F2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "grapes":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            Console.WriteLine($"{num * 3.85:F2}");
                            break;
                        case "Saturday":
                        case "Sunday":
                            Console.WriteLine($"{num * 4.2:F2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
