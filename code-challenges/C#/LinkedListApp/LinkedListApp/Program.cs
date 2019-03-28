using System;
using LinkedListApp.Classes;

namespace LinkedListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedListA = new LinkedList();
            Node nodeTwoA = new Node(3572);
            Node nodeThreeA = new Node(1);
            Node nodeFourA = new Node(50);
            Node nodeFiveA = new Node(6752347);
            int counter = 47;

            for (int i = 0; i < 5; i++)
            {
                Node newNode = new Node(counter);
                linkedListA.Append(newNode);
                counter++;
            }

            Console.WriteLine("Initialized Linked List:");
            linkedListA.PrintAllNodes();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Value to Insert before Head: 3572");
            linkedListA.Insert(nodeTwoA);
            linkedListA.PrintAllNodes();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Value to Append after Tail: 1");
            linkedListA.Append(nodeThreeA);
            linkedListA.PrintAllNodes();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Value to Insert before Node 3 Tail: 50");
            linkedListA.InsertBefore(nodeFourA, 48);
            linkedListA.PrintAllNodes();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Value to Insert after Node 5: 6752347");
            linkedListA.InsertAfter(nodeFiveA, 49);
            linkedListA.PrintAllNodes();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Does Linked List include 3572?\n" +
                $"{linkedListA.Includes(3572)}");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Does Linked List include -50?\n" +
                $"{linkedListA.Includes(-50)}");
            Console.ReadKey();
            Console.Clear();

            int[] actualReturn = linkedListA.RertunAllNodes();
            Console.WriteLine("All Node Values Returned: [{0}]", string.Join(", ", actualReturn));
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"Third Node from the end: {linkedListA.ReturnKthFromEnd(3).Value}");
            Console.ReadKey();
            Console.Clear();

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
    }
}
