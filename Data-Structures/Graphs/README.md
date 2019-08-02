# Graph
**Author**: Jon Rice

## Description
A **Graph** is a data structure where data is stored in a collection of **Verticies**.
Each of these nodes has a **value** and a collection of verticies that can be accessed from that vertex.
A connection between verticies in a graph is called an **Edge**, and in a **Weighted Graph** each edge is given a **Weight**.

A graph can be represented through an **adjacency matrix**.


### Types of Graphs
- In a **directed graph**, edges are traversed in a single direction. A -> B is possible but not B -> A.
- In an **undirected graph**, edges are taversed in any direction. A -> B or B -> A.
- In a **complete graph**, all verticies are connected to one another.
- In a **connected graph**, it is possible to traverse to every vertex but not directly.
- A **cyclic graph** is a directional graph that allows traversal back to the starting vertex. 
- An **acyclic graph** is a directional graph that does not allow traversal back to the starting vertex. 

All of these types of graphs can be created in this implementation.

## Methods
| Method | Summary | Big O Time | Big O Space |
| :----: | :-----: | :--------: | :---------: | 
| AddNode | Adds a vertex | O(1) | O(1) |
| AddEdge | Creates an edge between two verticies | O(1) | O(1) |
| GetNodes | Gets all verticies in the graph | O(1) | O(n) |
| GetNeighbors | Gets all neighboring verticies of a given vertex | O(n) | O(n) |
| Size | Gets the number of verticies in the graph | O(1) | O(1) |

## Whiteboard
![Breadth First Graph](https://github.com/RevYolution/data-structures-and-algorithms/blob/master/assets/BreadthFirst%20Graph%20Whiteboard.jpg)
