using System;

namespace ArrayShift
{
   public class Program
    {
        static void Main(string[] args)
        {
            insertShiftArray();
        }

        public static int[] insertShiftArray()
        {
            int[] array = new int[5] { 1, 3, 4, 8, 10 };
            int insertion = 9;
            for (int i = 0; i <= array.Length; i++)
            {
                if (i >= (array.Length)/2 && i < array.Length+1)
                {
                    i = insertion;
                }
            }
                int[] insertArray = array;
            Console.WriteLine(insertArray);
                return insertArray;
        }
    }
}
