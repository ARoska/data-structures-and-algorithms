using System;
using Xunit;

namespace SortsTests
{
    public class InsertionSortTests
    {
        [Fact]
        public void RandomlyGeneratedArrayShouldReturnSorted()
        {
            int[] unsortedArr = new int[] { 5, 64, 1, 75, 32, -1 };

            int[] expectedArr = new int[] { -1, 1, 5, 32, 64, 75 };

            int[] sortedArr = new int[6];

            Assert.Equal(expectedArr, sortedArr);
        }

        [Fact]
        public void SortedArrayShouldReturnSameSortedArray()
        {
            int[] unsortedArr = new int[] { -1, 1, 5, 32, 64, 75 };

            int[] expectedArr = new int[] { -1, 1, 5, 32, 64, 75 };

            int[] sortedArr = new int[6];

            Assert.Equal(expectedArr, sortedArr);
        }

        [Fact]
        public void BackwardsSortedArrayShouldReturnForwardsSortedArray()
        {
            int[] unsortedArr = new int[] { 75, 64, 32, 5, 1, -1 };

            int[] expectedArr = new int[] { -1, 1, 5, 32, 64, 75 };

            int[] sortedArr = new int[6];

            Assert.Equal(expectedArr, sortedArr);
        }

        [Fact]
        public void EmptyArrayShouldReturnEmpty()
        {
            int[] unsortedArr = new int[] { };

            int[] expectedArr = new int[] { };

            int[] sortedArr = new int[6];

            Assert.Equal(expectedArr, sortedArr);
        }

        [Fact]
        public void ArrayOfOneElementReturnsSameArray()
        {
            int[] unsortedArr = new int[] { 5 };

            int[] expectedArr = new int[] { 5 };

            int[] sortedArr = new int[1];

            Assert.Equal(expectedArr, sortedArr);
        }


    }
}
