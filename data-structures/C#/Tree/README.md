# Binary Tree and Binary Search Tree
#### *Author: Andrew Roska*

------------------------------

## Description
A C# implimentation of both a `Binary Tree` and a `Binary Search Tree`.  A `Binary Tree` is a data structure that contains a `Root Node` and that `Node` can have up to two `Nodes` attached to it as `Left Child` and `Right Child`.  Each `Child Node` can in turn be a `Root Node` for 2 `Child Nodes`, creating the `Tree`.  The paths between `Root` and `Child` are called `Edges` and a `Child` with no `Children` is a `Leaf`.  `Child Nodes` can be attached to any `Root` that does not already have 2 `Children`.

A `Binary Search Tree` is a `Binary Tree` with a special rule on how `Nodes` are added.  When adding a new `Node` the current `Root` is examined, and if the new `Node's Value` is less than the current `Root's Value` the `Node` is placed on the left.  Otherwise it is placed on the right.  If there is already a `Child` on that side, the `Tree` is traversed and the check is run again. 

------------------------------

## Binary Tree Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Add | Adds a new `Node` to the `Binary Tree` in a top-to-bottom, left-to-right approach | O(n) | O(w) w = width of the `Tree` | myTree.Add(Node) |
| BreadthFirst | Traverses the `Binary Tree` in a top-to-bottom, left-to-right approach, printing and returning a `List` of all values | O(n) | O(w) w = width of the `Tree` | myTree.BreadthFirst() |
| PreOrder | Returns a list of all `Nodes` in `Root` first order | O(n) | O(h) h = call stack height | myTree.PreOrder(Root Node, Empty List) |
| InOrder | Returns a list of all `Nodes` in `Left Child` first order | O(n) | O(h) h = call stack height | myTree.InOrder(Root Node, Empty List) |
| PostOrder | Returns a list of all `Nodes` in `Left Child` and `Right Child` first order | O(n) | O(h) h = call stack height | myTree.PostOrder(Root Node, Empty List) |

## Binary Search Tree Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Add | Adds a `Node` to the `BST` based on how large it is | O(log n) | O(h) h = call stack height | myTree.Add(Node) |
| Contains | Returns `True` if the value is in the `BST` | O(log n) | O(h) h = call stack height | myTree.Contains(value) |

------------------------------

## Visuals

##### Breadth First Whiteboard
![Breadth First Whiteboard](https://github.com/Roketsu86/data-structures-and-algorithms/blob/master/assets/Tree/BreadthFirst-WB.jpg)

------------------------------

## Change Log
1.1: *Adds Breadth First Add and Traversal Methods* - 10 April 2019

1.0: *Initialization* - 08 April 2019
