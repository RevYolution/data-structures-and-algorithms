﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LList
    {
        public Node Current { get; set; }
        public Node Head { get; set; }

        /// <summary>
        /// Adds new node at the start of the list
        /// </summary>
        /// <param name="value">Value of the added node</param>
        public void Insert(int value)
        {
            Node node = new Node(value) { Next = Head};
            node.Next = Head;
            Head = node;
        }

        /// <summary>
        /// Prints list as a string
        /// </summary>
        /// <returns>String that contains the node values</returns>
        public string Print()
        {
            StringBuilder builder = new StringBuilder();
            Current = Head;
            while (Current != null)
            {
                builder.Append(Current.Value);
                if (Current.Next != null) builder.Append(" => ");
                Current = Current.Next;
            }
            return builder.ToString();
        }


        /// <summary>
        /// Determines if a list contains a value
        /// </summary>
        /// <param name="value">Value being searched for in the list</param>
        /// <returns></returns>
        public bool Includes(int value)
        {
            Current = Head;
            while (Current != null)
            {
                if (Current.Value == value) return true;
                else Current = Current.Next;
            }
            return false;
        }

        /// <summary>
        /// Adds new node at the end of a list
        /// </summary>
        /// <param name="value">Value to be added to the end of the list</param>
        public void Append(int value)
        {
            Node endNode = new Node(value);
            if (Head is null) Head = endNode;
            else
            {
                Current = Head;
                while (Current.Next != null)
                {
                    Current = Current.Next;
                }
                Current.Next = endNode;
            }
        }

        /// <summary>
        /// Adds a new node in front of a target node 
        /// </summary>
        /// <param name="target">Node added in front of</param>
        /// <param name="value">Value of the added node</param>
        public void InsertBefore(int target, int value)
        {
            if(Head != null)
            {
                if (target == Head.Value) Insert(value);
                else
                {
                    Current = Head;
                    while (Current.Next != null)
                    {
                        if (Current.Next.Value == target)
                        {
                            Node addedNode = new Node(value) { Next = Current.Next };
                            Current.Next = addedNode;
                            break;
                        }
                        Current = Current.Next;
                    }
                }
            }
        }

        /// <summary>
        /// Adds new node after target node
        /// </summary>
        /// <param name="target">Node to be added after</param>
        /// <param name="value">Value of the node being added</param>
        public  void InsertAfter(int target, int value)
        {
            Current = Head;
            while (Current != null)
            {
                if (Current.Value == target)
                {
                    Node addedNode = new Node(value) { Next = Current.Next };
                    Current.Next = addedNode;
                    break;
                }
                Current = Current.Next;
            }
        }

        public int FindKthFromEnd(int k)
        {
            Current = Head;
            int counter = 0;
            if(k < 0)
            {
                throw new ArgumentOutOfRangeException("k is out of range. Please choose a non negative number.");
            }

            while(Current.Next != null)
            {
                counter++;
                Current = Current.Next;
            }

            if(k > counter)
            {
                throw new ArgumentOutOfRangeException("k is too large. Please choose a smaller value for k.");
            }

            while(k < counter)
            {
                counter--;
                Current = Current.Next;
            }
            return Current.Value;
        }
    }

}
