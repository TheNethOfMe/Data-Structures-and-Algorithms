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

        public static Stack InstantiateEmptyStack()
        {
            Node newNode = new Node("POP ME");
            Stack newStack = new Stack(newNode);
            newStack.Pop();
            return newStack;
        }

        public static void EnqueueWithStacks(Stack input, Node nodeToAdd)
        {
            input.Push(nodeToAdd);
        }

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
