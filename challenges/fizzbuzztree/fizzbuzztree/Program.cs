using System;
using trees.Classes;

namespace fizzbuzztree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinaryTree testTree = CreateTree();
            FizzBuzzTree(testTree.Root);
            Console.ReadKey();
        }

        public static BinaryTree CreateTree()
        {
            BinaryTree result = new BinaryTree(new Node(5));
            result.Add(new Node(6));
            result.Add(new Node(30));
            result.Add(new Node(21));
            result.Add(new Node(7));
            result.Add(new Node(1));
            return result;
        }

        public static void FizzBuzzTree(Node root)
        {
            switch (root.Value)
            {
                case int n when (n % 15 == 0):
                    Console.WriteLine("FizzBuzz");
                    break;
                case int n when (n % 5 == 0):
                    Console.WriteLine("Buzz");
                    break;
                case int n when (n % 3 == 0):
                    Console.WriteLine("Fizz");
                    break;
                default:
                    Console.WriteLine(root.Value);
                    break;
            }
            if (root.GetLeft() != null)
            {
                FizzBuzzTree(root.GetLeft());
            }
            if (root.GetRight() != null)
            {
                FizzBuzzTree(root.GetRight());
            }
        }
    }
}
