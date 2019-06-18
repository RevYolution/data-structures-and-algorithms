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
        }

        [Fact]
        public void CanInsertIntoList()
        {

        }

        [Fact]
        public void HeadPointsToFirstNode()
        {

        }

        [Fact]
        public void CanAddMultipleNodesToList()
        {

        }

        [Theory]
        [InlineData(true, 3)]
        [InlineData(false, 205)]
        public void CanFindValueInList(bool expected, int value)
        {

        }

        [Fact]
        public void CanReturnAllNodeValues()
        {

        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(10, 10)]
        [InlineData(20, 20)]
        public void CanAddNodeToEndOfList(int expected, int node)
        {

        }

        [Fact]
        public void CanAddMultipleNodesToEndOfList()
        {

        }

        [Fact]
        public void CanAddBeforeANode()
        {

        }

        [Fact]
        public void CanAddNodeAtStartOfList()
        {

        }

        [Fact]
        public void CanAddNodeToMiddleOfList()
        {

        }

        [Fact] 
        public void CanAddToEndofList()
        {

        }

    }
}
