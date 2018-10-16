using System;
using linkedList;
using linkedList.Classes;

namespace linkedListKthFromEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CerealList myList = CreateInitialList();
            string test = CeriealKthFromEnd(myList, 4);
            Console.WriteLine($"The returned value is {test}");
            Console.ReadKey();
        }

        static string CeriealKthFromEnd(CerealList LL, int IndexFromEnd)
        {
            int count = 0;
            Cereal result = null;

            LL.Current = LL.Head;

            while(LL.Current.Next != null)
            {
                count += 1;
                LL.Current = LL.Current.Next;
            }

            LL.Current = LL.Head;
            count -= IndexFromEnd;
            
            if (count < 0)
            {
                throw new System.ArgumentException("Parameter can't be greater than or equal to the number of nodes in the index", "IndexFromEnd");
            }

            for (int i = 0; i < count; i++)
            {
                LL.Current = LL.Current.Next;
            }

            result = LL.Current;
            LL.Current = LL.Head;
            return result.Value;
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
