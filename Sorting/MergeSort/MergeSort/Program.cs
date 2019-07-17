using System;

namespace MergeSort
{
    public class Program
    {
        public static int[] MergeSort(int[] array)
        {
            int[] leftOfMid;
            int[] rightOfMid;
            int[] sortedArray = new int[array.Length];
            int n = array.Length;
            int midPoint = n / 2;

            if (n <= 1)
                return array;
            leftOfMid = new int[midPoint];

            if (n % 2 == 0)
            {
                rightOfMid = new int[midPoint];
            }
            else
            {
                rightOfMid = new int[midPoint + 1];
            }

            for (int i = 0; i < midPoint; i++)
            {
                leftOfMid[i] = array[i];
            }

            int x = 0;
            for (int i = midPoint; i < array.Length; i++)
            {
                rightOfMid[x] = array[i];
                x++;
            }

            leftOfMid = MergeSort(leftOfMid);
            rightOfMid = MergeSort(rightOfMid);
            sortedArray = Merge(leftOfMid, rightOfMid);
            return sortedArray;
            

        }

        public static int[] Merge(int[] left, int[] right)
        {
            int arrayLength = left.Length + right.Length;
            int[] resultArray = new int[arrayLength];

            int leftIndex = 0;
            int rightIndex = 0;
            int resultIndex = 0;

            while (leftIndex < left.Length || rightIndex < right.Length)
            {
                if (leftIndex < left.Length && rightIndex < right.Length)
                {
                    if (left[leftIndex] <= right[rightIndex])
                    {
                        resultArray[resultIndex] = left[leftIndex];
                        leftIndex++;
                        resultIndex++;
                    }
                    else
                    {
                        resultArray[resultIndex] = right[rightIndex];
                        rightIndex++;
                        resultIndex++;
                    }
                }
                else if (leftIndex < left.Length)
                {
                    resultArray[resultIndex] = left[leftIndex];
                    leftIndex++;
                    resultIndex++;
                }
                else if (rightIndex < right.Length)
                {
                    resultArray[resultIndex] = right[rightIndex];
                    rightIndex++;
                    resultIndex++;
                }
            }
            return resultArray;
        }

        static void Main(string[] args)
        {
            int[] exampleArray = new int[] { 5, 2, 8, 1, 3, 61, 15, 4, 6, 9, 7, 11, 25, 45 };
            Console.WriteLine($"Example unsotred array: {string.Join(",", exampleArray)}");
            //MergeSort(exampleArray);
            Console.WriteLine($"Example array sorted: {string.Join(",", MergeSort(exampleArray))}");
        }
    }
}
