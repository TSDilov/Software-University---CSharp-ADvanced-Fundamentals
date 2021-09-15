using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badMarks = int.Parse(Console.ReadLine());
            int countBadMarks = 0;
            int countMarks = 0;
            double marksSum = 0.0;
            string lastTask = "";
            bool failed = true;
            while (countBadMarks < badMarks)
            {
                string task = Console.ReadLine();
                if (task == "Enough")
                {
                    failed = false;
                    break;
                }
                int mark = int.Parse(Console.ReadLine());
                if (mark <= 4)
                {
                    countBadMarks++;
                }
                marksSum += mark;
                countMarks++;
                lastTask = task;              
            }
            if (failed)
            {
                Console.WriteLine($"You need a break, {badMarks} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {marksSum / countMarks:F2}");
                Console.WriteLine($"Number of problems: {countMarks}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
        }
    }
}
