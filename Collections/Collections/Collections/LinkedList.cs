using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class LinkedList
    {
        // Items are scattered across the memory space, one points to another SinglyLinkedList or items has references to next and previous items
        // FASTER than List (Array) when we insert, add or remove items frequently
        // SLOWER than List (Array) when we need to access items from the List, because we need to iterate through the list from the beginning
        // LinkedList is in C# DoublyLinkedList

        // Linked list doesn't contain our objects directly, it is created thanks to nodes LinkedListNode
        // and these nodes has field Value which contains our object


        /// Methods

        /*
            AddAfter()      - Přidá nový prvek za daný prvek.
            AddBefore()     - Přidá nový prvek před daný prvek.
            AddFirst()      - Přidá nový prvek na začátek seznamu.
            AddLast()       - Přidá nový prvek na konec seznamu.
            First           - Vlastnost vracející první prvek.
            Last            - Vlastnost vracející poslední prvek.
            RemoveFirst()   - Odstraní první prvek.
            RemoveLast()    - Odstraní poslední prvek.
         */
    }
}
