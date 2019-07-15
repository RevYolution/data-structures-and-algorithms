using System;

namespace InsertionSort
{
    class Program
    {
        public static int[] InsertionSort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                temp = array[i];
                for (int j = i-1; j >= 0; j--)
                {
                    if (array[j] > temp)
                    {
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                    else break;
                }
            }

            return array;
        }

        static void Main(string[] args)
        {
            int[] exampleArray = new int[] { 5, 2, 8, 1, 3, 61, 15, 4, 6, 9, 7, 11, 25, 45 };
            Console.WriteLine($"Example unsotred array: {string.Join(",",exampleArray)}");
            InsertionSort(exampleArray);
            Console.WriteLine($"Example array sorted: {string.Join(",",exampleArray)}");
        }
    }
}
