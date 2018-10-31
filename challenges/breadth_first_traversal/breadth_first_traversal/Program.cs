using System;
using System.Linq;
using breadth_first_traversal.Classes;

namespace breadth_first_traversal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tree testTree = CreateTree();
            int[] output = BreadtFirstTraversal(testTree.Root);
            foreach(int i in output)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        public static Tree CreateTree()
        {
            Tree result = new Tree(new Node(6));
            result.Add(new Node(5));
            result.Add(new Node(4));
            result.Add(new Node(3));
            result.Add(new Node(2));
            result.Add(new Node(1));
            return result;
        }

        public static int[] BreadtFirstTraversal(Node root)
        {
            int[] result = new int[] { };
            Queue holding = new Queue(root);
            while (holding.Front != null)
            {
                Node current = holding.Dequeue();
                int[] toConcat = new int[] { current.Value };
                result = result.Concat(toConcat).ToArray();
                if (current.GetLeft() != null)
                {
                    holding.Enqueue(current.GetLeft());
                }
                if (current.GetRight() != null)
                {
                    holding.Enqueue(current.GetRight());
                }
            }
            return result;
        }
    }
}
