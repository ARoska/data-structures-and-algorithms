# Multi-Bracket Validation
#### *Author: Andrew Roska*

------------------------------

## Description
A simple C# application that uses a `Stack` model to check any string for balanced brackets (`()` or  `{}` or `[]`).  Every opening bracket must be matched in proper order with a closing bracket, meaning that if the closing brackets are all present but not in the correct order the check will still fail.

------------------------------

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| MultibracketValidation | Takes in a `string` and compares opening brackets against closing brackets using a `Stack` | O(n) | O(n) | MultibracketValidation(`string`) |
| Compare | Helper Method used to compare the current closing bracked against the top of the `Stack` | O(1) | O(1) | Compare(`char`, `Stack`) |


------------------------------

## Visuals

##### MultibracketValidation Method
*Loops across the input `string` checking each individual `char`.  If the `char` in question is an opening bracket then it is pushed onto the `Stack`.  If the `char` is a closing bracket `Compare()` is invoked.  If `Compare()` ever retruns `false` the `string` is unbalanced and the Method returns `false`.  If the loop successfully traverses the `string` then the brackets are balanced and `true` is returned.*

![MultiBracket Validation Demo](https://github.com/Roketsu86/data-structures-and-algorithms/blob/master/assets/MultiBracketValidation/MultiBracketValidation%20-%20demo.jpg)

##### Compare Method
*Helper Method called when a closing bracket is found.  Checks the current `Stack` to ensure that there is something on top, and if there is compares the top to the closing bracket that was passed in.  If the they match returns `true`, otherwise returns `false`.*

------------------------------

## Change Log
1.0: *Initial build* - 04 April 2019
![Whiteboard](https://github.com/Roketsu86/data-structures-and-algorithms/blob/master/assets/MultiBracketValidation/MultiBracketValidation%20-%20wb.jpg)
