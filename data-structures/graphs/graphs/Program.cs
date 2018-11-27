using graphs.Classes;
using System;
using System.Collections.Generic;

namespace graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Graph testGraph = CreateGraph();
            Console.WriteLine("Size");
            Console.WriteLine(testGraph.Size());
            Tuple<Vertex, int>[] CNeighbors = testGraph.GetNeighbors(new Vertex("Node C"));
            Console.WriteLine("Node C neighbors.");
            PrintEdges(CNeighbors);
            Console.WriteLine("Get All Nodes!");
            Vertex[] allNodes = testGraph.GetNodes();
            PrintEdges(allNodes);
            Console.ReadLine();
        }

        static public Graph CreateGraph()
        {
            Vertex NodeA = new Vertex("Node A");
            Vertex NodeB = new Vertex("Node B");
            Vertex NodeC = new Vertex("Node C");
            Vertex NodeD = new Vertex("Node D");
            Vertex NodeE = new Vertex("Node E");
            Vertex NodeF = new Vertex("Node F");

            Graph myGraph = new Graph(NodeA);
            myGraph.AddNewAdjacencyRow(NodeB);
            myGraph.AddEdge(NodeC, NodeD, 5);
            myGraph.AddEdge(NodeC, NodeE, 2);
            myGraph.AddEdge(NodeC, NodeF, 0);

            return myGraph;
        }

        public static void PrintEdges(Tuple<Vertex, int>[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Value: ");
                Console.Write(array[i].Item1.Value);
                Console.Write("  Weight: ");
                Console.Write(array[i].Item2 + "\n");
            }
        }

        public static void PrintEdges(Vertex[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Value: {array[i].Value}");
            }
        }
    }
}
