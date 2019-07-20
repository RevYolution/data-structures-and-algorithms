# Lecture Notes: Insertion Sort
Insertion Sort is considered a simple sort. As such it is a brute force sorting method that meaning it finds the smallest element in an array and swaps it with the first element. Then finds the next smallest and swaps with the second element and so on until the array is sorted. 

Insertion Sort can be done in place giving a space complexity of O(1). It can also allow for an array to be built as items are recieved however, lists over 50 are not optimal for this sort. 

### Algorithm Overview
  Insertion Sort works by iteration. Consuming each element in a list and inserting it into its place within the array. The iteration continues until all elements within the list have been consumed and sorted. The sorted list is grown in place growing the sorted list behind the iteration element. During each iteration the consumed element is compared to the largest value in the list. If the consumed value is greater it is left in place. Otherwise, the vlaue is sorted into its proper place in the list.  

## Learning Objectives

1. Students will be able to describe attributes of an Insertion Sort
2. Stiudents will be able to walk through how an Insertion Sort functions
3. Students will be able to talk about space and time complexity of Insertion Sort


## **Algorithm Walkthrough**
#### *What does Insertion Sort do at a high level?*

1. During an iteration it considers one element 
2. It determines the elements proper place **based on elements already sorted**. 
3. Insertion is done in place
4. Iterations go until entire list have been traveresed

##### *Suggested Algorithm For Insertion Sort*
- Start with an outer loop that will be used to iterate through all elements of the list
- Use a temporary varible to hold the value at the current outerloop index
- Set a new varible (j) to one less than the outer loop index
- Using an inner while loop that runs as long as j is greater than zero and the temporary value is less than j
  - Within the loop move the value of j over one and decrement it back
- When the conditions of the while loop have been broken one of two things must be true
  - j has reached the start of the list
  - The value of j is less than the temporary value and needs to be inserted
- Now the outer loop needs to be increased and the whole proccess started over

## Effiency
##### *Time*
**Best**: The array is sorted and nothing needs to be done. This will only depend on the number of elements in the array giving O(n).

**Worst**: The array is in the reverse order. All elments have to be swapped giving O(n^2).

**Average**: A random assortment of integers still gives a O(n^2) runtime leading this sort to be best for lists under 50.

##### *Space*

Since the sort is done in place a O(1) is given for space. 


## Diagram
![Sort Diagram](https://github.com/RevYolution/data-structures-and-algorithms/blob/master/assets/insertionsort.png)

*Image above from https://www.geeksforgeeks.org/insertion-sort/

## Example Walkthrough
[Walkthrough](https://www.hackerearth.com/practice/algorithms/sorting/insertion-sort/tutorial/)

## Readings And Reference

### Videos
[Geeks for Geeks Video](https://www.youtube.com/watch?v=OGzPmgsI-pQ)

### Links
[Khan Academy Insertion Sort](https://www.khanacademy.org/computing/computer-science/algorithms/insertion-sort/a/insertion-sort)
