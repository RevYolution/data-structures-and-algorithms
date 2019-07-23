# ***Tree Intersection***
------------------------------

# Tree Intersection
##### *Author: Jon Rice*

------------------------------

### Description

Console application that allows users to input two trees and find any common values. 
------------------------------

## Getting Started
Clone this repository to your local machine.
```
$ git clone [https://github.com/RevYolution/data-structures-and-algorithms.git]
```
#### To run the program from Visual Studio:
Select ```File``` -> ```Open``` -> ```Project/Solution```

Next navigate to the location you cloned the Repository.

Double click on the ```TreeIntersection``` directory.

Then select and open ```TreeIntersection.sln```

------------------------------

## Visuals


##### WhiteBoard
![Tree Intersection Whiteboard](https://github.com/RevYolution/data-structures-and-algorithms/blob/master/assets/Repeat%20Word%20Whiteboard.jpg)
##### Using the Application
Coming Soon
##### Application End
Coming Soon
------------------------------
## Approach & Efficiency
Take in two trees and traverse the first tree and hash all nodes into a hash table. Traverse the second tree and create a linked list whenever there is a collision and the values are the same. When a collision occurs add to the collision counter and after traversing the second tree crate a new array with length eqaul to the number of the collisions. Search the hash table for any bucket that is greater than one and add the head of the list to the array. Return the array for all values that occur in both trees. 
### Big O
**Time**: O(h)  
**Space**: O(2n)

## Change Log

