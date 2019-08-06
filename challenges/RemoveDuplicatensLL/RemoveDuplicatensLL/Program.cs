using LinkedList.Classes;
using System;
using LinkedList;
using System.Collections.Generic;

namespace RemoveDuplicatensLL
{
    public class Program
    {
        public static Node Current { get; set; }
        public static Node Head { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node test1 = new Node(1);
            Node test2 = new Node(1);
            Node test3 = new Node(1);
            Node test4 = new Node(1);

            test1.Next = test2;
            test2.Next = test3;
            test3.Next = test4;

            Node sendNode = test1;
            LinkedListRemoveDuplicatens(sendNode);
        }

        public static Node LinkedListRemoveDuplicatens(Node node)
        {
            Head = node;
            Current = Head;
            Node temp = null;
            HashSet<int> dups = new HashSet<int>();

            while (Current != null)
            {
                if (!dups.Contains(Current.Value))
                {
                    dups.Add(Current.Value);
                    Current = Current.Next;
                    temp = Current;
                }
                else
                {
                    temp.Next = Current.Next;
                    Current.Next = null;
                    Current = temp.Next;
                }
            }
            return Head;
        }
    }
}
