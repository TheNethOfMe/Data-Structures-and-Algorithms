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
            BinarySearchTree testBST = GenerateBinarySearchTree();
            Console.ReadKey();
            Console.WriteLine("Binary Search Tree");
            Console.WriteLine($"          {testBST.Root.Value}");
            Console.WriteLine($"     {testBST.Root.GetLeft().Value} ------- {testBST.Root.GetRight().Value}");
            Console.WriteLine($"  null --- {testBST.Root.GetLeft().GetRight().Value} | {testBST.Root.GetRight().GetLeft().Value} --- {testBST.Root.GetRight().GetRight().Value}");
            Console.WriteLine($"x | x | x | {testBST.Root.GetLeft().GetRight().GetRight().Value} | x | x | {testBST.Root.GetRight().GetRight().GetLeft().Value} | x");
            Console.ReadKey();
            Node[] inorderedBST = testTree.InOrder(testBST.Root);
            PrintList(inorderedBST);
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

        public static BinarySearchTree GenerateBinarySearchTree()
        {
            BinarySearchTree result = new BinarySearchTree(new Node(100));
            result.Add(new Node(50));
            result.Add(new Node(200));
            result.Add(new Node(75));
            result.Add(new Node(300));
            result.Add(new Node(250));
            result.Add(new Node(101));
            result.Add(new Node(99));
            return result;
        }
    }
}
