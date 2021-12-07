using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box <T>
    {
        private List<T> myList = new List<T>();

        public void Add(T element)
        {
            myList.Add(element);
        }
        public int Count => myList.Count;
        public T Remove()
        {
            T element = myList[myList.Count - 1];
            myList.RemoveAt(myList.Count - 1);
            return element;
        }
        
    }
}
