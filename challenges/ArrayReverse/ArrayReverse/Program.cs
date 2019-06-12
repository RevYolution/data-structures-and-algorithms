using System;

namespace ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many elements would you like in your array?");
            string usersArrayLength = Console.ReadLine();
            int convertUsersArray = Convert.ToInt32(usersArrayLength);
            int[] initialArraySize = new int[convertUsersArray];
            Console.WriteLine($"Array length is {convertUsersArray}");

            for (int i = 0; i < initialArraySize.Length; i++)
            {
                Console.WriteLine($"Enter element {i+1} of {initialArraySize.Length}");
                string arrayInput = Console.ReadLine();
                int convertArrayInput = Convert.ToInt32(arrayInput);
                initialArraySize[i] = convertArrayInput;
            }
            Console.Write("Your array is ");
            for (int i = 0; i < initialArraySize.Length; i++)
            {

            Console.Write(initialArraySize[i]);
            }

            int reverseArray = initialArraySize.Length - 1;
            string reversed = null;

            while (reverseArray >= 0)
            {
                reversed = reversed + initialArraySize[reverseArray];
                reverseArray--;
            }

            Console.WriteLine();
            Console.WriteLine($"Reversed array is {reversed}");
        }
    }
}
