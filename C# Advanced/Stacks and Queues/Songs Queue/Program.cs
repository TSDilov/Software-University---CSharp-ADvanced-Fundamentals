using System;
using System.Collections.Generic;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstSongs = Console.ReadLine().Split(", ");
            Queue<string> songs = new Queue<string>();
            for (int i = 0; i < firstSongs.Length; i++)
            {
                songs.Enqueue(firstSongs[i]);
            }
            string command = Console.ReadLine();
            while (songs.Count > 0)
            {
                int indexSeparator = command.IndexOf(' ');
                switch (indexSeparator == -1 ? command : command.Substring(0,indexSeparator))
                {
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Add":
                        string songToAdd = command.Substring(indexSeparator + 1);
                        if (!songs.Contains(songToAdd))
                        {
                            songs.Enqueue(songToAdd);
                        }
                        else
                        {
                            Console.WriteLine($"{songToAdd} is already contained!");
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songs));
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
