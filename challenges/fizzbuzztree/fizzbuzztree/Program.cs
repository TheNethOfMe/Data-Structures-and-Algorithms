using System;
using System.Linq;
using trees.Classes;

namespace fizzbuzztree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinaryTree testTree = CreateTree();
            string[] test = FizzBuzzTree(testTree.Root);
            foreach(String str in test) {
                Console.WriteLine(str);
            }
            Console.ReadLine();
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

        public static string[] FizzBuzzTree(Node root)
        {
            string[] result = new string[1];
            switch (root.Value)
            {
                case int n when (n % 15 == 0):
                    result[0] = "FizzBuzz";
                    break;
                case int n when (n % 5 == 0):
                    result[0] = "Buzz";
                    break;
                case int n when (n % 3 == 0):
                    result[0] = "Fizz";
                    break;
                default:
                    result[0] = root.Value.ToString();
                    break;
            }
            if (root.GetLeft() != null)
            {
                result = result.Concat(FizzBuzzTree(root.GetLeft())).ToArray();
            }
            if (root.GetRight() != null)
            {
                result = result.Concat(FizzBuzzTree(root.GetRight())).ToArray();
            }
            return result;
        }
    }
}
