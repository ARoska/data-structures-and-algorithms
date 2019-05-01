using Hashtable.Classes;
using System;
using System.Collections.Generic;
using Tree.Classes;

namespace TreeIntersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static List<int> TreeIntersection(MyBinaryTree<int> treeOne, MyBinaryTree<int> treeTwo)
        {
            if (treeOne.Root == null || treeTwo.Root == null)
            {
                return null;
            }

            MyHashTable hashTable = new MyHashTable();
            List<int> returnList = new List<int>();
            Queue<Node<int>> queue = new Queue<Node<int>>();

            queue.Enqueue(treeOne.Root);

            while (queue.Count != 0)
            {
                Node<int> node = queue.Dequeue();

                if (node.LChild != null)
                {
                    queue.Enqueue(node.LChild);
                }
                if (node.RChild != null)
                {
                    queue.Enqueue(node.RChild);
                }

                hashTable.Add(node.Value.ToString(), "");
            }

            queue.Enqueue(treeTwo.Root);

            while (queue.Count != 0)
            {
                Node<int> node = queue.Dequeue();

                if (node.LChild != null)
                {
                    queue.Enqueue(node.LChild);
                }
                if (node.RChild != null)
                {
                    queue.Enqueue(node.RChild);
                }

                if (hashTable.Contains(node.Value.ToString()))
                {
                    returnList.Add(node.Value);
                    hashTable.Remove(node.Value.ToString(), "");
                }
            }

            if (returnList.Count > 0)
            {
                return returnList;
            }

            return null;
        }

        public static List<int> TreeIntersection(MyBinarySearchTree treeOne, MyBinarySearchTree treeTwo)
        {
            if (treeOne.Root == null || treeTwo.Root == null)
            {
                return null;
            }

            MyHashTable hashTable = new MyHashTable();
            List<int> returnList = new List<int>();
            Queue<Node<int>> queue = new Queue<Node<int>>();

            queue.Enqueue(treeOne.Root);

            while (queue.Count != 0)
            {
                Node<int> node = queue.Dequeue();

                if (node.LChild != null)
                {
                    queue.Enqueue(node.LChild);
                }
                if (node.RChild != null)
                {
                    queue.Enqueue(node.RChild);
                }

                hashTable.Add(node.Value.ToString(), "");
            }

            queue.Enqueue(treeTwo.Root);

            while (queue.Count != 0)
            {
                Node<int> node = queue.Dequeue();

                if (node.LChild != null)
                {
                    queue.Enqueue(node.LChild);
                }
                if (node.RChild != null)
                {
                    queue.Enqueue(node.RChild);
                }

                if (hashTable.Contains(node.Value.ToString()))
                {
                    returnList.Add(node.Value);
                    hashTable.Remove(node.Value.ToString(), "");
                }
            }

            if (returnList.Count > 0)
            {
                return returnList;
            }

            return null;
        }

        public static List<int> TreeIntersection(MyBinaryTree<int> treeOne, MyBinarySearchTree treeTwo)
        {
            if (treeOne.Root == null || treeTwo.Root == null)
            {
                return null;
            }

            MyHashTable hashTable = new MyHashTable();
            List<int> returnList = new List<int>();
            Queue<Node<int>> queue = new Queue<Node<int>>();

            queue.Enqueue(treeOne.Root);

            while (queue.Count != 0)
            {
                Node<int> node = queue.Dequeue();

                if (node.LChild != null)
                {
                    queue.Enqueue(node.LChild);
                }
                if (node.RChild != null)
                {
                    queue.Enqueue(node.RChild);
                }

                hashTable.Add(node.Value.ToString(), "");
            }

            queue.Enqueue(treeTwo.Root);

            while (queue.Count != 0)
            {
                Node<int> node = queue.Dequeue();

                if (node.LChild != null)
                {
                    queue.Enqueue(node.LChild);
                }
                if (node.RChild != null)
                {
                    queue.Enqueue(node.RChild);
                }

                if (hashTable.Contains(node.Value.ToString()))
                {
                    returnList.Add(node.Value);
                    hashTable.Remove(node.Value.ToString(), "");
                }
            }

            if (returnList.Count > 0)
            {
                return returnList;
            }

            return null;
        }
    }
}
