using System;
using Xunit;
using BinarySearch;

namespace BinaryTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0,1)]
        [InlineData(1,2)]
        [InlineData(2,3)]
        [InlineData(3,4)]
        [InlineData(4,5)]
        [InlineData(5,6)]
        [InlineData(6,7)]


        public void CanBinarySearch(int expected, int searchKey)
        {
            int[] testArray = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            Assert.Equal(expected, Program.BinarySearch(testArray, searchKey));
        }
    }
}
