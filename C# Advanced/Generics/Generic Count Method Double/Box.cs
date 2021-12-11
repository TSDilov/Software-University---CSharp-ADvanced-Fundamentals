using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodDouble
{
    public class Box<T>
        where T : IComparable
    {
        private List<T> items;
        public Box()
        {
            items = new List<T>();
        }
        public void Add(T item)
        {
            items.Add(item);
        }
        public int GreaterCount(T item)
        {
            int count = 0;
            foreach (var element in items)
            {
                if (element.CompareTo(item) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
