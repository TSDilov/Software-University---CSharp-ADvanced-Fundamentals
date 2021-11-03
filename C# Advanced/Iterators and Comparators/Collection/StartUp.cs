using System;
using System.Linq;

namespace ListyIterator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            ListyIterator<string> myColection = new ListyIterator<string>();
            while (command != "END")
            {
                string[] currentCommand = command.Split();
                string exactCommand = currentCommand[0];
                if (exactCommand == "Create")
                {
                    myColection = new ListyIterator<string>(currentCommand.Skip(1).ToArray());
                }
                else if (exactCommand == "Move")
                {
                    Console.WriteLine(myColection.Move());
                }
                else if (exactCommand == "HasNext")
                {
                    Console.WriteLine(myColection.HasNext());
                }
                else if (exactCommand == "Print")
                {
                    myColection.Print();
                }
                else if (exactCommand == "PrintAll")
                {
                    foreach (var item in myColection)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
                command = Console.ReadLine();
            }
        }
    }
}
