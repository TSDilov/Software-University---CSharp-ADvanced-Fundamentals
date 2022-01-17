using System;
using System.Collections.Generic;

namespace CollectionHierarchy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var addCollection = new AddCollection();
            var addRemoveCollection = new AddRemoveCollection();
            var myList = new MyList();
            var inputString = Console.ReadLine().Split();
            var indexesInAddCollection = new List<int>();
            var indexesIntAddRemoveCollection = new List<int>();
            var indexesInMyList = new List<int>();
            foreach (var word in inputString)
            {
                indexesInAddCollection.Add(addCollection.Add(word));
                indexesIntAddRemoveCollection.Add(addRemoveCollection.Add(word));
                indexesInMyList.Add(myList.Add(word));
            }
            var numberOfRemoveOperations = int.Parse(Console.ReadLine());
            var removedFromAddRemoveCollection = new List<string>();
            var removedFromMyList = new List<string>();
            for (int i = 0; i < numberOfRemoveOperations; i++)
            {
                removedFromAddRemoveCollection.Add(addRemoveCollection.Remove());
                removedFromMyList.Add(myList.Remove());
            }

            Console.WriteLine(string.Join(" ", indexesInAddCollection));
            Console.WriteLine(string.Join(" ", indexesIntAddRemoveCollection));
            Console.WriteLine(string.Join(" ", indexesInMyList));
            Console.WriteLine(string.Join(" ", removedFromAddRemoveCollection));
            Console.WriteLine(string.Join(" ", removedFromMyList));
        }
    }
}
