using System;
using System.Collections.Generic;
using Xunit;
using StacksAndQueues.Classes;

namespace StackAndQueueTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanPushOntoStack()
        {
            Stack<int> testStack = new Stack<int>();

            testStack.Push(11);
            Assert.Equal(11, testStack.Peek());
        }

        [Fact]
        public void CanPushMultipleOntoStack()
        {
            Stack<int> testStack = new Stack<int>();

            testStack.Push(11);
            testStack.Push(27);
            testStack.Push(20);
            Assert.Equal(20, testStack.Peek());
        }

        [Fact]
        public void CanPopOffStack()
        {
            Stack<int> testStack = new Stack<int>();

            testStack.Push(11);
            testStack.Push(27);
            testStack.Push(20);
            Assert.Equal(20, testStack.Peek());

            testStack.Pop();
            Assert.Equal(27, testStack.Peek());

            testStack.Pop();
            Assert.Equal(11, testStack.Peek());

        }

        [Fact]
        public void CanEmptyStack()
        {
            Stack<int> testStack = new Stack<int>();

            testStack.Push(11);
            testStack.Push(27);
            testStack.Push(20);
            Assert.Equal(20, testStack.Peek());

            testStack.Pop();
            Assert.Equal(27, testStack.Peek());

            testStack.Pop();
            Assert.Equal(11, testStack.Peek());

            testStack.Pop();
            Exception expectedException = null;

            try
            {
                testStack.Pop();
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }

            Assert.NotNull(expectedException);
            //Assert.IsType<Exception>(expectedException);
        }
        [Fact]
        public void CanPeekStack()
        {
            Stack<int> testStack = new Stack<int>();

            testStack.Push(11);
            Assert.Equal(11, testStack.Peek());

        }

        [Fact]
        public void CanMakeEmptyStack()
        {
            Stack<int> testStack = new Stack<int>();

            Assert.NotNull(testStack);
        }

        [Fact]
        public void CanEnqueue()
        {
            Queue<int> testQueue = new Queue<int>();

            testQueue.Enqueue(11);
            Assert.Equal(11, testQueue.Peek());
        }

        [Fact]
        public void CanEnqueueMultiple()
        {
            Queue<int> testQueue = new Queue<int>();

            testQueue.Enqueue(11);
            testQueue.Enqueue(27);
            testQueue.Enqueue(20);
            testQueue.Dequeue();
            Assert.Equal(27, testQueue.Peek());

        }

        [Fact]
        public void CanDequeue()
        {
            Queue<int> testQueue = new Queue<int>();

            testQueue.Enqueue(11);
            testQueue.Enqueue(27);
            testQueue.Dequeue();
            Assert.Equal(27, testQueue.Peek());


        }

        [Fact]
        public void CanPeekQueue()
        {
            Queue<int> testQueue = new Queue<int>();

            testQueue.Enqueue(11);
            Assert.Equal(11, testQueue.Peek());
        }

        [Fact]
        public void CanEmptyQueue()
        {
            Queue<int> testQueue = new Queue<int>();

            testQueue.Enqueue(11);
            testQueue.Enqueue(27);
            testQueue.Enqueue(20);
            Assert.Equal(11, testQueue.Peek());


            testQueue.Dequeue();
            Assert.Equal(27, testQueue.Peek());

            testQueue.Dequeue();
            Assert.Equal(20, testQueue.Peek());

            testQueue.Dequeue();
            Exception expectedException = null;

            try
            {
                testQueue.Dequeue();
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }

            Assert.NotNull(expectedException);
        }

        [Fact]
        public void CanMakeEmptyQueue()
        {
            Queue<int> testQueue = new Queue<int>();
            Assert.NotNull(testQueue);
        }
    }
}
