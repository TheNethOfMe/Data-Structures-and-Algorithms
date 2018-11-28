using System;
using Xunit;
using graphs;
using graphs.Classes;

namespace TestGraph
{
    public class UnitTest1
    {
        [Fact]
        // Should create a Graph
        public void ShouldCreateAGraph()
        {
            Graph test = Program.CreateGraph();
            Assert.Equal(6, test.Size());
        }

        [Fact]
        // Should add single node to Graph
        public void ShouldAddNode()
        {
            Vertex NodeA = new Vertex("Cat");
            Graph test = new Graph();
            test.AddEdge(NodeA);
            int testNeighbors = test.GetNeighbors(NodeA).Length;
            Assert.Equal(0, testNeighbors);
        }

        [Fact]
        // Should add an edge and new node to graph
        public void ShouldCreateEdge()
        {
            Vertex NodeA = new Vertex("Cat");
            Vertex NodeB = new Vertex("Dog");
            Graph test = new Graph();
            test.AddEdge(NodeA);
            test.AddEdge(NodeA, NodeB);
            Tuple<Vertex, int> testNeighbor = test.GetNeighbors(NodeA)[0];
            Assert.Equal("Dog", testNeighbor.Item1.Value);
        }

        [Fact]
        // Should add an edge with weight
        public void ShouldCreateEdgeWithWeight()
        {
            Vertex NodeA = new Vertex("Cat");
            Vertex NodeB = new Vertex("Dog");
            Graph test = new Graph();
            test.AddEdge(NodeA);
            test.AddEdge(NodeA, NodeB, 12);
            Tuple<Vertex, int> testNeighbor = test.GetNeighbors(NodeA)[0];
            Assert.Equal(12, testNeighbor.Item2);
        }

        [Theory]
        // Should get neighbors
        [InlineData(0, "Node D")]
        [InlineData(1, "Node E")]
        [InlineData(2, "Node F")]
        public void ShouldGetNeighbors(int i, string val)
        {
            Graph test = Program.CreateGraph();
            Tuple<Vertex, int>[] CNeighbors = test.GetNeighbors(new Vertex("Node C"));
            Assert.Equal(val, CNeighbors[i].Item1.Value);
        }

        [Theory]
        // Should get weights accociated with edges
        [InlineData(0, 5)]
        [InlineData(1, 2)]
        [InlineData(2, 0)]
        public void ShouldGetNeighborsWeights(int i, int val)
        {
            Graph test = Program.CreateGraph();
            Tuple<Vertex, int>[] CNeighbors = test.GetNeighbors(new Vertex("Node C"));
            Assert.Equal(val, CNeighbors[i].Item2);
        }

        [Theory]
        // Should get nodes
        [InlineData(0, "Node A")]
        [InlineData(1, "Node B")]
        [InlineData(2, "Node C")]
        [InlineData(3, "Node D")]
        [InlineData(4, "Node E")]
        [InlineData(5, "Node F")]
        public void ShouldGetAddNodes(int i, string val)
        {
            Graph test = Program.CreateGraph();
            Vertex[] allNodes = test.GetNodes();
            Assert.Equal(val, allNodes[i].Value);
        }

        [Fact]
        // Size should be 0 by default
        public void SizeShouldBeZero()
        {
            Graph test = new Graph();
            Assert.Equal(0, test.Size());
        }

        [Fact]
        // Size should be 1 if graph is created with a vertex
        public void SizeShouldBeOne()
        {
            Graph test = new Graph(new Vertex("Dog"));
            Assert.Equal(1, test.Size());
        }

        [Fact]
        // Should update size when new egdes are added
        public void SizeShouldUpdate()
        {
            Graph test = new Graph(new Vertex("Dog"));
            test.AddEdge(new Vertex("Cat"));
            Assert.Equal(2, test.Size());
        }

        [Fact]
        // Should NOT update size when new egdes are added if nodes already exist
        public void SizeShouldNotUpdate()
        {
            Vertex NodeA = new Vertex("Cat");
            Vertex NodeB = new Vertex("Dog");
            Graph test = new Graph(NodeA);
            test.AddEdge(NodeB);
            test.AddEdge(NodeB, NodeA);
            Assert.Equal(2, test.Size());
        }
    }
}
