using System;
using Xunit;
using LinkedListApp.Classes;

namespace LinkedListTest
{
    public class UnitTest1
    {
        [Fact]
        public void NewLinkedListShouldBeNullUntilPopulated()
        {
            LinkedList nullLinkedList = new LinkedList();
            Assert.Null(nullLinkedList.Head);
        }

        [Fact]
        public void HeadProperlyPointsToFirstNodeInList()
        {
            Node nodeOne = new Node(47);
            Node nodeTwo = new Node(3572);
            Node nodeThree = new Node(1);
            Node nodeFour = new Node(50);
            Node nodeFive = new Node(6752347);

            LinkedList linkedList = new LinkedList(nodeOne);

            linkedList.Append(nodeTwo);
            linkedList.Append(nodeThree);
            linkedList.Append(nodeFour);
            linkedList.Append(nodeFive);

            int expectedHeadValue = 47;

            int actualHeadValue = linkedList.Head.Value;

            Assert.Equal(expectedHeadValue, actualHeadValue);
        }

        [Fact]
        public void CanInsertNewNodeAtFrontOfList()
        {
            Node nodeOne = new Node(47);
            Node nodeTwo = new Node(3572);
            Node nodeThree = new Node(1);
            Node nodeFour = new Node(50);
            Node nodeFive = new Node(6752347);

            LinkedList linkedList = new LinkedList(nodeOne);

            linkedList.Append(nodeTwo);
            linkedList.Append(nodeThree);
            linkedList.Append(nodeFour);
            linkedList.Append(nodeFive);

            Node newNode = new Node(52);
            int[] expectedReturn = { 52, 47, 3572, 1, 50, 6752347 };

            linkedList.Insert(newNode);
            int[] actualReturn = linkedList.RertunAllNodes();

            Assert.Equal(expectedReturn, actualReturn);
        }

        [Fact]
        public void CanInsertMultipleNodesAtFrontOfList()
        {
            Node nodeOne = new Node(47);
            Node nodeTwo = new Node(3572);
            Node nodeThree = new Node(1);
            Node nodeFour = new Node(50);
            Node nodeFive = new Node(6752347);

            LinkedList linkedList = new LinkedList(nodeOne);

            linkedList.Insert(nodeTwo);
            linkedList.Insert(nodeThree);
            linkedList.Insert(nodeFour);
            linkedList.Insert(nodeFive);

            int[] expectedReturn = { 6752347, 50, 1, 3572, 47 };

            int[] actualReturn = linkedList.RertunAllNodes();

            Assert.Equal(expectedReturn, actualReturn);
        }

        [Fact]
        public void CanAppendNodeAtEndOfList()
        {
            Node nodeOne = new Node(47);
            Node nodeTwo = new Node(3572);
            Node nodeThree = new Node(1);
            Node nodeFour = new Node(50);
            Node nodeFive = new Node(6752347);

            LinkedList linkedList = new LinkedList(nodeOne);

            linkedList.Insert(nodeTwo);
            linkedList.Insert(nodeThree);
            linkedList.Insert(nodeFour);
            linkedList.Insert(nodeFive);

            Node newNode = new Node(52);
            int[] expectedReturn = { 6752347, 50, 1, 3572, 47, 52 };

            linkedList.Append(newNode);
            int[] actualReturn = linkedList.RertunAllNodes();

            Assert.Equal(expectedReturn, actualReturn);
        }

        [Fact]
        public void CanAppendMultipleNodesAtEndOfList()
        {
            Node nodeOne = new Node(47);
            Node nodeTwo = new Node(3572);
            Node nodeThree = new Node(1);
            Node nodeFour = new Node(50);
            Node nodeFive = new Node(6752347);

            LinkedList linkedList = new LinkedList(nodeOne);

            linkedList.Append(nodeTwo);
            linkedList.Append(nodeThree);
            linkedList.Append(nodeFour);
            linkedList.Append(nodeFive);

            int[] expectedReturn = { 47, 3572, 1, 50, 6752347 };

            int[] actualReturn = linkedList.RertunAllNodes();

            Assert.Equal(expectedReturn, actualReturn);
        }

