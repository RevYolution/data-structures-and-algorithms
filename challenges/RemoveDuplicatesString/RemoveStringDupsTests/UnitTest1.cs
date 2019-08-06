using System;
using Xunit;
using RemoveDuplicatesString;

namespace RemoveStringDupsTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanRemoveDups()
        {
            string test = Program.RemoveDuplicates("All I Think about is winning");

            Assert.Equal("Al IThinkaboutswg", test);
        }

        [Fact]
        public void CanReturnEmpty()
        {
            string test = Program.RemoveDuplicates("");

            Assert.Equal("", test);
        }

        [Fact]
        public void CanReturnSpecialChars()
        {
            string test = Program.RemoveDuplicates("Aa,,Bb,Cc,Aa,Bb,Cc");

            Assert.Equal("Aa,BbCc", test);
        }

        [Fact] 
        public void CanReturnNumbers()
        {
            string test = Program.RemoveDuplicates("00112233445566778899");

            Assert.Equal("0123456789", test);
        }
    }
}
