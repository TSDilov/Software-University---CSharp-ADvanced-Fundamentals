using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> elements = new Stack<string>(Console.ReadLine().Split().Reverse());
            while (elements.Count > 1)
            {
                int firstForCalculate = int.Parse(elements.Pop());
                string calculator = elements.Pop();
                int secondForCalculate = int.Parse(elements.Pop());
                elements.Push(calculator == "+" ? (firstForCalculate + secondForCalculate).ToString() : 
                    (firstForCalculate - secondForCalculate).ToString());
            }
            Console.WriteLine(elements.Pop());
        }
    }
}
