using System;
using fifo_animal_shelter.Classes;

namespace fifo_animal_shelter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        /// <summary>
        /// Creates a shelter with five animals for the purposes of testing
        /// </summary>
        /// <returns>A shelter with five Pet nodes inside</returns>
        public static Shelter PopulateShelter()
        {
            Dog Jason = new Dog("Jason");
            Dog Kim = new Dog("Kim");
            Cat Zach = new Cat("Zach");
            Cat Trini = new Cat("Trini");
            Dog Billy = new Dog("Billy");
            Shelter result = new Shelter(Jason);
            result.Enqueue(Kim);
            result.Enqueue(Zach);
            result.Enqueue(Trini);
            result.Enqueue(Billy);
            return result;
        }

        /// <summary>
        /// Creates a Shelter that only contains Cat nodes again for testing purposes
        /// </summary>
        /// <returns>A Shelter with three Cat nodes</returns>
        public static Shelter CatsOnly()
        {
            Cat Rocky = new Cat("Rocky");
            Cat Aiesha = new Cat("Aiesha");
            Cat Adam = new Cat("Adam");
            Shelter result = new Shelter(Rocky);
            result.Enqueue(Aiesha);
            result.Enqueue(Adam);
            return result;
        }
    }
}
