# Remove Duplicate Characters in a String
A C# algorithm challenge implementation that removes duplicate characters from a string.

## Challenge
Write a function that removes any duplicate characters from a string and return the modified string.

## Approach & Efficiency
For each character in a string are added to a HashSet. Given that there cannot be any duplicate values in a HashSet any duplicates will not be added to the HashSet. Once the string has been traversed stringify the HashSet and return the modified string. 

### Big O
- **Time**: O(n)
  - The solution must go through the whole string.
- **Space**: O(n)
  - The addition of a new HashSet.
