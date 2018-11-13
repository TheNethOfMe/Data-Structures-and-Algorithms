using System;
using Xunit;
using hashTables;
using hashTables.Classes;

namespace TestHashTables
{
    public class UnitTest1
    {
        [Fact]
        // Should instantate and add items to a new HashTable
        public void ShouldAddItemToHashTable()
        {
            HashTable testTable = new HashTable(300);
            testTable.Add("Cat1", "Matilda");
            int MatildaID = testTable.GetHash("Cat1");
            Assert.Equal("Matilda", testTable.Table[MatildaID].Head.Value);
        }

        [Fact]
        // Contains should only return true if the key is found
        public void ContainsMethodShouldReturnProperValue()
        {
            HashTable testTable = new HashTable(300);
            testTable.Add("Cat1", "Matilda");
            testTable.Add("Cat2", "Honey");
            Assert.True(testTable.Contains("Cat1"));
            Assert.True(testTable.Contains("Cat2"));
            Assert.False(testTable.Contains("Cat3"));
        }

        [Fact]
        // Should get the correct value even if nodes end up in the same index
        public void ShouldReturnCorrectValue()
        {
            HashTable testTable = new HashTable(300);
            
            testTable.Add("Cat1", "Matilda");
            testTable.Add("Cat2", "Honey");
            // The two values above will both end up on the same index

            testTable.Add("Doggo25", "Spud");
            // This node will end up in its own index

            Assert.Equal("Matilda", testTable.Find("Cat1"));
            Assert.Equal("Honey", testTable.Find("Cat2"));
            Assert.Equal("Spud", testTable.Find("Doggo25"));
        }
    }
}
