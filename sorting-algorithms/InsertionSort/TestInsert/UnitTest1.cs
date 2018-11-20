using System;
using Xunit;
using InsertionSort;

namespace TestInsert
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 2)]
        [InlineData(2, 4)]
        [InlineData(3, 7)]
        [InlineData(4, 12)]
        [InlineData(5, 99)]
        // Should sort the array
        public void ShouldSortArrayWithInsertionSort(int index, int result)
        {
            int[] unsortedArr = new int[] { 4, 2, 99, 7, 12, 1 };
            int[] sortedArr = Program.InsertionSort(unsortedArr);
            Assert.Equal(result, sortedArr[index]);
        }
    }
}
