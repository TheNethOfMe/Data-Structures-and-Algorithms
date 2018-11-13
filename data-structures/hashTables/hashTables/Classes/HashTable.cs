using System;
using System.Collections.Generic;
using System.Text;

namespace hashTables.Classes
{
    public class HashTable
    {
        /// <summary>
        /// An array of HashLinks (linked lists) that will make up the HashTable
        /// </summary>
        public HashLink[] Table { get; set; }

        /// <summary>
        /// Instantiates a new HashTable
        /// </summary>
        /// <param name="linkLength">An integer indicating the Length of the Table array</param>
        public HashTable(int linkLength)
        {
            Table = new HashLink[linkLength];
        }

        /// <summary>
        /// Adds a new node to the HashTable by hashing the key and storing a node with the key and value into the linked list
        /// at the index matching the hash. This method calls the AddNode method on the HashLink at that index.
        /// </summary>
        /// <param name="key">The key property the new node will have</param>
        /// <param name="value">The value property the new node will have</param>
        public void Add(string key, string value)
        {
            HashNode node = new HashNode(key, value);
            int index = GetHash(node.Key);
            if (Table[index] == null)
            {
                Table[index] = new HashLink();
                Table[index].AddNode(node);
            }
            else
            {
                Table[index].AddNode(node);
            }
        }

        /// <summary>
        /// Finds and returns the value from the node that has the same key passed into the method
        /// </summary>
        /// <param name="key">The key that the node must match before a value is returned</param>
        /// <returns>The value of the node or null if the key does not exist</returns>
        public string Find(string key)
        {
            string result = null;
            int index = GetHash(key);
            Table[index].Current = Table[index].Head;
            while (Table[index].Current != null && Table[index].Current.Key != key)
            {
                Table[index].Current = Table[index].Current.Next;
            }
            if (Table[index].Current != null)
            {
                result = Table[index].Current.Value;
            }
            return result;
        }

        /// <summary>
        /// Checks if the key exists in the HashTable and returns true or false
        /// </summary>
        /// <param name="key">The key a HashNode in the table must have to return true</param>
        /// <returns>True if the node is found, false if it doesn't</returns>
        public bool Contains(string key)
        {
            bool result = false;
            int index = GetHash(key);
            if (Table[index] != null)
            {
                Table[index].Current = Table[index].Head;
                while (Table[index].Current != null && Table[index].Current.Key != key)
                {
                    Table[index].Current = Table[index].Current.Next;
                }
                if (Table[index].Current != null)
                {
                    result = true;
                }
            }
            return result;
        }

        /// <summary>
        /// Creates an integer based on an algorithm based on the key and the hashtable's length
        /// </summary>
        /// <param name="key">The key to be hashed</param>
        /// <returns>An integer resulting from hashing the key string</returns>
        public int GetHash(string key)
        {
            int total = 0;
            foreach(char x in key)
            {
                int CharToInt = (int)x;
                total += CharToInt;
            }
            total *= 599;
            while (total > Table.Length)
            {
                total = total / Table.Length;
            }
            return total;
        }
    }
}
