using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            var threads = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            var taskForKill = int.Parse(Console.ReadLine());

            while (true)
            {
                if (tasks.Peek() == taskForKill)
                {
                    Console.WriteLine($"Thread with value {threads.Peek()} killed task {taskForKill}");
                    Console.WriteLine(string.Join(" ", threads));
                    break;
                }

                var currentTask = tasks.Peek();
                var currentThread = threads.Peek();
                if (currentThread >= currentTask)
                {
                    tasks.Pop();
                    threads.Dequeue();
                }
                else
                {
                    threads.Dequeue();
                }
            }
        }
    }
}

