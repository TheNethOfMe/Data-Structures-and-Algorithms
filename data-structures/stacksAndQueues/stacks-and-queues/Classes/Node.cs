using System;
using System.Collections.Generic;
using System.Text;

namespace stacks_and_queues.Classes
{
    public class Node
    {
        public object Value { get; set; }
        public Node Next { get; set; }

        /// <summary>
        /// Constructor for created nodes
        /// </summary>
        /// <param name="value">the object that will be the value held by the node</param>
        public Node(object value)
        {
            Value = value;
        }
    }
}
