using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to set the length of your array:");
            string arraySize = Console.ReadLine();
            int sizeOfArray = Convert.ToInt32(arraySize);
            int[] emptyArray = new int[sizeOfArray];
            Console.WriteLine("Input numbers one at a time in ascending order into your array");

            for (int i = 0; i < emptyArray.Length; i++)
            {
                Console.WriteLine($"Input number {i+1} of {emptyArray.Length}");
                string arrayInput = Console.ReadLine();
                int arrayNumbers = Convert.ToInt32(arrayInput);
                emptyArray[i] = arrayNumbers;
            }

            //Console.WriteLine($"Your array is [{emptyArray}]");
            Console.WriteLine("Enter a number in your array you would like to know the index of");
            string searchKeyInput = Console.ReadLine();
            int searchKeyNumber = Convert.ToInt32(searchKeyInput);
            {

            }


           int searchArray = BinarySearch(emptyArray, searchKeyNumber);

            Console.WriteLine($"The index of {searchKeyNumber} is {searchArray}.");
        }

        public static int BinarySearch(int[] arr, int searchKey)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                double startingM = Math.Floor((double)(left + right) / 2);
                int m = Convert.ToInt32(startingM);
                if (arr[m] < searchKey)
                {
                    left = m + 1;
                }
                else if (arr[m] > searchKey)
                {
                    right = m - 1;
                }
                else
                {
                    return m;
                }
            }
            return -1;
        }
    }
}
