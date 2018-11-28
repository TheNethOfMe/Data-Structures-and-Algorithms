# Graphs

## Challenge

Implement a Graph with the following methods

1. AddEdge(Vertex, Vertex, int) - This takes in two Verticies (one parent and one child), creates adjacency rows for either if they don't already exist in the graph, and puts the child in the dependancy list of the parent. This method can optionally take in an integer representing a weight. The weight is set to 0 if omitted.
1. AddEdge(Vertex) - This is an overload method that just takes one Vertex and creates an adjacency row for it if one doesn't exist on the graph.
1. GetNodes() - This returns all of the Verticies in the graph as an array.
1. GetNeighbors(Vertex) - This returns an array of Tuples. The method will search for an adjacency row with a Key Vertex that matches the Vertex passed into the method as an argument. All of the Verticies as well as their accociated weights are returned in the array.
1. Size() - Returns the number of Verticies in the Graph.

## Strategry

Because I don't like to just haphazardly collect generic lists of generic lists, I decided to give my graphs a little more structure. The graphs will contain a list of AdjacencyRows which is a utility class consisting of a key vertex and a list of adjacency vertecies and accociated weights. 

## How to Run

You can interact with this and run a short demo by running `dotnet run` from the graphs directory. This also features a full test suite which can be run with the `dotnet test` command from the TestGraph directory.