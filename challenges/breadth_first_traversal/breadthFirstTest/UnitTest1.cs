using System;
using Xunit;
using breadth_first_traversal;
using breadth_first_traversal.Classes;

namespace breadthFirstTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, 6)]
        [InlineData(1, 5)]
        [InlineData(2, 4)]
        [InlineData(3, 3)]
        [InlineData(4, 2)]
        [InlineData(5, 1)]
        // Tests the PreOrder method
        public void ShouldPutNodesInArrayPreOrder(int index, int result)
        {
            Tree testTree = Program.CreateTree();
            int[] ordered = Program.BreadtFirstTraversal(testTree.Root);
            Assert.Equal(ordered[index], result);
        }
    }
}
