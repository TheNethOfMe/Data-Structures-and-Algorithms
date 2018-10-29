using System;
using System.Collections.Generic;
using System.Text;

namespace trees.Classes
{
    public class Node
    {
        public int Value { get; set; }
        private Node LeftChild { get; set; }
        private Node RightChild { get; set; }

        /// <summary>
        /// Instantiates a new instance of Node
        /// </summary>
        /// <param name="value">The numerical value the Node will contain in its Value property</param>
        public Node(int value)
        {
            Value = value;
        }

        /// <summary>
        /// Returns the LeftChild property of the node
        /// </summary>
        /// <returns>The Node's LeftChild</returns>
        public Node GetLeft()
        {
            return LeftChild;
        }

        /// <summary>
        /// Returns the RightChild property of the node
        /// </summary>
        /// <returns>The Node's RightChild</returns>
        public Node GetRight()
        {
            return RightChild;
        }

        /// <summary>
        /// Adds a new LeftChild property to the node
        /// </summary>
        /// <param name="node">The Node to set the LeftChild property to</param>
        public void AddLeft(Node node)
        {
            LeftChild = node;
        }

        /// <summary>
        /// Adds a new RightChild property to the node
        /// </summary>
        /// <param name="node">The Node to set the RightChild property to</param>
        public void AddRight(Node node)
        {
            RightChild = node;
        }
    }
}
