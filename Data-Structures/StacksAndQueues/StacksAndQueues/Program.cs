using System;
using System.Collections.Generic;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stack<int> stack = new Stack<int>();

            stack.Push(11);
            stack.Push(20);
            stack.Pop();
            stack.Pop();
        }
    }
}
