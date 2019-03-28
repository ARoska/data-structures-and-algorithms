using LinkedListApp.Classes;
using static LLMerge.Program;
using System;
using Xunit;

namespace LLMergeTest
{
    public class UnitTest1
    {
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

            LinkedList mergedList = MergeLists(linkedListA, linkedListB);
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

            LinkedList mergedList = MergeLists(linkedListA, linkedListB);
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

            LinkedList mergedList = MergeLists(linkedListA, linkedListB);
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

            LinkedList mergedList = MergeLists(linkedListA, linkedListB);
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

            LinkedList mergedList = MergeLists(linkedListA, linkedListB);
            int[] actualReturn = mergedList.RertunAllNodes();

            Assert.Equal(expectedReturn, actualReturn);
        }

        [Fact]
        public void GivinTwoNullListsReturnNullList()
        {
            LinkedList linkedListA = new LinkedList();
            LinkedList linkedListB = new LinkedList();

            LinkedList mergedList = MergeLists(linkedListA, linkedListB);

            Assert.Null(mergedList.Head);
        }

    }
}
