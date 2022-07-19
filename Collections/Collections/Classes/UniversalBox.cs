using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Classes
{
    internal class UniversalBox<T> where T : IItem
    {
        public T Item { get; set; }

        public UniversalBox(T item)
        {
            Item = item;
        }
    }

    internal interface IItem
    {
        string Name { get; }
    }

    internal class Book : IItem
    {
        public string Name { get; private set; }

        public Book(string name)
        {
            Name = name;
        }
    }

    internal class Shoe : IItem
    {
        public string Name { get; private set; }
        public float Size { get; private set; }

        public Shoe(string name, float size)
        {
            Name = name;
            Size = size;
        }
    }

    internal class Bottle : IItem
    {
        public string Name { get; private set; }
        public float Volume { get; private set; }

        public Bottle(string name, float volume)
        {
            Name = name;
            Volume = volume;
        }
    }
}

