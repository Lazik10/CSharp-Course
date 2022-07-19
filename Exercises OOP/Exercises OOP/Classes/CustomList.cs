using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Classes
{
    internal class CustomList
    {
        private object[] list = new object[10];

        public int Count { get; private set; }

        public object this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }

        public CustomList()
        {

        }

        public void Add(object item)
        {
            if (Count == list.Length)
                Expand();

            list[Count] = item;
            Count++;
        }

        private void Expand()
        {
            object[] expandedlist = new object[list.Length * 2];
            list.CopyTo(expandedlist, 0);
            list = expandedlist;
        }
    }
}
