using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    class Stack<T>
    {
        public Node<T> Top { get; set; }

        /// <summary>
        /// Constructor that requires at least one value. 
        /// </summary>
        /// <param name="value"></param>
        public Stack(T value)
        {
            Node<T> node = new Node<T>(value);

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
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Removes the top node from the Stack and returns its value
        /// </summary>
        /// <returns>Value of node being removed</returns>
        public T Pop()
        {
            try
            {
                Node<T> temp = Top;
                Top = Top.Next;
                temp.Next = null;
                return temp.Value;
            }
            catch(NullReferenceException)
            {
                throw new NullReferenceException("No Node Found");
            }
        }

        public T Peek()
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
