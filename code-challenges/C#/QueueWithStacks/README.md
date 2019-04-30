# Stacks And Queues
### *PseudoQueue**
#### *Author: Andrew Roska*

## Description

Create a brand new `PseudoQueue Class` without using the existing `Queue Class`. Instead, `this PseudoQueue Class` will implement our standard queue interface, but will internally only utilize 2 `Stack` objects. The `Stack` instances have only `Push`, `Pop`, and `Peek` methods.

------------------------------
## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| MyPseudoQueue | Creates a new, empty `PseudoQueue` | O(1) | O(1) | new MyPseudoQueue() |
| Enque | Adds a new `Node` to the back of the `PseudoQueue` | O(1) | O(1) | myPseudoQueue.Enque(`Node`) |
| Dequeue | Removes the front `Node` of the `PseudoQueue`, returning the `Node's` data | O(1) | O(1) | myPseudoQueue.Dequeue() |
| Peek | Returns the data of the front `Node` in the `PseudoQueue` while leaving the `PseudoQueue` intact.  Should always be used before using `Dequeue`. | O(1) | O(1) | myPseudoQueue.Peek() |

------------------------------

## Change Log
1.0: *Initial Creation of PsuedoQueue Class* - 1 April 2019


------------------------------
