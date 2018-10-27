using System;
using System.Collections.Generic;
using Xunit;
using diminishing_lists;

namespace TestDiminish
{
    public class UnitTest1
    {
        [Fact]
        // Tests that the correct string gets removed with a small data set
        public void ShouldRemoveSecondString()
        {
            List<string> testList = new List<string> { "good", "evil" };
            Assert.Equal("good", Program.Diminish(testList, 2));
        }

        [Theory]
        [InlineData(2, "test six")]
        [InlineData(5, "test three")]
        [InlineData(6, "test four")]
        // Tests that the correct string gets returned after the method runs
        public void ShouldReturnTheCorrectString(int num, string expectedResult)
        {
            List<string> testList = Program.GenerateList();
            Assert.Equal(expectedResult, Program.Diminish(testList, num));
        }
    }
}
