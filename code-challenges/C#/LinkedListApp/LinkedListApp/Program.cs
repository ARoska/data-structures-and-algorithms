using System;
using LinkedListApp.Classes;

namespace LinkedListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Node nodeTwo = new Node(3572);
            Node nodeThree = new Node(1);
            Node nodeFour = new Node(50);
            Node nodeFive = new Node(6752347);
            int counter = 47;

            for (int i = 0; i < 5; i++)
            {
                Node newNode = new Node(counter);
                linkedList.Append(newNode);
                counter++;
            }

            Console.WriteLine("Initialized Linked List:");
            linkedList.PrintAllNodes();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Value to Insert before Head: 3572");
            linkedList.Insert(nodeTwo);
            linkedList.PrintAllNodes();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Value to Append after Tail: 1");
            linkedList.Append(nodeThree);
            linkedList.PrintAllNodes();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Value to Insert before Node 3 Tail: 50");
            linkedList.InsertBefore(nodeFour, 48);
            linkedList.PrintAllNodes();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Value to Insert after Node 5: 6752347");
            linkedList.InsertAfter(nodeFive, 49);
            linkedList.PrintAllNodes();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Does Linked List include 3572?\n" +
                $"{linkedList.Includes(3572)}");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Does Linked List include -50?\n" +
                $"{linkedList.Includes(-50)}");
            Console.ReadKey();
            Console.Clear();

            int[] actualReturn = linkedList.RertunAllNodes();
            Console.WriteLine("All Node Values Returned: [{0}]", string.Join(", ", actualReturn));
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"Third Node from the end: {linkedList.ReturnKthFromEnd(3).Value}");
            Console.ReadKey();
        }
    }
}
