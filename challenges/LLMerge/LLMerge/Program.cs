using System;
namespace LLMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void MergeLists(LinkList listOne, LinkList listTwo)
        {
            listOne.Current = listOne.Head;
            listTwo.Current = listTwo.Head;

            while(listOne.Current != null && listTwo.Current != null)
            {
                listTwo.Current = listTwo.Head;
                listTwo.Current.Next = listOne.Current.Next;
                listOne.Current.Next = listTwo.Current;
                listOne.Current = listTwo.Current.Next;
                listTwo.Current = listTwo.Head;
            }

            if (listOne.Current.Next == null)
            {
                listOne.Current.Next = listTwo.Current;
            }

            return listOne;
        }
    }
}
