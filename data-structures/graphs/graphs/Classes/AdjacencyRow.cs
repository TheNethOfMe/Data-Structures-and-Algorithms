using System;
using System.Collections.Generic;
using System.Text;

namespace graphs.Classes
{
    public class AdjacencyRow
    {
        public Vertex KeyVertex { get; set; }
        public List<Tuple<Vertex, int>> Edges { get; set; }
        public int AdjacencyCount { get; set; }

        public AdjacencyRow(Vertex vertex)
        {
            KeyVertex = vertex;
            AdjacencyCount = 0;
            Edges = new List<Tuple<Vertex, int>>();
        }

        /// <summary>
        /// Creates a new Edge to the Adjacency Rows Edges List and increments its count
        /// </summary>
        /// <param name="vertex">The vertex to be added</param>
        /// <param name="weight">The wieght to be paired with the vertex</param>
        public void AddEdge(Vertex vertex, int weight)
        {
            Tuple<Vertex, int> EdgeToAdd = new Tuple<Vertex, int>(vertex, weight);
            Edges.Add(EdgeToAdd);
            AdjacencyCount += 1;
        }
    }
}
