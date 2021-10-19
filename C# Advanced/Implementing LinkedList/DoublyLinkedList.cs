using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementingLinkedList
{
    public class DoublyLinkedList<T>
    {
        private LinkedListItem<T> first = null;
        private LinkedListItem<T> last = null;
        public int Count
        {
            get
            {
                int count = 0;

                LinkedListItem<T> current = first;
                while (current != null)
                {
                    count++;
                    current = current.Next;
                }

                return count;
            }
        }
        public void AddFirst(T element)
        {
            LinkedListItem<T> newItem = new LinkedListItem<T>(element);
            if (first == null)
            {
                first = newItem;
                last = newItem;
            }
            else
            {
                newItem.Next = first;
                first.Previous = newItem;
                first = newItem;
            }
        }
        public void DeleteByValue(T value)
        {
            var current = first;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    if (current == first)
                    {
                        RemoveFirst();
                        break;
                    }
                    if (current == last)
                    {
                        RemoveLast();
                        break;
                    }
                        current.Next.Previous = current.Previous;
                        current.Previous.Next = current.Next;
                        break;
                }

                current = current.Next;
            }
        }
        public void AddLast(T element)
        {
            LinkedListItem<T> newItem = new LinkedListItem<T>(element);
            if (last == null)
            {
                first = newItem;
                last = newItem;
            }
            else
            {
                last.Next = newItem;
                newItem.Previous = last;
                last = newItem;
            }
        }
        public T RemoveFirst()
        {
            if (first == null) 
            {
                throw new InvalidOperationException("Linked list empty!");
            }

            T currentFirstValue = first.Value;
            if (first == last) 
            {
                first = null;
                last = null;
            }
            else 
            {
                LinkedListItem<T> newFirst = first.Next;
                newFirst.Previous = null;
                first = newFirst;
            }

            return currentFirstValue;
        }
        public T RemoveLast()
        {
            if (last == null)
            {
                throw new InvalidOperationException("Linked list empty!");
            }

            T currentLastValue = last.Value;
            if (first == last)
            {
                first = null;
                last = null;
            }
            else
            {
                LinkedListItem<T> newLast = last.Previous;
                newLast.Next = null;
                last = newLast;
            }

            return currentLastValue;
        }
        public void ForEach(Action<T> action)
        {
            LinkedListItem<T> current = first;
            while (current != null)
            {
                action(current.Value);
                current = current.Next;
            }
        }
        public T[] ToArray()
        {
            T[] array = new T[Count];

            LinkedListItem<T> current = first;
            int index = 0;
            while (current != null)
            {
                array[index] = current.Value;
                index++;
                current = current.Next;
            }

            return array;
        }
    }
}
