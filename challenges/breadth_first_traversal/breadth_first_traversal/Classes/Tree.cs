using System;
using System.Collections.Generic;
using System.Text;

namespace breadth_first_traversal.Classes
{
    public class Tree
    {
        public Node Root { get; set; }

        /// <summary>
        /// Instantiates a new instace of a Binary Tree data structure
        /// </summary>
        /// <param name="root">The Node that will serve as the root of the Binary Tree</param>
        public Tree(Node root)
        {
            Root = root;
        }

        /// <summary>
        /// Adds a node to the BinaryTree
        /// </summary>gf
        /// <param name="newNode">The node to insert into the BinaryTree</param>
        public void Add(Node newNode)
        {
            // if there is no root for some reason, set the new node to be the root
            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                // otherwise, create a new queue and store the root node in the queue
                Queue<Node> q = new Queue<Node>();
                q.Enqueue(Root);
                while (q.Count > 0)
                {
                    // dequeue one node and check it for children
                    Node current = q.Dequeue();
                    if (current.GetLeft() != null && current.GetRight() != null)
                    {
                        // if it has two children, enqueue both of them
                        q.Enqueue(current.GetLeft());
                        q.Enqueue(current.GetRight());
                    }
                    else
                    {
                        // otherwise, set the new node to the left or right child property of the parent and break the root
                        if (current.GetLeft() == null)
                        {
                            current.AddLeft(newNode);
                        }
                        else
                        {
                            current.AddRight(newNode);
                        }
                        break;
                    }
                }

            }
        }
    }
}
