# ***Breadth Traversal of Binary Tree***
------------------------------

# Breadth First
##### *Author: Jon Rice*

------------------------------

### Description

Console application that traverses a Binary Tree in a breadth first way outputing each value in order. 
------------------------------

## Getting Started
Clone this repository to your local machine.
```
$ git clone [https://github.com/RevYolution/data-structures-and-algorithms.git]
```
#### To run the program from Visual Studio:
Select ```File``` -> ```Open``` -> ```Project/Solution```

Next navigate to the location you cloned the Repository.

Double click on the ```BreadthFirst``` directory.

Then select and open ```BreadthFirst.sln```

------------------------------

## Visuals


##### WhiteBoard
![BreadthFirst Whiteboard](https://github.com/RevYolution/data-structures-and-algorithms/blob/master/assets/BreadthFirst%20WhiteBoard.jpg)
##### Using the Application
Coming Soon
##### Application End
Coming Soon
------------------------------
## Approach & Efficiency
Take in a tree and traverse the tree using Breath First traversial. The funciton will set up an empty queue and enqueue the root into the queue. It then checks to see if there is a value at the front of the queue and if there is sets the front value equal to it and prints it. Following that it checks to see if the front has any children and enqueues those values if present. The function repeats this proccess until there is nothing in the queue.  
### Big O
**Time**: O(n)  
**Space**: O(w)

## Change Log

