using System;
using Xunit;
using graphs.Classes;
using get_edges;

namespace TestGetEdges
{
    public class UnitTest1
    {
        [Fact]
        // Should Return a string with True and the Weight
        public void ShouldReturnTrueWithWeight()
        {
            Vertex STL = new Vertex("St. Louis");
            Vertex SEA = new Vertex("Seattle");

            Graph myGraph = new Graph(STL);
            myGraph.AddEdge(STL, SEA, 82);

            Vertex[] test = { STL, SEA };
            Assert.Equal("True, 82", Program.GetEdge(myGraph, test));
        }

        [Fact]
        // Should Return False with 0
        public void ShouldReturnFalse()
        {
            Vertex STL = new Vertex("St. Louis");
            Vertex SEA = new Vertex("Seattle");
            Vertex MIA = new Vertex("Miami");

            Graph myGraph = new Graph(STL);
            myGraph.AddEdge(STL, SEA, 82);
            myGraph.AddEdge(STL, MIA, 26);

            Vertex[] test = { MIA, SEA };
            Assert.Equal("False, 0", Program.GetEdge(myGraph, test));
        }

        [Fact]
        // Should Properly add up weights
        public void ShouldCalculateWeightsWhenTrue()
        {
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

            Vertex[] test = { BOS, ATL, MIA, LAX };
            Assert.Equal("True, 365", Program.GetEdge(myGraph, test));
        }
    }
}
