using System;
using Xunit;
using ll_reverse;
using linkedList.Classes;


namespace TestLLReverse
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Cocoa Puffs", 0)]
        [InlineData("Frosted Flakes", 1)]
        [InlineData("Fruit Loops", 2)]
        [InlineData("Lucky Charms", 3)]
        // tests that the test LL is being reversed
        public void ShouldReverseTheLL(string cereal, int index)
        {
            CerealList testList = Program.generateListForTesting();
            Program.ReverseLL(testList);
            string[] testArr = testList.ListToArr(4);
            Assert.Equal(cereal, testArr[index]);
        }

        [Theory]
        [InlineData("Cocoa Puffs", 0)]
        [InlineData("Frosted Flakes", 1)]
        [InlineData("Fruit Loops", 2)]
        [InlineData("Lucky Charms", 3)]
        [InlineData("Fruity Yummy Mummy", 4)]
        [InlineData("Cap'n Crunch", 5)]
        [InlineData("Golden Grahams", 6)]
        // tests that the method can reverse a longer LL with an odd number of nodes
        public void ShouldReverseOddNumberLL(string cereal, int index)
        {
            CerealList testList = Program.generateListForTesting();
            testList.AddCereal(new Cereal("Fruity Yummy Mummy"));
            testList.AddCereal(new Cereal("Cap'n Crunch"));
            testList.AddCereal(new Cereal("Golden Grahams"));
            Program.ReverseLL(testList);
            string[] testArr = testList.ListToArr(7);
            Assert.Equal(cereal, testArr[index]);
        }

        [Fact]
        // tests that an LL with only one node just gets returned
        public void ShouldReturnSingleEntryList()
        {
            CerealList testList = new CerealList(new Cereal("Raisin Bran"));
            Program.ReverseLL(testList);
            string[] testArr = testList.ListToArr(1);
            Assert.Equal("Raisin Bran", testArr[0]);
        }
    }
}
