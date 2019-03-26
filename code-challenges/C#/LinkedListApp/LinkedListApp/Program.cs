using System;
using LinkedListApp.Classes;

namespace LinkedListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            int counter = 47;

            for (int i = 0; i < 5; i++)
            {
                Node newNode = new Node(counter);
                linkedList.Insert(newNode);
                counter++;
            }

            linkedList.PrintAllNodes();

            int[] actualReturn = linkedList.RertunAllNodes();
            Console.WriteLine("[{0}]", string.Join(", ", actualReturn));
        }
    }
}
