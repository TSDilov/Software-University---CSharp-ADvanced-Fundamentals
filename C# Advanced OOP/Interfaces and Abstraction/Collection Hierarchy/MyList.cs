using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class MyList : IAdd, IRemove
    {
        private List<string> elements;

        public MyList()
        {
            this.elements = new List<string>();
        }
        public int Used => this.elements.Count;

        public int Add(string element)
        {
            elements.Insert(0, element);
            return 0;
        }

        public string Remove()
        {
            var element = elements[0];
            elements.RemoveAt(0);
            return element;
        }
    }
}
