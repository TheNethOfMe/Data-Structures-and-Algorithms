using System;
using System.Collections.Generic;
using System.Text;

namespace graphs.Classes
{
    public class Graph
    {
        //public LinkedList<LinkedList<Tuple<Vertex, int>>> AdjacencyList { get; set; }
        public List<AdjacencyRow> AdjacencyList { get; set; }
        private int Count { get; set; }

        /// <summary>
        /// Creates new Graph with first vertex already included
        /// </summary>
        /// <param name="vertex">The vertex that will be the key for the graph's first adjacency row</param>
        public Graph(Vertex vertex)
        {
            Count = 0;
            AdjacencyList = new List<AdjacencyRow>();
            AddNewAdjacencyRow(vertex);
        }

        /// <summary>
        /// Creates an empty Graph object
        /// </summary>
        public Graph()
        {
            Count = 0;
            AdjacencyList = new List<AdjacencyRow>();
        }

        /// <summary>
        /// Adds a new Adjacency Row to the Graph object and increments its count
        /// </summary>
        /// <param name="vertex">The vertex that will be the key for that adjacency row</param>
        public void AddNewAdjacencyRow(Vertex vertex)
        {
            AdjacencyList.Add(new AdjacencyRow(vertex));
            Count += 1;
        }

        /// <summary>
        /// A utility function that checks for an existing Adjacency Row with the Vertex passed
        /// Or creates one if it doesn't exist
        /// </summary>
        /// <param name="vertex">The Vertex to check for or create in the Adjacency List</param>
        /// <returns>The Row that was found or created with the passed in vertex as its key</returns>
        public AdjacencyRow FindOrCreateAdjacencyRow(Vertex vertex)
        {
            AdjacencyRow RowWithKey = null;
            foreach (AdjacencyRow row in AdjacencyList)
            {
                if (row.KeyVertex.Value == vertex.Value)
                {
                    RowWithKey = row;
                }
            }
            if (RowWithKey == null)
            {
                AddNewAdjacencyRow(vertex);
                RowWithKey = AdjacencyList.Find(v => v.KeyVertex.Value == vertex.Value);
            }
            return RowWithKey;
        }

        /// <summary>
        /// A utility function that will check if an adjacency already exists and will create one if it does not
        /// </summary>
        /// <param name="checkRow">The row to check for (and possibly add) the adjacency</param>
        /// <param name="child">The vertex to get added to the adjacency list</param>
        /// <param name="addWeight">The weight to add to the adjacency if it's added (defaults to zero)</param>
        public void FindOrAddAdjacencyItem(AdjacencyRow checkRow, Vertex child, int? addWeight)
        {
            bool ChildAlreadyExists = false;
            foreach (var pair in checkRow.Edges)
            {
                if (pair.Item1.Value == child.Value)
                {
                    ChildAlreadyExists = true;
                } 
            }
            if (!ChildAlreadyExists)
            {
                int weight = addWeight != null ? (int)addWeight : 0;
                checkRow.AddEdge(child, weight);
            }
        }

        /// <summary>
        /// Creates rows for the parent and child (if they don't already exist) and adds the child to the parent's list
        /// </summary>
        /// <param name="parent">The parent Vertex</param>
        /// <param name="child">The child Vertex to be added to the parent's Adjacency List</param>
        /// <param name="weight">The weigth of the adjacency (optional, defaults to zero)</param>
        public void AddEdge(Vertex parent, Vertex child, int? weight)
        {
            AdjacencyRow ParentRow = FindOrCreateAdjacencyRow(parent);
            AdjacencyRow ChildRow = FindOrCreateAdjacencyRow(child);
            FindOrAddAdjacencyItem(ParentRow, child, weight);
        }

        /// <summary>
        /// Returns all of the nodes in a graph as an array of Vertecies
        /// </summary>
        /// <returns>An array of Vertecies</returns>
        public Vertex[] GetNodes()
        {
            Vertex[] result = new Vertex[Count];
            int i = 0;
            foreach (AdjacencyRow row in AdjacencyList)
            {
                result[i] = row.KeyVertex;
                i++;
            }
            return result;
        }

        /// <summary>
        /// Returns all of the Edges connected to a Vertex as well as the edge's accociated weight
        /// </summary>
        /// <param name="parent">The Vertex to return all accociated edges</param>
        /// <returns>All edges accociated with the parent</returns>
        public Tuple<Vertex, int>[] GetNeighbors(Vertex parent)
        {
            AdjacencyRow row = AdjacencyList.Find(a => a.KeyVertex.Value == parent.Value);
            Tuple<Vertex, int>[] result = new Tuple<Vertex, int>[row.AdjacencyCount];
            int i = 0;
            foreach (Tuple<Vertex, int> edge in row.Edges)
            {
                result[i] = edge;
                i++;
            }
            return result;
        }

        /// <summary>
        /// Returns the total number of vertecies in the graph
        /// </summary>
        /// <returns>the count property of the graph</returns>
        public int Size()
        {
            return Count;
        }
    }
}
