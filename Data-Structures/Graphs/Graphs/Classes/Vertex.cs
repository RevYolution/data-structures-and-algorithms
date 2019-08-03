using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Vertex<T>
    {
        public T Value { get; set; }

        public bool isVisited { get; set; }

        public Vertex (T value)
        {
            Value = value;
        }
    }
}
