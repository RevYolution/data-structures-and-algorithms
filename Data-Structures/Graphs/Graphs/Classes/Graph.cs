using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs.Classes
{
    class Graph<T>
    {
        Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }
        public int _size;

        public Graph()
        {
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
        }

        public Vertex<T> AddVertex(T value)
        {
            Vertex<T> vertex = new Vertex<T>(value);
            AdjacencyList.Add(vertex, new List<Edge<T>>());
            _size++;
            return vertex;
        }

        public void AddDirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
        {
            AdjacencyList[a].Add(
                new Edge<T>
                {
                    Weight = weight,
                    Vertex = b
                });
        }

        public void AddUndirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
        {
            AddDirectedEdge(a, b, weight);
            AddDirectedEdge(b, a, weight);
        }

        public List<Vertex<T>> GetVertices()
        {
            List<Vertex<T>> vertices = new List<Vertex<T>>();
            foreach(var item in AdjacencyList)
            {
                vertices.Add(item.Key);
            }
            return vertices;
        }

        public Dictionary<Vertex<T>, int> GetNeighbors(Vertex<T> findMe)
        {
            Dictionary<Vertex<T>, int> vertices = new Dictionary<Vertex<T>, int>();
            foreach (var item in AdjacencyList[findMe])
            {
                vertices.Add(item.Vertex, item.Weight);

            }

            return vertices;
        }

        public int Size()
        {
            return _size;   
        }
    }
}