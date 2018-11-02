using System;
using trees.Classes;

namespace findmaxvaluetree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinaryTree testTree = CreateTree();
            Console.WriteLine("The max value from the tree is...");
            Console.WriteLine(GetMaxValue(testTree.Root));
            Console.ReadLine();
        }

        public static BinaryTree CreateTree()
        {
            BinaryTree result = new BinaryTree(new Node(6));
            result.Add(new Node(20));
            result.Add(new Node(4));
            result.Add(new Node(21));
            result.Add(new Node(9));
            result.Add(new Node(1));
            return result;
        }

        public static int GetMaxValue(Node root, int start = 0)
        {
            int max = start;
            if (max < root.Value)
            {
                max = root.Value;
            }
            if (root.GetLeft() != null)
            {
                max = GetMaxValue(root.GetLeft(), max);
            }
            if (root.GetRight() != null)
            {
                max = GetMaxValue(root.GetRight(), max);
            }
            return max;
        }
    }
}
