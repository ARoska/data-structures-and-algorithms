using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class MyBinarySearchTree
    {
        public Node<int> Root { get; set; }
        public Node<int> Current { get; set; }

        public MyBinarySearchTree()
        {
            Root = null;
            Current = Root;
        }

        public void Add(Node<int> node)
        {
            if (Root == null)
            {
                Root = node;
                return;
            }

            if (Current.Value >= node.Value)
            {
                if (Current.RChild == null)
                {
                    Current.RChild = node;
                }
                else
                {
                    Current = Current.RChild;
                    Add(node);
                }
            }
            else
            {
                if (Current.LChild == null)
                {
                    Current.LChild = node;
                }
                else
                {
                    Current = Current.LChild;
                    Add(node);
                }
            }
        }

        //public static bool Contains(int value)
        //{

        //}

    }
}
