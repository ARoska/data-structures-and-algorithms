using StacksAndQueues.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class MyPseudoQueue<T> where T : class
    {
        public MyStack<T> StackOne { get; set; }

        /// <summary>
        /// Creates a Stack to store Nodes in
        /// </summary>
        public MyPseudoQueue()
        {
            StackOne = new MyStack<T>();
        }

        /// <summary>
        /// Uses a second, temporary stack to emulate the action of Enqueueing a Node in a Queue
        /// via transferring data back and forth between the Stacks
        /// Adds the Node to the PseudoQueue
        /// </summary>
        /// <param name="node">Node to add to the Rear of the PseudoQueue</param>
        public void Enqueue(Node<T> node)
        {
            MyStack<T> StackTwo = new MyStack<T>();

            while (StackOne.Top != null)
            {
                T temp = StackOne.Pop();
                Node<T> tempNode = new Node<T>(temp);
                StackTwo.Push(tempNode);
            }

            StackOne.Push(node);

            while (StackTwo.Top != null)
            {
                T temp = StackTwo.Pop();
                Node<T> tempNode = new Node<T>(temp);
                StackOne.Push(tempNode);
            }
        }

        /// <summary>
        /// Uses a second, temporary stack to emulate the action of Dequeueing a Node in a Queue
        /// via transferring data back and forth between the Stacks
        /// Removes the Node from the PseudoQueue
        /// </summary>
        /// <returns>Data in the Node that is removed from the Front of the PseudoQueue</returns>
        public T Dequeue()
        {
            T returnTemp = null;
            MyStack<T> StackTwo = new MyStack<T>();

            while (StackOne.Top != null)
            {
                T temp = StackOne.Pop();
                Node<T> tempNode = new Node<T>(temp);
                StackTwo.Push(tempNode);
            }

            if (StackTwo.Top != null)
            {
                returnTemp = StackTwo.Pop();
            }

            while (StackTwo.Top != null)
            {
                T temp = StackTwo.Pop();
                Node<T> tempNode = new Node<T>(temp);
                StackOne.Push(tempNode);
            }

            return returnTemp;
        }

        /// <summary>
        /// Uses a second, temporary stack to emulate the action of Peeking a Node in a Queue
        /// via transferring data back and forth between the Stacks
        /// Does not add or remove any Nodes from the PseudoQueue
        /// </summary>
        /// <returns>Data from the Node at the Front of the PseudoQueue</returns>
        public T Peek()
        {
            T returnTemp = null;
            MyStack<T> StackTwo = new MyStack<T>();

            while (StackOne.Top != null)
            {
                T temp = StackOne.Pop();
                Node<T> tempNode = new Node<T>(temp);
                StackTwo.Push(tempNode);
            }

            returnTemp = StackTwo.Peek();

            while (StackTwo.Top != null)
            {
                T temp = StackTwo.Pop();
                Node<T> tempNode = new Node<T>(temp);
                StackOne.Push(tempNode);
            }

            return returnTemp;
        }
    }
}
