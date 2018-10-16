using System;
using LinkedListKthFromEnd.Classes;

namespace LinkedListKthFromEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static CerealList CreateInitialList()
        {
            Cereal LuckyCharms = new Cereal("Lucky Charms");
            CerealList StarterList = new CerealList(LuckyCharms);
            Cereal AppleJacks = new Cereal("Apple Jacks");
            Cereal Trix = new Cereal("Trix");
            Cereal FruitLoops = new Cereal("Fruit Loops");
            Cereal CocoaPebbles = new Cereal("Cocoa Pebbles");
            StarterList.AddCereal(AppleJacks);
            StarterList.AppendCereal(Trix);
            StarterList.AddBefore(FruitLoops, "Lucky Charms");
            StarterList.AddAfter(CocoaPebbles, "Lucky Charms");
            return StarterList;
        }
    }
}
