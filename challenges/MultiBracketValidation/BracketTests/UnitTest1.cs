using System;
using Xunit;

namespace BracketTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanMatchBrackets()
        {
            Assert.True(true, "(()){}[]");
        }

        [Fact]
        public void CanFindNonMatchLeading()
        {
            Assert.False(false, "(()[]{}");
        }
        [Fact]
        public void CanFindNonMatchClosing()
        {
            Assert.False(false, "()[[[]]]]{}");
        }
        [Fact]
        public void CanFindNonMatchingWithOtherChar()
        {
            Assert.False(false, "(Hi)[You]{Are}{{Testing}");
        }

        [Fact]
        public void CanMatchWithOtherChar()
        {
            Assert.True(true, "(Hi)[You]{Are}{Testing}");

        }
    }
}
