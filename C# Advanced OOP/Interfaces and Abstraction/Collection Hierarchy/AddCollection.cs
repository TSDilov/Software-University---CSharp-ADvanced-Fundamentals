using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class AddCollection : IAdd
    {
        private List<string> elements;

        public AddCollection()
        {
            this.elements = new List<string>();
        }

        public int Add(string element)
        {
            elements.Add(element);
            return elements.Count - 1;
        }
    }
}
