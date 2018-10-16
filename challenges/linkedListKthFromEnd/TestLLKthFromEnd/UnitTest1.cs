using System;
using Xunit;
using linkedListKthFromEnd;
using linkedList.Classes;

namespace TestLLKthFromEnd
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, "Trix")]
        [InlineData(1, "Cocoa Pebbles")]
        [InlineData(2, "Lucky Charms")]
        [InlineData(3, "Fruit Loops")]
        [InlineData(4, "Apple Jacks")]
        public void ShouldReturnValueAtProperIndex(int input, string expectedOutput)
        {
            CerealList testList = Program.CreateInitialList();
            Assert.Equal(expectedOutput, Program.CerealKthFromEnd(testList, input));
        }

        [Fact]
        public void ShouldThrowExceptionForImproperInput()
        {
            CerealList testList = Program.CreateInitialList();
            var exception = Record.Exception(() => Program.CerealKthFromEnd(testList, 8));
            Assert.IsType<ArgumentException>(exception);
        }
    }
}
