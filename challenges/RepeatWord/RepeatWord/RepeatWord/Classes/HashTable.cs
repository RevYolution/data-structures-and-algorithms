using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable.Classes
{
    public class Hashtable
    {
        public LinkedList<Node>[] Map { get; set; }

        public Hashtable()
        {

        }

        public Hashtable(int size)
        {
            // Creates Linked List array to the needed size
            Map = new LinkedList<Node>[size];

        }

        public int GetHash(string key)
        {
            int total = 0;
            // Adds all Char values of the key
            for (int i = 0; i < key.Length; i++)
            {
                total += key[i];
            }
            
            int primeValue = total * 599;

            // Modulo by the size of the array
            return primeValue % Map.Length;
        }


        public void Add(string key, int value)
        {
            int index = GetHash(key);
            // Check to see if bucket is empty
            if (Map[index] != null)
            {
                // Add item to head of the list
                Map[index].AddFirst(new Node(key, value));
            }
            else
            {
                // Creates a Linked List if bucket is not empty
                Map[index] = new LinkedList<Node>();
                Map[index].AddFirst(new Node(key, value));
            }
        }


        // Look up and get the value of a node in the table. 
        public int Get(string key)
        {
            int index = GetHash(key);

            var node = Map[index].First;
            try
            {

            while (node != null)
            {
                if (node.Value.Key == key)
                {
                    return node.Value.Value;
                }
            }
            }
            catch
            {
                throw new Exception($"{key} not found");
            }
            return index;
        }

        // Contains
        public bool Contains(string key)
        {
            if (Get(key) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
