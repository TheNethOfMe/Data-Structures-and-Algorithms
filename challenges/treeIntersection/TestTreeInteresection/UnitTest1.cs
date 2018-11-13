using System;
using Xunit;
using treeIntersection;
using trees.Classes;
using System.Collections.Generic;

namespace TestTreeInteresection
{
    public class UnitTest1
    {
        [Fact]
        // tests the CreateTree method (which is only used for testing and always places a node with value 6 at the root)
        public void ShouldInstatiateBinaryTree()
        {
            int[] treeGen1 = new int[] { 4, 7, 9, 12, 13, 20 };
            BinaryTree testTreeOne = Program.CreateTree(treeGen1);
            Assert.Equal(6, testTreeOne.Root.Value);
            Assert.Equal(4, testTreeOne.Root.GetLeft().Value);
            Assert.Equal(7, testTreeOne.Root.GetRight().Value);
        }

        [Theory]
        [InlineData(0, 6)]
        [InlineData(1, 4)]
        [InlineData(2, 9)]
        [InlineData(3, 12)]
        [InlineData(4, 7)]
        [InlineData(5, 13)]
        [InlineData(6, 20)]
        // tests the PreOrderIntOnly method
        public void ShouldReturnAListOfInts(int index, int value)
        {
            int[] treeGen1 = new int[] { 4, 7, 9, 12, 13, 20 };
            BinaryTree testTreeOne = Program.CreateTree(treeGen1);
            int[] result = Program.PreOrderIntOnly(testTreeOne.Root);
            Assert.Equal(value, result[index]);
        }

        [Theory]
        [InlineData(0, 6)]
        [InlineData(1, 4)]
        [InlineData(2, 9)]
        [InlineData(3, 13)]
        // tests the TreeIntersection method
        public void ShouldReturnAListofIntesFromBothTables(int index, int value)
        {
            int[] treeGen1 = new int[] { 4, 7, 9, 12, 13, 20 };
            int[] treeGen2 = new int[] { 1, 2, 4, 9, 18, 13, 21 };
            BinaryTree testTreeOne = Program.CreateTree(treeGen1);
            BinaryTree testTreeTwo = Program.CreateTree(treeGen2);
            List<int> result = Program.TreeIntersection(testTreeOne, testTreeTwo);
            Assert.Equal(value, result[index]);
        }
    }
}
