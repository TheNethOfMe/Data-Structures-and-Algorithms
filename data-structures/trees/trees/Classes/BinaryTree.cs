using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace trees.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        /// <summary>
        /// Instantiates a new instace of a Binary Tree data structure
        /// </summary>
        /// <param name="root">The Node that will serve as the root of the Binary Tree</param>
        public BinaryTree(Node root)
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
                        } else
                        {
                            current.AddRight(newNode);
                        }
                        break;
                    }
                }
                
            }
        }

        /// <summary>
        /// Collects all of the Nodes from a Binary Tree in Preorder traversal pattern
        /// </summary>
        /// <param name="root">The root node of the tree</param>
        /// <returns>An array of Nodes in root, left, right order</returns>
        public Node[] PreOrder(Node root)
        {
            Node[] result = new Node[1];
            result[0] = root;
            if (root.GetLeft() != null)
            {
                result = result.Concat(PreOrder(root.GetLeft())).ToArray();
            }
            if (root.GetRight() != null)
            {
                result = result.Concat(PreOrder(root.GetRight())).ToArray();
            }
            return result;
        }

        /// <summary>
        /// Collects all of the Nodes from a Binary Tree in InOrder traversal pattern
        /// </summary>
        /// <param name="root">The root node of the tree</param>
        /// <returns>An array of Nodes in left, root, right order</returns>
        public Node[] InOrder(Node root)
        {
            Node[] result = new Node[0];
            if (root.GetLeft() != null)
            {
                result = result.Concat(InOrder(root.GetLeft())).ToArray();
            }
            result = result.Concat(new Node[] { root }).ToArray();
            if (root.GetRight() != null)
            {
                result = result.Concat(InOrder(root.GetRight())).ToArray();
            }
            return result;
        }

        /// <summary>
        /// Collects all of the Nodes from a Binary Tree in PostOrder traversal pattern
        /// </summary>
        /// <param name="root">The root node of the tree</param>
        /// <returns>An array of Nodes in left, right, root order</returns>
        public Node[] PostOrder(Node root)
        {
            Node[] result = new Node[0];
            if (root.GetLeft() != null)
            {
                result = result.Concat(PostOrder(root.GetLeft())).ToArray();
            }
            if (root.GetRight() != null)
            {
                result = result.Concat(PostOrder(root.GetRight())).ToArray();
            }
            result = result.Concat(new Node[] { root }).ToArray();
            return result;
        }
    }
}
