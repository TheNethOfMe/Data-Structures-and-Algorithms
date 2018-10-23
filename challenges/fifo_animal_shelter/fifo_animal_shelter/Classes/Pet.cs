using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter.Classes
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public Pet Next { get; set; }

        /// <summary>
        /// Constructor for created nodes
        /// </summary>
        /// <param name="value">the object that will be the value held by the node</param>
        public Pet(string name)
        {
            Name = name;
        }
    }
}
