using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string guessCode = Console.ReadLine();
            HashSet<string> vip = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();
            while (guessCode != "PARTY")
            {
                if (char.IsDigit(guessCode[0]))
                {
                    vip.Add(guessCode);
                }
                else
                {
                    regular.Add(guessCode);
                }
                guessCode = Console.ReadLine();
            }
            string guessWhoActuallyArreve = Console.ReadLine();
            while (guessWhoActuallyArreve != "END")
            {
                if (char.IsDigit(guessWhoActuallyArreve[0]))
                {
                    vip.Remove(guessWhoActuallyArreve);
                }
                else
                {
                    regular.Remove(guessWhoActuallyArreve);
                }
                guessWhoActuallyArreve = Console.ReadLine();
            }
            Console.WriteLine(vip.Count + regular.Count);
            foreach (var v in vip)
            {
                Console.WriteLine(v);
            }
            foreach (var r in regular)
            {
                Console.WriteLine(r);
            }
        }
    }
}
