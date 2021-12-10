using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodString
{
    public class Box<T>
        where T : IComparable
    {
        public T Value { get; set; }
        private List<T> items;
        public Box()
        {
            items = new List<T>();
        }
        public void Add(T item)
        {
            items.Add(item);
        }
        public int FilterCount(T item)
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
