using QuickSort;
using System;
using Xunit;

namespace QuickSortTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnArrayOfOne()
        {
            int[] testArray = new int[] { 20 };
            int[] expectedResult = { 20 };
            int n = testArray.Length;
            int[] testResult = Program.QuickSort(testArray, 0, n - 1);
            Assert.Equal(expectedResult, testResult);
        }

        [Fact]
        public void CanReturnArrayOfZero()
        {
            int[] testArray = new int[] { };
            int[] expectedResult = { };
            int n = testArray.Length;
            int[] testResult = Program.QuickSort(testArray, 0, n - 1);
            Assert.Equal(expectedResult, testResult);
        }

        [Fact]
        public void CanSortEvenArray()
        {
            int[] testArray = new int[] { 6, 7, 1, 9, };
            int[] expectedResult = new int[] { 1, 6, 7, 9 };
            int n = testArray.Length;
            int[] testResult = Program.QuickSort(testArray, 0, n - 1);
            Assert.Equal(expectedResult, testResult);
        }

        [Fact]
        public void CanSortOddArray()
        {
            int[] testArray = new int[] { 5, 8, 3, 9, 7 };
            int[] expectedResult = new int[] { 3, 5, 7, 8, 9 };
            int n = testArray.Length;
            int[] testResult = Program.QuickSort(testArray, 0, n - 1);
            Assert.Equal(expectedResult, testResult);
        }

        [Fact]
        public void CanSortArrayWithMultiples()
        {
            int[] testArray = new int[] { 5, 8, 3, 9, 7, 3 };
            int[] expectedResult = new int[] { 3, 3, 5, 7, 8, 9 };
            int n = testArray.Length;
            int[] testResult = Program.QuickSort(testArray, 0, n - 1);
            Assert.Equal(expectedResult, testResult);
        }

        [Fact]
        public void CanSortArrayWithMultipleMultiples()
        {
            int[] testArray = new int[] { 5, 8, 5, 3, 9, 8, 7, 3 };
            int[] expectedResult = new int[] { 3, 3, 5, 5, 7, 8, 8, 9 };
            int n = testArray.Length;
            int[] testResult = Program.QuickSort(testArray, 0, n - 1);
            Assert.Equal(expectedResult, testResult);
        }
    }
}
