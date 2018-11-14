using System;
using Xunit;
using repeatedWord;

namespace TestRepeatedWord
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("The quick brown fox jumped over the lazy dog.", "the")]
        [InlineData("There's something strange going on tonight. Here's something going on that's not quite right.", "something")]
        // Should return the first repeated word
        public void ShouldReturnRepeatedWords(string text, string result)
        {
            string test = text;
            string testResult = Program.RepeatedWord(test);
            Assert.Equal(result, testResult);
        }

        [Fact]
        // Should return null if there is no repeated word
        public void ShouldReturnNullIfNoRepeatedWords()
        {
            string test = "A quick brown fox jumped over the lazy dog.";
            string testResult = Program.RepeatedWord(test);
            Assert.Null(testResult);
        }
    }
}
