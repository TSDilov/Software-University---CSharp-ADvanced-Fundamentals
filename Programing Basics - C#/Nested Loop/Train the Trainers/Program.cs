using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int judges = int.Parse(Console.ReadLine());
            string finish = Console.ReadLine();
            double allMarksForPresentation = 0;
            double allMarks = 0;
            int countMarks = 0;
            while (finish != "Finish")
            {
                double mark;
                for (int i = 1; i <= judges; i++)
                {
                    mark = double.Parse(Console.ReadLine());
                    allMarksForPresentation +=mark;
                    allMarks += mark;
                    countMarks++;   
                }
                Console.WriteLine($"{finish} - {allMarksForPresentation / judges:F2}.");
                finish = Console.ReadLine();
                allMarksForPresentation = 0;
            }
            Console.WriteLine($"Student's final assessment is {allMarks / countMarks :F2}.");
        }
    }
}
