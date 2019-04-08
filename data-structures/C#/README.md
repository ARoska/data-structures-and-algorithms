# Binary Tree and Binary Search Tree
#### *Author: Andrew Roska*

------------------------------

## Description
A C# implimentation of both a `Binary Tree` and a `Binary Search Tree`.  A `Binary Tree` is a data structure that contains a `Root Node` and that `Node` can have up to two `Nodes` attached to it as `Left Child` and `Right Child`.  Each `Child Node` can in turn be a `Root Node` for 2 `Child Nodes`, creating the `Tree`.  The paths between `Root` and `Child` are called `Edges` and a `Child` with no `Children` is a `Leaf`.  `Child Nodes` can be attached to any `Root` that does not already have 2 `Children`.

A `Binary Search Tree` is a `Binary Tree` with a special rule on how `Nodes` are added.  When adding a new `Node` the current `Root` is examined, and if the new `Node's Value` is less than the current `Root's Value` the `Node` is placed on the left.  Otherwise it is placed on the right.  If there is already a `Child` on that side, the `Tree` is traversed and the check is run again. 

------------------------------

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Insert | Adds a new `Node` to the `Tree` | O(1) | O(1) | myTree.Insert(99) |


------------------------------

## Visuals

##### Insert Method
![Image 1](https://via.placeholder.com/750x500)

------------------------------

## Change Log
1.0: *Initialization* - 08 April 2019
