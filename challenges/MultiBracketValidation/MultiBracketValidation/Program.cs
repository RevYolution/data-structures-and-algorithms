using System;
using System.Collections;

namespace MultiBracketValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MultiBracketValidation("input");
        }

        public static bool MultiBracketValidation(string input)
        {
            Stack vaildationStack = new Stack();
            foreach (char items in input)
            {
                if ("[](){}".Contains(items))
                {
                    if (items == '[' || items == '(' || items == '{')
                    {
                        vaildationStack.Push(items);
                    }
                    else if (items == ']' || items == ')' || items == '}')
                    {
                        try
                        {
                            vaildationStack.Pop();
                        }
                        catch 
                        {
                            return false;
                        }
                    }
                    else
                    {
                        try
                        {
                            vaildationStack.Peek();
                            return false;
                        }
                        catch
                        {

                            return true;
                        }
                    }
                }
            }
            return true;
        }
    }
}
