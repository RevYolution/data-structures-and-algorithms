# Remove Duplicate Nodes from a Linked List
A C# algorithm challenge implementation that removes any duplicate value nodes from a linked list.

## Challenge
Write a function that determines if there are any duplicate value nodes contained in a linked list. Remove the nodes and return the modified list.

## Approach & Efficiency
This solution traverses the linked list adding values to a HashSet. If any vlaue is already contained in the HashSet the node is removed. The node is removed by setting the previously added nodes next value to the current nodes next value. Then the current nodes next value is set to null and removed by garbage collection. Once the linked list is traversed the modified list is returned.  

### Big O
- **Time**: O(n)
  - The solution must traverse thought the entire list.
- **Space**: O(n)
  - The solution utilizes a new HashSet but returns the linked list that is modified in place.
