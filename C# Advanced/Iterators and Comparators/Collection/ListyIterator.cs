using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private  List<T> list;
        private int currentIndex;

        public ListyIterator(params T[] data)
        {
            this.list = new List<T>(data);
            currentIndex = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in list)
            {
                yield return item;
            }
        }

        public bool HasNext()
        {
            return currentIndex < list.Count - 1;
        }
        public bool Move()
        {
            bool canMove = HasNext();
            if (canMove)
            {
                currentIndex++;
            }
            return canMove;
        }
        public void Print()
        {
            if (list.Count == 0)
            {
                throw new ArgumentException(message:"Invalid Operation!");
            }
            Console.WriteLine(list[currentIndex]);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
