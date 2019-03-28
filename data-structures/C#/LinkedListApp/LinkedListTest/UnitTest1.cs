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
            int[] expectedReturn = { 47, 3572, 52, 1, 50, 6752347 };

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
        public void ReturnThirdValueFromTheEnd()
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

            Node expectedReturn = nodeThree;

            Node actualReturn = linkedList.ReturnKthFromEnd(3);

            Assert.Equal(expectedReturn.Value, actualReturn.Value);
        }

        [Fact]
        public void ReturnZerothValueFromTheEnd()
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

            Node expectedReturn = nodeFive;

            Node actualReturn = linkedList.ReturnKthFromEnd(0);

            Assert.Equal(expectedReturn.Value, actualReturn.Value);
        }

        [Fact]
        public void ReturnZerothValueFromTheEndWithListSizeOne()
        {
            Node nodeOne = new Node(47);

            LinkedList linkedList = new LinkedList(nodeOne);

            Node expectedReturn = nodeOne;

            Node actualReturn = linkedList.ReturnKthFromEnd(0);

            Assert.Equal(expectedReturn.Value, actualReturn.Value);
        }

        [Fact]
        public void WillReturnNullIfKIsLargerThanList()
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

            Assert.Null(linkedList.ReturnKthFromEnd(10));
        }

        [Fact]
        public void WillReturnNullIfKIsNegative()
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

            Assert.Null(linkedList.ReturnKthFromEnd(-2));
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

        [Fact]
        public void GivinTwoSameLengthListsReturnMergedList()
        {
            Node nodeOneA = new Node(47);
            Node nodeTwoA = new Node(3572);
            Node nodeThreeA = new Node(1);
            Node nodeFourA = new Node(50);
            Node nodeFiveA = new Node(6752347);

            Node nodeOneB = new Node(54);
            Node nodeTwoB = new Node(132);
            Node nodeThreeB = new Node(6);
            Node nodeFourB = new Node(-341);
            Node nodeFiveB = new Node(975);

            LinkedList linkedListA = new LinkedList(nodeOneA);
            LinkedList linkedListB = new LinkedList(nodeOneB);

            linkedListA.Append(nodeTwoA);
            linkedListA.Append(nodeThreeA);
            linkedListA.Append(nodeFourA);
            linkedListA.Append(nodeFiveA);

            linkedListB.Append(nodeTwoB);
            linkedListB.Append(nodeThreeB);
            linkedListB.Append(nodeFourB);
            linkedListB.Append(nodeFiveB);

            int[] expectedReturn = { 47, 54, 3572, 132, 1, 6, 50, -341, 6752347, 975 };

            LinkedList mergedList = LinkedList.Merge(linkedListA, linkedListB);
            int[] actualReturn = mergedList.RertunAllNodes();

            Assert.Equal(expectedReturn, actualReturn);
        }

        [Fact]
        public void GivinTwoListsWhereFirstIsLongerReturnMergedList()
        {
            Node nodeOneA = new Node(47);
            Node nodeTwoA = new Node(3572);
            Node nodeThreeA = new Node(1);
            Node nodeFourA = new Node(50);
            Node nodeFiveA = new Node(6752347);
            Node nodeSixA = new Node(555);
            Node nodeSevenA = new Node(555);
            Node nodeEightA = new Node(5555);

            Node nodeOneB = new Node(54);
            Node nodeTwoB = new Node(132);
            Node nodeThreeB = new Node(6);
            Node nodeFourB = new Node(-341);
            Node nodeFiveB = new Node(975);

            LinkedList linkedListA = new LinkedList(nodeOneA);
            LinkedList linkedListB = new LinkedList(nodeOneB);

            linkedListA.Append(nodeTwoA);
            linkedListA.Append(nodeThreeA);
            linkedListA.Append(nodeFourA);
            linkedListA.Append(nodeFiveA);
            linkedListA.Append(nodeSixA);
            linkedListA.Append(nodeSevenA);
            linkedListA.Append(nodeEightA);

            linkedListB.Append(nodeTwoB);
            linkedListB.Append(nodeThreeB);
            linkedListB.Append(nodeFourB);
            linkedListB.Append(nodeFiveB);

            int[] expectedReturn = { 47, 54, 3572, 132, 1, 6, 50, -341, 6752347, 975, 555, 555, 5555 };

            LinkedList mergedList = LinkedList.Merge(linkedListA, linkedListB);
            int[] actualReturn = mergedList.RertunAllNodes();

            Assert.Equal(expectedReturn, actualReturn);
        }

        [Fact]
        public void GivinTwoListsWhereSecondIsLongerReturnMergedList()
        {
            Node nodeOneA = new Node(47);
            Node nodeTwoA = new Node(3572);
            Node nodeThreeA = new Node(1);
            Node nodeFourA = new Node(50);
            Node nodeFiveA = new Node(6752347);

            Node nodeOneB = new Node(54);
            Node nodeTwoB = new Node(132);
            Node nodeThreeB = new Node(6);
            Node nodeFourB = new Node(-341);
            Node nodeFiveB = new Node(975);
            Node nodeSixB = new Node(999);
            Node nodeSevenB = new Node(234);
            Node nodeEightB = new Node(-5);

            LinkedList linkedListA = new LinkedList(nodeOneA);
            LinkedList linkedListB = new LinkedList(nodeOneB);

            linkedListA.Append(nodeTwoA);
            linkedListA.Append(nodeThreeA);
            linkedListA.Append(nodeFourA);
            linkedListA.Append(nodeFiveA);

            linkedListB.Append(nodeTwoB);
            linkedListB.Append(nodeThreeB);
            linkedListB.Append(nodeFourB);
            linkedListB.Append(nodeFiveB);
            linkedListA.Append(nodeSixB);
            linkedListA.Append(nodeSevenB);
            linkedListA.Append(nodeEightB);

            int[] expectedReturn = { 47, 54, 3572, 132, 1, 6, 50, -341, 6752347, 975, 999, 234, -5 };

            LinkedList mergedList = LinkedList.Merge(linkedListA, linkedListB);
            int[] actualReturn = mergedList.RertunAllNodes();

            Assert.Equal(expectedReturn, actualReturn);
        }

        [Fact]
        public void GivinTwoListsWhereFirstIsNullReturnNonNullList()
        {
            Node nodeOneA = new Node(47);
            Node nodeTwoA = new Node(3572);
            Node nodeThreeA = new Node(1);
            Node nodeFourA = new Node(50);
            Node nodeFiveA = new Node(6752347);

            LinkedList linkedListA = new LinkedList(nodeOneA);
            LinkedList linkedListB = new LinkedList();

            linkedListA.Append(nodeTwoA);
            linkedListA.Append(nodeThreeA);
            linkedListA.Append(nodeFourA);
            linkedListA.Append(nodeFiveA);

            int[] expectedReturn = { 47, 3572, 1, 50, 6752347 };

            LinkedList mergedList = LinkedList.Merge(linkedListA, linkedListB);
            int[] actualReturn = mergedList.RertunAllNodes();

            Assert.Equal(expectedReturn, actualReturn);
        }

        [Fact]
        public void GivinTwoListsWhereSecondIsNullReturnNonNullList()
        {
            Node nodeOneB = new Node(54);
            Node nodeTwoB = new Node(132);
            Node nodeThreeB = new Node(6);
            Node nodeFourB = new Node(-341);
            Node nodeFiveB = new Node(975);

            LinkedList linkedListA = new LinkedList();
            LinkedList linkedListB = new LinkedList(nodeOneB);

            linkedListB.Append(nodeTwoB);
            linkedListB.Append(nodeThreeB);
            linkedListB.Append(nodeFourB);
            linkedListB.Append(nodeFiveB);

            int[] expectedReturn = { 54, 132, 6, -341, 975 };

            LinkedList mergedList = LinkedList.Merge(linkedListA, linkedListB);
            int[] actualReturn = mergedList.RertunAllNodes();

            Assert.Equal(expectedReturn, actualReturn);
        }

        [Fact]
        public void GivinTwoNullListsReturnNullList()
        {
            LinkedList linkedListA = new LinkedList();
            LinkedList linkedListB = new LinkedList();

            LinkedList mergedList = LinkedList.Merge(linkedListA, linkedListB);

            Assert.Null(mergedList.Head);
        }

    }
}
