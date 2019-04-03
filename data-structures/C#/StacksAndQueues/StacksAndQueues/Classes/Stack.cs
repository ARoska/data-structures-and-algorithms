using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class MyStack<T> where T : IConvertible
    {
        /// <summary>
        /// Assigns Node to Top of Stack
        /// </summary>
        public Node<T> Top { get; set; }

        /// <summary>
        /// Generates a new Stack with a default value of Null
        /// </summary>
        public MyStack()
        {
            Top = null;
        }

        /// <summary>
        /// Takes in a Node as a param and places it on the Top of the Stack
        /// </summary>
        /// <param name="node">Node to be placed in Stack</param>
        public void Push(Node<T> node)
        {
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Removes the Top Node from the Stack, returning it
        /// </summary>
        /// <returns>Top Node</returns>
        public Node<T> Pop()
        {
            Node<T> temp = Top;
            Top = Top.Next;
            return temp;
        }

        /// <summary>
        /// Checks the Node at the Top of the Stack
        /// This should ALWAYS be used before using the Pop Method to ensure that there is an avaiable Node on the Stack
        /// </summary>
        /// <returns>Node at Top of Stack, or Null if no Node exists</returns>
        public Node<T> Peek()
        {
            //if (Top == null)
            //{
            //    return null;
            //}

            return Top;
        }
    }
}
