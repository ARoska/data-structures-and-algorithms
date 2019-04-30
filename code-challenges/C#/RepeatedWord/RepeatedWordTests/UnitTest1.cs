using System;
using Xunit;
using RepeatedWord;

namespace RepeatedWordTests
{
    public class UnitTest1
    {
        [Fact]
        public void ReturnsFirstRepeatedWord()
        {
            string input = "Once upon a time, there was a princess who...";

            string result = RepeatedWord.Program.RepeatedWord(input);

            Assert.Equal("a", result);
        }

        [Fact]
        public void ReturnsFirstRepeatedWordWhenMoreThanOneWordRepeats()
        {
            string input = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness...";

            string result = RepeatedWord.Program.RepeatedWord(input);

            Assert.Equal("it", result);
        }

        [Fact]
        public void ReturnsNullWhenOnlyOneWordInput()
        {
            string input = "None";

            string result = RepeatedWord.Program.RepeatedWord(input);

            Assert.Null(result);
        }
    }
}
