using System;
using Xunit;
using InsertionSort;

namespace InsertionSortTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanSortEmpty()
        {
            int[] testArry = new int[0];
            int[] testResults = Program.InsertionSort(testArry);
            Assert.Empty(testResults);
        }

        [Fact]
        public void CanSortSingle()
        {
            int[] testArray = new int[] { 20 };
            int[] expectedResult = new int[] { 20 };
            int[] testResult = Program.InsertionSort(testArray);
            Assert.Equal(expectedResult, testResult);
        }

        [Fact]
        public void CanSortAlreadySorted()
        {
            int[] testArray = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] expectedResult = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] testResult = Program.InsertionSort(testArray);
            Assert.Equal(expectedResult, testResult);
        }

        [Fact]
        public void CanSortReversedArray()
        {
            int[] testArray = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expectedResult = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] testResult = Program.InsertionSort(testArray);
            Assert.Equal(expectedResult, testResult);
        }

        [Fact]
        public void CanSortRandomArray()
        {
            int[] testArray = new int[] { 4, 1, 2, 18, 13, 20, 84, 6, 19 };
            int[] expectedResult = new int[] { 1, 2, 4, 6, 13, 18, 19, 20, 84 };
            int[] testResult = Program.InsertionSort(testArray);
            Assert.Equal(expectedResult, testResult);
        }
    }
}
