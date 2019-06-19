using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LList
    {
        public Node Current { get; set; }
        public Node Head { get; set; }
        public LList()
        {

        }

        public LList(int value)
        {
            Node node = new Node(value);
            Head = node;
        }

        public void Insert(int value)
        {
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
        }

        public void Print()
        {
            Node current = Head;
            while (current != null)
            {
                Console.Write($"{current.Value} => ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
        public bool Includes(int value)
        {
            while (Current != null)
            {
                if (Current.Value == value) return true;
                else Current = Current.Next;
            }
            return false;
        }
    }

}
