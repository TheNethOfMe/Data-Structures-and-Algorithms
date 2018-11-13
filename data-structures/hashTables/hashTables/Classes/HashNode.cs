using System;
using System.Collections.Generic;
using System.Text;

namespace hashTables.Classes
{
    public class HashNode
    {
        // The individual nodes that get inserted into HashLinks, which make up the HashTables
        /// <summary>
        /// The key that will be used to find the node later and will be hashed to determine where the node goes
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// The value that will be returned when the Find method is called on the Hashtable
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// The next HashNode in the list, applicable if more than one key gets hashed to the same index to handle collision
        /// </summary>
        public HashNode Next { get; set; }

        /// <summary>
        /// Instantiates a new instance of HashNode. Gets called by the Add method on HashTable.
        /// </summary>
        /// <param name="key">The key the node will have (the string to be hashed)</param>
        /// <param name="value">The value that will be returned from the Find method on the Hashtable</param>
        public HashNode(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
