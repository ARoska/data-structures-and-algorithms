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

        /// <summary>
        /// Creates empty Binary Tree
        /// </summary>
        public MyBinaryTree()
        {
            Root = null;
        }

        /// <summary>
        /// Takes in a Root Node and a List, and adds each Node in the BT to the List in a Root-first order
        /// </summary>
        /// <param name="root">Node to start at, the "Root"</param>
        /// <param name="list">Empty List to populate</param>
        /// <returns>List populated with all Nodes in BT</returns>
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

        /// <summary>
        /// Takes in a Root Node and a List, and adds each Node in the BT to the List in a Root-between order
        /// </summary>
        /// <param name="root">Node to start at, the "Root"</param>
        /// <param name="list">Empty List to populate</param>
        /// <returns>List populated with all Nodes in BT</returns>
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

        /// <summary>
        /// Takes in a Root Node and a List, and adds each Node in the BT to the List in a Root-last order
        /// </summary>
        /// <param name="root">Node to start at, the "Root"</param>
        /// <param name="list">Empty List to populate</param>
        /// <returns>List populated with all Nodes in BT</returns>
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


        public List<object> BreadthFirst()
        {
            if (Root == null)
            {
                return null;
            }

            List<Node<T>> list = new List<Node<T>>();
            List<object> returnList = new List<object>();
            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(Root);
            
            while (queue.Count != 0)
            {
                Node<T> node = queue.Dequeue();
                list.Add(node);
                returnList.Add(node.Value);
                Console.WriteLine(node.Value);

                if (node.LChild != null)
                {
                    queue.Enqueue(node.LChild);
                }
                if (node.RChild != null)
                {
                    queue.Enqueue(node.RChild);
                }
            }

            return returnList;
        }

        public void AddToBT(Node<T> node)
        {
            if (Root == null)
            {
                Root = node;
                return;
            }
            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(Root);

            while (queue.Count != 0)
            {
                Node<T> temp = queue.Dequeue();

                if (temp.LChild != null)
                {
                    queue.Enqueue(temp.LChild);
                }
                else
                {
                    temp.LChild = node;
                    return;
                }

                if (temp.RChild != null)
                {
                    queue.Enqueue(temp.RChild);
                }
                else
                {
                    temp.RChild = node;
                    return;
                }
            }

        }
    }
}
