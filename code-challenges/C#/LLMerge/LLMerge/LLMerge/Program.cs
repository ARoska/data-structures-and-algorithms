using System;

namespace LLMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node nodeOneB = new Node(54);
            Node nodeTwoB = new Node(132);
            Node nodeThreeB = new Node(6);
            Node nodeFourB = new Node(-341);
            Node nodeFiveB = new Node(975);

            LinkedList linkedListB = new LinkedList(nodeOneB);

            linkedListB.Append(nodeTwoB);
            linkedListB.Append(nodeThreeB);
            linkedListB.Append(nodeFourB);
            linkedListB.Append(nodeFiveB);

            Console.WriteLine("Merging two lists.");
            Console.WriteLine("List 1: ");
            linkedListA.PrintAllNodes();
            Console.WriteLine("List 2: ");
            linkedListB.PrintAllNodes();
            Console.WriteLine();

            LinkedList mergedList = LinkedList.Merge(linkedListA, linkedListB);

            Console.WriteLine("Merged List: ");
            mergedList.PrintAllNodes();
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Merges two linked lists into a single list in a "zipper" fashion,
        /// alternating Nodes from list A and list B and returns a reference to the merged list.
        /// If one list is Null returns just the Non-Null list.
        /// If both lists are Null returns a Null list.
        /// </summary>
        /// <param name="linkedListA">First list to merge.</param>
        /// <param name="linkedListB">Second list to merge.</param>
        /// <returns>Reference to the now-merged list.</returns>
        public static LinkedList Merge(LinkedList linkedListA, LinkedList linkedListB)
        {
            if (linkedListA.Head == null)
            {
                return linkedListB;
            }

            if (linkedListB.Head == null)
            {
                return linkedListA;
            }

            if (linkedListA.Head == null && linkedListB == null)
            {
                return null;
            }

            Node CurrentA = linkedListA.Head;
            Node CurrentB = linkedListB.Head;

            while (CurrentA != null && CurrentB != null)
            {
                linkedListB.Head = CurrentB.Next;
                CurrentB.Next = CurrentA.Next;
                CurrentA.Next = CurrentB;
                CurrentA = CurrentB.Next;
                CurrentB = linkedListB.Head;
            }

            if (CurrentB != null)
            {
                CurrentA.Next = CurrentB;
            }

            return linkedListA;
        }
    }
}
