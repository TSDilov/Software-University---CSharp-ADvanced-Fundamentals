using System;

namespace TheBattleoftheFiveArmies
{
    class Program
    {
        static void Main(string[] args)
        {
            int armyArmor = int.Parse(Console.ReadLine());
            int sizeOfMap = int.Parse(Console.ReadLine());

            char[][] map = new char[sizeOfMap][];

            for (int row = 0; row < sizeOfMap; row++)
            {
                var chars = Console.ReadLine().ToCharArray();
                map[row] = chars;

            }
            var armyRow = 0;
            var armyCol = 0;

            for (int row = 0; row < sizeOfMap; row++)
            {
                for (int col = 0; col < map[row].Length; col++)
                {
                    if (map[row][col] == 'A')
                    {
                        armyRow = row;
                        armyCol = col;
                    }
                }
            }
            while (true)
            {
                var command = Console.ReadLine().Split(' ');
                var direction = command[0];
                var orcRow = int.Parse(command[1]);
                var orcCol = int.Parse(command[2]);

                armyArmor--;
                map[orcRow][orcCol] = 'O';
                map[armyRow][armyCol] = '-';

                if (direction == "up" && armyRow - 1 >= 0)
                {
                    armyRow--;
                }
                else if (direction == "down" && armyRow + 1 < sizeOfMap)
                {
                    armyRow++;
                }
                else if (direction == "left" && armyCol - 1 >= 0)
                {
                    armyCol--;
                }
                else if (direction == "right" && armyCol + 1 < map[armyRow].Length)
                {
                    armyCol ++;
                }
                if (map[armyRow][armyCol] == 'O')
                {
                    armyArmor -= 2;
                }
                if (map[armyRow][armyCol] == 'M')
                {
                    map[armyRow][armyCol] = '-';
                    Console.WriteLine($"The army managed to free the Middle World! Armor left: {armyArmor}");
                    break;
                }
                if (armyArmor <= 0)
                {
                    map[armyRow][armyCol] = 'X';
                    Console.WriteLine($"The army was defeated at {armyRow};{armyCol}.");
                    break;
                }
                map[armyRow][armyCol] = 'A';
            }
            for (int i = 0; i < sizeOfMap; i++)
            {
                Console.WriteLine(new string(map[i]));
            }
        }
    }
}
