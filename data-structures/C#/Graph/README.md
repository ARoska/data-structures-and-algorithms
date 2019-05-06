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


------------------------------

## Visuals
***[Add screenshots of your methods in action]***

##### Insert Method
***[In your own words explain what this method is doing]***
*The Insert Method takes in an int as a parameter. A new Node is then created using the* 
*int param as its Value. The new Node is then placed in the Linked List at the Head and*
*the previous Head is assigned as the new Nodes Next.*
![Image 1](https://via.placeholder.com/750x500)
##### Includes Method
***[In your own words explain what this method is doing]***
*The Includes Method takes in an int as a parameter then iterates through the Nodes of the*
*Linked List checking all the Values. If the value is found True is returned, if not then*
*False is returned.*
![Image 1](https://via.placeholder.com/750x500)
##### Print Method
***[In your own words explain what this method is doing]***
*The Print Method displays a well formatted depiction of the current state of the*
*Linked List by iterating over all Nodes.*
![Image 1](https://via.placeholder.com/750x500)

------------------------------

## Change Log
***[The change log will list any changes made to the code base. This includes any changes from TA/Instructor feedback]***
1.3: *Added new passing tests for Contains method* - 17 Nov 2012
1.2: *Fixed bug where Next relation was being lost on Insert* - 14 Nov 2012
1.1: *Fixed formatting for the Print method* - 13 Nov 2012

------------------------------

For more information on Markdown: https://www.markdownguide.org/cheat-sheet