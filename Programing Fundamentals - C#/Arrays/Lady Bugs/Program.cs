using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladyBugsPlaces = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] playingField = new int[fieldSize];
            playingField = PlayingField(playingField, ladyBugsPlaces);


            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputArray = input.Split();

                int indexOfLadyBug = int.Parse(inputArray[0]);
                int moves = int.Parse(inputArray[2]);

                if (indexOfLadyBug < 0 || indexOfLadyBug >= fieldSize || playingField[indexOfLadyBug] == 0)
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (moves < 0 && inputArray[1] == "left")
                {
                    inputArray[1] = "right";
                }
                else if (moves < 0 && inputArray[1] == "right")
                {
                    inputArray[1] = "left";
                }
                moves = Math.Abs(moves);
                switch (inputArray[1])
                {
                    case "left":
                        if (moves > 0)
                        {
                            playingField[indexOfLadyBug] = 0;
                            if (indexOfLadyBug - moves < 0)
                            {
                                break;
                            }
                            if (playingField[indexOfLadyBug - moves] == 1)
                            {
                                if (indexOfLadyBug - moves * 2 < 0)
                                {
                                    break;  
                                }
                                else
                                {
                                    playingField[indexOfLadyBug - moves * 2] = 1;
                                    break;
                                }
                            }
                            playingField[indexOfLadyBug - moves] = 1;
                        }
                        break;
                    case "right":
                        if (moves > 0)
                        {
                            playingField[indexOfLadyBug] = 0;
                            if (indexOfLadyBug + moves >= playingField.Length)
                            {
                                break;
                            }
                            if (playingField[indexOfLadyBug + moves] == 1)
                            {
                                if (indexOfLadyBug + moves * 2 >= playingField.Length)
                                {
                                    break;
                                }
                                else
                                {
                                    playingField[indexOfLadyBug + moves * 2] = 1;
                                    break;
                                }
                            }
                            playingField[indexOfLadyBug + moves] = 1;
                        }
                        break;
                }

                input = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ", playingField));
        }

        static int[] PlayingField(int[] playingField, int[] ladyBugsPlaces)
        {
            for (int i = 0; i < playingField.Length; i++)
            {
                for (int j = 0; j < ladyBugsPlaces.Length; j++)
                {
                    if (i == ladyBugsPlaces[j])
                    {
                        playingField[i] = 1;
                    }
                }
            }
            return playingField;
        }
    }
}
