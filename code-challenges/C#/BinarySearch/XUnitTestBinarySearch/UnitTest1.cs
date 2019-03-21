using System;
using Xunit;
using BinarySearch;

namespace XUnitTestBinarySearch
{
    public class UnitTest1
    {
        [Fact]
        public void HappyPathWillReturnIndexOfValueMatchingSeachKey()
        {
            int[] sortedArray = { 1, 2, 3, 4, 5 };
            int searchKey = 3;
            int expectedAnswer = 2;

            int answer = Program.BinarySearch(sortedArray, searchKey);

            Assert.Equal(answer, expectedAnswer);
        }

        [Fact]
        public void HappyPathWillReturnDefaultValueIfSearchKeyNotFound()
        {
            int[] sortedArray = { 1, 2, 3, 4, 5 };
            int searchKey = 30;
            int expectedAnswer = -1;

            int answer = Program.BinarySearch(sortedArray, searchKey);

            Assert.Equal(answer, expectedAnswer);
        }

        [Fact]
        public void EdgeCaseTestEmptyArrayShouldReturnAsThoughSeachKeyNotFound()
        {
            int[] emptyArray = new int[0];
            int searchKey = 3;
            int expectedAnswer = -1;

            int answer = Program.BinarySearch(emptyArray, searchKey);

            Assert.Equal(answer, expectedAnswer);
        }
    }
}
