﻿using System;

namespace GenericBoxofString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Box<string> input = new Box<string>(Console.ReadLine());
                Console.WriteLine(input);
            }
        }
    }
}