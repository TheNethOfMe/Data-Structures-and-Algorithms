using System;
using linkedList.Classes;

namespace ll_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CerealList testList = generateListForTesting();
            // Print the list
            testList.PrintList();
            // Reverse the list
            ReverseLL(testList);
            // Print the list again, showing that it has been reversed
            testList.PrintList();
            Console.ReadKey();
        }

        /// <summary>
        /// Reverses a CerealList in place
        /// </summary>
        /// <param name="LL">The Linked List (CerealList in this case) to be reversed</param>
        /// <returns>The list that was input, which will be reversed</returns>
        static CerealList ReverseLL(CerealList LL)
        {
            LL.Current = LL.Head;
            Cereal tempPrev = null;
            while (LL.Current.Next != null)
            {
                Cereal tempNext = LL.Current.Next;
                LL.Current.Next = tempPrev;
                tempPrev = LL.Current;
                LL.Current = tempNext;
            }
            LL.Current.Next = tempPrev;
            LL.Head = LL.Current;
            return LL;
        }

        /// <summary>
        /// A method for generating a CerealList to use for testing
        /// </summary>
        /// <returns>The Cereal list we will use to test</returns>
        static CerealList generateListForTesting()
        {
            CerealList testList = new CerealList(new Cereal("Lucky Charms"));
            testList.AppendCereal(new Cereal("Fruit Loops"));
            testList.AppendCereal(new Cereal("Frosted Flakes"));
            testList.AppendCereal(new Cereal("Cocoa Puffs"));
            return testList;
        }
    }
}
