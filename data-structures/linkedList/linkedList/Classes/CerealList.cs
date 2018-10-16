using System;
using System.Collections.Generic;
using System.Text;

namespace linkedList.Classes
{
    public class CerealList
    {
        /// <summary>
        /// Points to the first Cereal Node in the LL
        /// </summary>
        public Cereal Head { get; set; }

        /// <summary>
        /// Poinst to the currently selected Node in the LL
        /// </summary>
        public Cereal Current { get; set; }

        /// <summary>
        /// LL requires a node at time of create to be the Head
        /// </summary>
        /// <param name="node">Node to start the LL</param>
        public CerealList(Cereal cereal)
        {
            Head = cereal;
            Current = cereal;
        }

        /// <summary>
        /// Add new Node to the begining of the LL
        /// </summary>
        /// <param name="node">Node to add</param>
        public void AddCereal(Cereal cereal) //O(1)
        {
            cereal.Next = Head;
            Head = cereal;
            Current = Head;
        }

        /// <summary>
        /// Traverse the LL and print out the value of each node
        /// </summary>
        public void PrintList() //O(n)
        {
            Current = Head;

            while (Current.Next != null)
            {
                Console.WriteLine($"* {Current.Value}");
                Current = Current.Next;
            }
            Console.WriteLine($"* {Current.Value}");
            Console.WriteLine("\n");
            Current = Head;
        }

        /// <summary>
        /// Add a new node to the end of the list
        /// </summary>
        /// <param name="node">Node to add</param>
        public void AppendCereal(Cereal node) //O(n)
        {
            Current = Head;

            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = node;

            Current = Head;
        }

        /// <summary>
        /// Adds a Node before another Node
        /// </summary>
        /// <param name="newNode">Node to be added</param>
        /// <param name="prevNode">The Node that will be the new Node's Next</param>
        public void AddBefore(Cereal newNode, string prevNodeVal)
        {
            Current = Head;
            if (Head.Value == prevNodeVal)
            {
                AddCereal(newNode);
            }
            else
            {
                while (Current.Next != null)
                {
                    if (Current.Next.Value == prevNodeVal)
                    {
                        newNode.Next = Current.Next;
                        Current.Next = newNode;
                        return;
                    }
                    Current = Current.Next;
                }
                if (Current.Next == null)
                {
                    Console.WriteLine("That cereal wasn't found.");
                }
            }
            Current = Head;
        }

        /// <summary>
        /// Adds a new node after an existing node
        /// </summary>
        /// <param name="newNode">Node to be added to LL</param>
        /// <param name="nextNode">Node that the new Node will come after</param>
        public void AddAfter(Cereal newNode, string nextNodeVal)
        {
            Current = Head;
            if (Head.Value == nextNodeVal)
            {
                newNode.Next = Head.Next;
                Head.Next = newNode;
                return;
            }
            else
            {
                while (Current.Next != null)
                {
                    if (Current.Value == nextNodeVal)
                    {
                        newNode.Next = Current.Next;
                        Current.Next = newNode;
                        return;
                    }
                    Current = Current.Next;
                }
                if (Current.Value == nextNodeVal)
                {
                    AppendCereal(newNode);
                } else
                {
                    Console.WriteLine("That cereal wasn't found");
                }
            }
            Current = Head;
        }

        /// <summary>
        /// Find a specific cereal
        /// </summary>
        /// <param name="cerealToFind">the cereal value you want found</param>
        /// <returns>returns the cereal matched or null if not found</returns>
        public Cereal FindNode(string cerealToFind)
        {
            Current = Head;
            if (Head.Value == cerealToFind)
            {
                return Head;
            }
            else
            {
                while (Current.Next != null)
                {
                    if (Current.Value == cerealToFind)
                    {
                        return Current;
                    }
                    Current = Current.Next;
                }
                Console.WriteLine($"{cerealToFind} not found.");
                return null;
            }

        }
        
        /// <summary>
        /// Turns the linked list into an array, used ONLY for unit tests
        /// </summary>
        /// <param name="x">length of the array</param>
        /// <param name="list">CerealList to convert</param>
        /// <returns>an array of Cereal node values</returns>
        public string[] ListToArr(int x)
        {
            Current = Head;
            string[] result = new string[x];
            for (int i = 0; i < x; i++)
            {
                result[i] = Current.Value;
                Current = Current.Next;
            }
            Current = Head;
            return result;
        }
    }
}
