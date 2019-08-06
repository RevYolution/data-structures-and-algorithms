# Find Binary Tree Height
A C# algorithm challenge implementation that finds the height of a Binary Tree.

## Challenge
Write a function that determines the height of a given binary tree.

## Approach & Efficiency
This solution uses a recursive, depth first traversal to find the tree's height. 
Each time the method is run, the root node of the sub-tree is checked if it is null. If it is, the current height is returned as 0.
If not, the height of the left and right sub trees are compared. The greater of the two height is then returned.

### Big O
- **Time**: O(n)
  - Must traverse whole tree giving O(n) of the size of the tree.
- **Space**: O(h)
  - The space is equal to the height of the call stack at any given time.
