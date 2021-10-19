using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ImplementingList
{
    public class CustomList<T> : IEnumerable<T>
    {
        private const int CapacityInBeginning = 2;
        private T[] elements;
        public CustomList()
        {
            elements = new T[CapacityInBeginning];
        }
        public int Count { get; private set; }
        public T this[int index]
        {
            get
            {
                if (index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return elements[index];
            }
            set
            {
                if (index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                elements[index] = value;
            }
        }

        public void Add(T element)
        {
            if (Count == elements.Length)
            {
                T[] tempArray = new T[elements.Length * 2];
                for (int i = 0; i < elements.Length; i++)
                {
                    tempArray[i] = elements[i];
                }
                elements = tempArray;
            }
            elements[Count] = element;
            Count++;
        }

        public T RemoveAt(int index)
        {
            if (index >= Count)
            {
                throw new IndexOutOfRangeException();
            }
            T element = elements[index];
            elements[index] = default(T);
            Shift(index);
            Count--;
            if (Count <= elements.Length / 4)
            {
                Shrink();
            }

            return element;
        }
        public bool Contains(T element) 
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }
        public void Swap(int firstIndex, int secondIndex)
        {
            if (firstIndex < 0 || firstIndex >= Count || secondIndex < 0 || secondIndex >= Count)
            {
                throw new IndexOutOfRangeException();
            }
            T mover = elements[firstIndex];
            elements[firstIndex] = elements[secondIndex];
            elements[secondIndex] = mover;
        }
        public void Insert(int index, T element)
        {
            if (index > Count)
            {
                throw new IndexOutOfRangeException();
            }
            if (Count == elements.Length)
            {
                T[] tempArray = new T[elements.Length * 2];
                for (int i = 0; i < elements.Length; i++)
                {
                    tempArray[i] = elements[i];
                }
                elements = tempArray;
            }
            ShiftRight(index);
            Count++;
            elements[index] = element;
        }
        public bool Find(T element) 
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }
        public void ShiftRight(int index)
        {
            for (int i = Count; i > index; i--)
            {
                elements[i] = elements[i - 1];
            }
        }
        public void Shift(int index)
        {
            for (int i = index; i < this.Count; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
        }
        private void Shrink()
        {
            T[] tempArray = new T[elements.Length / 2];
            for (int i = 0; i < elements.Length; i++)
            {
                tempArray[i] = elements[i];
            }
            elements = tempArray;
        }

        public void Print()
        {
            Console.WriteLine(string.Join(" ", elements));
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < elements.Length; i++)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
