using System;
using System.Collections.Generic;
using System.Text;

namespace trees.Classes
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        /// <summary>
        /// Instantiates a new instace of a Binary Search Tree data structure
        /// </summary>
        /// <param name="root">The Node that will serve as the root of the Binary Search Tree</param>
        public BinarySearchTree(Node root)
        {
            Root = root;
        }

        /// <summary>
        /// Adds a new node to the Binary Search Tree in the proper position related to its value
        /// </summary>
        /// <param name="newNode">The node to be added</param>
        public void Add(Node newNode)
        {
            Node current = Root;
            while (current != newNode)
            {
                if (current.Value > newNode.Value)
                {
                    if (current.GetLeft() == null)
                    {
                        current.AddLeft(newNode);
                    }
                    current = current.GetLeft();
                }
                else
                {
                    if (current.GetRight() == null)
                    {
                        current.AddRight(newNode);
                    }
                    current = current.GetRight();
                }
            }
        }

        /// <summary>
        /// Searches the binary search tree for the value passed in
        /// </summary>
        /// <param name="searchVal">The value to search nodes for</param>
        /// <returns>The node which matches the value passed as an argument, or null if none is found</returns>
        public Node Search(int searchVal)
        {
            Node result = null;
            Node current = Root;
            while (result == null && current != null)
            {
                if (searchVal == current.Value)
                {
                    result = current;
                }
                else if (searchVal > current.Value)
                {
                    current = current.GetRight();
                }
                else
                {
                    current = current.GetLeft();
                }
            }
            return result;
        }
    }
}
