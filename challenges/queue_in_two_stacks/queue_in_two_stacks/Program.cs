using System;
using stacks_and_queues.Classes;

namespace queue_in_two_stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stack iStack = InstantiateEmptyStack();
            Stack oStack = InstantiateEmptyStack();
        }

        static Stack InstantiateEmptyStack()
        {
            Node newNode = new Node("POP ME");
            Stack newStack = new Stack(newNode);
            newStack.Pop();
            return newStack;
        }

        static void EnqueueWithStacks(Stack input, Node nodeToAdd)
        {
            input.Push(nodeToAdd);
        }

        static Node DequeueWithStacks(Stack input, Stack output)
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
