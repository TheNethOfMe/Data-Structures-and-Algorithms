using System;
using System.Collections.Generic;
using System.Text;

namespace stacks_and_queues.Classes
{
    class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        /// <summary>
        /// Creates a new queue with one node that will be the front and rear until more are added
        /// </summary>
        /// <param name="node">The node that will start the queue</param>
        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// Returns the node in the queue's front without altering the queue
        /// </summary>
        /// <returns>The node in front</returns>
        public Node Peek()
        {
            return Front;
        }

        /// <summary>
        /// Adds a node to the rear of the queue
        /// </summary>
        /// <param name="node">the node that will be added to the queue</param>
        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
        }

        /// <summary>
        /// Removes the node at the front of the queue
        /// </summary>
        /// <returns>the node that was just removed</returns>
        public Node Dequeue()
        {
            Node temp = Peek();
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }
    }
}
