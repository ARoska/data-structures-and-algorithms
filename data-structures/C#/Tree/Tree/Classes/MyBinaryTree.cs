using StacksAndQueues.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class MyBinaryTree<T>
    {
        public Node<T> Root { get; set; }
        public Node<T> Current { get; set; }

        public MyBinaryTree()
        {
            Root = null;
        }

        public List<T> PreOrder(Node<T> root, List<T> list)
        {
            if (root == null)
            {
                return null;
            }

            list.Add(root.Value);

            if (root.LChild != null)
            {
                PreOrder(root.LChild, list);
            }
            if (root.RChild != null)
            {
                PreOrder(root.RChild, list);
            }

            return list;
        }

        public List<T> InOrder(Node<T> root, List<T> list)
        {
            if (root == null)
            {
                return null;
            }
            if (root.LChild != null)
            {
                InOrder(root.LChild, list);
            }

            list.Add(root.Value);

            if (root.RChild != null)
            {
                InOrder(root.RChild, list);
            }

            return list;
        }

        public List<T> PostOrder(Node<T> root, List<T> list)
        {
            if (root == null)
            {
                return null;
            }

            if (root.LChild != null)
            {
                PostOrder(root.LChild, list);
            }
            if (root.RChild != null)
            {
                PostOrder(root.RChild, list);
            }

            list.Add(root.Value);

            return list;
        }


        //public void AddToBT(T root, T node)
        //{
        //    Queue<T> queue = new Queue<T>();
        //    queue.Enqueue(root);

        //    while (queue.Peek() != null)
        //    {
        //        Node<T> temp = new Node<T>();
        //        T front = queue.Dequeue();
        //        temp.Value = front;
        //        if (front.)
        //        {

        //        }
        //    }


        //}
    }
}
