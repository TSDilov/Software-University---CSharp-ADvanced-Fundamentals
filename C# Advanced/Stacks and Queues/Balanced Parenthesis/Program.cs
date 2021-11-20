using System;
using System.Collections.Generic;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string parenthesis = Console.ReadLine();
            Stack<char> balancedOrNot = new Stack<char>();
            bool isBalanced = true;

            foreach (var symbol in parenthesis)
            {

                if (symbol == '{' || symbol == '[' || symbol == '(')
                {
                    balancedOrNot.Push(symbol);
                }
                else
                {
                    if (balancedOrNot.Count == 0)
                    {
                        isBalanced = false;
                        break;
                    }
                    if (symbol == '}' && balancedOrNot.Peek() == '{')
                    {
                        balancedOrNot.Pop();
                    }
                    else if (symbol == ']' && balancedOrNot.Peek() == '[')
                    {
                        balancedOrNot.Pop();
                    }
                    else if (symbol == ')' && balancedOrNot.Peek() == '(')
                    {
                        balancedOrNot.Pop();
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }
            }
            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
