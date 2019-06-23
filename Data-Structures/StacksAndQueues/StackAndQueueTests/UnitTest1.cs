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

        //[Fact]
        //public void CanEmptyStack()
        //{
        //    Stack<int> testStack = new Stack<int>();

        //    testStack.Push(11);
        //    testStack.Push(27);
        //    testStack.Push(20);
        //    Assert.Equal(20, testStack.Peek());

        //    testStack.Pop();
        //    Assert.Equal(27, testStack.Peek());

        //    testStack.Pop();
        //    Assert.Equal(11, testStack.Peek());

        //    testStack.Pop();
        //    Assert.Null(testStack.);
        //}

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

        //[Theory]
        //[InlineData()]
        //[InlineData()]
        //[InlineData()]
        //[InlineData()]
        //[InlineData()]
        //public void CanEnqueue()
        //{

        //}

        //[Fact]
        //public void CanEnqueueMultiple()
        //{

        //}

        //[Theory]
        //[InlineData()]
        //[InlineData()]
        //[InlineData()]
        //[InlineData()]
        //[InlineData()]
        //public void CanDequeue()
        //{

        //}

        //[Fact]
        //public void CanPeekQueue()
        //{

        //}

        //[Fact]
        //public void CanEmptyQueue()
        //{

        //}

        //[Fact]
        //public void CanMakeEmptyQueue()
        //{

        //}
    }
}
