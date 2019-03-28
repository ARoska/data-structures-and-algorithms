# Linked List
#### *Author: Andrew Roska*

## Description

A C# implementation of a `Singly Linked List`. Singly Linked Lists contain individual nodes that have a reference to the `Next` node in the list as well as a `Value`. The methods of this `Linked List` are `Insert`, `Insert Before`, `Append`, `Insert After`,  `Includes`, `Print All Nodes`, `Return All Nodes` and `Return Kth From End`.

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Insert | Adds a new `Node` before the `Head` of the `Linked List` | O(1) | O(1) | myList.Insert(Node) |
| Insert Before | Adds a new `Node` to the `Linked List` before the first `Node` with the supplied target `Value` | O(N) | O(1) | myList.InsertBefore(Node, Target) |
| Append | Adds a new `Node` after the `Tail` of the `Linked List` | O(N) | O(1) | myList.Append(Node) |
| Insert After | Adds a new `Node` to the `Linked List` after the first `Node` with the supplied target `Value` | O(N) | O(1) | myList.InsertAfter(Node, Target) |
| Includes | Takes in a value and returns a boolean depending on if the value is in the `LinkedList` | O(N) | O(1) | myList.Includes(99) |
| Print All Nodes | Prints the `Linked List` to the console | O(N) | O(1) | myList.PrintAllNodes() |
| Return All Nodes | Returns an `Array` of all `Values` in the `Linked List` | O(N) | O(N) | myList.ReturnAllNodes() |
| Return Kth From End | Returns the `Value` of the `Node` that is `K` from the end of the `Linked List` | O(N) | O(1) | myList.ReturnKthFromTheEnd(K) |

------------------------------

## Visuals

##### Print Method
*The Print Method displays a well formatted depiction of the current state of the Linked List by iterating over all Nodes.*

![Print Linked List](https://github.com/Roketsu86/data-structures-and-algorithms/blob/master/assets/LinkedListApp/linked-list-print.jpg)

##### Insert Method
*The Insert Method takes in a `Node` as a parameter.  The new Node is then placed in the Linked List at the Head and the previous Head is assigned as the new Nodes Next.*

![Insert](https://github.com/Roketsu86/data-structures-and-algorithms/blob/master/assets/LinkedListApp/linked-list-insert.jpg)

##### Insert Before Method
*The Insert Before Method takes in a `Node` as a parameter as well as a target `Value`.  The new Node is then placed in the Linked List before the `Node` with the target `Value` and the target `Node` is assigned as the new Nodes Next.*

![Insert](https://github.com/Roketsu86/data-structures-and-algorithms/blob/master/assets/LinkedListApp/linked-list-insert-before.jpg)

##### Append Method
*The Append Method takes in a `Node` as a parameter.  The new Node is then placed in the Linked List after the `Tail` the new Node is assigned as the `Tail's` Next.*

![Includes](https://github.com/Roketsu86/data-structures-and-algorithms/blob/master/assets/LinkedListApp/linked-list-append.jpg)

##### Insert After Method
*The Insert After Method takes in a `Node` as a parameter as well as a target `Value`.  The new Node is then placed in the Linked List after the `Node` with the target `Value` and the new Node is assigned as the target `Node's` Next.*

![Insert After](https://github.com/Roketsu86/data-structures-and-algorithms/blob/master/assets/LinkedListApp/linked-list-insert-after.jpg)

##### Includes Method
*The Includes Method takes in an int as a parameter then iterates through the Nodes of the Linked List checking all the Values. If the value is found True is returned, if not then False is returned.*

![Includes](https://github.com/Roketsu86/data-structures-and-algorithms/blob/master/assets/LinkedListApp/linked-list-includes.jpg)

![Doesn't Include](https://github.com/Roketsu86/data-structures-and-algorithms/blob/master/assets/LinkedListApp/linked-list-doesnt-include.jpg)

##### Return All Nodes Method
*The Return All Nodes Method returns an array of the current `Values` in the Linked List by iterating over all Nodes.*

![Includes](https://github.com/Roketsu86/data-structures-and-algorithms/blob/master/assets/LinkedListApp/linked-list-return-all.jpg)

##### Return Kth From The End Method
*The Return Kth From The End Method returns the current `Value` of the `K` Node from the end of the Linked List by iterating over all Nodes to find the Kth Node.*

![Includes](https://github.com/Roketsu86/data-structures-and-algorithms/blob/master/assets/LinkedListApp/linked-list-return-k-from-end.jpg)

##### Merge Method
*Given two `Linked Lists` merge them togethe into a single `List` in a "zipper" manner (alternating `Nodes` from each `List`).  Returns a reference to the new `Head Node`.*

![Merge](https://github.com/Roketsu86/data-structures-and-algorithms/blob/master/assets/LinkedListApp/linked-list-merge.jpg)


------------------------------

## Change Log
1.3: *Added Merge Method* - 27 March 2019

![Mege Whiteboard](https://github.com/Roketsu86/data-structures-and-algorithms/blob/master/assets/LinkedListApp/ll_merge-wb.jpg)

1.2: *Added Return Kth From End Method* - 27 March 2019

![Kth From End Whiteboard](https://github.com/Roketsu86/data-structures-and-algorithms/blob/master/assets/LinkedListApp/ll_kth_from_end-wb.jpg)

1.1: *Added Insert Before, Insert After and Append Methods* - 26 March 2019

![Insertions Whiteboard](https://github.com/Roketsu86/data-structures-and-algorithms/blob/master/assets/LinkedListApp/ll_insertions-wb.jpg)

1.0: *Initial build* - 24 March 2019

------------------------------
