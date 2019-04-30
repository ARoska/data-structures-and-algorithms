using StacksAndQueues.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class MyPseudoQueue<T> where T : IConvertible
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
                Node<T> temp = StackOne.Pop();
                StackTwo.Push(temp);
            }

            StackOne.Push(node);

            while (StackTwo.Top != null)
            {
                Node<T> temp = StackTwo.Pop();
                StackOne.Push(temp);
            }
        }

        /// <summary>
        /// Uses a second, temporary stack to emulate the action of Dequeueing a Node in a Queue
        /// via transferring data back and forth between the Stacks
        /// Removes the Node from the PseudoQueue
        /// </summary>
        /// <returns>Node that is removed from the Front of the PseudoQueue</returns>
        public Node<T> Dequeue()
        {
            Node<T> returnTemp = null;
            MyStack<T> StackTwo = new MyStack<T>();

            while (StackOne.Top != null)
            {
                Node<T> temp = StackOne.Pop();
                StackTwo.Push(temp);
            }

            if (StackTwo.Top != null)
            {
                returnTemp = StackTwo.Pop();
            }

            while (StackTwo.Top != null)
            {
                Node<T> temp = StackTwo.Pop();
                StackOne.Push(temp);
            }

            return returnTemp;
        }

        /// <summary>
        /// Uses a second, temporary stack to emulate the action of Peeking a Node in a Queue
        /// via transferring data back and forth between the Stacks
        /// Does not add or remove any Nodes from the PseudoQueue
        /// </summary>
        /// <returns>Node at the Front of the PseudoQueue</returns>
        public Node<T> Peek()
        {
            Node<T> returnTemp = null;
            MyStack<T> StackTwo = new MyStack<T>();

            while (StackOne.Top != null)
            {
                Node<T> temp = StackOne.Pop();
                StackTwo.Push(temp);
            }

            returnTemp = StackTwo.Peek();

            while (StackTwo.Top != null)
            {
                Node<T> temp = StackTwo.Pop();
                StackOne.Push(temp);
            }

            return returnTemp;
        }
    }
}
