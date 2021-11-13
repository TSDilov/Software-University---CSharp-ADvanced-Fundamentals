﻿using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (input[i] == ')')
                {
                    int openBrakeIndex = indexes.Pop();
                    int closeBrakeIndex = i;
                    Console.WriteLine(input.Substring(openBrakeIndex, closeBrakeIndex - openBrakeIndex + 1));
                }
            }
        }
    }
}