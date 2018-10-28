using System;
using System.Collections.Generic;
using trees.Classes;

namespace trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinaryTree testTree = CreateTree();
            Console.WriteLine($"          {testTree.Root.Value}");
            Console.WriteLine($"     {testTree.Root.GetLeft().Value} ------- {testTree.Root.GetRight().Value}");
            Console.WriteLine($"  {testTree.Root.GetLeft().GetLeft().Value} --- {testTree.Root.GetLeft().GetRight().Value} | {testTree.Root.GetRight().GetLeft().Value} --- null");
            Node[] preordered = testTree.PreOrder(testTree.Root);
            PrintList(preordered);
            Console.ReadLine();
        }

        static BinaryTree CreateTree()
        {
            BinaryTree result = new BinaryTree(new Node(6));
            result.Add(new Node(5));
            result.Add(new Node(4));
            result.Add(new Node(3));
            result.Add(new Node(2));
            result.Add(new Node(1));
            return result;
        }

        static void PrintList(Node[] list)
        {
            Console.WriteLine(list.Length);
            foreach(Node node in list)
            {
                Console.WriteLine(node.Value);
            }
        }
    }
}
