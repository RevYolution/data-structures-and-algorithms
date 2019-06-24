using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    class Queue<T>
    {
        Node<T> Front { get; set; }
        Node<T> Rear { get; set; }

        /// <summary>
        /// Requires a queue with an input value set to the from and rear.
        /// </summary>
        /// <param name="value">Value of node to be input.</param>
        public Queue(T value)
        {
            Node<T> node = new Node<T>(value);
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// Allows for an empty queue to be set up. 
        /// </summary>
        public Queue()
        {

        }

        /// <summary>
        /// Adds a node to the rear of the queue. 
        /// </summary>
        /// <param name="value">The value of the node being added</param>
        public void Enqueue(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = Rear;
            Rear = node;
        }

        /// <summary>
        /// Removes a node from the front of the queue and returns its value. 
        /// </summary>
        /// <returns>Value of the node being returned from the queue</returns>
        public T Dequeue()
        {
            Node<T> temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp.Value;
        }

        /// <summary>
        /// Looks at the front of the queue and returns the value that is there. Returns NullReference if none exists.
        /// </summary>
        /// <returns>Value of the front node of the queue.</returns>
        public T Peek()
        {
            try
            {
                return Front.Value;
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException("Front Not Found");
            }
        }
    }
}
