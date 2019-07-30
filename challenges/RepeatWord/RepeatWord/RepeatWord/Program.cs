using System;
using System.Text.RegularExpressions;
using HashTable.Classes;

namespace RepeatWord
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string FirstRepeateWord(string input)
        {
            if(input == null)
            {
                return null;
            }

            //Removes all spaces and punctuation. Keeps -/'
            Regex isolateWords = new Regex(@"(?:(?!['-])\W)+");
            //Runs the input through the regex and splits the words. Also ensures they are all lower case.
            string[] onlyWords = isolateWords.Split(input.ToLower());

            Hashtable hashtable = new Hashtable();

            for (int i = 0; i < onlyWords.Length; i++)
            {
                if (hashtable.Contains(onlyWords[i]))
                {
                    return onlyWords[i];
                }
                else
                {
                    hashtable.Add(onlyWords[i], i);
                }
            }
            return null;
        }
    }
}
