using System;
using Xunit;
using MergeSort;

namespace MergeSortTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanArrayOfOne()
        {
            int[] testArray = new int[] { 20 };
            int[] expectedResult = { 20};
            int[] testResult = Program.MergeSort(testArray);
            Assert.Equal(expectedResult, testResult);
        }

        [Fact]
        public void CanReturnNull()
        {
            int[] testArray = new int[0];
            int[] testResult = Program.MergeSort(testArray);
            Assert.Null(testResult);
        }
    }
}
