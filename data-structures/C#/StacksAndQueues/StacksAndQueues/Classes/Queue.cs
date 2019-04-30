using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class MyQueue<T>
    {
        /// <summary>
        /// Assigns Rear of Queue
        /// </summary>
        public Node<T> Rear { get; set; }

        /// <summary>
        /// Assigns Front of Queue
        /// </summary>
        public Node<T> Front { get; set; }

        /// <summary>
        /// Generates a new Queue with a Null default
        /// </summary>
        public MyQueue()
        {
            Front = null;
            Rear = Front;
        }

        /// <summary>
        /// Takes in a Node as a param and places it at the Rear of the Queue
        /// </summary>
        /// <param name="node">Node to be placed in Queue</param>
        public void Enqueue(Node<T> node)
        {
            if (Front == null)
            {
                Front = node;
                Rear = Front;
                return;
            }

            Rear.Next = node;
            Rear = node;
        }

        /// <summary>
        /// Removes the Front Node from the Queue, returning the Node
        /// </summary>
        /// <returns>Node that is removed</returns>
        public Node<T> Dequeue()
        {
            Node<T> temp = Front;
            Front = Front.Next;
            return temp;
        }

        /// <summary>
        /// Checks the Node at the Front of the Queue
        /// This should ALWAYS be used before using the Dequeue Method to ensure that there is an avaiable Node in the Queue
        /// </summary>
        /// <returns>Node at Front of Queue, or Null if no Node exists</returns>
        public Node<T> Peek()
        {
            //if (Front == null)
            //{
            //    return null;
            //}

            return Front;
        }
    }
}
