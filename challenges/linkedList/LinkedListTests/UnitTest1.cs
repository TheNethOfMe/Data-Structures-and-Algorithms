using System;
using Xunit;
using linkedList;
using linkedList.Classes;


namespace LinkedListTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, "Apple Jacks")]
        [InlineData(1, "Fruit Loops")]
        [InlineData(2, "Lucky Charms")]
        [InlineData(3, "Cocoa Pebbles")]
        [InlineData(4, "Trix")]
        // tests that a list with nodes were created by finding nodes in a created list
        public void ShouldCreateListAndNodes(int arrIdx, string cerVal)
        {
            CerealList testList = Program.CreateInitialList();
            string[] testArr = testList.ListToArr(5);
            Assert.Equal(cerVal, testArr[arrIdx]);
        }

        [Fact]
        public void ShouldAddCerealToListHead()
        {
            CerealList testList = Program.CreateInitialList();
            Cereal frostedFlakes = new Cereal("Frosted Flakes");
            testList.AddCereal(frostedFlakes);
            string[] testArr = testList.ListToArr(1);
            Assert.Equal("Frosted Flakes", testArr[0]);
        }

        [Fact]
        public void ShouldAddCerealToListEnd()
        {
            CerealList testList = Program.CreateInitialList();
            Cereal frostedFlakes = new Cereal("Frosted Flakes");
            testList.AppendCereal(frostedFlakes);
            string[] testArr = testList.ListToArr(6);
            Assert.Equal("Frosted Flakes", testArr[5]);
        }

        [Fact]
        public void ShouldAddCerealBeforeFruitLoops()
        {
            CerealList testList = Program.CreateInitialList();
            Cereal frostedFlakes = new Cereal("Frosted Flakes");
            testList.AddBefore(frostedFlakes, "Fruit Loops");
            string[] testArr = testList.ListToArr(6);
            Assert.Equal("Frosted Flakes", testArr[1]);
            Assert.Equal("Fruit Loops", testArr[2]);
        }

        [Fact]
        public void ShouldAddCerealAfterFruitLoops()
        {
            CerealList testList = Program.CreateInitialList();
            Cereal frostedFlakes = new Cereal("Frosted Flakes");
            testList.AddAfter(frostedFlakes, "Fruit Loops");
            string[] testArr = testList.ListToArr(6);
            Assert.Equal("Frosted Flakes", testArr[2]);
            Assert.Equal("Fruit Loops", testArr[1]);
        }
    }
}
