using System;
using stacks_and_queues.Classes;

namespace stacks_and_queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            stackStuff();
            queueStuff();
            Console.ReadKey();
        }

        static void stackStuff()
        {
            Stack myStack = new Stack(new Node(0));
            for (int i = 1; i < 6; i++)
            {
                pushAll(myStack, i);
            }
            for (int j = 0; j < 6; j++)
            {
                popAll(myStack);
            }
        }

        static void pushAll(Stack st, int nodeValue)
        {
            Console.WriteLine($"Push {nodeValue}");
            st.Push(new Node(nodeValue));
        }

        static void popAll(Stack st)
        {
            Node popped = st.Pop();
            Console.WriteLine($"Pop {popped.Value}");
        }

        static void queueStuff()
        {
            Queue myQueue = new Queue(new Node(0));
            for (int i = 1; i < 6; i++)
            {
                enqueueAll(myQueue, i);
            }
            for (int j = 0; j < 6; j++)
            {
                dequeueAll(myQueue);
            }
        }

        static void enqueueAll(Queue qu, int nodeValue)
        {
            Console.WriteLine($"Enque node number {nodeValue}");
            qu.Enqueue(new Node(nodeValue));
        }

        static void dequeueAll(Queue qu)
        {
            Node dequeued = qu.Dequeue();
            Console.WriteLine($"Dequeue node {dequeued.Value}");
        }
    }
}
