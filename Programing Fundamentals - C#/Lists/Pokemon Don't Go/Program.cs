using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;

            while (integers.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    int removePokemon = integers[0];
                    sum += removePokemon;
                    integers[0] = integers[integers.Count - 1];
                    for (int i = 0; i < integers.Count; i++)
                    {
                        if (integers[i] <= removePokemon)
                        {
                            integers[i] += removePokemon;
                        }
                        else
                        {
                            integers[i] -= removePokemon;
                        }
                    }
                }
                else if (index > integers.Count - 1)
                {
                    int removePokemon = integers[integers.Count - 1];
                    sum += removePokemon;
                    integers[integers.Count - 1] = integers[0];
                    for (int i = 0; i < integers.Count; i++)
                    {
                        if (integers[i] <= removePokemon)
                        {
                            integers[i] += removePokemon;
                        }
                        else
                        {
                            integers[i] -= removePokemon;
                        }
                    }
                }
                else
                {
                    sum += integers[index];
                    int removePokemon = integers[index];
                    integers.RemoveAt(index);

                    for (int i = 0; i < integers.Count; i++)
                    {
                        if (integers[i] <= removePokemon)
                        {
                            integers[i] += removePokemon;
                        }
                        else
                        {
                            integers[i] -= removePokemon;
                        }
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
