using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double sabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            double sabreMore = Math.Ceiling(students * 0.1);
            int beltFree = students / 6;
            double costs = (students + sabreMore) * sabrePrice + students * robePrice + (students - beltFree) * beltPrice;
            if (money >= costs)
            {
                Console.WriteLine($"The money is enough - it would cost {costs:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(costs - money):F2}lv more.");
            }
        }
    }
}
