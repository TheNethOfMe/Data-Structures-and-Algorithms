using System;
using System.Collections.Generic;
using System.Text;

namespace stacks_and_queues.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        /// <summary>
        /// Constructor for creating a new stack
        /// </summary>
        /// <param name="node">The node that will go into the stack first</param>
        public Stack(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// Allows the user to see the node on top without altering the stack
        /// </summary>
        /// <returns>The node at the top</returns>
        public Node Peek()
        {
            return Top;
        }

        /// <summary>
        /// Removes the node from the top
        /// </summary>
        /// <returns>The Node that was just removed</returns>
        public Node Pop()
        {
            Node temp = Peek();
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// Places a new node on top of the stack
        /// </summary>
        /// <param name="node">The node to go on top of the stack</param>
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }
    }
}
