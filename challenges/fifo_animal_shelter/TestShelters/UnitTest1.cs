using System;
using Xunit;
using fifo_animal_shelter;
using fifo_animal_shelter.Classes;

namespace TestShelters
{
    public class UnitTest1
    {
        [Fact]
        // Checks that the Shelters are properly instantiated
        public void ShouldInstantiateShelter()
        {
            Shelter testShelter = Program.PopulateShelter();
            Assert.Equal("Jason", testShelter.Front.Name);
            Assert.Equal("Billy", testShelter.Rear.Name);
        }

        [Fact]
        // Ensure that the Enqueue method works on instantiated shelter
        public void ShouldEnqueueIntoShelter()
        {
            Shelter testShelter = Program.PopulateShelter();
            testShelter.Enqueue(new Dog("Tommy"));
            Assert.Equal("Tommy", testShelter.Rear.Name);
        }

        [Fact]
        // Should Dequeue Front Pet from Shelter when no arguments are passed to Dequeue method
        public void ShouldDequeueAnyPet()
        {
            Shelter testShelter = Program.PopulateShelter();
            Pet adopted = testShelter.Dequeue();
            Assert.Equal("Kim", testShelter.Front.Name);
            Assert.Equal("Jason", adopted.Name);
        }

        [Fact]
        // Should Return front-most requested animal when an argument is passed into Dequeue method
        // Should also keep the order of the Pets unchanged otherwise
        public void ShouldDequeueFirstPreferredPet()
        {
            Shelter testShelter = Program.PopulateShelter();
            Pet adopted = testShelter.Dequeue(new Cat("test"));
            Assert.Equal("Zach", adopted.Name);
            Assert.Equal("Jason", testShelter.Front.Name);
            Assert.Equal("Billy", testShelter.Rear.Name);
        }

        [Fact]
        // Should Return the Front Pet in the case that there are no instances of the prefered Pet type in the Shelter
        public void ShouldReturnFirstPetIfNoPreferedExist()
        {
            Shelter catShelter = Program.CatsOnly();
            Pet adopted = catShelter.Dequeue(new Dog("test"));
            Assert.Equal("Rocky", adopted.Name);
            Assert.Equal("Aiesha", catShelter.Front.Name);
            Assert.Equal("Adam", catShelter.Rear.Name);
        }
    }
}
