using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListApp.Classes
{
    public class LinkedList
    {
        Node head;

        public void Insert(int data)
        {
            Node newNode = new Node();
            newNode.data = data;

            newNode.next = head;
            head = newNode;
        }

        public bool Includes(int data)
        {
            Node current = head;

            while (current.next != null)
            {
                if (current.data == data)
                {
                    return true;
                }

                current = current.next;
            }

            return false;
        }

        public void PrintAllNodes()
        {
            Node current = head;

            while (current.next != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }

            Console.WriteLine(current.data +
                "\n" +
                "End of Linked List.");
            Console.ReadKey();

        }

        public int[] RertunAllNodes()
        {
            Node current = head;
            int[] returnArr = new int[0];
            int[] tempArr = new int[returnArr.Length + 1];

            while (current.next != null)
            {
                tempArr = new int[returnArr.Length + 1];
                for (int i = 0; i < returnArr.Length; i++)
                {
                    tempArr[i] = returnArr[i];
                }

                tempArr[tempArr.Length - 1] = current.data;
                returnArr = tempArr;
                current = current.next;
            }
            tempArr = new int[returnArr.Length + 1];
            for (int i = 0; i < returnArr.Length; i++)
            {
                tempArr[i] = returnArr[i];
            }

            tempArr[tempArr.Length - 1] = current.data;
            returnArr = tempArr;

            return returnArr;
        }

    }
}
