# Hash Table
#### *Author: Andrew Roska*

------------------------------

## Description
A C# implementation of a `Hash Table`.  A `Hash Table` is a Data Structure that stores `Key:Value` pairs.  The location of the pairs in the `Hash Table` is determined by running the `Key` through a `Hashing` algorythm to get an index value.  That value is then used to determine the position in the `Hash Table` array.  Because the specific index is always targetted, the best-case Big O is always O(1).  

If the `Hashing` algorythm is not a `Perfect Hash` then it is possible to get the same `Hash Key` from multiple different `Keys`.  This is referred to as a `Collision`.  Because of this, each index in the `Hash Table` array contains a `Linked List` called a `Bucket`.  If a `Collision` occures the `Key:Value` pair is inserted at the front of the `Bucket`.  Each `Bucket` can contain multiple `Key:Value` pairs, and so retreival of the values in a `Hash Table` with an imperfect `Hash` results in a O(n) Time.

------------------------------

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Hash | Hashes the given Key string | O(1) | O(1) | myHashTable.Hash(Key) |
| Add | Adds the Key:Value string pair to the HashTable based on thier Key | O(1) | O(1) | myHashTable.Add(Key, Value) |
| Remove | Removes the Key:Value string pair from the HashTable based on thier Key | O(n) | O(1) | myHashTable.Remove(Key, Value) |
| Get | Returns the Key:Value string pair based on the input Key | O(n) | O(1) | myHashTable.Get(Key) |
| Contains | Returns true if at least one Key:Value pair exists at Key | O(1) | O(1) | myHashTable.Contains(Key) |
| ContainsUnique | Returns true if Key:Value is found in HashTable | O(n) | O(1) | myHashTable.ContainsUnique(Key, Value) |


------------------------------

## Change Log
1.1: *Adds Remove and ContainsUnique methods* - 1 May 2019
1.0: *Initialization* - 29 April 2019

------------------------------
