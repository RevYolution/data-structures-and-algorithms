using System;

namespace ArrayShift
{
   public class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,2,3,4,5};
            int insertion = 11;
            Console.WriteLine(String.Join(", ", ShiftArray(array, insertion)));
            ShiftArray(array, insertion);
        }
        /// <summary>
        /// Takes in an array and inserts given number at mid point of the array
        /// </summary>
        /// <param name="array">Integer array</param>
        /// <param name="insertion">Integer to be inserted at midpoint</param>
        /// <returns></returns>
        static int[] ShiftArray(int[] array, int insertion)
        {
            int middle = array.Length / 2;
            int[] newArray = new int[array.Length + 1];
            int counter = 0;

            for (int i = 0; i < newArray.Length; i++)
            {
                if (i == middle)
                {
                    newArray[i] = insertion;
                }
                else
                {
                    newArray[i] = array[counter];
                    counter++;
                }
            }
            return newArray;
        }
    }
}
