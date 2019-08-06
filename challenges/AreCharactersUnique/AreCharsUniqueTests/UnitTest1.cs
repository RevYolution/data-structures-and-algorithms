using System;
using Xunit;
using AreCharactersUnique;

namespace AreCharsUniqueTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnTrue()
        {
            bool test = Program.AreCharactersUnique("Thequickbrownlazy");

            Assert.True(test);
        }

        [Fact]
        public void CanReturnFalse()
        {
            bool test = Program.AreCharactersUnique("The quick brown lazy");

            Assert.False(test);
        }

    }
}
