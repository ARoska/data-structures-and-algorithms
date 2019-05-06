# Graph
#### *Author: Graph*

------------------------------

## Description
A C# implementation of a `Graph`. A `Graph` is a large data structure consisting of `Vertices` (or `Nodes`).  Each `Vertex` can be connected to any, all, or none of the other `Vertices` via an `Edge`.  `Edges` can be single-direction or bi-directional, and each `Edge` carries a given `Weight` value.  A `Vertex` cluster of `Vertices` is called an `Island`.

------------------------------

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| AddNode | Adds a new `Node` to the `Graph` | O(1) | O(1) | myGraph.AddNode(99) |
| AddUndirectedEdge | Adds a new, undirected `Edge` to `NodeA` in the `Graph`.  This `Edge` carries a `Weight` and points towards `NodeB` in the `Graph` | O(1) | O(1) | myGraph.AddUndirectedEdge(NodeA, NodeB, 99) |
| AddDirectedEdge | Adds a new, Directed `Edge` between `NodeA` and `NodeB` in the `Graph`.  This `Edge` carries a `Weight` | O(1) | O(1) | myGraph.AddDirectedEdge(NodeA, NodeB, 99) |
| GetNodes | Retruns a list of all `Nodes` in the `Graph` | O(n) | O(n) | myGraph.GetNodes() |
| GetNeighbors | Retruns a list of all adjacent `Edges` extending out from the given `Node` in the `Graph` along with the weights associated | O(n) | O(n) | myGraph.GetNeighbors(Node) |
| Size | Returns the total size of the `Graph` | O(1) | O(1) | myGraph.Size() |


## Change Log
1.0: *Initial build* - 06 May 2019