        [Fact]
        public void CanInsertNewNodeBeforeGivenData()
        {
            Node nodeOne = new Node(47);
            Node nodeTwo = new Node(3572);
            Node nodeThree = new Node(1);
            Node nodeFour = new Node(50);
            Node nodeFive = new Node(6752347);

            LinkedList linkedList = new LinkedList(nodeOne);

            linkedList.Append(nodeTwo);
            linkedList.Append(nodeThree);
            linkedList.Append(nodeFour);
            linkedList.Append(nodeFive);

            Node nodeToInsert = new Node(52);
            int data = 50;
            int[] expectedReturn = { 47, 3572, 1, 52, 50, 6752347 };

            linkedList.InsertBefore(nodeToInsert, data);
            int[] actualReturn = linkedList.RertunAllNodes();

            Assert.Equal(expectedReturn, actualReturn);
        }

        [Fact]
        public void CanInsertNewNodeBeforeFistNodeInList()
        {
            Node nodeOne = new Node(47);
            Node nodeTwo = new Node(3572);
            Node nodeThree = new Node(1);
            Node nodeFour = new Node(50);
            Node nodeFive = new Node(6752347);

            LinkedList linkedList = new LinkedList(nodeOne);

            linkedList.Append(nodeTwo);
            linkedList.Append(nodeThree);
            linkedList.Append(nodeFour);
            linkedList.Append(nodeFive);

            Node nodeToInsert = new Node(465);
            int data = nodeOne.Value;
            int[] expectedReturn = { 465, 47, 3572, 1, 50, 6752347 };

            linkedList.InsertBefore(nodeToInsert, data);
            int[] actualReturn = linkedList.RertunAllNodes();

            Assert.Equal(expectedReturn, actualReturn);

        }

        [Fact]
        public void CanInsertNewNodeAfterGivenData()
        {
            Node nodeOne = new Node(47);
            Node nodeTwo = new Node(3572);
            Node nodeThree = new Node(1);
            Node nodeFour = new Node(50);
            Node nodeFive = new Node(6752347);

            LinkedList linkedList = new LinkedList(nodeOne);

            linkedList.Append(nodeTwo);
            linkedList.Append(nodeThree);
            linkedList.Append(nodeFour);
            linkedList.Append(nodeFive);

            Node nodeToInsert = new Node(52);
            int data = 3572;
            int[] expectedReturn = { 47, 3572, 52, 1, 50,6752347 };

            linkedList.InsertAfter(nodeToInsert, data);
            int[] actualReturn = linkedList.RertunAllNodes();

            Assert.Equal(expectedReturn, actualReturn);
        }

        [Fact]
        public void CanInsertNodeAfterLastNodeInList()
        {
            Node nodeOne = new Node(47);
            Node nodeTwo = new Node(3572);
            Node nodeThree = new Node(1);
            Node nodeFour = new Node(50);
            Node nodeFive = new Node(6752347);

            LinkedList linkedList = new LinkedList(nodeOne);

            linkedList.Append(nodeTwo);
            linkedList.Append(nodeThree);
            linkedList.Append(nodeFour);
            linkedList.Append(nodeFive);

            Node nodeToInsert = new Node(9785);
            int data = nodeFive.Value;
            int[] expectedReturn = { 47, 3572, 1, 50, 6752347, 9785 };

            linkedList.InsertAfter(nodeToInsert, data);
            int[] actualReturn = linkedList.RertunAllNodes();

            Assert.Equal(expectedReturn, actualReturn);
        }

        [Fact]
        public void WillReturnTrueIfRequestedValueExistsInList()
        {
            Node nodeOne = new Node(47);
            Node nodeTwo = new Node(3572);
            Node nodeThree = new Node(1);
            Node nodeFour = new Node(50);
            Node nodeFive = new Node(6752347);

            LinkedList linkedList = new LinkedList(nodeOne);

            linkedList.Append(nodeTwo);
            linkedList.Append(nodeThree);
            linkedList.Append(nodeFour);
            linkedList.Append(nodeFive);

            bool expectedReturn = true;

            bool actualReturn = linkedList.Includes(50);

            Assert.Equal(expectedReturn, actualReturn);
        }

        [Fact]
        public void WillReturnFalseIfRequestedValueDoesNotExistsInList()
        {
            Node nodeOne = new Node(47);
            Node nodeTwo = new Node(3572);
            Node nodeThree = new Node(1);
            Node nodeFour = new Node(50);
            Node nodeFive = new Node(6752347);

            LinkedList linkedList = new LinkedList(nodeOne);

            linkedList.Append(nodeTwo);
            linkedList.Append(nodeThree);
            linkedList.Append(nodeFour);
            linkedList.Append(nodeFive);

            bool expectedReturn = false;

            bool actualReturn = linkedList.Includes(6457);

            Assert.Equal(expectedReturn, actualReturn);
        }

    }
}
