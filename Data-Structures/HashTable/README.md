# Hash Table
**Author: Jon Rice**

## Overview

At its core a *Hash Table* is an array of key value pairs. Key value pairs are assigned indcies within the array by a hashing algorithm. Typically the value associated with characters of the key are summed, divided by a large prime number and modulod by the current length of the array. The result will give a unique number that is associated with the index the key value will reside. 

There is the possibility that two keys are mapped to the same index. This results in a collision. One of two things can occur when a collision happens. Either the second item can be added to the bucket, utilizing a linked list or a tree, or the array can be resized. When rezizing occurs all pairs that are in the current array must be rehashed and assigned again. This is becuase the index value is directly dependant on the size of the array. 

The implementation here utilizes a Linked List to handle collisions. 

## Methods
| Method | Summary | Big O Time | Big O Space |
| :----: | :-----: | :--------: | :---------: |
| Add | Takes in a key and a value, and adds the value to the table at the index of the hashed key. | O(1) | O(1) | 
| Get | Takes in a key and returns the value at the index of the hashed key. | O(1) | O(1) | 
| Contains | Takes in a key and checks if a value exists at the index of the hashed key. | O(1) | O(1) | 
| Hash | Takes in a key and uses that key to generate a number. | O(1) | O(1) | 
