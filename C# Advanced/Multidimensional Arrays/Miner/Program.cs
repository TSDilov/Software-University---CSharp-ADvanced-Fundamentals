using System;
using System.Linq;


namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            long fieldSize = int.Parse(Console.ReadLine());
            string[] directions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            char[,] field = new char[fieldSize, fieldSize];
            int minerRow = 0;
            int minerCol = 0;
            int coalCounter = 0;
            for (int row = 0; row < fieldSize; row++)
            {
                string[] charLines = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < fieldSize; col++)
                {
                    field[row, col] = char.Parse(charLines[col]);
                }
            }


            for (int row = 0; row < fieldSize; row++)
            {
                for (int col = 0; col < fieldSize; col++)
                {
                    if (field[row, col] == 's')
                    {
                        minerRow = row;
                        minerCol = col;
                    }
                }
            }

            foreach (var direction in directions)
            {
                switch (direction)
                {
                    case "up":
                        minerRow -= 1;
                        if (minerRow < 0)
                        {
                            minerRow += 1;
                        }
                        break;
                    case "down":
                        minerRow += 1;
                        if (minerRow >= field.GetLength(0))
                        {
                            minerRow -= 1;
                        }
                        break;
                    case "left":
                        minerCol -= 1;
                        if (minerCol < 0)
                        {
                            minerCol += 1;
                        }
                        break;
                    case "right":
                        minerCol += 1;
                        if (minerCol >= field.GetLength(1))
                        {
                            minerCol -= 1;
                        }
                        break;
                }
                if (field[minerRow, minerCol] == 'c')
                {
                    coalCounter++;
                    field[minerRow, minerCol] = '*';
                    var query = from char element in field where element == 'c' select element;
                    if (!query.Any())
                    {
                        Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                        return;
                    }
                }
                else if (field[minerRow, minerCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                    return;
                }
            }

            var coals = from char element in field where element == 'c' select element;
            Console.WriteLine($"{coals.Count()} coals left. ({minerRow}, {minerCol})");
        }
    }
}
