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
                Current = Root;
                return;
            }


            if (node.Value >= Current.Value)
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

            Current = Root;
        }

        public bool Contains(Node<int> root, int value)
        {
            if (root == null)
            {
                return false;
            }

            if (root.Value == value)
            {
                return true;
            }

            if (value >= root.Value)
            {
                if (Contains(root.RChild, value))
                {
                    return true;
                }
            }
            if (value < root.Value)
            {
                if (Contains(root.LChild, value))
                {
                    return true;
                }
            }

            return false;
        }

    }
}
