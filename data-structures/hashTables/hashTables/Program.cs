using System;
using hashTables.Classes;

namespace hashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            HashTable testTable = new HashTable(300);
            testTable.Add("Cat1", "Matilda");
            testTable.Add("Cat2", "Honey");
            testTable.Add("Doggo25", "Spud");
            int MatildaID = testTable.GetHash("Cat1");
            int HoneyID = testTable.GetHash("Cat2");
            int SpudID = testTable.GetHash("Dog");
            int Test = testTable.GetHash("Cat3");
            Console.WriteLine($"Matilda's ID is {MatildaID}");
            Console.WriteLine($"Honey's ID is {HoneyID}");
            Console.WriteLine($"Spud's ID is {SpudID}");
            Console.WriteLine($"Test is {Test}");
            string MatildaVal = testTable.Find("Cat1");
            string HoneyVal = testTable.Find("Cat2");
            bool SpudBool = testTable.Contains("Doggo25");
            bool TestBool = testTable.Contains("Cat3");
            Console.WriteLine($"Should be Matilda: {MatildaVal}");
            Console.WriteLine($"Should be Honey: {HoneyVal}");
            Console.WriteLine($"Should be true: {SpudBool}");
            Console.WriteLine($"Should be false: {TestBool}");
            Console.ReadLine();
        }
    }
}
