using System;
using System.Collections.Generic;
using System.Linq;
using trees.Classes;

namespace treeIntersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's Create some binary tress");
            int[] treeGen1 = new int[] { 4, 7, 9, 12, 13, 20 };
            int[] treeGen2 = new int[] { 1, 2, 4, 9, 18, 13, 21 };
            Console.WriteLine("Values in tree one");
            foreach (int x in treeGen1)
            {
                Console.Write($"{x}, ");
            }
            Console.Write(6);
            Console.WriteLine("\nValues in tree two");
            foreach (int x in treeGen2)
            {
                Console.Write($"{x}, ");
            }
            Console.Write(6);
            BinaryTree testTreeOne = CreateTree(treeGen1);
            BinaryTree testTreeTwo = CreateTree(treeGen2);
            Console.WriteLine("\nWe've created two binary trees, now let's run them through the TreeInteresection method.");
            List<int> finalArray = TreeIntersection(testTreeOne, testTreeTwo);
            Console.WriteLine("Final Result (Only values that appear in both trees)");
            Console.Write("[");
            foreach(int x in finalArray)
            {
                Console.Write($"{x},");
            }
            Console.Write("]");
            Console.ReadLine();
        }

        /// <summary>
        /// The method that takes both trees and returns a list of ints with only the repeated values
        /// </summary>
        /// <param name="first">The first binary tree</param>
        /// <param name="second">The second binary tree</param>
        /// <returns>A list of ints</returns>
        public static List<int> TreeIntersection(BinaryTree first, BinaryTree second)
        {
            List<int> result = new List<int>();
            int[] arrOne = PreOrderIntOnly(first.Root);
            int[] arrTwo = PreOrderIntOnly(second.Root);

            foreach(int x in arrOne)
            {
                if (arrTwo.Contains(x))
                {
                    result.Add(x);
                }
            }
            return result;
        }

        /// <summary>
        /// A special version of the PreOrder that returns an array of integers istead of an array of Nodes
        /// </summary>
        /// <param name="root">The node to start from</param>
        /// <returns>An array containing ints representing all of the node values</returns>
        public static int[] PreOrderIntOnly(Node root)
        {
            int[] result = new int[1];
            result[0] = root.Value;
            if (root.GetLeft() != null)
            {
                result = result.Concat(PreOrderIntOnly(root.GetLeft())).ToArray();
            }
            if (root.GetRight() != null)
            {
                result = result.Concat(PreOrderIntOnly(root.GetRight())).ToArray();
            }
            return result;
        }

        public static BinaryTree CreateTree(int[] values)
        {
            BinaryTree result = new BinaryTree(new Node(6));
            foreach(int x in values)
            {
                result.Add(new Node(x));
            }
            return result;
        }
    }
}
