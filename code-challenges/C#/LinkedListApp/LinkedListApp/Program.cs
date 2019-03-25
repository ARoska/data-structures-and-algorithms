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
            linkedList.Insert(counter);
            counter++;
            linkedList.Insert(counter);
            counter++;

            linkedList.PrintAllNodes();

            int[] actualReturn = linkedList.RertunAllNodes();
            Console.WriteLine("[{0}]", string.Join(", ", actualReturn));
        }
    }
}
