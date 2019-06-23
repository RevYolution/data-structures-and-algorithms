# ***Binary Search Console Application***
------------------------------

# Binary Search
##### *Author: Jon Rice*

------------------------------

## Description
Console application that allows users to build a sorted array and find the index of an element in their array.

------------------------------

## Getting Started
Clone this repository to your local machine.
```
$ git clone [https://github.com/RevYolution/data-structures-and-algorithms.git]
```
#### To run the program from Visual Studio:
Select ```File``` -> ```Open``` -> ```Project/Solution```

Next navigate to the location you cloned the Repository.

Double click on the ```BinarySearch``` directory.

Then select and open ```BinarySearch.sln```

------------------------------

## Visuals


##### WhiteBoard
![Binary Search Whiteboard](https://github.com/RevYolution/data-structures-and-algorithms/blob/master/assets/Binary%20Search%20Whiteboard.jpg)
##### Using the Application
![Binary Search Start](https://github.com/RevYolution/data-structures-and-algorithms/blob/master/assets/Binary%20Search%20Start.PNG)
![Binary Search progress](https://github.com/RevYolution/data-structures-and-algorithms/blob/master/assets/Binary%20Search%20progress.PNG)
##### Application End
![Binary Search End](https://github.com/RevYolution/data-structures-and-algorithms/blob/master/assets/Binary%20Search%20End.PNG)

------------------------------
## Approach & Efficiency
Once a sorted array is set up the upper and lower bounds of the array are set. The middle index is calculated by dividing the sum of the bounds by 2. A search key is given and the middle index is compared to the key. If the index is less than the search key the lower bound is set to the middle index added to one. If the index is greater than the search key the upper bound is set to the middle index minus one. The comarison continues until the index is equal to the search key or is not found which results in an error.  

### Big O
**Time**: O(n)  
**Space**: O(1)

## Change Log
1.1 Added conformation of outside bounds test. 
