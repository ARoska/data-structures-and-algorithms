using System;
using Xunit;

namespace TreeTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanCreateEmptyTree()
        {


            Assert.Null(tree);
        }

        [Fact]
        public void CanCreateTreeWithOneRoot()
        {


            Assert.Equal("root", root);
        }

        [Fact]
        public void CanAddLeftChild()
        {


            Assert.Equal("left", left);
        }

        [Fact]
        public void CanAddRightChild()
        {


            Assert.Equal("right", right);
        }

        [Fact]
        public void CanRetrieveDataFromPreOrder()
        {


            int[] expected = new int[] { 1, 2, 3 };

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanRetrieveDataFromInOrder()
        {


            int[] expected = new int[] { 1, 2, 3 };

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanRetrieveDataFromPostOrder()
        {


            int[] expected = new int[] { 1, 2, 3 };

            Assert.Equal(expected, actual);
        }


    }
}
