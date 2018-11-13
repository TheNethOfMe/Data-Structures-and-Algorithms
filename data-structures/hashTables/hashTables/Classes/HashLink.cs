using System;
using System.Collections.Generic;
using System.Text;

namespace hashTables.Classes
{
    public class HashLink
    {
        // A linked list which will get placed in each one of the indicies of the HashTable to handle collisions
        /// <summary>
        /// The Head (first node) of the linked list where traversal will start
        /// </summary>
        public HashNode Head { get; set; }
        /// <summary>
        /// The Current node in the traversal
        /// </summary>
        public HashNode Current { get; set; }

        /// <summary>
        /// A method to pass a new node into the list. This gets called from the HashTable Add method.
        /// </summary>
        /// <param name="node">The node to be added</param>
        public void AddNode(HashNode node)
        {
            if (Head != null)
            {
                node.Next = Head;
            }
            Head = node;
            Current = Head;
        }
    }
}
