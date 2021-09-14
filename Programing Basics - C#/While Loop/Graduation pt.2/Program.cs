using System;

namespace Graduationpt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grades = 1;
            double sum = 0;
            int fail = 0;
            bool excluded = false;
            while (grades <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4.00)
                {
                    if (fail > 0)
                    {
                        Console.WriteLine($"{name} has been excluded at {--grades} grade");
                        excluded = true;
                        break;
                    }
                    fail++;
                }
                sum += grade;
                grades++;
            }
            if (!excluded)
            {
                double average = sum / 12;
                Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
            }
        }
    }
}
