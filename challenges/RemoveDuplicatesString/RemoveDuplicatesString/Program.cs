using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveDuplicatesString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Original text:All I Think About is winning");
            Console.WriteLine("Modified:" + RemoveDuplicates("All I Think About is winning"));
        }

       public static string RemoveDuplicates(string input)
        {
            HashSet<char> check = new HashSet<char>();

            foreach (char item in input)
            {
                if (!check.Contains(item))
                {
                    check.Add(item);
                }
            }

            string output = string.Join("", check);

            return output;
        }
    }
}
