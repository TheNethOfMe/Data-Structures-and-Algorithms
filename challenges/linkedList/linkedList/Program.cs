using System;
using linkedList.Classes;

namespace linkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CerealList MyCereal = CreateInitialList();

            Console.WriteLine("Here's a list of cereals!");
            MyCereal.PrintList();

            UserLoop(MyCereal);
        }

        /// <summary>
        /// Creates a list of cereals to start the user off
        /// Also useful for testing
        /// </summary>
        /// <returns>A CerealList with a set of Cereal nodes already in it</returns>
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

        static void UserLoop(CerealList MyCereal)
        {
            char userPick = UserOptions();
            if (userPick != '6')
            {
                PerformAction(userPick, MyCereal);
            }
        }

        static char UserOptions()
        {
            Console.WriteLine("Please select an option.");
            Console.WriteLine("1. Add a cereal to the beginning of the list.");
            Console.WriteLine("2. Add a cereal to the end of the list.");
            Console.WriteLine("3. Add a cereal before an existing cereal.");
            Console.WriteLine("4. Add a cereal after an existing cereal.");
            Console.WriteLine("5. Print cereal list.");
            Console.WriteLine("6. Exit");
            
            return Console.ReadKey().KeyChar;
        }

        static void PerformAction(char pick, CerealList MyCereal)
        {
            Cereal newCer = null;
            string oldCer = null;
            Console.WriteLine("\n");
            switch (pick)
            {
                case '1':
                    newCer = new Cereal(GetNewCereal());
                    MyCereal.AddCereal(newCer);
                    break;
                case '2':
                    newCer = new Cereal(GetNewCereal());
                    MyCereal.AppendCereal(newCer);
                    break;
                case '3':
                    newCer = new Cereal(GetNewCereal());
                    Console.WriteLine("Which cereal should come after this new one?");
                    oldCer = Console.ReadLine();
                    MyCereal.AddBefore(newCer, oldCer);
                    break;
                case '4':
                    newCer = new Cereal(GetNewCereal());
                    Console.WriteLine("Which cereal should come before this new one?");
                    oldCer = Console.ReadLine();
                    MyCereal.AddAfter(newCer, oldCer);
                    break;
                case '5':
                    MyCereal.PrintList();
                    break;
                default:
                    Console.WriteLine("Sorry, that wan't an option.");
                    break;
            }
            UserLoop(MyCereal);
        }

        static string GetNewCereal()
        {
            Console.WriteLine("Please enter the name of the cereal you want to add.");
            return Console.ReadLine();
        }
    }
}
