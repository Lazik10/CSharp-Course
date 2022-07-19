using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Collection
    {
        private List<int> _items = new List<int> {1,2,3,4,5};

        // Indexer
        public int this[int i]
        {
            get { return _items[i]; }
            set { _items[i] = value; }
        }

        public override bool Equals(object? obj)
        {
            return obj is Collection && this == (Collection)obj;
        }

        public static bool operator ==(Collection collection1, Collection collection2)
        {
            if (collection1._items.Count == collection2._items.Count)
            {
                bool answer = true;
                for(int i = 0; i < collection1._items.Count; i++)
                {
                    if (collection1._items[i] != collection2._items[i])
                        answer = false;
                }
                return answer;
            }
            return false;
        }

        public static bool operator !=(Collection collection1, Collection collection2)
        {
            return !(collection1 == collection2);
        }

        public override int GetHashCode()
        {
            return _items.GetHashCode();
        }
    }
}
