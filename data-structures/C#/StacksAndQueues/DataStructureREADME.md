# Stacks and Queues
#### *Author: Andrew Roska*

------------------------------

## Description
A C# implementation of a `Stacks and Queues`. A `Stack` refers to one or more `Nodes` in a First-in-Last-out order, where the first `Node` added to the `Stack` is the last `Node` processed.  A `Queue` refers to one or more `Nodes` in a First-in-First-out arrangement where the most recently added `Node` is the first to be processed.

------------------------------

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| MyStack | Creates a new, empty `Stack` | O(1) | O(1) | new MyStack() |
| Push | Adds a new `Node` to the top of the `Stack` | O(1) | O(1) | myStack.Push(`Node`) |
| Pop | Removes the top `Node` of the `Stack`, returning the `Node's` data | O(1) | O(1) | myStack.Pop() |
| MyQueue | Creates a new, empty `Queue` | O(1) | O(1) | new MyStack() |
| Enque | Adds a new `Node` to the back of the `Queue` | O(1) | O(1) | myQueue.Enque(`Node`) |
| Dequeue | Removes the front `Node` of the `Queue`, returning the `Node's` data | O(1) | O(1) | myQueue.Dequeue() |
| Peek (Stack) | Returns the data of the top `Node` in the `Stack`.  Should always be used before using `Pop`. | O(1) | O(1) | myStack.Peek() |
| Peek (Queue) | Returns the data of the front `Node` in the `Queue`.  Should always be used before using `Pop`. | O(1) | O(1) | myQueue.Peek() |



------------------------------

## Change Log
1.0: *Initial build* - 01 April 2019
