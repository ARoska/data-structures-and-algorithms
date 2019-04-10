using System;
using System.Collections.Generic;
using Tree.Classes;

namespace FindMaximumBinaryTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int FindMaximumValue(MyBinaryTree<int> tree)
        {
            int maxValue = 0;
            Queue<Node<int>> queue = new Queue<Node<int>>();
            queue.Enqueue(tree.Root);

            while (queue.Count != 0)
            {
                Node<int> temp = queue.Dequeue();

                if (temp.LChild != null)
                {
                    queue.Enqueue(temp.LChild);
                }
                if (temp.RChild != null)
                {
                    queue.Enqueue(temp.RChild);
                }
                if (temp.Value > maxValue)
                {
                    maxValue = temp.Value;
                }
            }

            return maxValue;
        }
    }
}
