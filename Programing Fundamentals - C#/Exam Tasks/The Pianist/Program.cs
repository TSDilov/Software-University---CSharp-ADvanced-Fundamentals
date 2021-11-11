using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> pieceComposers = new Dictionary<string, string>();
            Dictionary<string, string> pieceKeys = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] pieces = Console.ReadLine().Split("|");
                pieceComposers.Add(pieces[0], pieces[1]);
                pieceKeys.Add(pieces[0], pieces[2]);
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] currentCommand = command.Split("|");
                switch (currentCommand[0])
                {
                    case "Add":
                        if (pieceComposers.ContainsKey(currentCommand[1]))
                        {
                            Console.WriteLine($"{currentCommand[1]} is already in the collection!");
                        }
                        else
                        {
                            pieceComposers.Add(currentCommand[1], currentCommand[2]);
                            pieceKeys.Add(currentCommand[1], currentCommand[3]);
                            Console.WriteLine($"{currentCommand[1]} by {currentCommand[2]} in {currentCommand[3]} added to the collection!");
                        }
                        break;
                    case "Remove":
                        if (pieceComposers.ContainsKey(currentCommand[1]))
                        {
                            pieceComposers.Remove(currentCommand[1]);
                            pieceKeys.Remove(currentCommand[1]);
                            Console.WriteLine($"Successfully removed {currentCommand[1]}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {currentCommand[1]} does not exist in the collection.");
                        }
                        break;
                    case "ChangeKey":
                        if (pieceKeys.ContainsKey(currentCommand[1]))
                        {
                            pieceKeys[currentCommand[1]] = currentCommand[2];
                            Console.WriteLine($"Changed the key of {currentCommand[1]} to {currentCommand[2]}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {currentCommand[1]} does not exist in the collection.");
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            foreach (var piece in pieceComposers.OrderBy(n => n.Key).ThenBy(n => n.Value))
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value}, Key: {pieceKeys[piece.Key]}");
            }
        }
    }
}
