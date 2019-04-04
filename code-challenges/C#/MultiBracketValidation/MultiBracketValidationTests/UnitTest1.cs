using StacksAndQueues.Classes;
using System;
using Xunit;
using static MultiBracketValidation.Program;

namespace MultiBracketValidationTests
{
    public class UnitTest1
    {
        [Fact]
        public void CompareHelperFuncitonCorrectlyReturnsTrueIfSame()
        {
            char test = '{';
            MyStack<char> myStack = new MyStack<char>();
            Node<char> node = new Node<char>('{');
            myStack.Push(node);

            bool result = Compare(test, myStack);

            Assert.True(result);
        }

        [Fact]
        public void CompareHelperFuncitonCorrectlyReturnsFalseIfDifferent()
        {
            char test = '[';
            MyStack<char> myStack = new MyStack<char>();
            Node<char> node = new Node<char>('{');
            myStack.Push(node);

            bool result = Compare(test, myStack);

            Assert.False(result);
        }

        [Theory]
        [InlineData("[]")]
        [InlineData("{}")]
        [InlineData("()")]
        [InlineData("[[]]")]
        [InlineData("{{}}")]
        [InlineData("(())")]
        [InlineData("({[]})")]
        public void ValidationCorrectlyReturnsTrueForUseCases(string str)
        {
            bool result = MultibracketValidation(str);

            Assert.True(result);
        }

        [Theory]
        [InlineData("[}")]
        [InlineData("{)")]
        [InlineData("(]")]
        [InlineData("[{]]")]
        [InlineData("{(}}")]
        [InlineData("([))")]
        [InlineData("][]")]
        [InlineData("({]})")]
        public void ValidationCorrectlyReturnsFalseForUseCases(string str)
        {
            bool result = MultibracketValidation(str);

            Assert.False(result);
        }
    }
}
