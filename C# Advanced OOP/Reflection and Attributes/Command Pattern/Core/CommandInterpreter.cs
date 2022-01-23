using CommandPattern.Core.Commands;
using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            var input = args.Split();
            var commandName = input[0] + "Command";
            var arguments = input.Skip(1).ToArray();
            
            var type = Assembly.GetCallingAssembly()
                .GetTypes()
                .Where(t => t.Name == commandName)
                .FirstOrDefault();
            if (type == null)
            {
                throw new InvalidOperationException("Invalid command");
            }

            ICommand command = (ICommand)Activator.CreateInstance(type);
            var result = command.Execute(arguments);
            return result;
        }
    }
}
