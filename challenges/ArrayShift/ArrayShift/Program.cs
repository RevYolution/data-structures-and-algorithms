using System;

namespace ArrayShift
{
   public class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,2,3,4,5};
            int insertion = 11;
            Console.WriteLine(",", insertShiftArray(array, insertion));
            insertShiftArray(array, insertion);
        }
        // Floor half way point. Create new empty array and add in values from previous values with addition of new value. Create if else statement related to midpoint. Add a counter.  
        public static int[] insertShiftArray(int[] array, int insertion)
        {
            int mid = array.Length / 2;
            int[] newArray = new int[array.Length +1];
            int counter = 0;

            for (int i = 0; i <= newArray.Length; i++)
            {
                if (newArray[i] = mid)
                {
                    newArray[i] = insertion;
                }
                else 
                {
                    newArray[i] = array[counter++];
                }
                
                return newArray;
             }
        }
    }
}
