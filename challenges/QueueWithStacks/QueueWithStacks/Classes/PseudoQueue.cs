using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class PseudoQueue<T>
    {
        private Stack<T> PushStack { get; set; }
        private Stack<T> PopStack { get; set; }

        public PseudoQueue()
        {
            PushStack = new Stack<T>();
            PopStack = new Stack<T>();
        }

        private void FillPopStack(Stack<T> start, Stack<T> finish)
        {
            while(start.Top != null)
            {
                finish.Push(start.Pop());
            }
        }

        public void Enqueue(T node)
        {
            FillPopStack(PopStack, PushStack);
            PushStack.Push(node);
        }

        public T Dequeue()
        {
            FillPopStack(PushStack, PopStack);
            if (PopStack.Top is null) throw new InvalidOperationException("Queue empty please add more.");
            else return PopStack.Pop();
        }
    }
}
