using LinkedList.Classes;
using System;
using LinkedList;
using System.Collections.Generic;

namespace RemoveDuplicatensLL
{
    class Program
    {
        public Node Current { get; set; }
        public Node Head { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public Node LinkedListRemoveDuplicatens(Node node)
        {
            Head = node;
            Current = Head;
            Node temp = null;
            HashSet<Node> dups = new HashSet<Node>();

            while (node != null)
            {
                if (!dups.Contains(node))
                {
                    dups.Add(node);
                    Current = node.Next;
                    temp = Current;
                }
                else
                {
                    temp.Next = Current.Next;
                    Current.Next = null;
                    Current = temp.Next;
                }
            }
            return node;
        }
    }
}
