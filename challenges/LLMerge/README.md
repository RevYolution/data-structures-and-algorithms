# ***Link List Merge***
------------------------------

# Link List Merge
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

Double click on the ```LLMerge``` directory.

Then select and open ```LLMerge.sln```

------------------------------

## Visuals


##### WhiteBoard
![LLMerge Whiteboard](https://github.com/RevYolution/data-structures-and-algorithms/blob/master/assets/LLMerge%20Whiteboard.jpg)
##### Using the Application
Coming Soon
##### Application End
Coming Soon
------------------------------
## Approach & Efficiency
Take in two link lists and set the current node of each list to the head of the respective list. While neither the first or second list current value is null the following will execute. Move the second list current pointer to the next node in the list. Then the head of the second list next pointer will be set to the current next pointer of list one. List one current next pointer will change to point to the head of the second list. The current node of the first list will be set to the next pointer of the head of the second list. Last the head of the second list will change to the current node of the second list. Once compelete the list will be returned.  
### Big O
**Time**: O(n)  
**Space**: O(1)

## Change Log

