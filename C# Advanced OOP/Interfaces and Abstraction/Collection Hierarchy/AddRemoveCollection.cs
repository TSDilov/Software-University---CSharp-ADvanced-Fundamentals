using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class AddRemoveCollection : IAdd, IRemove
    {
        private List<string> elements;

        public AddRemoveCollection()
        {
            this.elements = new List<string>();
        }

        public int Add(string element)
        {
            elements.Insert(0, element);
            return 0;
        }

        public string Remove()
        {
            var element = elements[elements.Count - 1];
            elements.RemoveAt(elements.Count - 1);
            return element;
        }
    }
}
