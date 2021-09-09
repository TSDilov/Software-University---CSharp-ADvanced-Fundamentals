using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string metricin = Console.ReadLine();
            string metricout = Console.ReadLine();
            double fromMMtoCM = num / 10;
            double fromMMtoM = num / 1000;
            double fromCMtoMM = num * 10;
            double fromCmtoM = num / 100;
            double fromMtoMM = num * 1000;
            double fromMtoCM = num * 100;
            if (metricin == "mm" & metricout == "cm")
            {
                Console.WriteLine($"{fromMMtoCM:F3}");
            }
            else if (metricin == "mm" & metricout == "m")
            {
                Console.WriteLine($"{fromMMtoM:F3}");
            }
            else if (metricin == "cm" & metricout == "mm")
            {
                Console.WriteLine($"{fromCMtoMM:F3}");
            }
            else if (metricin == "cm" & metricout == "m")
            {
                Console.WriteLine($"{fromCmtoM:F3}");
            }
            else if (metricin == "m" & metricout == "mm")
            {
                Console.WriteLine($"{fromMtoMM:F3}");
            }
            else
            {
                Console.WriteLine($"{fromMtoCM:F3}");
            }
        }
    }
}
