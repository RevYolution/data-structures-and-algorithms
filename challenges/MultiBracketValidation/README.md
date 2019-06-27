# ***Multi Bracket Validation***
------------------------------

# Bracket Validation
##### *Author: Jon Rice*

------------------------------

### Description

Console application that allows users to input a string and verify that brackets are paired. 
------------------------------

## Getting Started
Clone this repository to your local machine.
```
$ git clone [https://github.com/RevYolution/data-structures-and-algorithms.git]
```
#### To run the program from Visual Studio:
Select ```File``` -> ```Open``` -> ```Project/Solution```

Next navigate to the location you cloned the Repository.

Double click on the ```MultiBracketValidation``` directory.

Then select and open ```MultiBracketValidation.sln```

------------------------------

## Visuals


##### WhiteBoard
![MultiBracketValidation Whiteboard](https://github.com/RevYolution/data-structures-and-algorithms/blob/master/assets/Bracket%20Whiteboard.jpg)
##### Using the Application
Coming Soon
##### Application End
Coming Soon
------------------------------
## Approach & Efficiency
Take in a string and iterate through the string finding all (,{, or [. When a bracket ), }, or ] is found pop off associated stack if nothing to pop return false. When at the end of the string peek at each stack if there is a value return false else return true. 
### Big O
**Time**: O(n)  
**Space**: O(n)

## Change Log

