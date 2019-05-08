# Get Edges
#### *Author: Andrew Roska*

------------------------------

## Description
Given a business trip itinerary, and an Alaska Airlines route map, is the trip possible with direct flights? If so, how much will the total trip cost be?


------------------------------

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| GetEdges | Returns the total value of all edges if direct path exists, otherwise returns null | O(1) | O(1) | myList.GetEdges(Map, Itinerary) |


------------------------------

## Visuals

##### Get Edges
*Takes in a map and a path as an array of strings and determines if the array of strings can be visited in direct order in the map.  If successful, the total sum of all weights in the path is returned.  If there is no direct path from one position in the next returns null.*

![Image 1](https://via.placeholder.com/750x500)

## Change Log
1.0: *Initial Build* - 05 May 2019
