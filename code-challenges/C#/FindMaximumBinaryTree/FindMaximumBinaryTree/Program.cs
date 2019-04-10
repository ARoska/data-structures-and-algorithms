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

        public static int? FindMaximumValue(MyBinaryTree<object> tree)
        {
            bool hasNumbers = false;
            int maxValue = 0;
            Queue<Node<object>> queue = new Queue<Node<object>>();
            queue.Enqueue(tree.Root);

            while (queue.Count != 0)
            {
                Node<object> temp = queue.Dequeue();
                int tempValue = 0;
                try
                {
                    tempValue = (int)temp.Value;
                }
                catch (Exception)
                {
                }

                if (maxValue < tempValue)
                {
                    maxValue = tempValue;
                    hasNumbers = true;
                }
                if (temp.LChild != null)
                {
                    queue.Enqueue(temp.LChild);
                }
                if (temp.RChild != null)
                {
                    queue.Enqueue(temp.RChild);
                }
            }

            if (hasNumbers)
            {
                return maxValue;
            }
            else
            {
                return null;
            }
        }
    }
}
