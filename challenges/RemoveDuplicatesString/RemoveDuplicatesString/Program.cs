using System;
using System.Collections.Generic;

namespace RemoveDuplicatesString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

       public string RemoveDuplicates(string input)
        {
            HashSet<char> check = new HashSet<char>();

            foreach (char item in input)
            {
                if (!check.Contains(item))
                {
                    check.Add(item);
                }
                else
                {
                    input.Remove(item);
                }
            }

            return input;
        }
    }
}
