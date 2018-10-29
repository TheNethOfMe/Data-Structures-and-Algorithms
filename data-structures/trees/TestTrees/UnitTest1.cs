using System;
using Xunit;
using trees.Classes;
using trees;

namespace TestTrees
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, 6)]
        [InlineData(1, 5)]
        [InlineData(2, 3)]
        [InlineData(3, 2)]
        [InlineData(4, 4)]
        [InlineData(5, 1)]
        // Tests the PreOrder method
        public void ShouldPutNodesInArrayPreOrder(int index, int result)
        {
            BinaryTree testTree = Program.CreateTree();
            Node[] ordered = testTree.PreOrder(testTree.Root);
            Assert.Equal(ordered[index].Value, result);
        }

        [Theory]
        [InlineData(0, 3)]
        [InlineData(1, 5)]
        [InlineData(2, 2)]
        [InlineData(3, 6)]
        [InlineData(4, 1)]
        [InlineData(5, 4)]
        // Tests the InOrder method
        public void ShouldPutNodesInArrayInOrder(int index, int result)
        {
            BinaryTree testTree = Program.CreateTree();
            Node[] ordered = testTree.InOrder(testTree.Root);
            Assert.Equal(ordered[index].Value, result);
        }

        [Theory]
        [InlineData(0, 3)]
        [InlineData(1, 2)]
        [InlineData(2, 5)]
        [InlineData(3, 1)]
        [InlineData(4, 4)]
        [InlineData(5, 6)]
        // Tests the PostOrder method
        public void ShouldPutNodesInArrayPostOrder(int index, int result)
        {
            BinaryTree testTree = Program.CreateTree();
            Node[] ordered = testTree.PostOrder(testTree.Root);
            Assert.Equal(ordered[index].Value, result);
        }
    }
}
