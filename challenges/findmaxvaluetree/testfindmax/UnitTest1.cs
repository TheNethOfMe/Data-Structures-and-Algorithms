using System;
using Xunit;
using findmaxvaluetree;
using trees.Classes;

namespace testfindmax
{
    public class UnitTest1
    {
        [Fact]
        // Should Find the Max Value given a Root Node
        public void ShouldFindMaxValue()
        {
            BinaryTree testTree = Program.CreateTree();
            Console.WriteLine("The max value from the tree is...");
            int result = Program.GetMaxValue(testTree.Root);
            Assert.Equal(21, result);
        }
    }
}
