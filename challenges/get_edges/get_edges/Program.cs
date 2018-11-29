using System;
using graphs.Classes;

namespace get_edges
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is a demo for the GetEdges method.");
            Console.WriteLine("Creating a graph with vertecies and egdes.");
            Vertex STL = new Vertex("St. Louis");
            Vertex SEA = new Vertex("Seattle");
            Vertex LAX = new Vertex("LA");
            Vertex BOS = new Vertex("Boston");
            Vertex ATL = new Vertex("Atlanta");
            Vertex MIA = new Vertex("Miami");

            Graph myGraph = new Graph(STL);
            myGraph.AddEdge(STL, SEA, 82);
            myGraph.AddEdge(STL, LAX, 37);
            myGraph.AddEdge(STL, MIA, 26);
            myGraph.AddEdge(STL, ATL, 105);
            myGraph.AddEdge(STL, BOS, 99);
            myGraph.AddEdge(SEA, BOS, 150);
            myGraph.AddEdge(BOS, ATL, 42);
            myGraph.AddEdge(ATL, MIA, 73);
            myGraph.AddEdge(MIA, LAX, 250);

            Console.WriteLine("Testing");
            
            Vertex[] test1 = { STL, SEA };
            Vertex[] test2 = { BOS, ATL, MIA };
            Vertex[] test3 = { MIA, SEA };
            Vertex[] test4 = { LAX, BOS, STL };

            Console.WriteLine("St. Louis to Seattle");
            Console.WriteLine(GetEdge(myGraph, test1));

            Console.WriteLine("Boston to Atlanta to Miami");
            Console.WriteLine(GetEdge(myGraph, test2));

            Console.WriteLine("Miami to Seattle");
            Console.WriteLine(GetEdge(myGraph, test3));

            Console.WriteLine("LA to Boston to St. Louis");
            Console.WriteLine(GetEdge(myGraph, test4));

            Console.ReadLine();
        }

        public static string GetEdge(Graph graph, Vertex[] array)
        {
            bool resultBool = true;
            int resultTotal = 0;
            int i = 0;
            while (resultBool && i < array.Length - 1)
            {
                Tuple<Vertex, int>[] checkRow = graph.GetNeighbors(array[i]);
                bool found = false;
                for (int j = 0; j < checkRow.Length; j++)
                {
                    if (checkRow[j].Item1.Value == array[i + 1].Value)
                    {
                        found = true;
                        resultTotal += checkRow[j].Item2;
                    }
                }
                if (!found)
                {
                    resultBool = false;
                    resultTotal = 0;
                }
                i++;
            }

            return $"{resultBool}, {resultTotal}";
        }
    }
}
