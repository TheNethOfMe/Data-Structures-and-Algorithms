using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter.Classes
{
    public class Shelter
    {
        public Pet Front { get; set; }
        public Pet Rear { get; set; }

        /// <summary>
        /// Creates a new Shelter with one pet that will be the front and rear until more are added
        /// </summary>
        /// <param name="pet">The node that will start the queue</param>
        public Shelter(Pet pet)
        {
            Front = pet;
            Rear = pet;
        }

        /// <summary>
        /// Returns the Pet in front of the Shelter without altering it
        /// </summary>
        /// <returns>The Pet in front</returns>
        public Pet Peek()
        {
            return Front;
        }

        /// <summary>
        /// Adds a node to the rear of the queue
        /// </summary>
        /// <param name="pet">the node that will be added to the queue</param>
        public void Enqueue(Pet node)
        {
            Rear.Next = node;
            Rear = node;
        }

        /// <summary>
        /// Takes the first pet of the prefered type out of the shelter
        /// </summary>
        /// <param name="prefered">A Pet of the type that will be returned</param>
        /// <returns>A Pet depending on the type of prefered Pet passed in</returns>
        public Pet Dequeue(Pet preferred)
        {
            Pet result = null;
            Pet temp = null;
            if (preferred.GetType() == Front.GetType())
            {
                result = Dequeue();
            }
            else
            {
                temp = Dequeue();
                Enqueue(temp);
                while (Front != temp)
                {
                    if ((Front.GetType() == preferred.GetType()) && (result == null))
                    {
                        result = Dequeue();
                    }
                    else
                    {
                        Enqueue(Dequeue());
                    }
                }
            }
            if (result == null)
            {
                result = Dequeue();
            }
            return result;
        }

        /// <summary>
        /// Takes the pet in front out of the shelter, because he/she found a home!
        /// </summary>
        /// <returns>The Pet that is going to his/her new home</returns>
        public Pet Dequeue()
        {
            Pet temp = Peek();
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }
    }
}