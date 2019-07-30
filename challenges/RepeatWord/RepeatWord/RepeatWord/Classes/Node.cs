using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable.Classes
{
    public class Node
    {
        public string Key { get; set; }
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(string key, int value)
        {
            Key = key;
            Value = value;
        }
    }
}
