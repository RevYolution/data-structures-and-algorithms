using System;
using System.Collections.Generic;

namespace AreCharactersUnique
{
    public class Program
    {
        static void Main(string[] args)
        {
            AreCharactersUnique("The quick brown lazy");
        }

        public static bool AreCharactersUnique(string input)
        {
            HashSet<char> check = new HashSet<char>();

            //string noSpace = string.Join("", input);

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
