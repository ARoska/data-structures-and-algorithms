# Tree Intersection
#### *Author: Andrew Roska*

------------------------------

## Description
This challenge was to take in two `Binary Trees` and determine any shared values between them.  A `List` of values is then returned.  A `HashTable` is used to store the values of the first tree, and then the second tree's values are checked agains that table.  If the value in the second tree is found already in the `HashTable` then the value is added to the return list.  In order to prevent possible false-positives, any time a value is found in the `HashTable` it is removed.

------------------------------

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| TreeIntersection | Returns a list of all values shared by two Binary Trees | O(n) | O(n) | TreeIntersection(treeOne, treeTwo) |


------------------------------
##### White Board
![Tree Intersection White Board](https://via.placeholder.com/750x500)

------------------------------

## Change Log
1.0: *Initial Build* - 01 May 2019
