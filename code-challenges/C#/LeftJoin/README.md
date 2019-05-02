# Left Join
#### *Author: Andrew Roska*

------------------------------

## Description
Takes in two `Hash Tables`, and performs a `Left Join` on them.  All values from the first table are added to a list, followed by any values in the second table with a matching key.  If table two does not have a matching key, `null` is added after the first value.  The key and values are added in the following order: `[key, value1, value2]`.

------------------------------

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| LeftJoin | Left Joins two Hash Tables | O(n) | O(n) | LeftJoin(tableOne, tableTwo) |

------------------------------

## White Board
![Left Join White Board](https://github.com/ARoska/data-structures-and-algorithms/blob/master/assets/LeftJoin/LeftJoin%20WB.jpg)

------------------------------

## Change Log
1.0: *Initial Build* - 01 May 2019
