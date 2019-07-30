using RepeatWord;
using System;
using Xunit;

namespace RepeatWordTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindRepeatWord()
        {
            string testInput = "Testing to see if can find repeat word repeat";
            string testResult = Program.FirstRepeateWord(testInput);

            Assert.Equal("repeat", testResult);
        }
    }
}
