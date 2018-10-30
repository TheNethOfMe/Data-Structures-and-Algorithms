using System;
using Xunit;
using fizzbuzztree;
using trees.Classes;

namespace testfizzbuzztree
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, "Buzz")]
        [InlineData(1, "Fizz")]
        [InlineData(2, "Fizz")]
        [InlineData(3, "7")]
        [InlineData(4, "FizzBuzz")]
        [InlineData(5, "1")]
        public void Test1(int position, string result)
        {
            BinaryTree testTree = Program.CreateTree();
            string[] test = Program.FizzBuzzTree(testTree.Root);
            Assert.Equal(result, test[position]);
        }
    }
}
