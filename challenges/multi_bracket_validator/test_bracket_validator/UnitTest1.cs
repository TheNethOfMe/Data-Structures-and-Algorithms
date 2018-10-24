using System;
using Xunit;
using multi_bracket_validator;

namespace test_bracket_validator
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("The parenthesis do (not)matter.")]
        [InlineData("Look [at {all (this (crap))}]")]
        [InlineData("That wasn't {really} it [I'm back. (Tee Hee)]")]
        [InlineData("I don't have any brackets or parens.")]
        // All of these follow the rules of proper bracket/paren use and should evaluate true.
        public void ShouldReturnTrueIfBracketsMatch(string testString)
        {
            Assert.True(Program.MultiBracketValidator(testString));
        }

        [Theory]
        [InlineData("I'm missing an opening] bracket")]
        [InlineData("I'm (missing (a) closing parentheses")]
        // These two strings are each missing an opening or closing bracket/paren and should return false.
        public void ShouldReturnFalseIfBracketsMissing(string testString)
        {
            Assert.False(Program.MultiBracketValidator(testString));
        }

        [Theory]
        [InlineData("All (mixed [up)]!")]
        [InlineData("Almost (but [not {quite})]")]
        // These all have matching brackets in the wrong order and should return false.
        public void ShouldReturnFalseIfBracketsMismatched(string testString)
        {
            Assert.False(Program.MultiBracketValidator(testString));
        }
    }
}
