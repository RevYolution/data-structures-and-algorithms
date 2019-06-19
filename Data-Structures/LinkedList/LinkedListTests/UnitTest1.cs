using System;
using Xunit;
using LinkedList.Classes;

namespace LinkedListTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanMakeAList()
        {
            LList testList = new LList();
            Assert.NotNull(testList);
        }

        [Fact]
        public void CanInsertIntoList()
        {
            LList testList = new LList();
            testList.Insert(20);
            Assert.Equal(20, testList.Head.Value);
        }

        [Fact]
        public void HeadPointsToFirstNode()
        {
            LList testList = new LList();
            testList.Insert(20);
            testList.Insert(11);
            Assert.Equal(20, testList.Head.Next.Value);
        }

        [Fact]
        public void CanAddMultipleNodesToList()
        {
            LList testList = new LList();
            testList.Insert(20);
            testList.Insert(11);
            Assert.NotNull(testList.Head.Next);
        }

        [Fact]
        public void CanFindValueInListTrue()
        {
            LList testList = new LList();
            testList.Insert(20);
            Assert.True(testList.Includes(20));
        }

        //    [Fact]
        //    public void CanReturnAllNodeValues()
        //    {

        //    }

        //    [Theory]
        //    [InlineData(1, 1)]
        //    [InlineData(2, 2)]
        //    [InlineData(3, 3)]
        //    [InlineData(10, 10)]
        //    [InlineData(20, 20)]
        //    public void CanAddNodeToEndOfList(int expected, int node)
        //    {

        //    }

        //    [Fact]
        //    public void CanAddMultipleNodesToEndOfList()
        //    {

        //    }

        //    [Fact]
        //    public void CanAddBeforeANode()
        //    {

        //    }

        //    [Fact]
        //    public void CanAddNodeAtStartOfList()
        //    {

        //    }

        //    [Fact]
        //    public void CanAddNodeToMiddleOfList()
        //    {

        //    }

        //    [Fact] 
        //    public void CanAddToEndofList()
        //    {

        //    }

    }
}
