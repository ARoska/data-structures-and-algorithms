# Depth-First Traversal of a Graph
#### *Author: Andrew Roska*

------------------------------

## Description
Create a function that accepts a graph, and conducts a depth first traversal. Return a collection of nodes in their pre-order depth-first traversal order.

This process is done via recursion.  The method takes in a `Graph` and a `Node` to start at (called the `Root`).  A new `List` is created and the helper Method `Traverse` is called to fill the `List` out.

------------------------------

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| DepthFirstPreOrder | Accepts a `Graph`, a `Root Node` and returns a `List` of `Nodes` in the `Graph`  | O(n) | O(n) | DepthFirstPreOrder(Graph, Root) |
| Traverse (helper Method) | Accepts a `Graph`, a `Root Node` and a `List` and returns a `List` of `Nodes` in the `Graph`  | O(n) | O(n) | Traverse(Graph, Root, List) |


------------------------------

## Visuals

##### Depth-First Graph Traversal White Board
![Depth-First Graph Traversal White Board](https://via.placeholder.com/750x500)

## Change Log
1.0: *Initial Build* - 09 May 2019
