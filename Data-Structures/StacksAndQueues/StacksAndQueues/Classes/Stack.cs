using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    class Stack
    {
        public Node Top { get; set; }

        /// <summary>
        /// Constructor that requires at least one value. 
        /// </summary>
        /// <param name="value"></param>
        public Stack(int value)
        {
            Node node = new Node(value);

            Top = node;
        }

        /// <summary>
        /// Allows for creation of empty stack.
        /// </summary>
        public Stack()
        {
                
        }

        /// <summary>
        /// Adds a new node to the top of the stack. 
        /// </summary>
        /// <param name="value">Value associated with the node</param>
        public void Push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Removes the top node from the Stack and returns its value
        /// </summary>
        /// <returns>Value of node being removed</returns>
        public int Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp.Value;
        }

        public int Peek()
        {
            try
            {
                return Top.Value;
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException("No Node Found");
            }
        }
    }
}
