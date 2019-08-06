using System;
using System.Collections.Generic;

namespace AreCharactersUnique
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool AreCharactersUnique(string input)
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
                    return false;
                }
            }
            return true;
        }
    }
}
