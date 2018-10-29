using System;
using System.Collections.Generic;
using trees.Classes;

namespace trees
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ordering Nodes in This Tree!");
            BinaryTree testTree = CreateTree();
            Console.WriteLine($"          {testTree.Root.Value}");
            Console.WriteLine($"     {testTree.Root.GetLeft().Value} ------- {testTree.Root.GetRight().Value}");
            Console.WriteLine($"  {testTree.Root.GetLeft().GetLeft().Value} --- {testTree.Root.GetLeft().GetRight().Value} | {testTree.Root.GetRight().GetLeft().Value} --- null");
            Node[] preordered = testTree.PreOrder(testTree.Root);
            Node[] inordered = testTree.InOrder(testTree.Root);
            Node[] postordered = testTree.PostOrder(testTree.Root);
            Console.ReadKey();
            Console.WriteLine("\nPre-Order");
            PrintList(preordered);
            Console.ReadKey();
            Console.WriteLine("\nIn-Order");
            PrintList(inordered);
            Console.ReadKey();
            Console.WriteLine("\nPost-Order");
            PrintList(postordered);
            Console.ReadKey();
        }

        public static BinaryTree CreateTree()
        {
            BinaryTree result = new BinaryTree(new Node(6));
            result.Add(new Node(5));
            result.Add(new Node(4));
            result.Add(new Node(3));
            result.Add(new Node(2));
            result.Add(new Node(1));
            return result;
        }

        public static void PrintList(Node[] list)
        {
            int i = 1;
            foreach(Node node in list)
            {
                Console.Write($"{i}: ");
                Console.WriteLine(node.Value);
                i++;
            }
        }
    }
}
