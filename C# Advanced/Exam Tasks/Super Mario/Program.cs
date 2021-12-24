using System;

namespace SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            char[][] maze = new char[rows][];
            var marioRow = 0;
            var marioCol = 0;
            for (int row = 0; row < rows; row++)
            {
                var chars = Console.ReadLine().ToCharArray();
                maze[row] = chars;
                for (int col = 0; col < chars.Length; col++)
                {
                    if (chars[col] == 'M')
                    {
                        marioRow = row;
                        marioCol = col;
                    }
                }
            }

            while (lives > 0)
            {
                var command = Console.ReadLine().Split();
                var direction = command[0];
                var bowserRow = int.Parse(command[1]);
                var bowserCol = int.Parse(command[2]);
                maze[bowserRow][bowserCol] = 'B';
                if (direction == "W")
                {
                    lives -= 1;
                    if (marioRow != 0)
                    {
                        maze[marioRow][marioCol] = '-';
                        marioRow -= 1;
                        if (maze[marioRow][marioCol] == 'B')
                        {
                            lives -= 2;
                        }
                        else if (maze[marioRow][marioCol] == 'P')
                        {
                            maze[marioRow][marioCol] = '-';
                            Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
                            break;
                        }
                        maze[marioRow][marioCol] = 'M';
                    }
                }
                else if (direction == "S")
                {
                    lives -= 1;
                    if (marioRow != maze.Length - 1)
                    {
                        maze[marioRow][marioCol] = '-';
                        marioRow += 1;
                        if (maze[marioRow][marioCol] == 'B')
                        {
                            lives -= 2;
                        }
                        else if (maze[marioRow][marioCol] == 'P')
                        {
                            maze[marioRow][marioCol] = '-';
                            Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
                            break;
                        }
                        maze[marioRow][marioCol] = 'M';
                    }
                }
                else if (direction == "A")
                {
                    lives -= 1;
                    if (marioCol != 0)
                    {
                        maze[marioRow][marioCol] = '-';
                        marioCol -= 1;
                        if (maze[marioRow][marioCol] == 'B')
                        {
                            lives -= 2;
                        }
                        else if (maze[marioRow][marioCol] == 'P')
                        {
                            maze[marioRow][marioCol] = '-';
                            Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
                            break;
                        }
                        maze[marioRow][marioCol] = 'M';
                    }
                }
                else if (direction == "D")
                {
                    lives -= 1;
                    if (marioCol != maze[marioRow].Length - 1)
                    {
                        maze[marioRow][marioCol] = '-';
                        marioCol += 1;
                        if (maze[marioRow][marioCol] == 'B')
                        {
                            lives -= 2;
                        }
                        else if (maze[marioRow][marioCol] == 'P')
                        {
                            maze[marioRow][marioCol] = '-';
                            Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
                            break;
                        }
                        maze[marioRow][marioCol] = 'M';
                    }
                }
            }
            if (lives <= 0)
            {
                Console.WriteLine($"Mario died at {marioRow};{marioCol}.");
                maze[marioRow][marioCol] = 'X';
            }
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(new string(maze[i]));
            }
        }
    }
}
