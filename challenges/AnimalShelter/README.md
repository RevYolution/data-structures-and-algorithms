# ***FIFO Animal Shelter***
------------------------------

# FIFO Animal Shelter
##### *Author: Jon Rice*

------------------------------

## Description
Console application that allows users to add/addopt dog or cat objects in a  virtual animal shelter. Preferances for which animal the user would like to addopt is taken in and the animal first in queue of that type is given to the user. If no preferance is stated the animal that has been in the shelter longest is returned. 
------------------------------

## Getting Started
Clone this repository to your local machine.
```
$ git clone [https://github.com/RevYolution/data-structures-and-algorithms.git]
```
#### To run the program from Visual Studio:
Select ```File``` -> ```Open``` -> ```Project/Solution```

Next navigate to the location you cloned the Repository.

Double click on the ```AnimalShelter``` directory.

Then select and open ```AnimalShelter.sln```

------------------------------

## Visuals


##### WhiteBoard
![AnimalShelter Whiteboard](https://github.com/RevYolution/data-structures-and-algorithms/blob/master/assets/AnimalShelter%20Whiteboard.JPG)
##### Using the Application
Coming Soon
##### Application End
Coming Soon
------------------------------
## Approach & Efficiency
Set up two queues one for dogs and one for cats. When Enqueueing check to see if the object is a dog or cat and add it to the rear of the queue. When a preferance for type of object is taken in Dequeue will check to see if matches dog or cat. If does not match it will return null otherwise it will return the front of the respective queue and add to that counter present by one. If no preferance is given the dog and cat counters will be compared and the lower counter queue will dequeue and then reset the other counter.  
### Big O
**Time**: O(1)  
**Space**: O(1)

## Change Log

