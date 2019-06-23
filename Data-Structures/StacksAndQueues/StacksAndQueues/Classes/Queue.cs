using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    class Queue
    {
        Node Front { get; set; }
        Node Rear { get; set; }

        public Queue(int value)
        {
            Node node = new Node(value);
            Front = node;
            Rear = node;
        }

        public Queue()
        {

        }

        public void Enqueue(int value)
        {
            Node node = new Node(value);
            node.Next = Rear;
            Rear = node;
        }

        public int Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp.Value;
        }

        public int Peek()
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
