using System;
using linkedList;
using linkedList.Classes;

namespace LinkedListMerge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");CerealList GeneralMills = genListOne();
            CerealList Kellogs = genListTwo();
            Console.WriteLine("General Mills");
            GeneralMills.PrintList();
            Console.WriteLine("Kellogs");
            Kellogs.PrintList();
            CerealList Combined = Merge(GeneralMills, Kellogs);
            Console.WriteLine("Combined");
            Combined.PrintList();
            Console.ReadKey();
        }

        public static CerealList Merge(CerealList listA, CerealList listB)
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

        public static CerealList generateList(string[] cerealList)
        {
            CerealList temp = new CerealList(new Cereal(cerealList[0]));
            for (int i = 1; i < cerealList.Length; i++)
            {
                temp.AddCereal(new Cereal(cerealList[i]));
            }
            return temp;
        }

        public static CerealList genListOne()
        {
            string[] cerealList1 = new string[4]
            {
                "Lucky Charms",
                "Cocoa Puffs",
                "Trix",
                "Boo Berry"
            };
            return generateList(cerealList1);
        }

        public static CerealList genListTwo()
        {
            string[] cerealList2 = new string[4]
            {
                "Corn Pops",
                "Smacks",
                "Special K",
                "Frosted Flakes"
            };
            return generateList(cerealList2);
        }

        public static CerealList genListThree()
        {
            string[] cerealList3 = new string[2]
            {
                "Cocoa Pebbles",
                "Fruity Pebbles"
            };
            return generateList(cerealList3);
        }
    }
}
