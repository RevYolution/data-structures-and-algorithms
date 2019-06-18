using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    class LList
    {
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
            Node searchValue = new Node(value);
            while (searchValue != value)
            {

            }
        }
    }

}
