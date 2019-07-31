# Get Edges
A C# algorithm challenge implementation.

## Challenge
Given an array and graph determine if the traversal is possible from one index to another. If it is return the weight of the edges taversed. 

## Approach & Implementation
The array is iterated thorough to check if there is an edge present between the current index and the next index. If the two contain an edge the weight of the edge is added to a counter. If all indicies are connected the counter is returned with the weight of the edges. If any of the indices in order do not contain an edge to the next index the counter is reset and returned. 

### Big O
- **Time**: O(n)
  - If all indices are connected all idicies are visited given O(n).
- **Space**: O(1)
  - No additional storage is used. 

## Solution
![GetEdge Whiteboard](https://github.com/RevYolution/data-structures-and-algorithms/blob/master/assets/GetEdges%20Whiteboard.jpg)
