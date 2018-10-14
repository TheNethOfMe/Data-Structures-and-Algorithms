using System;
using Xunit;
using Fibonacci;

namespace FibonacciTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        [InlineData(6, 8)]
        public void ShouldReturnProperFibonacciIndexValue(int input, int expectedOutput)
        {
            Assert.Equal(expectedOutput, Program.GetFibonacciSequenceAtIndex(input));
        }
    }
}
