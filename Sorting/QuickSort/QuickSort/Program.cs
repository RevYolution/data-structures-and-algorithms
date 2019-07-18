using System;

namespace QuickSort
{
    public class Program
    {
        /// <summary>
        /// Partitions an array based off the high value of the given array as a pivot point. 
        /// </summary>
        /// <param name="array">Array provided to the function</param>
        /// <param name="lowValue">First element in the array</param>
        /// <param name="highValue">Last element in the array</param>
        /// <returns></returns>
        static int Partition(int[] array, int lowValue, int highValue)
        {
            int pivot = array[highValue];
            int i = (lowValue - 1);

            for (int j = lowValue; j < highValue; j++)
            {
                //If the element being compared is less than the pivot value
                if (array[j] <= pivot)
                {
                    i++;
                    //Swaps the elements 
                    int tempValueLow = array[i];
                    array[i] = array[j];
                    array[j] = tempValueLow;
                }
            }

            //Creates new pivot
            int tempValueHigh = array[i + 1];
            array[i + 1] = array[highValue];
            array[highValue] = tempValueHigh;

            return i + 1;
        }

        /// <summary>
        /// Method that does the recursive sort of the array 
        /// </summary>
        /// <param name="array">Array to be sorted</param>
        /// <param name="lowValue">Starting index</param>
        /// <param name="highValue">Ending index</param>
        public static int[] QuickSort(int[] array, int lowValue, int highValue)
        {
            if (lowValue < highValue)
            {
                int partitionIndex = Partition(array, lowValue, highValue);

                //Recursive sort elements lower than the partition
                QuickSort(array, lowValue, partitionIndex - 1);

                //Recursive sort elements higher than the partition
                QuickSort(array, partitionIndex + 1, highValue);
            }
            return array;
        }

        static void Main(string[] args)
        {
            int[] exampleArray = new int[] { 5, 2, 8, 1, 3, 61, 15, 4, 6, 9, 7, 11, 25, 45 };
            int n = exampleArray.Length;
            Console.WriteLine($"Example unsorted array: {string.Join(",", exampleArray)}");
            QuickSort(exampleArray, 0, n - 1);
            Console.WriteLine($"Example array sorted: {string.Join(",",exampleArray)}");
        }
    }
}
