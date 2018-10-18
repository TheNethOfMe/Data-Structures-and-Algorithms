using System;
using linkedList;
using linkedList.Classes;

namespace LinkedListMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] cerealList1 = new string[4]
            {
                "Lucky Charms",
                "Cocoa Pops",
                "Trix",
                "Boo Berry"
            };
            string[] cerealList2 = new string[4]
            {
                "Corn Pops",
                "Smacks",
                "Special K",
                "Frosted Flakes"
            };
            string[] cerealList3 = new string[2]
            {
                "Cocoa Pebbles",
                "Fruity Pebbles"
            };
            CerealList GeneralMills = generateList(cerealList1);
            CerealList Kellogs = generateList(cerealList2);
            Console.WriteLine("General Mills");
            GeneralMills.PrintList();
            Console.WriteLine("Kellogs");
            Kellogs.PrintList();
            CerealList Combined = Merge(GeneralMills, Kellogs);
            Console.WriteLine("Combined");
            Combined.PrintList();
            Console.ReadKey();
        }

        static CerealList Merge(CerealList listA, CerealList listB)
        {
            listA.Current = listA.Head;
            listB.Current = listB.Head;
            while (listA.Current.Next != null && listB.Current.Next != null)
            {
                Cereal tempA = listA.Current.Next;
                Cereal tempB = listB.Current.Next;
                listA.Current.Next = listB.Current;
                listB.Current.Next = tempA;
                listA.Current = tempA;
                listB.Current = tempB;
            }
            if (listA.Current.Next == null)
            {
                listA.Current.Next = listB.Current;
            } else
            {
                listB.Current.Next = listA.Current.Next;
                listA.Current.Next = listB.Current;
            }
            return listA;
        }

        static CerealList generateList(string[] cerealList)
        {
            CerealList temp = new CerealList(new Cereal(cerealList[0]));
            for (int i = 1; i < cerealList.Length; i++)
            {
                temp.AddCereal(new Cereal(cerealList[i]));
            }
            return temp;
        }
    }
}
