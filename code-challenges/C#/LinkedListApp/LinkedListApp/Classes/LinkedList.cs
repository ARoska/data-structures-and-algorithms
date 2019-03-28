using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListApp.Classes
{
    public class LinkedList
    {
        /// <summary>
        /// Sets Head of LL
        /// </summary>
        public Node Head { get; set; }

        /// <summary>
        /// Sets Current of LL
        /// </summary>
        public Node Current { get; set; }

        /// <summary>
        /// Creates null LL
        /// </summary>
        public LinkedList()
        {
            Head = Current;
        }

        /// <summary>
        /// Creates LL with a Head Node
        /// </summary>
        /// <param name="node">Node to start LL with</param>
        public LinkedList(Node node)
        {
            Head = node;

            Current = node;
        }

        /// <summary>
        /// Inserts new Node at the start of LL
        /// </summary>
        /// <param name="node">Node to Insert</param>
        public void Insert(Node node)
        {
            Current = Head;
            node.Next = Head;
            Head = node;
            Current = Head;
        }

        /// <summary>
        /// Appends new Node to the end of LL
        /// </summary>
        /// <param name="node">Node to Append</param>
        public void Append(Node node)
        {
            Current = Head;

            if (Head == null)
            {
                Head = node;
                return;
            }

            while (Current.Next != null)
            {
                Current = Current.Next;
            }

            Current.Next = node;
            Current = Head;
        }

        /// <summary>
        /// Inserts new Node before existing Node with specefied data
        /// </summary>
        /// <param name="node">Node to Insert</param>
        /// <param name="data">Data to look for</param>
        public void InsertBefore(Node node, int data)
        {
            Current = Head;

            if (Current.Value == data)
            {
                Insert(node);
                Current = Head;
                return;
            }

            while (Current.Next != null)
            {
                if (Current.Next.Value == data)
                {
                    node.Next = Current.Next;
                    Current.Next = node;
                    Current = Head;
                    return;
                }

                Current = Current.Next;
            }

            Current = Head;
        }

        /// <summary>
        /// Inserts new Node after existing Node with specefied data
        /// </summary>
        /// <param name="node">Node to Insert</param>
        /// <param name="data">Data to look for</param>
        public void InsertAfter(Node node, int data)
        {
            Current = Head;

            while (Current.Next != null)
            {
                if (Current.Value == data)
                {
                    node.Next = Current.Next;
                    Current.Next = node;
                    Current = Head;
                    return;
                }

                Current = Current.Next;
            }

            if (Current.Value == data)
            {
                node.Next = Current.Next;
                Current.Next = node;
                Current = Head;
                return;
            }

            Current = Head;
        }

        /// <summary>
        /// Searchesb LL for a node with the specefied data and returns boolean value
        /// </summary>
        /// <param name="data">Data to search for</param>
        /// <returns>Bool indicating if data is found</returns>
        public bool Includes(int data)
        {
            Current = Head;

            while (Current != null)
            {
                if (Current.Value == data)
                {
                    return true;
                }

                Current = Current.Next;
            }

            return false;
        }

        /// <summary>
        /// Prints a list of all Node Values in LL to Console
        /// </summary>
        public void PrintAllNodes()
        {
            Current = Head;

            Console.WriteLine("-------------------------\n" +
                "");
            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} ----> ");
                Current = Current.Next;
            }

            Console.WriteLine($"{Current.Value} ----> Null");
            Console.WriteLine("\n" +
                "-------------------------");
        }

        /// <summary>
        /// Returns the Value of a Node that is K Nodes from the end of the Linked List
        /// </summary>
        /// <param name="k">Target position from end of LL</param>
        /// <returns>Value of K</returns>
        public Node ReturnKthFromEnd(int k)
        {
            if (k < 0)
            {
                return null;
            }

            Current = Head;
            int counter = 0;

            while (Current != null)
            {
                counter++;
                Current = Current.Next;
            }

            if (k > counter)
            {
                return null;
            }

            Current = Head;
            if (k == 0)
            {
                counter--;
            }

            for (int i = 0; i < (counter - k); i++)
            {
                Current = Current.Next;
            }

            return Current;
        }

        /// <summary>
        /// Creates and returns an array with all Node Values in LL
        /// </summary>
        /// <returns>Int[] with all Node Values</returns>
        public int[] RertunAllNodes()
        {
            Current = Head;

            int counter = 0;

            while (Current.Next != null)
            {
                counter++;
                Current = Current.Next;
            }
            Current = Head;

            counter++;
            int[] returnArr = new int[counter];
            counter = 0;

            while (Current.Next != null)
            {
                returnArr[counter] = Current.Value;
                Current = Current.Next;
                counter++;
            }

            returnArr[counter] = Current.Value;

            Current = Head;
            return returnArr;
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
