using LinkedList.Classes;
using System;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            LList list = new LList();
            for (int i = 0; i < 15; i++)
            {
                list.Insert(i + 1);
            }
            Console.WriteLine(list.Print());
        }
    }
}
