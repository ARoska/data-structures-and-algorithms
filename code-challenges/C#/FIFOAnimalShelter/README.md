# FIFO Animal Shelter
#### *Author: Andrew Roska*

------------------------------

## Description
Create a class called AnimalShelter which holds only dogs and cats. The shelter operates using a first-in, first-out approach. If a cat or dog isn’t preferred, return whichever animal has been waiting in the shelter the longest.

------------------------------

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Enqueue(Animal) | Adds a new `Animal` to the end of either the `Cat Queue` or the `Dog Queue`.  A `Name` must be given to the `Animal`. `Animal` can only be `Cat` or `Dog`. | O(1) | O(1) | AnimalShelter.Enqueue(Animal, Name) |
| Dequeue(Pref) | Returns either a `Cat` or `Dog` to the user.  If `Pref` is not `Cat` or `Dog` then the oldest `Animal` in the `Queue` is returned. | O(1) | O(1) | AnimalShelter.Dequeue(Pref) |


------------------------------

## Change Log
1.0: *Implements the AnimalShelter Class* - 02 April 2019
![Animal Shelter Whiteboard]()
