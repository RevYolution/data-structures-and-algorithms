# Find Tree Depth
A C# algorithm challenge implementation to see if all characters in string are unique.

## Challenge
Write a function that determines if all characters contained in a string are unique.

## Approach & Efficiency
This solution utilizes a HashSet to compare the characters of a string. If the character is not contained in the HashSet it is added. If any character is already contianed in the HashSet a false is return otherwise all the characters are unique and a true is returned. 

### Big O
- **Time**: O(n)
  - The whole string must be traversed in order to give a true. 
- **Space**: O(n)
  - Utilizing the HashSet adds new memory that needs to be taken into account. 
