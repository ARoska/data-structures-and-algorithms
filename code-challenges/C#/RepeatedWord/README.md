# Repeated Word
#### *Author: Andrew Roska*

------------------------------

## Description
This challenge is to take in a lengthy string, typically one or mor paragraphs, and return the first word that repeats.  I solved the challenge using a `HashTable`.  The lengthy string is split into individual words and added to an array, and then the array is traversed.  Each word in the array is checked as a `Key` in the `HashTable` and if there is a match then the word is returned.  If no matches are found then `null` is returned.

------------------------------

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| RepeatedWord | Returns the first word to be repeated in a string of words, or null | O(n) | O(n) | RepeatedWord(string) |


------------------------------

## Visuals

![Repeated Word Whiteboard](https://via.placeholder.com/750x500)

## Change Log
1.0: *First build* - 30 April 2019
