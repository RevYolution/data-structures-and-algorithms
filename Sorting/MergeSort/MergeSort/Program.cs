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

                for (int j = 0; j < midPoint; j++)
                {
                    rightOfMid[j] = array[midPoint+j];
                }
                return Merge(leftOfMid, rightOfMid);
            
        }

        public static int[] Merge(int[] left, int[] right)
        {
            return right;
        }

        static void Main(string[] args)
        {
            int[] exampleArray = new int[] { 5, 2, 8, 1, 3, 61, 15, 4, 6, 9, 7, 11, 25, 45 };
            Console.WriteLine($"Example unsotred array: {string.Join(",", exampleArray)}");
            MergeSort(exampleArray);
            Console.WriteLine($"Example array sorted: {string.Join(",", exampleArray)}");
        }
    }
}
