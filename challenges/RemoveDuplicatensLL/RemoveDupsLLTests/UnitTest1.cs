using System;
using Xunit;
using RemoveDuplicatensLL;
using LinkedList;

namespace RemoveDupsLLTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanRemoveDupNode()
        {
            Node test1 = new Node(1);
            Node test2 = new Node(2);
            Node test3 = new Node(3);
            Node test4 = new Node(1);

            test1.Next = test2;
            test2.Next = test3;
            test3.Next = test4;

            Node sendNode = test1;


        }
    }
}
