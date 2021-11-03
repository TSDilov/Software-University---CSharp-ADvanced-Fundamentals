using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StackWithIterator
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> stack;
        public Stack(params T[] data)
        {
            stack = new List<T>(data);
        }
        public void Push(params T[] elements)
        {
            foreach (var element in elements)
            {
                stack.Add(element);
            }
        }
        public T Pop()
        {
            if (stack.Count == 0)
            {
                throw new ArgumentException(message:"No elements");
            }
            var lastIndex = stack.Count - 1;
            var last = stack[lastIndex];
            stack.RemoveAt(lastIndex);
            return last;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                yield return stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
