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

## Visuals


##### Push Method
*The Push Method takes in a `Node` as a prameter and places that `Node` at the top of the `Stack`.*
![Image 1](https://via.placeholder.com/750x500)
##### Pop Method
*The Pop Method removes the `Node` at the top of the `Stack` and returns any data that `Node` may have been holding.*
![Image 1](https://via.placeholder.com/750x500)
##### Peek (Stack) Method
*The Peek (Stack) Method returns the data in the `Node` at the top of the `Stack`.  This should always be used to confirm that a `Node` is present before using Pop().*
![Image 1](https://via.placeholder.com/750x500)
##### Enqueue Method
*The Enqueue Method takes in a `Node` as a prameter and places that `Node` at the back of the `Queue`.*
![Image 1](https://via.placeholder.com/750x500)
##### Dequeue Method
*The Dequeue Method removes the `Node` at the front of the `Queue` and returns any data that `Node` may have been holding.*
![Image 1](https://via.placeholder.com/750x500)
##### Peek (Queue) Method
*The Peek (Queue) Method returns the data in the `Node` at the front of the `Queue`.  This should always be used to confirm that a `Node` is present before using Dequeue().*
![Image 1](https://via.placeholder.com/750x500)


------------------------------

## Change Log
1.0: *Initial build* - 01 April 2019
