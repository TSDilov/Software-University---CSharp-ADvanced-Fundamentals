using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Core
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;
        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }
        public void Run()
        {
            while (true)
            {
                try
                {
                    var input = Console.ReadLine();
                    var result = this.commandInterpreter.Read(input);
                    if (result == null)
                    {
                        break;
                    }
                    Console.WriteLine(result);
                }
                catch (InvalidOperationException opEx)
                {
                    Console.WriteLine(opEx.Message);
                };
            }
        }
    }
}
