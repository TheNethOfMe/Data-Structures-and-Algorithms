using System;
using stacks_and_queues.Classes;

namespace queue_in_two_stacks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stack iStack = InstantiateEmptyStack();
            Stack oStack = InstantiateEmptyStack();
            Node testNode1 = new Node(1);
            Node testNode2 = new Node(2);
            Node testNode3 = new Node(3);
            Node testNode4 = new Node(4);
            Console.WriteLine("Add three nodes to input stack one");
            EnqueueWithStacks(iStack, testNode1);
            EnqueueWithStacks(iStack, testNode2);
            EnqueueWithStacks(iStack, testNode3);
            Console.WriteLine($"Input stack top is now {iStack.Top.Value}");
            Console.WriteLine("Remove one node.");
            Node resultNode = DequeueWithStacks(iStack, oStack);
            Console.WriteLine($"Output stack top is now {oStack.Top.Value}");
            Console.WriteLine("Add node 4 to the stack pair.");
            EnqueueWithStacks(iStack, testNode4);
            Console.WriteLine("The stack pair now behaves like a queue");
            Console.WriteLine($"The front is effectively {oStack.Top.Value}");
            Console.WriteLine($"The rear is effectively {iStack.Top.Value}");
            Console.ReadKey();
            Console.ReadKey();
        }
        /// <summary>
        /// This methods allows for the instantiation of an empty stack (which is normally 
        /// not allowed since stacks have to be instantiated with at least one node.
        /// This circumvents that process by instantating the stack and then removing the
        /// test node it's created with.
        /// </summary>
        /// <returns>A stack with no nodes inside.</returns>
        public static Stack InstantiateEmptyStack()
        {
            Node newNode = new Node("POP ME");
            Stack newStack = new Stack(newNode);
            newStack.Pop();
            return newStack;
        }

        /// <summary>
        /// Emulates an enqueue method, but with a stack. Pushes one node onto the input stack
        /// </summary>
        /// <param name="input">the stack acting as the input stack</param>
        /// <param name="nodeToAdd">the node to be enqueued on the input stack</param>
        public static void EnqueueWithStacks(Stack input, Node nodeToAdd)
        {
            input.Push(nodeToAdd);
        }

        /// <summary>
        /// Emulates the dequeue method with stacks. Removes one node from the output stack
        /// or puts the nodes from the input stack into the output stack in reverse order 
        /// and then removes from the output stack
        /// </summary>
        /// <param name="input">The stack acting as the input stack</param>
        /// <param name="output">The stack acting as the output stack</param>
        /// <returns>The node that was dequeued from the stacks</returns>
        public static Node DequeueWithStacks(Stack input, Stack output)
        {
            Node oStackHasNode = output.Peek();
            if (oStackHasNode == null)
            {
                Node checkNode = input.Peek();
                while (checkNode != null)
                {
                    Node poppedNode = input.Pop();
                    output.Push(poppedNode);
                    checkNode = input.Peek();
                }
            }
            return output.Pop();
        }
    }
}
