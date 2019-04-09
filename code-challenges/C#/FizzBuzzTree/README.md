# FizzBuzz Tree
#### *Author: Andrew Roska*

------------------------------

## Description
Performs "FizzBuzz" on a `Binary Tree`.  In FizzBuzz each value is examined, and then converted if it matches one of the following requirements:
- Value evenly divisable by 3 = Fizz
- Value evenly divisable by 5 = Buzz
- Value evenly divisable by both 3 and 5 = FizzBuzz

The modified `Binary Tree` is then returned to the user.

------------------------------

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| FizzBuzz | Primary method call, takes in a `Binary Tree` and returns the modified `Tree` | O(1) | O(1) | FizzBuzz(`Tree`) |
| PreOrderMod | Secondary method called by `FizzBuzz`.  Recursively traverses `Binary Tree` in a `Root` first fashion and converts `Values` based on description above | O(n) | O(1) | PreOrderMod(`Root Node`) |


------------------------------

## Change Log
1.0: *Initial Build* - 09 April 019

![FizzBuzzTree Whiteboard]()

------------------------------
