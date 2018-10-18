using System;
using Xunit;
using LinkedListMerge;
using linkedList.Classes;

namespace MergeTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, "Boo Berry")]
        [InlineData(1, "Frosted Flakes")]
        [InlineData(2, "Trix")]
        [InlineData(3, "Special K")]
        [InlineData(4, "Cocoa Puffs")]
        [InlineData(5, "Smacks")]
        [InlineData(6, "Lucky Charms")]
        [InlineData(7, "Corn Pops")]
        public void ShouldMergeEqualLengthLists(int index, string expectedOutput)
        {
            CerealList GeneralMills = Program.genListOne();
            CerealList Kellogs = Program.genListTwo();
            CerealList CombinedList = Program.Merge(GeneralMills, Kellogs);
            string[] CombinedArr = CombinedList.ListToArr(8);
            Assert.Equal(expectedOutput, CombinedArr[index]);
        }

        [Theory]
        [InlineData(0, "Boo Berry")]
        [InlineData(1, "Fruity Pebbles")]
        [InlineData(2, "Trix")]
        [InlineData(3, "Cocoa Pebbles")]
        [InlineData(4, "Cocoa Puffs")]
        [InlineData(5, "Lucky Charms")]
        public void ShouldMergeWhenListAIsLonger(int index, string expectedOutput)
        {
            CerealList GeneralMills = Program.genListOne();
            CerealList Post = Program.genListThree();
            CerealList CombinedList = Program.Merge(GeneralMills, Post);
            string[] CombinedArr = CombinedList.ListToArr(6);
            Assert.Equal(expectedOutput, CombinedArr[index]);
        }

        [Theory]
        [InlineData(0, "Fruity Pebbles")]
        [InlineData(1, "Frosted Flakes")]
        [InlineData(2, "Cocoa Pebbles")]
        [InlineData(3, "Special K")]
        [InlineData(4, "Smacks")]
        [InlineData(5, "Corn Pops")]
        public void ShouldMergeWhenListBIsLonger(int index, string expectedOutput)
        {
            CerealList Post = Program.genListThree();
            CerealList Kellogs = Program.genListTwo();
            CerealList CombinedList = Program.Merge(Post, Kellogs);
            string[] CombinedArr = CombinedList.ListToArr(6);
            Assert.Equal(expectedOutput, CombinedArr[index]);
        }
    }
}
