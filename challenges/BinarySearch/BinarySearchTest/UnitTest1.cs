using System;
using Xunit;
using BinarySearch;

namespace BinarySearchTest
{
    public class UnitTest1
    {

        [Fact] // Should return -1 if the value is not in the array
        public void ValueIsNotInArray()
        {
            Assert.Equal(-1, Program.CheckArrayForValue(new int[] { 1, 2, 3, 4, 6, 7, 8, 9 }, 5));
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 6, 7, 8, 9 }, 7, 5)] // Should return the index where the value is located
        [InlineData(new int[] { 1 }, 1, 0)] // Should return the index where the value is located
        public void ValueIsInArray(int[] arrToTest, int valToTest, int expectedResult)
        {
            Assert.Equal(expectedResult, Program.CheckArrayForValue(arrToTest, valToTest));
        }

        [Fact] // Should return -1 for an empty array
        public void ValueIsNotInEmptyArray()
        {
            Assert.Equal(-1, Program.CheckArrayForValue(new int[] { }, 5));
        }
    }
}
