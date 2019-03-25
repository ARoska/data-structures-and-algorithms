using System;
using Xunit;
using LinkedListApp.Classes;

namespace LinkedListTest
{
    public class UnitTest1
    {
        LinkedList linkedList = new LinkedList();
        int counter = 47;

        [Fact]
        public void CanInsertNewNodeAtFrontOfList()
        {
            int[] expectedReturn = { 47 };
            linkedList.Insert(47);

            int[] actualReturn = linkedList.RertunAllNodes();

            Assert.Equal(expectedReturn, actualReturn);
        }

        [Fact]
        public void CanInsertMultipleNodesAtFrontOfList()
        {
            int[] expectedReturn = { 51, 50, 49, 48, 47 };
            linkedList.Insert(counter);
            counter++;
            linkedList.Insert(counter);
            counter++;
            linkedList.Insert(counter);
            counter++;
            linkedList.Insert(counter);
            counter++;
            linkedList.Insert(counter);
            counter++;

            int[] actualReturn = linkedList.RertunAllNodes();

            Assert.Equal(expectedReturn, actualReturn);
        }

        [Fact]
        public void WillReturnTrueIfRequestedValueExistsInList()
        {
            bool expectedReturn = true;

            linkedList.Insert(counter);
            counter++;
            linkedList.Insert(counter);
            counter++;
            linkedList.Insert(counter);
            counter++;
            linkedList.Insert(counter);
            counter++;
            linkedList.Insert(counter);
            counter++;

            bool actualReturn = linkedList.Includes(50);

            Assert.Equal(expectedReturn, actualReturn);
        }

        [Fact]
        public void WillReturnFalseIfRequestedValueDoesNotExistsInList()
        {
            bool expectedReturn = false;

            linkedList.Insert(counter);
            counter++;
            linkedList.Insert(counter);
            counter++;
            linkedList.Insert(counter);
            counter++;
            linkedList.Insert(counter);
            counter++;
            linkedList.Insert(counter);
            counter++;

            bool actualReturn = linkedList.Includes(6457);

            Assert.Equal(expectedReturn, actualReturn);
        }

    }
}
